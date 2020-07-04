namespace SayusiAndo.BlazoredCarbon.Test.Components.Button
{
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;
    using Bunit;
    using Carbon.BlazoredCarbon.Components;
    using Carbon.BlazoredCarbon.Components.Button;
    using FluentAssertions;
    using Xunit;

    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class ButtonComponent_Size_Should : TestContext
    {
        [Fact]
        public async Task BeDefault_ByDefault()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>();

            // Assert
            cut.Find(HtmlElements.Button);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnSizeSmall).Should().Be(false);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnSizeField).Should().Be(false);
        }

        [Fact]
        public async Task BeDefault_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>();

            // Assert
            cut.Find(HtmlElements.Button);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnSizeSmall).Should().Be(false);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnSizeField).Should().Be(false);
        }

        [Fact]
        public async Task BeField_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                (ButtonApi.Size, Size.Field));

            // Assert
            cut.Find(HtmlElements.Button);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnSizeSmall).Should().Be(false);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnSizeField).Should().Be(true);
        }

        [Fact]
        public async Task BeSmall_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                (ButtonApi.Size, Size.Small));

            // Assert
            cut.Find(HtmlElements.Button);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnSizeSmall).Should().Be(true);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnSizeField).Should().Be(false);
        }
    }
}
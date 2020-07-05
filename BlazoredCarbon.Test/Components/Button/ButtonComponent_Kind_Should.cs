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
    public class ButtonComponent_Kind_Should : TestContext
    {
        [Fact]
        // It has to be checked in the doc
        public async Task BePrimary_ByDefault()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>();

            // Assert
            cut.Find(HtmlElements.Button);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnKindPrimary).Should().BeTrue();
        }

        [Fact]
        public async Task BePrimary_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                (ButtonApi.Kind, BcButtonApi.Kind.Primary));

            // Assert
            cut.Find(HtmlElements.Button);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnKindPrimary).Should().BeTrue();
        }

        [Fact]
        public async Task BeSecondary_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                (ButtonApi.Kind, BcButtonApi.Kind.Secondary));

            // Assert
            cut.Find(HtmlElements.Button);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnKindSecondary).Should().BeTrue();
        }

        [Fact]
        public async Task BeTertiary_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                (ButtonApi.Kind, BcButtonApi.Kind.Tertiary));

            // Assert
            cut.Find(HtmlElements.Button);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnKindTertiary).Should().BeTrue();
        }

        [Fact]
        public async Task BeDanger_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                (ButtonApi.Kind, BcButtonApi.Kind.Danger));

            // Assert
            cut.Find(HtmlElements.Button);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnKindDanger).Should().BeTrue();
        }

        [Fact]
        public async Task BeGhost_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                (ButtonApi.Kind, BcButtonApi.Kind.Ghost));

            // Assert
            cut.Find(HtmlElements.Button);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnKindGhost).Should().BeTrue();
        }
    }
}
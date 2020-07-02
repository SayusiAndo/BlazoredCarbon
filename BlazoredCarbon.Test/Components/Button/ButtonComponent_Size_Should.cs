namespace SayusiAndo.BlazoredCarbon.Test.Components.Button
{
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;
    using Bunit;
    using Carbon.BlazoredCarbon.Components.Button;
    using FluentAssertions;
    using Xunit;

    [ExcludeFromCodeCoverage]
    public class ButtonComponent_Size_Should : TestContext
    {
        [Fact]
        public async Task BeDefault_ByDefault()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>();

            // Assert
            cut.Find("button");
            cut.Find("button").ToMarkup().Contains("bx--btn--small").Should().Be(false);
            cut.Find("button").ToMarkup().Contains("bx--btn--field").Should().Be(false);
        }

        [Fact]
        public async Task BeDefault_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>();

            // Assert
            cut.Find("button");
            cut.Find("button").ToMarkup().Contains("bx--btn--small").Should().Be(false);
            cut.Find("button").ToMarkup().Contains("bx--btn--field").Should().Be(false);
        }

        [Fact]
        public async Task BeField_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                ("Size", Size.Field));

            // Assert
            cut.Find("button");
            cut.Find("button").ToMarkup().Contains("bx--btn--small").Should().Be(false);
            cut.Find("button").ToMarkup().Contains("bx--btn--field").Should().Be(true);
        }

        [Fact]
        public async Task BeSmall_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                ("Size", Size.Small));

            // Assert
            cut.Find("button");
            cut.Find("button").ToMarkup().Contains("bx--btn--small").Should().Be(true);
            cut.Find("button").ToMarkup().Contains("bx--btn--field").Should().Be(false);
        }
    }
}
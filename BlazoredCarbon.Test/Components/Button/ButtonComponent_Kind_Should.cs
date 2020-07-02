namespace SayusiAndo.BlazoredCarbon.Test.Components.Button
{
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;
    using Bunit;
    using Carbon.BlazoredCarbon.Components.Button;
    using FluentAssertions;
    using Xunit;

    [ExcludeFromCodeCoverage]
    public class ButtonComponent_Kind_Should : TestContext
    {
        [Fact]
        // It has to be checked in the doc
        public async Task BePrimary_ByDefault()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>();

            // Assert
            cut.Find("button");
            cut.Find("button").ToMarkup().Contains("bx--btn--primary").Should().BeTrue();
        }

        [Fact]
        public async Task BePrimary_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                ("Kind", Kind.Primary));

            // Assert
            cut.Find("button");
            cut.Find("button").ToMarkup().Contains("bx--btn--primary").Should().BeTrue();
        }

        [Fact]
        public async Task BeSecondary_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                ("Kind", Kind.Secondary));

            // Assert
            cut.Find("button");
            cut.Find("button").ToMarkup().Contains("bx--btn--secondary").Should().BeTrue();
        }

        [Fact]
        public async Task BeTertiary_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                ("Kind", Kind.Tertiary));

            // Assert
            cut.Find("button");
            cut.Find("button").ToMarkup().Contains("bx--btn--tertiary").Should().BeTrue();
        }

        [Fact]
        public async Task BeDanger_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                ("Kind", Kind.Danger));

            // Assert
            cut.Find("button");
            cut.Find("button").ToMarkup().Contains("bx--btn--danger").Should().BeTrue();
        }

        [Fact]
        public async Task BeGhost_WhenItIsConfiguredAccordingly()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                ("Kind", Kind.Ghost));

            // Assert
            cut.Find("button");
            cut.Find("button").ToMarkup().Contains("bx--btn--ghost").Should().BeTrue();
        }
    }
}
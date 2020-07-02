namespace SayusiAndo.BlazoredCarbon.Test.Components.Button
{
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;
    using Bunit;
    using Carbon.BlazoredCarbon.Components.Button;
    using FluentAssertions;
    using Xunit;

    [ExcludeFromCodeCoverage]
    public class ButtonComponent_EnabledDisabled_Should : TestContext
    {
        [Fact]
        public async Task BeEnabled_ByDefault()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>();

            // Assert
            cut.Find("button").ToMarkup().Contains("enabled").Should().BeFalse();
            cut.Find("button").ToMarkup().Contains("disabled").Should().BeFalse();
        }

        [Fact]
        public async Task BeEnabled_WhenEnabledStateIsConfigured()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                ("IsDisabled", false));

            // Assert
            cut.Find("button").ToMarkup().Contains("enabled").Should().BeFalse();
            cut.Find("button").ToMarkup().Contains("disabled").Should().BeFalse();
        }

        [Fact]
        public async Task BeDisabled_WhenDisabledStateIsConfigured()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                ("IsDisabled", true));

            // Assert
            cut.Find("button").ToMarkup().Contains("enabled").Should().BeFalse();
            cut.Find("button").ToMarkup().Contains("disabled").Should().BeTrue();
        }
    }
}
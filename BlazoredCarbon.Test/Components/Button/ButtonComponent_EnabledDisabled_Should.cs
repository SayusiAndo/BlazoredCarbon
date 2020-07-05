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
    public class ButtonComponent_EnabledDisabled_Should : TestContext
    {
        [Fact]
        public async Task BeDisabled_WhenDisabledStateIsConfigured()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                (ButtonApi.IsDisabled, true));

            // Assert
            cut.Find(HtmlElements.Button).ToMarkup().Contains("enabled").Should().BeFalse();
            cut.Find(HtmlElements.Button).ToMarkup().Contains("disabled").Should().BeTrue();
        }

        [Fact]
        public async Task BeEnabled_ByDefault()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>();

            // Assert
            cut.Find(HtmlElements.Button).ToMarkup().Contains("enabled").Should().BeFalse();
            cut.Find(HtmlElements.Button).ToMarkup().Contains("disabled").Should().BeFalse();
        }

        [Fact]
        public async Task BeEnabled_WhenEnabledStateIsConfigured()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                (ButtonApi.IsDisabled, false));

            // Assert
            cut.Find(HtmlElements.Button).ToMarkup().Contains("enabled").Should().BeFalse();
            cut.Find(HtmlElements.Button).ToMarkup().Contains("disabled").Should().BeFalse();
        }
    }
}
namespace SayusiAndo.BlazoredCarbon.Test.Components.Button
{
    using System;
    using System.Threading.Tasks;
    using AngleSharp.Dom;
    using Bunit;
    using Carbon.BlazoredCarbon.Components.Button;
    using FluentAssertions;
    using Xunit;

    public class ButtonComponent_EnabledDisabled_Should : TestContext
    {
        [Fact(DisplayName = "Checks whether the component is enabled by default," +
                            "independently whether it is configured or not.")]
        public async Task BeEnabled_ByDefault()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>();

            // Assert
            cut.Find("button").ToMarkup().Contains("enabled").Should().BeFalse();
            cut.Find("button").ToMarkup().Contains("disabled").Should().BeFalse();
        }

        [Fact(DisplayName = "Checks whether the generated HTML is correct when" +
                            "enabled/disabled state is configured.")]
        public async Task BeEnabled_WhenEnabledStateIsConfigured()
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                ("IsDisabled", false));

            // Assert
            cut.Find("button").ToMarkup().Contains("enabled").Should().BeFalse();
            cut.Find("button").ToMarkup().Contains("disabled").Should().BeFalse();
        }

        [Fact(DisplayName = "Checks whether the generated HTML is correct," +
                            "enabled/disabled state is configured.")]
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
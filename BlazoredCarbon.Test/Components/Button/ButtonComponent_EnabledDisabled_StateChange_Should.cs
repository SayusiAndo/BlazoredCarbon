namespace SayusiAndo.BlazoredCarbon.Test.Components.Button
{
    using System.Threading.Tasks;
    using Bunit;
    using Carbon.BlazoredCarbon.Components.Button;
    using FluentAssertions;
    using Xunit;

    // ReSharper disable once InconsistentNaming
    public class ButtonComponent_EnabledDisabled_StateChange_Should : TestContext
    {
        [Theory(DisplayName = "Checks whether the component works properly," +
                              "when its IsDisabled parameter value changes.")]
        [InlineData(true, false, false)]
        [InlineData(false, true, true)]
        public async Task Change_EnabledDisabledState(
            bool startState,
            bool endState,
            bool result)
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                ("IsDisabled", startState));

            // Act
            cut.SetParametersAndRender(parameters => parameters.Add(p => p.IsDisabled, endState));

            // Assert
            cut.Find("button").ToMarkup().Contains("disabled").Should().Be(result);
        }
    }
}
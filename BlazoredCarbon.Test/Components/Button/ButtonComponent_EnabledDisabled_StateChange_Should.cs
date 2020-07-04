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
    public class ButtonComponent_EnabledDisabled_StateChange_Should : TestContext
    {
        [Theory]
        [InlineData(true, false, false)]
        [InlineData(false, true, true)]
        public async Task Change_EnabledDisabledState(
            bool startState,
            bool endState,
            bool result)
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                (ButtonApi.IsDisabled, startState));

            // Act
            cut.SetParametersAndRender(parameters => parameters.Add(p => p.IsDisabled, endState));

            // Assert
            cut.Find(HtmlElements.Button).ToMarkup().Contains("disabled").Should().Be(result);
        }
    }
}
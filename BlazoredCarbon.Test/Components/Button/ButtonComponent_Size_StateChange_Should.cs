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
    public class ButtonComponent_Size_StateChange_Should : TestContext
    {
        [Theory]
        [InlineData(Size.Default, Size.Field, true, false)]
        [InlineData(Size.Default, Size.Small, false, true)]
        [InlineData(Size.Field, Size.Default, false, false)]
        [InlineData(Size.Field, Size.Small, false, true)]
        [InlineData(Size.Small, Size.Default, false, false)]
        [InlineData(Size.Small, Size.Field, true, false)]
        public async Task BeDefault_ByDefault(
            string startState,
            string endState,
            bool isField,
            bool isSmall)
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                (ButtonApi.Size, startState));

            // Act
            cut.SetParametersAndRender(parameters => parameters.Add(p => p.Size, endState));

            // Assert
            cut.Find(HtmlElements.Button);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnSizeSmall).Should().Be(isSmall);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnSizeField).Should().Be(isField);
        }
    }
}
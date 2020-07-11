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
        [InlineData(BcButtonApi.Size.Default, BcButtonApi.Size.Field, true, false)]
        [InlineData(BcButtonApi.Size.Default, BcButtonApi.Size.Small, false, true)]
        [InlineData(BcButtonApi.Size.Field, BcButtonApi.Size.Default, false, false)]
        [InlineData(BcButtonApi.Size.Field, BcButtonApi.Size.Small, false, true)]
        [InlineData(BcButtonApi.Size.Small, BcButtonApi.Size.Default, false, false)]
        [InlineData(BcButtonApi.Size.Small, BcButtonApi.Size.Field, true, false)]
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
            cut.Find(HtmlElements.Button).ToMarkup().Contains(CarbonDesignSystemCss.Button.BxBtnSizeSmall).Should()
                .Be(isSmall);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(CarbonDesignSystemCss.Button.BxBtnSizeField).Should().Be
                (isField);
        }
    }
}
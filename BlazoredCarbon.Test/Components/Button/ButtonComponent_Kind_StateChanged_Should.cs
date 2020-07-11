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
    public class ButtonComponent_Kind_StateChange_Should : TestContext
    {
        [Theory]
        [InlineData(BcButtonApi.Kind.Primary, BcButtonApi.Kind.Secondary, false, true, false, false, false)]
        [InlineData(BcButtonApi.Kind.Primary, BcButtonApi.Kind.Tertiary, false, false, true, false, false)]
        [InlineData(BcButtonApi.Kind.Primary, BcButtonApi.Kind.Danger, false, false, false, true, false)]
        [InlineData(BcButtonApi.Kind.Primary, BcButtonApi.Kind.Ghost, false, false, false, false, true)]
        [InlineData(BcButtonApi.Kind.Secondary, BcButtonApi.Kind.Tertiary, false, false, true, false, false)]
        [InlineData(BcButtonApi.Kind.Secondary, BcButtonApi.Kind.Danger, false, false, false, true, false)]
        [InlineData(BcButtonApi.Kind.Secondary, BcButtonApi.Kind.Ghost, false, false, false, false, true)]
        [InlineData(BcButtonApi.Kind.Secondary, BcButtonApi.Kind.Primary, true, false, false, false, false)]
        [InlineData(BcButtonApi.Kind.Tertiary, BcButtonApi.Kind.Danger, false, false, false, true, false)]
        [InlineData(BcButtonApi.Kind.Tertiary, BcButtonApi.Kind.Ghost, false, false, false, false, true)]
        [InlineData(BcButtonApi.Kind.Tertiary, BcButtonApi.Kind.Primary, true, false, false, false, false)]
        [InlineData(BcButtonApi.Kind.Tertiary, BcButtonApi.Kind.Secondary, false, true, false, false, false)]
        [InlineData(BcButtonApi.Kind.Danger, BcButtonApi.Kind.Ghost, false, false, false, false, true)]
        [InlineData(BcButtonApi.Kind.Danger, BcButtonApi.Kind.Primary, true, false, false, false, false)]
        [InlineData(BcButtonApi.Kind.Danger, BcButtonApi.Kind.Secondary, false, true, false, false, false)]
        [InlineData(BcButtonApi.Kind.Danger, BcButtonApi.Kind.Tertiary, false, false, true, false, false)]
        [InlineData(BcButtonApi.Kind.Ghost, BcButtonApi.Kind.Primary, true, false, false, false, false)]
        [InlineData(BcButtonApi.Kind.Ghost, BcButtonApi.Kind.Secondary, false, true, false, false, false)]
        [InlineData(BcButtonApi.Kind.Ghost, BcButtonApi.Kind.Tertiary, false, false, true, false, false)]
        [InlineData(BcButtonApi.Kind.Ghost, BcButtonApi.Kind.Danger, false, false, false, true, false)]
        public async Task ChangeKindState(
            string startState,
            string endState,
            bool isPrimary,
            bool isSecondary,
            bool isTertiary,
            bool isDanger,
            bool isGhost)
        {
            // Arrange
            IRenderedComponent<BcButton> cut = RenderComponent<BcButton>(
                (ButtonApi.Kind, startState));

            // Act
            cut.SetParametersAndRender(pr => pr.Add(p => p.Kind, endState));

            // Assert
            cut.Find(HtmlElements.Button);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(CarbonDesignSystemCss.Button.BxBtnKindPrimary).Should()
                .Be(isPrimary);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(CarbonDesignSystemCss.Button.BxBtnKindSecondary).Should()
                .Be(isSecondary);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(CarbonDesignSystemCss.Button.BxBtnKindTertiary).Should()
                .Be(isTertiary);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(CarbonDesignSystemCss.Button.BxBtnKindDanger).Should()
                .Be(isDanger);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(CarbonDesignSystemCss.Button.BxBtnKindGhost).Should()
                .Be(isGhost);
        }
    }
}
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
        [InlineData(Kind.Primary, Kind.Secondary, false, true, false, false, false)]
        [InlineData(Kind.Primary, Kind.Tertiary, false, false, true, false, false)]
        [InlineData(Kind.Primary, Kind.Danger, false, false, false, true, false)]
        [InlineData(Kind.Primary, Kind.Ghost, false, false, false, false, true)]
        [InlineData(Kind.Secondary, Kind.Tertiary, false, false, true, false, false)]
        [InlineData(Kind.Secondary, Kind.Danger, false, false, false, true, false)]
        [InlineData(Kind.Secondary, Kind.Ghost, false, false, false, false, true)]
        [InlineData(Kind.Secondary, Kind.Primary, true, false, false, false, false)]
        [InlineData(Kind.Tertiary, Kind.Danger, false, false, false, true, false)]
        [InlineData(Kind.Tertiary, Kind.Ghost, false, false, false, false, true)]
        [InlineData(Kind.Tertiary, Kind.Primary, true, false, false, false, false)]
        [InlineData(Kind.Tertiary, Kind.Secondary, false, true, false, false, false)]
        [InlineData(Kind.Danger, Kind.Ghost, false, false, false, false, true)]
        [InlineData(Kind.Danger, Kind.Primary, true, false, false, false, false)]
        [InlineData(Kind.Danger, Kind.Secondary, false, true, false, false, false)]
        [InlineData(Kind.Danger, Kind.Tertiary, false, false, true, false, false)]
        [InlineData(Kind.Ghost, Kind.Primary, true, false, false, false, false)]
        [InlineData(Kind.Ghost, Kind.Secondary, false, true, false, false, false)]
        [InlineData(Kind.Ghost, Kind.Tertiary, false, false, true, false, false)]
        [InlineData(Kind.Ghost, Kind.Danger, false, false, false, true, false)]
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
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnKindPrimary).Should().Be(isPrimary);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnKindSecondary).Should().Be(isSecondary);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnKindTertiary).Should().Be(isTertiary);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnKindDanger).Should().Be(isDanger);
            cut.Find(HtmlElements.Button).ToMarkup().Contains(ButtonCss.BxBtnKindGhost).Should().Be(isGhost);
        }
    }
}
namespace SayusiAndo.BlazoredCarbon.Test.Components.Accordion
{
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    using AngleSharp.Dom;

    using Bunit;

    using Carbon.BlazoredCarbon.Components;
    using Carbon.BlazoredCarbon.Components.Accordion;

    using FluentAssertions;

    using Xunit;

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [ExcludeFromCodeCoverage]
    public class BcAccordionItem_EnabledDisabled_Should : TestContext
    {
        [Fact]
        public async Task Disabled_ByDefault()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                p => p.AddChildContent<BcAccordionItem>());

            // Assert
            cut.Find(HtmlElements.Li).ToMarkup()
                .Contains(CarbonDesignSystemCss.Accordion.BxAccordionItemActive)
                .Should()
                .BeFalse();
        }

        [Fact]
        public async Task Disabled_WhenClickOnItAndItWasEnabled()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                p => p.AddChildContent<BcAccordionItem>(b =>
                {
                    b.Add(p => p.IsActive, true);
                    b.AddChildContent<BcAccordionTitle>();
                }));
            IElement button = cut.Find(HtmlElements.Button);

            // Act
            button.Click();

            // Assert
            cut.Find(HtmlElements.Li).ToMarkup()
                .Contains(CarbonDesignSystemCss.Accordion.BxAccordionItemActive)
                .Should()
                .BeFalse();
        }

        [Fact]
        public async Task Disabled_WhenItIsConfiguredSo()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                p => p.AddChildContent<BcAccordionItem>(b => { b.Add(p => p.IsActive, false); }));

            // Assert
            cut.Find(HtmlElements.Li).ToMarkup()
                .Contains(CarbonDesignSystemCss.Accordion.BxAccordionItemActive)
                .Should()
                .BeFalse();
        }

        [Fact]
        public async Task Enabled_WhenClickOnItAndItWasDisabled()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                p => p.AddChildContent<BcAccordionItem>(b =>
                {
                    b.Add(p => p.IsActive, false);
                    b.AddChildContent<BcAccordionTitle>();
                }));
            IElement button = cut.Find(HtmlElements.Button);

            // Act
            button.Click();

            // Assert
            cut.Find(HtmlElements.Li).ToMarkup()
                .Contains(CarbonDesignSystemCss.Accordion.BxAccordionItemActive)
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Enabled_WhenItisConfigureSo()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                p => p.AddChildContent<BcAccordionItem>(b => { b.Add(p => p.IsActive, true); }));

            // Assert
            cut.Find(HtmlElements.Li).ToMarkup()
                .Contains(CarbonDesignSystemCss.Accordion.BxAccordionItemActive)
                .Should()
                .BeTrue();
        }
    }
}
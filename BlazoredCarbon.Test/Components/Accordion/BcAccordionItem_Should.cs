namespace SayusiAndo.BlazoredCarbon.Test.Components.Accordion
{
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;
    using Bunit;
    using Carbon.BlazoredCarbon.Components;
    using Carbon.BlazoredCarbon.Components.Accordion;
    using FluentAssertions;
    using Xunit;

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [ExcludeFromCodeCoverage]
    public class BcAccordionItem_Should : TestContext
    {
        [Fact]
        public async Task Be_A_Li_Item()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                p => p.AddChildContent<BcAccordionItem>());

            // Assert
            cut.Find(HtmlElements.Ul).ToMarkup()
                .Contains(HtmlElements.Li)
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Have_TheProper_CssClasses()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                p => p.AddChildContent<BcAccordionItem>());

            // Assert
            cut.Find(HtmlElements.Li).ToMarkup()
                .Contains(CarbonDesignSystemCss.Accordion.BxAccordionItem)
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Have_DataAccordionItem_Property()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                p => p.AddChildContent<BcAccordionItem>());

            // Assert
            cut.Find(HtmlElements.Li).ToMarkup()
                .Contains("data-accordion-item")
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Splatting_SingleUnknownAttribute()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                p => p.AddChildContent<BcAccordionItem>(builder => builder.AddUnmatched("custom", "value"))
            );

            // Assert
            cut.Find(HtmlElements.Li).ToMarkup()
                .Contains("custom=\"value\"")
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Splatting_MultipleUnknownAttributes()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                p => p.AddChildContent<BcAccordionItem>(builder =>
                {
                    builder.AddUnmatched("custom", "value");
                    builder.AddUnmatched("custom1", "value1");
                })
            );

            // Assert
            cut.Find(HtmlElements.Li).ToMarkup()
                .Contains("custom=\"value\"")
                .Should()
                .BeTrue();

            cut.Find(HtmlElements.Li).ToMarkup()
                .Contains("custom1=\"value1\"")
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Wrap_ChildContent()
        {
            // Arrange
            string childContent = "BcAccordionItem child content";
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                p => p.AddChildContent<BcAccordionItem>(builder => { builder.AddChildContent(childContent); })
            );

            // Assert
            cut.Find(HtmlElements.Li).ToMarkup()
                .Contains(childContent)
                .Should()
                .BeTrue();
        }
    }
}
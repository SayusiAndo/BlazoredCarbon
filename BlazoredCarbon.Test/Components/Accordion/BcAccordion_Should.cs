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
    public class BcAccordion_Should : TestContext
    {
        [Fact]
        public async Task Be_A_LiItem()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>();

            // Assert
            cut.Find(HtmlElements.Ul);
        }

        [Fact]
        public async Task HaveTheRight_CssClasses()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>();

            // Assert
            cut.Find(HtmlElements.Ul).ToMarkup()
                .Contains(CarbonDesignSystemCss.Accordion.BxAccordion)
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Have_DataAccordionProperty()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>();

            // Assert
            cut.Find(HtmlElements.Ul).ToMarkup()
                .Contains("data-accordion")
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Splatting_ASingleUnknownAttributes()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                ("custom", "custom-value"));

            // Assert
            cut.Find(HtmlElements.Ul).ToMarkup()
                .Contains("custom=\"custom-value\"")
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Splatting_MultipleUnknownAttributes()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                ("custom", "custom-value"),
                ("custom2", "custom-value2"));

            // Assert
            cut.Find(HtmlElements.Ul).ToMarkup()
                .Contains("custom=\"custom-value\"")
                .Should()
                .BeTrue();

            cut.Find(HtmlElements.Ul).ToMarkup()
                .Contains("custom2=\"custom-value2\"")
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Wrap_ChildContent()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                parameters => parameters.AddChildContent("<p>Test</p>"));

            // Assert
            cut.Find(HtmlElements.Ul).ToMarkup()
                .Contains("<p>Test</p>")
                .Should()
                .BeTrue();
        }
    }
}
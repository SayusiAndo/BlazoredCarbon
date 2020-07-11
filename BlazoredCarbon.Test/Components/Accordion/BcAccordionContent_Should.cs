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
    public class BcAccordionContent_Should : TestContext
    {
        [Fact]
        public async Task Have_DivElement()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                bca =>
                {
                    bca.AddChildContent<BcAccordionItem>(bcai =>
                    {
                        bcai.AddChildContent<BcAccordionContent>(bcaic =>
                        {
                            bcaic.AddChildContent("Something stuff");
                        });
                    });
                });

            // Assert
            IElement con = cut.Find("ul>li>div");
        }

        [Fact]
        public async Task Have_ProperClasses()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                bca =>
                {
                    bca.AddChildContent<BcAccordionItem>(bcai =>
                    {
                        bcai.AddChildContent<BcAccordionContent>(bcaic =>
                        {
                            bcaic.AddChildContent("Something stuff");
                        });
                    });
                });

            // Assert
            IElement con = cut.Find("ul>li>div");
            con.ClassList.Contains(CarbonDesignSystemCss.Accordion.BxAccordionContent)
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Splatting_MultipleUnknowParameters()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                bca =>
                {
                    bca.AddChildContent<BcAccordionItem>(bcai =>
                    {
                        bcai.AddChildContent<BcAccordionContent>(bcaic =>
                        {
                            bcaic.AddUnmatched("custom", "value");
                            bcaic.AddUnmatched("custom1", "value1");
                            bcaic.AddChildContent("Something stuff");
                        });
                    });
                });

            // Assert
            IElement con = cut.Find("ul>li>div");
            con.Attributes.GetNamedItem("custom").Value
                .Should().Be("value");
            con.Attributes.GetNamedItem("custom1").Value
                .Should().Be("value1");
        }

        [Fact]
        public async Task Splatting_SingleUnknownParameter()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                bca =>
                {
                    bca.AddChildContent<BcAccordionItem>(bcai =>
                    {
                        bcai.AddChildContent<BcAccordionContent>(bcaic =>
                        {
                            bcaic.AddUnmatched("custom", "value");
                            bcaic.AddChildContent("Something stuff");
                        });
                    });
                });

            // Assert
            IElement con = cut.Find("ul>li>div");
            con.Attributes.GetNamedItem("custom").Value
                .Should().Be("value");
        }

        [Fact]
        public async Task WrapContent()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                bca =>
                {
                    bca.AddChildContent<BcAccordionItem>(bcai =>
                    {
                        bcai.AddChildContent<BcAccordionContent>(bcaic =>
                        {
                            bcaic.AddChildContent("Something stuff");
                        });
                    });
                });

            // Assert
            IElement con = cut.Find("ul>li>div");
            con.InnerHtml.Contains("Something stuff")
                .Should().BeTrue();
        }
    }
}
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

    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class BcAccordionItemTitle_Should : TestContext
    {
        [Fact]
        public async Task Button_HaveProperClasses()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                bca =>
                {
                    bca.AddChildContent<BcAccordionItem>(bcai =>
                    {
                        bcai.AddChildContent<BcAccordionTitle>(bcat => { bcat.AddChildContent("Title"); });
                    });
                });

            // Assert
            IElement button = cut.Find(HtmlElements.Button);
            button.ClassList.Contains(CarbonDesignSystemCss.Accordion.BxAccordionHeading)
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Button_HaveSvgElement()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                bca =>
                {
                    bca.AddChildContent<BcAccordionItem>(bcai =>
                    {
                        bcai.AddChildContent<BcAccordionTitle>(bcat => { bcat.AddChildContent("Title"); });
                    });
                });

            // Assert
            cut.Find(HtmlElements.Svg);
        }

        [Fact]
        public async Task Div_HaveProperClasses()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                bca =>
                {
                    bca.AddChildContent<BcAccordionItem>(bcai =>
                    {
                        bcai.AddChildContent<BcAccordionTitle>(bcat => { bcat.AddChildContent("Title"); });
                    });
                });

            // Assert
            IElement div = cut.Find("button>div");
            div.ClassList.Contains(CarbonDesignSystemCss.Accordion.BxAccordionTitle)
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Div_Splatting_MultipleUnknowParameters()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                bca =>
                {
                    bca.AddChildContent<BcAccordionItem>(bcai =>
                    {
                        bcai.AddChildContent<BcAccordionTitle>(bcat =>
                        {
                            bcat.AddUnmatched("custom", "value");
                            bcat.AddUnmatched("custom1", "value1");
                            bcat.AddChildContent("Title");
                        });
                    });
                });

            // Assert
            IElement div = cut.Find("button>div");
            div.Attributes.GetNamedItem("custom")
                .Value
                .Should().Be("value");
            div.Attributes.GetNamedItem("custom1")
                .Value
                .Should().Be("value1");
        }

        [Fact]
        public async Task Div_Splatting_SingleUnknowParameter()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                bca =>
                {
                    bca.AddChildContent<BcAccordionItem>(bcai =>
                    {
                        bcai.AddChildContent<BcAccordionTitle>(bcat =>
                        {
                            bcat.AddUnmatched("custom", "value");
                            bcat.AddChildContent("Title");
                        });
                    });
                });

            // Assert
            IElement div = cut.Find("button>div");
            div.Attributes.GetNamedItem("custom")
                .Value
                .Should().Be("value");
        }

        [Fact]
        public async Task Have_ButtonElem()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                bca =>
                {
                    bca.AddChildContent<BcAccordionItem>(bcai =>
                    {
                        bcai.AddChildContent<BcAccordionTitle>(bcat => { bcat.AddChildContent("Title"); });
                    });
                });

            // Assert
            cut.Find(HtmlElements.Button);
            cut.Find(HtmlElements.Button).ToMarkup()
                .Contains("Title")
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Have_DivWithinButton()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                bca =>
                {
                    bca.AddChildContent<BcAccordionItem>(bcai =>
                    {
                        bcai.AddChildContent<BcAccordionTitle>(bcat => { bcat.AddChildContent("Title"); });
                    });
                });

            // Assert
            cut.Find("button>div");
        }

        [Fact]
        public async Task Wrap_TitleText()
        {
            // Arrange
            IRenderedComponent<BcAccordion> cut = RenderComponent<BcAccordion>(
                bca =>
                {
                    bca.AddChildContent<BcAccordionItem>(bcai =>
                    {
                        bcai.AddChildContent<BcAccordionTitle>(bcat => { bcat.AddChildContent("Title"); });
                    });
                });

            // Assert
            cut.Find("button>div").InnerHtml
                .Contains("Title")
                .Should()
                .BeTrue();
        }
    }
}
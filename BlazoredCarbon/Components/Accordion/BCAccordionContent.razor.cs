namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Accordion
{
    using Microsoft.AspNetCore.Components;

    public partial class BCAccordionContent
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
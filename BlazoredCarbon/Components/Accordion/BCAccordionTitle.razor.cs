namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Accordion
{
    using Microsoft.AspNetCore.Components;

    public partial class BCAccordionTitle
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        
        [CascadingParameter]
        public BCAccordionItem Parent { get; set; }

        private void Select()
        {
            Parent.Select();
        }
    }
}
namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Accordion
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Components;

    public partial class BCAccordion
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public bool SingleOpen { get; set; } = true;
        
        public List<BCAccordionItem> BcAccordionItems = new List<BCAccordionItem>();

        private BCAccordionItem _selected;

        public BCAccordionItem ActiveAccordionItem
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
                InvokeAsync(StateHasChanged);
            }
        }

    }
}
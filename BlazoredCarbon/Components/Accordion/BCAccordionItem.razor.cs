namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Accordion
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;

    public partial class BCAccordionItem
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [CascadingParameter]
        public BCAccordion BcAccordion { get; set; }

        private string defaultClass = "bx--accordion__item";
        private string activeClass = "bx--accordion__item--active";

        private string GetCss()
        {
            if (BcAccordion.ActiveAccordionItem == this)
            {
                return $"{defaultClass} {activeClass}";
            }

            return defaultClass;
        }

        protected override async Task OnInitializedAsync()
        {
            BcAccordion.BcAccordionItems.Add(this);
            await base.OnInitializedAsync();
        }

        public void Select()
        {
            if (BcAccordion.SingleOpen)
            {
                BcAccordion.ActiveAccordionItem = null;
                BcAccordion.ActiveAccordionItem = this;
            }

            InvokeAsync(StateHasChanged);
        }
    }
}
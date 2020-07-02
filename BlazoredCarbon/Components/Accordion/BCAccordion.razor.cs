namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Accordion
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Components;

    /// <summary>
    ///     Top element of Accordion Component
    /// </summary>
    /// <example>
    ///     <BCAccordion>some content</BCAccordion>
    /// </example>
    /// <see cref="BCAccordionItem" />
    /// <see cref="BCAccordionTitle" />
    /// <see cref="BCAccordionContent" />
    public partial class BCAccordion
    {
        private BCAccordionItem _selected;

        public List<BCAccordionItem> BcAccordionItems = new List<BCAccordionItem>();

        /// <summary>
        ///     The <see cref="RenderFragment">content</see> of the component.
        /// </summary>
        /// <example>
        ///     <BCAccordion>some content</BCAccordion>
        /// </example>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        public BCAccordionItem ActiveAccordionItem
        {
            get => _selected;
            set
            {
                _selected = value;
                InvokeAsync(StateHasChanged);
            }
        }
    }
}
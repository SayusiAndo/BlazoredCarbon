namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Accordion
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;

    /// <summary>
    /// An item in the accordion.
    /// </summary>
    /// <example>
    ///     <BCAccordion>
    ///         <BCAccordionItem>
    ///             <BCAccordionTitle>
    ///             </BCAccordionTitle>
    ///             <BCAccordionContent>
    ///                 Some content
    ///             </BCAccordionContent>
    ///         </BCAccordionItem>
    ///     </BCAccordion>
    /// </example>
    /// <see cref="BcAccordion"/>
    /// <see cref="BCAccordionTitle"/>
    /// <see cref="BCAccordionContent"/>
    public partial class BCAccordionItem
    {
        /// <summary>
        /// The content of the component.
        /// </summary>
        /// <example>
        ///     <BCAccordion>
        ///         <BCAccordionItem>
        ///             <BCAccordionTitle>
        ///             </BCAccordionTitle>
        ///             <BCAccordionContent>
        ///                 Some content
        ///             </BCAccordionContent>
        ///         </BCAccordionItem>
        ///     </BCAccordion>
        /// </example>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        /// <summary>
        /// If this item is open by default than it has to be true.
        /// </summary>
        /// <typeparam name="InitialSetup">Item is opened by default</typeparam>
        [Parameter]
        public bool InitialSetup { get; set; } = false;

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
            if (InitialSetup)
            {
                BcAccordion.ActiveAccordionItem = null;
                BcAccordion.ActiveAccordionItem = this;
            }

            BcAccordion.BcAccordionItems.Add(this);
            await base.OnInitializedAsync();
        }

        public void Select()
        {
            BcAccordion.ActiveAccordionItem = null;
            BcAccordion.ActiveAccordionItem = this;

            InvokeAsync(StateHasChanged);
        }
    }
}
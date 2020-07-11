namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Accordion
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Components;

    /// <summary>
    ///     An item in the accordion.
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
    /// <see cref="BcAccordion" />
    /// <see cref="BCAccordionTitle" />
    /// <see cref="BCAccordionContent" />
    public partial class BCAccordionItem
    {
        /// <summary>
        ///     The content of the component.
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
        ///     If this item is open by default than it has to be true.
        /// </summary>
        /// <typeparam name="InitialSetup">Item is opened by default</typeparam>
        [Parameter]
        public bool IsActive { get; set; } = false;

        /// <summary>
        /// Additional parameters which aren't part of the BcAccordionApi.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> UnknownParameters { get; set; }

        private string GetCss()
        {
            if (IsActive)
            {
                return $"{CarbonDesignSystemCss.Accordion.BxAccordionItem} " +
                       $"{CarbonDesignSystemCss.Accordion.BxAccordionItemActive}";
            }

            return CarbonDesignSystemCss.Accordion.BxAccordionItem;
        }

        public void Select()
        {
            IsActive = !IsActive;
            InvokeAsync(StateHasChanged);
        }
    }
}
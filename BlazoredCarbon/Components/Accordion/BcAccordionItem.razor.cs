namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Accordion
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Components;

    /// <summary>
    ///     An item in the accordion.
    /// </summary>
    /// <example>
    ///     <BcAccordion>
    ///         <BcAccordionItem>
    ///             <BcAccordionTitle>
    ///             </BcAccordionTitle>
    ///             <BcAccordionContent>
    ///                 Some content
    ///             </BcAccordionContent>
    ///         </BcAccordionItem>
    ///     </BcAccordion>
    /// </example>
    /// <see cref="BcAccordion" />
    /// <see cref="BcAccordionTitle" />
    /// <see cref="BcAccordionContent" />
    public partial class BcAccordionItem
    {
        /// <summary>
        ///     The content of the component.
        /// </summary>
        /// <example>
        ///     <BcAccordion>
        ///         <BcAccordionItem>
        ///             <BcAccordionTitle>
        ///             </BcAccordionTitle>
        ///             <BcAccordionContent>
        ///                 Some content
        ///             </BcAccordionContent>
        ///         </BcAccordionItem>
        ///     </BcAccordion>
        /// </example>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        /// <summary>
        ///     If this item is open by default than it has to be true.
        /// </summary>
        /// <typeparam name="IsActive">Item is opened by default</typeparam>
        [Parameter]
        public bool IsActive { get; set; } = false;

        /// <summary>
        ///     Additional parameters which aren't part of the BcAccordionApi.
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
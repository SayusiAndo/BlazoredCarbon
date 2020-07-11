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
        /// <summary>
        ///     The <see cref="RenderFragment">content</see> of the component.
        /// </summary>
        /// <example>
        ///     <BCAccordion>some content</BCAccordion>
        /// </example>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        /// <summary>
        /// Additional parameters which aren't part of the BcAccordionApi.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> UnknownParameters { get; set; }

        private string GetCss()
        {
            return CarbonDesignSystemCss.Accordion.BxAccordion;
        }
    }
}
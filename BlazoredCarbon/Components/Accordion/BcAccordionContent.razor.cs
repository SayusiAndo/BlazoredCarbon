namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Accordion
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Components;

    /// <summary>
    ///     The content of an Accordion element. This is the content
    ///     which will be collapsed and displayed.
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
    /// <see cref="BcAccordionItem" />
    /// <see cref="BcAccordionTitle" />
    public partial class BcAccordionContent
    {
        /// <summary>
        ///     The <see cref="RenderFragment" /> content of the component.
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        /// <summary>
        ///     Additional parameters which aren't part of the BcAccordionApi.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> UnknownParameters { get; set; }
    }
}
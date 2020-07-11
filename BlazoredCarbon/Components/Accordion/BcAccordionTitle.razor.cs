namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Accordion
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Components;

    /// <summary>
    ///     The text will be displayed in the accordion item.
    /// </summary>
    /// <example>
    ///     <BcAccordion>
    ///         <BcAccordionItem>
    ///             <BcAccordionTitle>
    ///                 Some title
    ///             </BcAccordionTitle>
    ///             <BcAccordionContent>
    ///                 Some content
    ///             </BcAccordionContent>
    ///         </BcAccordionItem>
    ///     </BcAccordion>
    /// </example>
    public partial class BcAccordionTitle
    {
        /// <summary>
        ///     The content of the component
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        /// <summary>
        ///     Additional parameters which aren't part of the BcAccordionApi.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> UnknownParameters { get; set; }

        /// <summary>
        ///     The parent <see cref="BcAccordionItem">instance</see>.
        /// </summary>
        [CascadingParameter]
        public BcAccordionItem Parent { get; set; }

        private void Select()
        {
            Parent.Select();
        }
    }
}
namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Accordion
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Components;

    /// <summary>
    ///     The text will be displayed in the accordion item.
    /// </summary>
    /// <example>
    ///     <BCAccordion>
    ///         <BCAccordionItem>
    ///             <BCAccordionTitle>
    ///                 Some title
    ///             </BCAccordionTitle>
    ///             <BCAccordionContent>
    ///                 Some content
    ///             </BCAccordionContent>
    ///         </BCAccordionItem>
    ///     </BCAccordion>
    /// </example>
    public partial class BCAccordionTitle
    {
        /// <summary>
        ///     The content of the component
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        /// <summary>
        /// Additional parameters which aren't part of the BcAccordionApi.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> UnknownParameters { get; set; }

        /// <summary>
        /// The parent <see cref="BCAccordionItem">instance</see>.
        /// </summary>
        [CascadingParameter]
        public BCAccordionItem Parent { get; set; }

        private void Select()
        {
            Parent.Select();
        }
    }
}
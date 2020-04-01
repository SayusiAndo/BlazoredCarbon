namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Accordion
{
    using Microsoft.AspNetCore.Components;

    /// <summary>
    /// The text will be displayed in the accordion item.
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
        /// The content of the component
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        
        [CascadingParameter]
        public BCAccordionItem Parent { get; set; }

        private void Select()
        {
            Parent.Select();
        }
    }
}
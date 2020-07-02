namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Tabs
{
    using Microsoft.AspNetCore.Components;

    public partial class BCTabList
    {
        private string _defaultCss = "bx--tabs";

        private string _IsContainerCss = "bx--tabs--container";

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public bool IsContainer { get; set; }

        private string GetCss()
        {
            if (IsContainer)
            {
                return $"{_defaultCss} {_IsContainerCss}";
            }

            return _defaultCss;
        }
    }
}
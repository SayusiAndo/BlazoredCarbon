namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Tabs
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Components;

    public partial class BCTabs
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        private BCTab _selected;

        public BCTab Selected
        {
            get => _selected;
            set
            {
                _selected = value;
                InvokeAsync(StateHasChanged);
            }
        }

        public List<BCTab> BcTabs = new List<BCTab>();
    }
}
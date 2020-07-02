namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Tabs
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Components;

    public partial class BCTabs
    {
        private BCTab _selected;

        public List<BCTab> BcTabs = new List<BCTab>();

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        public BCTab Selected
        {
            get => _selected;
            set
            {
                _selected = value;
                InvokeAsync(StateHasChanged);
            }
        }
    }
}
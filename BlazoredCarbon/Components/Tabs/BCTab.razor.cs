namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Tabs
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;

    public partial class BCTab
    {
        private string _defaultCss = "bx--tabs__nav-item";
        private string _selectedCss = "bx--tabs__nav-item--selected";

        [CascadingParameter]
        public BCTabList BcTabList { get; set; }

        [CascadingParameter]
        public BCTabs BcTabs { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public bool IsSelected { get; set; } = false;

        public bool Selected => BcTabs.Selected == this;
        public RenderFragment Content { get; set; }

        private string GetCss()
        {
            if (Selected)
            {
                return $"{_defaultCss} {_selectedCss}";
            }

            return _defaultCss;
        }

        public async Task Select()
        {
            BcTabs.Selected = this;
        }

        protected override async Task OnInitializedAsync()
        {
            if (BcTabs.Selected == null || IsSelected)
            {
                BcTabs.Selected = this;
            }

            BcTabs.BcTabs.Add(this);
            await base.OnInitializedAsync().ConfigureAwait(false);
        }

        public void UpdateContent()
        {
            BcTabs.BcTabs.First(q => q == this).Content = Content;
            if (BcTabs.Selected == this)
            {
                BcTabs.Selected = null;
                BcTabs.Selected = this;
                InvokeAsync(StateHasChanged);
            }
        }
    }
}
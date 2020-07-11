namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Tabs
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Components;

    public partial class BCTabContent
    {
        [CascadingParameter]
        public BCTab BcTab { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected override async Task OnInitializedAsync()
        {
            BcTab.Content = ChildContent;
            BcTab.UpdateContent();
            await base.OnInitializedAsync();
        }
    }
}
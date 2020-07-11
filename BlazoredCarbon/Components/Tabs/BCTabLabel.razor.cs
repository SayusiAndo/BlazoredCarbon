namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Tabs
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Components;

    public partial class BCTabLabel
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [CascadingParameter]
        protected BCTab ParentBcTab { get; set; }

        private async Task Select()
        {
            await ParentBcTab.Select().ConfigureAwait(false);
        }
    }
}
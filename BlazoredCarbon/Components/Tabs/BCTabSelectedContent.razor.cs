namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Tabs
{
    using Microsoft.AspNetCore.Components;

    public partial class BCTabSelectedContent
    {
        [CascadingParameter]
        public BCTabs BcTabs { get; set; }
    }
}
namespace SayusiAndo.Carbon.BlazoredCarbon.ServerSide.Shared.Components
{
    using System.Collections.Generic;

    public partial class LeftHandMenu
    {
        private List<BlazoredCarbonComponent> BlazoredCarbonComponents = new List<BlazoredCarbonComponent>
        {
            new BlazoredCarbonComponent
            {
                Name = "Tab",
                Desc = "Tab component",
                Status = StatusEnum.InProgress,
                Link = "tabs"
            },
            new BlazoredCarbonComponent
            {
                Name = "Accordion",
                Desc = "Accordion Component",
                Status = StatusEnum.Planned,
                Link = "accordion"
            }
        };
    }

    public class BlazoredCarbonComponent
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public StatusEnum Status { get; set; }
        public string Link { get; set; }
    }

    public enum StatusEnum
    {
        Done,
        InProgress,
        Planned
    }
}
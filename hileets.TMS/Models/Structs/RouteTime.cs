using System;
namespace hileets.TMS.Models.Structs
{
    public struct RouteTime
    {
        public int Id { get; set; }
        public DateTime departureTime { get; set; }
        public DateTime arrivalTime { get; set; }
        public Route Route { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}

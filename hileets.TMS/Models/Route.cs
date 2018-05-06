using System;
using System.Collections.Generic;
using hileets.TMS.Models.Structs;

namespace hileets.TMS
{
    public class Route
    {
        private Station _from { get; set; }
        private Station _to { get; set; }
        private List<RouteTime> _timings { get; set; }

        public Route(Station from, Station to)
        {
            this._from = from;
            this._to = to;
        }

        public void AddTimings(DateTime departureTime, DateTime arrivalTime)
        {
            if(DateTime.Compare(arrivalTime, departureTime) < 0){
                return;
            }
            this._timings.Add(new RouteTime
            {
                departureTime = departureTime,
                arrivalTime = arrivalTime
            });
        }
    }
}

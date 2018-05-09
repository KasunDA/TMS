using System;
using System.Collections.Generic;
using hileets.TMS.DbContext;
using hileets.TMS.Models.Structs;

namespace hileets.TMS
{
    public class Route
    {
        private Station _from { get; set; }
        private Station _to { get; set; }
        private List<RouteTime> _timings { get; set; }
        
		public Station From {
			get{
				return _from;
			}
			set
            {
				_from = value;
            }
        }      
		public Station To{
			get{
				return _to;
			}
			set{
				_to = value;
			}
		}

        public Route(Station from, Station to)
        {
            this._from = from;
            this._to = to;
        }
        
        public bool AddTimings(DateTime departureTime, DateTime arrivalTime)
        {
            if(DateTime.Compare(arrivalTime, departureTime) <= 0){
                return false;
            }
            this._timings.Add(new RouteTime
            {
                departureTime = departureTime,
                arrivalTime = arrivalTime
            });
			return true;
        }

		public IEnumerable<Route> GetAllRoutes(){
			return Context.Instance.Routes;
		}
    }
}

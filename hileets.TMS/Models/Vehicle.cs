using System;
using System.Collections.Generic;

namespace hileets.TMS.Models
{
    public abstract class Vehicle
    {
        private string _number { get; set; }
        private Driver _driver { get; set; }
        private int _seats { get; set; }
        private List<Route> _routes { get; set; }

        private Vehicle(string number, Driver driver, int seats=4)
        {
            this._number = number;
            this._driver = driver;
            this._seats = seats;
        }

		public string Number{
			get{
				return _number;
            }
			set{
				_number = value;
			}
        }
        
		public Driver Driver{
			get{
				
				return _driver;
			}
			set{
				_driver = value;
            }
        }
        public int Seats{
			get{
				return _seats;           
            }
			set{
				_seats = value;
			}
        }

        public bool AddRoute(Route route){
            this._routes.Add(route);
            return true;
        }
    }
}

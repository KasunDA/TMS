using System;
using System.Collections.Generic;
using hileets.TMS.DbContext;

namespace hileets.TMS.Models.Structs
{
    public struct Station
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Station(string name, string address)
        {
            var random = new Random();
            this.Id = random.Next(1, 1000).ToString();
            this.Name = name;
            this.Address = address;
        }

		public static Station Add(string name, string address){
		    return new Station(name, address);
		}

        public static IEnumerable<Station> GetAllStations(){
			return Context.Instance.Stations;
        }
    }
}

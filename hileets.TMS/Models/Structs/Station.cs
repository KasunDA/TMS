using System;
using System.Collections.Generic;

namespace hileets.TMS.Models.Structs
{
    public struct Station
    {
        private static List<Station> _stations { get; set; }
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

        public static IEnumerable<Station> GetAllStations(){
            return _stations;
        }
    }
}

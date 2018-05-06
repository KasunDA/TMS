using System;
using System.Collections.Generic;
using System.Linq;

namespace hileets.TMS.Models
{
    public class Bus : Vehicle
    {
        private Person _conductor { get; set; }
        private bool _isAirCondition { get; set; }
        private static List<Bus> buses = new List<Bus>();

        public Bus(string number, Driver driver, int seats, bool isAirCondition=false)
            : base(number, driver, seats)
        {
            this._isAirCondition = isAirCondition;
            buses.Add(this);
        }
        public bool save(){
            buses.Add(this);
            return true;
        }
        public static List<string> getInfo(){
            if (buses.Count == 0)
                return null;
           return buses.Select(bus => bus.getNumber()).ToList();
        }
    }
}

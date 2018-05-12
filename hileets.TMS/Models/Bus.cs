using hileets.TMS.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace hileets.TMS.Models
{
    public class Bus : Vehicle
    {
        private Conductor _conductor { get; set; }
        private bool _isAirCondition { get; set; }


		private Bus(string number, Driver driver, int seats, bool isAirCondition = false)
            : base(number, driver, seats)
        {
            this.IsAirCondition = isAirCondition;
            Context.Instance.Buses.Add(this);
        }

		public static Bus Add(string number, Driver driver, int seats, bool isAirCondition = false){
			return new Bus(number, driver, seats, isAirCondition);
		}

        public Conductor Conductor
        {
            get { return _conductor; }
            set { _conductor = value; }
        }

        public bool IsAirCondition {
            get { return _isAirCondition; }
            set { _isAirCondition = value; }
        }
        
        public static List<string> All(){
            if (Context.Instance.Buses.Count == 0)
                return null;
           return Context.Instance.Buses.Select(bus => bus.Number).ToList();
        }
    }
}

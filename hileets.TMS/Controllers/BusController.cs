using System;
using hileets.TMS.Interfaces;
using hileets.TMS.Models;

namespace hileets.TMS.Controllers
{
    public class BusController
    {
        private Bus model;
        private IBusView view;

        public BusController(IBusView busView){
            view = busView;
        }

        public Bus createBus(string number, Driver driver, int seats, bool isAirCondition = false){
            return new Bus(number, driver, seats, isAirCondition);
        }

        public bool saveBus(Bus bus){
            bus.save();
        }
    }
}

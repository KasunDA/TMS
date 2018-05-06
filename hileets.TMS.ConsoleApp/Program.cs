using System;
using hileets.TMS.Controllers;

namespace hileets.TMS.ConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var busView = new BusView();
            var busController = new BusController(busView);
            busController.addBus("123", null, 3);
            busController.addBus("321", null, 3);
            busController.addBus("abc", null, 3);
        }
    }
}

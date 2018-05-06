using System;
using hileets.TMS.Interfaces;
using hileets.TMS.Models;

namespace hileets.TMS.ConsoleApp
{
    public class BusView : IBusView
    {
        public void PrintBusDetails(string busName)
        {
            Console.WriteLine(busName);
        }
    }
}

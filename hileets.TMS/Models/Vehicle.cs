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

        public Vehicle(string number, Driver driver, int seats=4)
        {
            this._number = number;
            this._driver = driver;
            this._seats = seats;
            //this._color = color;
        }

        public bool changeNumber(string newNumber){
            this._number = newNumber;
            return true;
        }

        public bool changeDriver(Driver newDriver){
            this._driver = newDriver;
            return true;
        }

        //public bool changeColor(string newColor){
            //this._color = newColor;
            //return true;
        //}
        public string getNumber(){
            return this._number;
        }
        public bool changeSeats(int newSeats){
            this._seats = newSeats;
            return true;
        }

        public bool addRoute(Route route){
            this._routes.Add(route);
            return true;
        }
    }
}

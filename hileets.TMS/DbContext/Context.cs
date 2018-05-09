﻿using System;
using System.Collections.Generic;
using System.Linq;
using hileets.TMS.Models;
using hileets.TMS.Models.Structs;

namespace hileets.TMS.DbContext
{
    public sealed class Context
    {
        public static readonly Context _context = new Context();
		public List<Customer> Customers = new List<Customer>();
        public List<Admin> Admins = new List<Admin>();
        List<Booking> Bookings = new List<Booking>();
		public List<Station> Stations = new List<Station>();
		public List<Route> Routes = new List<Route>();

        static Context(){}
        private Context(){}

        public static Context Instance
        {
            get{
                return _context;
            }
        }
    }
}

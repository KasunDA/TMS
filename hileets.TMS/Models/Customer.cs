using System;
using System.Collections.Generic;

namespace hileets.TMS.Models
{
    public class Customer :  Person
    {
        private string username { get; set; }
        private string password { get; set; }
        private string email { get; set; }
        private List<Booking> _bookings { get; set; }

        public Customer(string name, string username, string password, string email, string phone, Gender gender) : base(name, phone, gender)
        {
            this.username = username;
            this.password = password;
            this.email = email;
        }

        public bool AddBooking(Route route, bool paymentStatus){
            return true;
        }

        public bool RemoveBooking(Route route){
            return true;
        }
        //public bool updateBooking(Route route)
        public IEnumerable<Booking> AllBookings(){
            return null;
        }
    }
}

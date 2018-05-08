using System;
using System.Collections.Generic;
using hileets.TMS.Models;
using hileets.TMS.Views;

namespace hileets.TMS.ConsoleApp
{
    public class VCustomer : IPersonView
    {
        public bool AddBooking()
        {
            throw new NotImplementedException();
        }

        public bool RemoveBooking()
        {
            throw new NotImplementedException();
        }

        public void LoggedIn(Person sender)
        {
            var customer = sender as Customer;
            Console.Clear();
            Console.WriteLine("{0}, Welcome to Customer Menu", customer.Name);
        }

        public void DisplayMenu(IEnumerable<string> Menu)
        {
            int index = 0;
            foreach(string item in Menu){
                index++;
                Console.WriteLine(index + ") " +item);
            }
        }

        public void SignedUp(Person sender)
        {
            var customer = sender as Customer;
            Console.WriteLine("New User {0} Signed Up Successfully", customer.Name);
        }
    }
}

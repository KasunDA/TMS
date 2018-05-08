using System;
using System.Collections.Generic;
using System.Linq;
using hileets.TMS.DbContext;

namespace hileets.TMS.Models
{
    public class Customer :  Person
    {
        private static readonly List<string> _menu = new List<string>(){
            "Add Booking",
            "Remove Booking",
            "Change Password"
        };
        
        private string _username { get; set; }
        private string _password { get; set; }
        private string _email { get; set; }
        private static Context _context = Context.Instance;

        public string UserName {
            get{
                return _username;
            }
            private set{
                var usrValidate = _context.Customers.SingleOrDefault(c => c.UserName == value);
                if (usrValidate == null)
                    _username = value;
                else{
                    throw new Exception("Username alredy exists.");            
                }
            }
        }

        public string Password {
            get{
                return "******";
            }
            private set{
                if (value.Length < 6){
                    throw new Exception("Password should be 6 character minimum.");
                }
                _password = value;
            }
        }

        public string Email {
            get{
                return _email;
            }
            private set{
                var emailValidate = _context.Customers.SingleOrDefault(c => c.Email == value);
                if(emailValidate == null)
                    _email = value;
                else{
                    throw new Exception("Email already exists.");
                }
            }
        }

        public static IEnumerable<string> Menu{
            get{
                return _menu;
            }
        }

        public bool ComparePassword(string pass){
            if (_password == pass)
                return true;
            else
                return false;
        }

        public bool ChangePassword(string oldpassword, string newpassword){
            if(ComparePassword(oldpassword)){
                Password = newpassword;
                return true;
            }
            return false;
        }

        public static Customer Login(string username, string password)
        {
            return _context.Customers.SingleOrDefault(customer => customer.UserName == username && customer.ComparePassword(password));
        }

        public static Customer Signup(string name, string username, string password, string email, string phone, Gender gender){
            var newCustomer = new Customer(name, username, password, email, phone, gender);
            _context.Customers.Add(newCustomer);
            return newCustomer;
        }

        private Customer(string name, string username, string password, string email, string phone, Gender gender) 
            : base(name, phone, gender)
        {
            this.UserName = username;
            this.Password = password;
            this.Email = email;
        }

    }
}

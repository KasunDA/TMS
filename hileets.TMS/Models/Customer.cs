using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using hileets.TMS.DbContext;
using hileets.TMS.Models.Interfaces;

namespace hileets.TMS.Models
{
    public class Customer :  Person
    {
        private static readonly List<string> _menu = new List<string>(){
            "Add Booking",
            "Remove Booking",
            "Change Password",

        };

        private string _username;
        private string _password { get; set; }
        private string _email { get; set; }
        private static Context _context = Context.Instance;

        //public event PropertyChangedEventHandler PropertyChanged;

        //public event PropertyChangedEventHandler PropertyChanged;

        public string UserName {
            get{
                return _username;
            }
            set{
				if (value.Length < 6)
					throw new Exception("Name should be 6 character minimum.");
				
                var usrValidate = _context.Customers.SingleOrDefault(c => c.UserName == value);
                if (usrValidate == null)
                    SetProperty(ref _username, value);
                else
                    throw new Exception("Username alredy exists.");            
               
            }
        }

        private void SetProperty(ref string username, string value)
        {
            username = value;

        }

        //private void OnPropertyChanged(string v)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if(handler != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(v));
        //}

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
            using (var con = new OleDbConnection(Context.connectionString))
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("dbo.CustomerLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                var res = cmd.ExecuteReader();
                //Console.WriteLine(res.Read());
                if (!res.HasRows)
                    throw new Exception("No user exist with these credentials.");

                res.Read();
                var newCustomer = new Customer(res.GetString(6), res.GetString(2), res.GetString(3), res.GetString(4), res.GetString(7), (Gender)res.GetByte(8));
                //Console.WriteLine(res);
                //var newCustomer = new Customer(name, username, password, email, phone, gender);
                //_context.Customers.Add(newCustomer);
                return newCustomer;
                //         var ReturnCustomer = _context.Customers.FirstOrDefault(customer => customer.UserName == username && customer.ComparePassword(password));
                //if (ReturnCustomer == null)
                //	throw new Exception("No customer found with the provided credentials");
                //return ReturnCustomer;
            }
        }

        public static Customer Signup(string name, string username, string password, string email, string phone, Gender gender){
            using (var con = new OleDbConnection(Context.connectionString))
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("dbo.CustomerSignup", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FullName", name);
                cmd.Parameters.AddWithValue("@PhoneNo", phone);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
                var newCustomer = new Customer(name, username, password, email, phone, gender);
                //_context.Customers.Add(newCustomer);
                return newCustomer;
            }
        }

        public void SaveChanges()
        {
            using (var con = new OleDbConnection(Context.connectionString))
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("dbo.CustomerUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FullName", this.Name);
                cmd.Parameters.AddWithValue("@PhoneNo", this.Phone);
                cmd.Parameters.AddWithValue("@Gender", this.Gender);
                cmd.Parameters.AddWithValue("@Username", this.UserName);
                cmd.Parameters.AddWithValue("@Password", this._password);
                cmd.Parameters.AddWithValue("@Email", this.Email);
                var res = cmd.ExecuteNonQuery();
            }
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

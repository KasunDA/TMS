using System;
namespace hileets.TMS.Models
{
    public enum Gender{
        Male,
        Female
    }
    public abstract class Person
    {
        protected string _name { get; set; }
        protected string _phone { get; set; }
        protected Gender _gender { get; set; }

        public Person(string name, string phone, Gender gender)
        {
            this._name = name;
            this._phone = phone;
            this._gender = gender;
        }
    }
}

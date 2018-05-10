using System;
namespace hileets.TMS.Models
{
    public enum Gender{
        Male = 1,
        Female = 2 
    }
    public abstract class Person
    {
        private string _name { get; set; }
        private string _phone { get; set; }
        private Gender _gender { get; set; }

        public string Name {
            get{
                return _name;
            }
            set{
                if (value.Length < 6)
                    throw new Exception("Please enter a valid name");
				else
                    _name = value;
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (value.Length < 11)
                   throw new Exception("Please enter a valid phone number of length 11.");
				else
                    _phone = value;
            }
        }

        public Gender Gender
        {
            get{
                return _gender;
            }
            set{
                _gender = value;
            }
        }
        protected Person(){}
        public Person(string name, string phone, Gender gender)
        {
            this.Name = name;
            this.Phone = phone;
            this.Gender = gender;
        }
    }
}

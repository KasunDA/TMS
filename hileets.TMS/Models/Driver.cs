using System;
using System.Collections;

namespace hileets.TMS.Models
{
    public class Driver : Person
    {
        public class PersonDTO
        {
            public string name { get; set; }
        }

        private string _license { get; set; }
        private string _cnic { get; set; }

        public Driver(string name, string phone="123", Gender gender=Gender.Male, string license="123", string cnic="123") : base(name, phone, gender)
        {
            this._license = license;
            this._cnic = cnic;
        }

        public PersonDTO getInfo(){
            return new PersonDTO()
            {
                name = this._name
            };
        }
    }
}


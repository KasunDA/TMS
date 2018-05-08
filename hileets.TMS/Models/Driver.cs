using System;
using System.Collections;

namespace hileets.TMS.Models
{
    public class Driver : Person
    {
        private string _license { get; set; }
        private string _cnic { get; set; }

        public string License {
            get{
                return _license;
            }
            set{
                _license = value;
            }
        }

        public string Cnic {
            get{
                return _cnic;
            }
            private set {
                _cnic = value;
            }
        }

        public Driver(string name, string phone="123", Gender gender=Gender.Male, string license="123", string cnic="123") 
            : base(name, phone, gender)
        {
            this.License = license;
            this.Cnic = cnic;
        }

       
    }
}


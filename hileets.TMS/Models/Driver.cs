using hileets.TMS.DbContext;
using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;

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

		public static Driver Add(string name, string phone = "123", Gender gender = Gender.Male, string license = "123", string cnic = "123"){
            using (var con = new OleDbConnection(Context.connectionString))
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("dbo.CustomerUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FullName", name);
                cmd.Parameters.AddWithValue("@PhoneNo", phone);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Licence", license);
                cmd.Parameters.AddWithValue("@Cnic", cnic);
                cmd.ExecuteNonQuery();
                return new Driver(name, phone, gender, license, cnic);
            }
		}

        private Driver(string name, string phone, Gender gender, string license, string cnic) 
            : base(name, phone, gender)
        {
            this.License = license;
            this.Cnic = cnic;
        }      
    }
}


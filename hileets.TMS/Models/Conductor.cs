using System;
using hileets.TMS.DbContext;

namespace hileets.TMS.Models
{
    public class Conductor : Person
    {
        private Conductor(string name, string phone, Gender gender) : base(name, phone, gender)
        {
			Context.Instance.Conductors.Add(this);
        }
        
		public static Conductor Add(string name, string phone, Gender gender){
			return new Conductor(name, phone, gender);
		}  
    }
}

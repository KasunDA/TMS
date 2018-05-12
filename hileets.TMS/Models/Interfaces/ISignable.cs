using System;
namespace hileets.TMS.Models.Interfaces
{
	public interface ISignable
	{
		string UserName { get; set; }
		string Password { get; set; }
		string Email { get; set; }
		bool ComparePassword { get; set; }
		bool ChangePassword { get; set; }
	}
}

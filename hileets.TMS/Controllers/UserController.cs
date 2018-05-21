using System;
using hileets.TMS.Views;
using hileets.TMS.Models;
using hileets.TMS.DbContext;

namespace hileets.TMS.Controllers
{
    public class UserController
    {
        private static IPersonView _view;
        private static Customer _model;

        public UserController(IPersonView customerView)
        {
            _view = customerView;
            _model = null;
        }

        public void Signup(string name, string username, string password, string email, string phone, Gender gender){
            if(_model != null){
                ErrorHandling.LogE("You are already logged In.");
                return;
            }
            _model = Customer.Signup(name, username, password, email, phone, gender);
            _view.SignedUp(_model);
        }

        public bool Login(string username, string password){
            if(_model != null){
                ErrorHandling.LogE("You are alredy logged In.");
                return false;
            }
            //_model = Customer.Login(username, password);
            if (_model == null){
				ErrorHandling.LogE("Unable to login with provided credetials.");
                return false;            
            }
            else{
                _view.LoggedIn(_model);
                return true;
            }
        }

        public void DisplayMenu(){
            _view.DisplayMenu(Customer.Menu);
        }

        public bool ChangePassword(string oldpassword, string newpassword){
            if(_model.ChangePassword(oldpassword, newpassword)){
                ErrorHandling.LogM("Your password chagned successfully!");
                return true;
            }else{
                ErrorHandling.LogE("Error while changing password");
                return false;
            }
        }
   }
}

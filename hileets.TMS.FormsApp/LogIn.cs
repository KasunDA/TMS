using hileets.TMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hileets.TMS.FormsApp
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string type = catagoryBox.Text;
                string username = usernameBox.Text;
                string password = passwordBox.Text;
                MessageBox.Show(String.Format("{0} | {1} | {2}", type, username, password), "OK");
                if (type == "Customer")
                {
                    var cust = Customer.Login(username, password);
                    if(cust != null)
                    {
                        CustomerBoard window = new CustomerBoard(cust);
                        window.Show();
                        this.Hide();
                    }
                } else if(type == "Admin")
                {
                    var admin = Admin.Login(username, password);
                    if (admin != null)
                    {
                        AdminBoard window = new AdminBoard(admin);
                        window.Show();
                        this.Hide();
                    }
                }
            }catch(Exception er)
            {
                MessageBox.Show(er.Message, "Error");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Visible = false;
        }
    }
}

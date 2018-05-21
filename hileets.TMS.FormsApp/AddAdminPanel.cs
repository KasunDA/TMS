using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hileets.TMS.Models;

namespace hileets.TMS.FormsApp
{
    public partial class AddAdminPanel : UserControl
    {
        public AddAdminPanel()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var fullname = textBox2.Text;
                var email = textBox3.Text;
                var username = usernameBox.Text;
                var password = passwordBox.Text;
                var phone = textBox1.Text;
                var gender = comboBox1.Text == "Male" ? Gender.Male : Gender.Female;
                var admin = Admin.Signup(fullname, username, password, email, phone, gender);
                MessageBox.Show(string.Format("New Admin with username {0} is created", admin.UserName));
            }catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}

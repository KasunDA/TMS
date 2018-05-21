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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Visible = false;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var name = textBox2.Text;
                var email = textBox3.Text;
                var username = usernameBox.Text;
                var password = passwordBox.Text;
                var phone = maskedTextBox1.Text;
                var gender = comboBox1.Text == "Male" ? Gender.Male : Gender.Female;
                MessageBox.Show(gender.ToString());
                var customer = Customer.Signup(name, username, password, email, phone, gender);
                if (customer != null)
                {
                    CustomerBoard board = new CustomerBoard(customer);
                    board.Show();
                    this.Hide();
                }
            }catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}

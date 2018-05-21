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
    public partial class CustomerBoard : Form
    {
        Customer customer;
        public CustomerBoard(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            highlighter.Visible = false;
        }

        private void CustomerBoard_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            highlighter.Location = new Point(12, 207);
            highlighter.Visible = true;
            mainPanel.Controls.Clear();
            var bookingActive = new CustomerBooking();
            mainPanel.Controls.Add(bookingActive);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            highlighter.Location = new Point(12, 258);
            highlighter.Visible = true;
            mainPanel.Controls.Clear();
            var bookingActive = new CustomerBookingCancellation();
            mainPanel.Controls.Add(bookingActive);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            highlighter.Location = new Point(12, 310);
            highlighter.Visible = true;
            mainPanel.Controls.Clear();
            var bookingActive = new CustomerAccountSettingPanel();
            mainPanel.Controls.Add(bookingActive);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

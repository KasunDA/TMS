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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            IEnumerable<string> s = Customer.Menu;
            highlighter.Visible = false;    
        }
        
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            highlighter.Location = new Point(12, 211);
            highlighter.Visible = true;
            mainPanel.Controls.Clear();
            var bookingActive = new BookingPanel();
            mainPanel.Controls.Add(bookingActive);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            highlighter.Location = new Point(12, 262);
            highlighter.Visible = true;
            mainPanel.Controls.Clear();
            var bookingActive = new TerminalPanel();
            mainPanel.Controls.Add(bookingActive);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            highlighter.Location = new Point(12, 314);
            highlighter.Visible = true;
            mainPanel.Controls.Clear();
            var bookingActive = new BusesPanel();
            mainPanel.Controls.Add(bookingActive);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            highlighter.Location = new Point(12, 365);
            highlighter.Visible = true;
            mainPanel.Controls.Clear();
            var bookingActive = new DriverPanel();
            mainPanel.Controls.Add(bookingActive);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            highlighter.Location = new Point(12, 416);
            highlighter.Visible = true;
            mainPanel.Controls.Clear();
            var bookingActive = new ConductorPanel();
            mainPanel.Controls.Add(bookingActive);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            highlighter.Location = new Point(12, 467);
            highlighter.Visible = true;
            mainPanel.Controls.Clear();
            var bookingActive = new CustomerPanel();
            mainPanel.Controls.Add(bookingActive);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            highlighter.Location = new Point(12, 518);
            highlighter.Visible = true;
            mainPanel.Controls.Clear();
            var bookingActive = new RoutePanel();
            mainPanel.Controls.Add(bookingActive);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            highlighter.Location = new Point(12, 569);
            highlighter.Visible = true;
            mainPanel.Controls.Clear();
            var bookingActive = new AddAdminPanel();
            mainPanel.Controls.Add(bookingActive);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var bookingActive = new AccountSettingPanel();
            mainPanel.Controls.Add(bookingActive);
        }
    }
}

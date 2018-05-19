using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hileets.TMS.FormsApp
{
    public partial class CustomerBooking : UserControl
    {
        public CustomerBooking()
        {
            InitializeComponent();
            reciptPanel.Visible = false;
            comboBox1.Items.Add("Booked");
            comboBox1.Items.Add("Purchased");
            maskedTextBox3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reciptPanel.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reciptPanel.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedTextBox3.Visible = true;
        }
    }
}

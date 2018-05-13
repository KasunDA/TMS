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
    public partial class BookingPanel : UserControl
    {
        public BookingPanel()
        {
            InitializeComponent();
            //dateTimePicker1.MinDate = DateTime.Now.Date;
            reciptPanel.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            String s = dateTimePicker2.Value.Date.ToString("MM-dd-yyyy");
            Console.WriteLine(s);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            reciptPanel.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reciptPanel.Visible = false;
        }
    }
}

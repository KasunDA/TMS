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
    }
}

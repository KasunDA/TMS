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
    public partial class CustomerBookingCancellation : UserControl
    {
        public CustomerBookingCancellation()
        {
            InitializeComponent();
            cancellationPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cancellationPanel.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cancellationPanel.Visible = false;
        }
    }
}

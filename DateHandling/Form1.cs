using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateDueDays_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to calculate the days until due date
            DateTime currentDate = DateTime.Today;
            DateTime futureDate = Convert.ToDateTime(txtFutureDate.Text);
            int days = currentDate.Subtract(futureDate).Days;
            StringBuilder sb = new StringBuilder();
            sb.Append($"Current date   :\t{currentDate:d}\n\n");
            sb.Append($"Future date    :\t{futureDate:d}\n\n");
            sb.Append($"Days until due :\t{days}\n\n");
            MessageBox.Show(sb.ToString(), "Due Days Calculateion");
        }

        private void btnCalculateAge_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to calculate the age
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

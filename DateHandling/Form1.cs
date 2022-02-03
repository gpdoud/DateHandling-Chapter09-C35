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
            TimeSpan timespan = futureDate.Subtract(currentDate);
            int days = timespan.Days;

            string message = string.Empty;
            message += $"Current date:\t{currentDate:d}\n\n";
            message += $"Future date: \t{futureDate:d}\n\n";
            message += $"Days until due :\t{days}\n\n";

            MessageBox.Show(message, "Due Days Calculation");
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

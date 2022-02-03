using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            int days = futureDate.Subtract(currentDate).Days;
            StringBuilder sb = new StringBuilder();
            sb.Append($"Current date   :\t{currentDate:d}\n\n");
            sb.Append($"Future date    :\t{futureDate:d}\n\n");
            sb.Append($"Days until due :\t{days}\n\n");
            MessageBox.Show(sb.ToString(), "Due Days Calculateion");
        }

        private void btnCalculateAge_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to calculate the age
            DateTime birthDate = DateTime.Parse(txtBirthDate.Text,
                                                CultureInfo.CurrentCulture,
                                                DateTimeStyles.AssumeLocal);
            DateTime currentDate = DateTime.Today;
            long ticks = currentDate.Ticks - birthDate.Ticks;
            int years = new DateTime(ticks).Year;
            if(currentDate.DayOfYear < birthDate.DayOfYear) {
                years--;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append($"Current Date:\t {currentDate.ToString("d")}\n\n");
            sb.Append($"Birth Date  :\t {birthDate.ToString("d")}\n\n");
            sb.Append($"Age         :\t {years}");
            MessageBox.Show(sb.ToString(), "Age Calculation");
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

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
            DateTime futureDate = DateTime.Parse(txtFutureDate.Text, 
                                                CultureInfo.CurrentCulture,
                                                DateTimeStyles.AssumeLocal);
            DateTime birthDate = DateTime.Parse(txtBirthDate.Text,
                                                CultureInfo.CurrentCulture,
                                                DateTimeStyles.AssumeLocal);
            int days = futureDate.Subtract(birthDate).Days;
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

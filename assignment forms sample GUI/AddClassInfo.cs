using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_forms_sample_GUI
{
    public partial class frmAddClassInfo : Form
    {
        public frmAddClassInfo()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TutorMenu tutomenu = new TutorMenu();
            tutomenu.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

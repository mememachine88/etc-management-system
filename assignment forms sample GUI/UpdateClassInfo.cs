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
    public partial class frmUpdateClassInfo : Form
    {
        public frmUpdateClassInfo()
        {
            InitializeComponent();
        }

        private void lblUpdateClassInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TutorMenu tutorMenu = new TutorMenu();
            tutorMenu.Show();
            this.Close();
        }

        private void btnUpdateExistingClass_Click(object sender, EventArgs e)
        {

        }
    }
}

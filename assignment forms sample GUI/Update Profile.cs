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
    public partial class frmUpdateProfile : Form
    {
        public frmUpdateProfile()
        {
            InitializeComponent();
        }

        private void txtNewName_TextChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            TutorMenu tutorMenu = new TutorMenu();
            this.Close();
            tutorMenu.Show();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile();
            this.Close();
            profile.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNewEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

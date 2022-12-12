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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            TutorMenu tutorMenu = new TutorMenu();
            this.Hide();
            tutorMenu.Show();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            frmUpdateProfile updateProfile = new frmUpdateProfile();
            updateProfile.Show();
            this.Hide(); 
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}

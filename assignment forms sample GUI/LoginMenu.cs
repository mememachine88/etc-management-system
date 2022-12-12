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
    public partial class frmLoginMenu : Form
    {
        public frmLoginMenu()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginUsername = txtUsername.Text;
            var loginPassword = txtPassword.Text;
          

            if (loginUsername.Equals("Ali") && loginPassword.Equals("12345"))
            {
                LoginInfo.Username= loginUsername;
                TutorMenu tutormenu = new TutorMenu();
                tutormenu.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Login Failed!");
                
            }
                



        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcomeLogin_Click(object sender, EventArgs e)
        {

        }
    }
}

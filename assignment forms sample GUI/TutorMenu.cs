using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace assignment_forms_sample_GUI
{
    public partial class TutorMenu : Form
    {
 
        
        public TutorMenu()
        {
            InitializeComponent();
            lblWelcomeMessage.Text = "welcome " + LoginInfo.Username;
        }
        private void btnAddClassInfo_Click(object sender, EventArgs e)
        {
            frmAddClassInfo addClassInfo = new frmAddClassInfo();
            addClassInfo.Show();
            this.Hide();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
           frmProfile profile = new frmProfile();
            profile.Show();
            this.Hide();
        }

        private void lblWelcomeMessage_Click(object sender, EventArgs e)
        {
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateClassInfo_Click(object sender, EventArgs e)
        {
            frmUpdateClassInfo updateClassInfo = new frmUpdateClassInfo();
            updateClassInfo.Show();
            this.Hide();
        }
    }
}
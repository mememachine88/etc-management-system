namespace assignment_forms_sample_GUI
{
    public partial class TutorMenu : Form
    {
        public TutorMenu()
        {
            InitializeComponent();
        }

        private void btnAddClassInfo_Click(object sender, EventArgs e)
        {
            frmAddClassInfo addClassInfo = new frmAddClassInfo();
            addClassInfo.Show();
            this.Hide();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
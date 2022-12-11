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
    public partial class Popup : Form
    {
    
        public Popup(string message)
        {
            InitializeComponent();
            lblPopup.Text = message;
        }

        private void lblPopup_Click(object sender, EventArgs e)
        {

        }
    }
}

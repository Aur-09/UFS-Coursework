using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //DisplayedInfo displayinfo = new DisplayedInfo(string name, string age, string chosenAnimal);
            //displayinfo = displayinfo.
        }
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.Yes)
            {
                frmWelcomePage welcomePage = new frmWelcomePage();
                welcomePage.Show();
                this.Hide();
            }
        }

        private void btnBuyPet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for buying with us! 🌊 " +
                "Your new fish is in great hands." +
                " We have sent your order summary to your email," +
                " and a team member will contact you within" +
                " a few hours regarding payment details and delivery. " +
                "Take great care of your little swimmer!", "Purchase Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

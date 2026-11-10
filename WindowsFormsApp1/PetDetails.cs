using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPetDetails : Form
    {
        public frmPetDetails()
        {
            InitializeComponent();
        }

        private void radJawlessfish_CheckedChanged(object sender, EventArgs e)
        {
            if (radJawlessfish.Checked)
            {
                lblFishType.Text = radJawlessfish.Text;
                pcbFishType.Image = Properties.Resources.Jawless_Fish_Agnatha;
                lblFishTypeInfo.Text = "Name: Jawless fish" +
            "\r\nPrice: R15.50" +
            "\r\nDanger: Low to Humans (parasitic to aquatic life)" +
            "\r\nHealth Benefits: High in protein and Vitamin B12" +
            "\r\nAverage Length: 0.15 m to 1.0 m";
            }
        }

        private void btnChooseFish_Click(object sender, EventArgs e)
        {
            if(DialogResult == DialogResult.Yes)
            {
                frmWelcomePage welcomepage = new frmWelcomePage();
                welcomepage.Show();
                this.Hide();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                frmPetFish bookAFish = new frmPetFish();
                bookAFish.Show();
                this.Hide();
            }
        }

        private void radCartilaginousfish_CheckedChanged(object sender, EventArgs e)
        {
            if (radCartilaginousfish.Checked)
            {
                lblFishType.Text = radCartilaginousfish.Text;
                pcbFishType.Image = Properties.Resources.Cartilaginous_Fish_Chondrichthyes;
                lblFishTypeInfo.Text = "Name: Cartilaginous fish" +
                "\r\nPrice: R18.00" +
                "\r\nDanger: High (includes sharks and stingrays)" +
                "\r\nHealth Benefits: High in chondroitin, protein, and squalene" +
                "\r\nAverage Length: 0.5 m to 12.0 m";
            }
        }

        private void radRayFinned_CheckedChanged(object sender, EventArgs e)
        {
            if (radRayFinned.Checked)
            {
                lblFishType.Text = radRayFinned.Text;
                pcbFishType.Image = Properties.Resources.Ray_Finned_Fish_Actinopterygii;
                lblFishTypeInfo.Text = "Name: Ray-finned fish" +
            "\r\nPrice: R12.00" +
            "\r\nDanger: Low to Moderate (depends on species)" +
            "\r\nHealth Benefits: Rich in protein, niacin, and phosphorus" +
            "\r\nAverage Length: 0.01 m to 3.0 m";
            }
        }

        private void radLobeFinnedfish_CheckedChanged(object sender, EventArgs e)
        {
            if (radLobeFinnedfish.Checked)
            {
                lblFishType.Text = radLobeFinnedfish.Text;
                pcbFishType.Image = Properties.Resources.lobe_finned_fish;
                lblFishTypeInfo.Text = "Name: Lobe-finned fish" +
                "\r\nPrice: R45.00" +
                "\r\nDanger: Low (rare deep-water species like Coelacanths)" +
                "\r\nHealth Benefits: Rarely consumed (protected species)" +
                "\r\nAverage Length: 1.5 m to 2.0 m";
            }
        }

        private void radFreshwaterfish_CheckedChanged(object sender, EventArgs e)
        {
            if (radFreshwaterfish.Checked)
            {
                lblFishType.Text = radFreshwaterfish.Text;
                pcbFishType.Image = Properties.Resources.Freshwater_fish;
                lblFishTypeInfo.Text = "Name: Freshwater fish" +
                "\r\nPrice: R10.50" +
                "\r\nDanger: Low" +
                "\r\nHealth Benefits: Good source of lean protein and Vitamin B3" +
                "\r\nAverage Length: 0.1 m to 2.5 m";
            }
        }

        private void radDemersalfish_CheckedChanged(object sender, EventArgs e)
        {
            if (radDemersalfish.Checked)
            {
                lblFishType.Text = radDemersalfish.Text;
                pcbFishType.Image = Properties.Resources.Dermesal_Fish;
                lblFishTypeInfo.Text = "Name: Demersal fish" +
                "\r\nPrice: R13.25" +
                "\r\nDanger: Low" +
                "\r\nHealth Benefits: Low in fat, high in lean protein and B-vitamins" +
                "\r\nAverage Length: 0.3 m to 1.5 m";
            }
        }

        private void radWhitefish_CheckedChanged(object sender, EventArgs e)
        {
            if (radWhitefish.Checked)
            {
                lblFishType.Text = radWhitefish.Text;
                pcbFishType.Image = Properties.Resources.whitefish;
                lblFishTypeInfo.Text = "Name: White fish" +
                "\r\nPrice: R11.00" +
                "\r\nDanger: Low" +
                "\r\nHealth Benefits: Low calorie, rich in Selenium and B12" +
                "\r\nAverage Length: 0.3 m to 1.0 m";
            }
        }

        private void radSaltwaterfish_CheckedChanged(object sender, EventArgs e)
        {
            if (radSaltwaterfish.Checked)
            {
                lblFishType.Text = radSaltwaterfish.Text;
                pcbFishType.Image = Properties.Resources.salt_water_fish;
                lblFishTypeInfo.Text = "Name: Saltwater fish" +
                "\r\nPrice: R16.75" +
                "\r\nDanger: Low to Moderate" +
                "\r\nHealth Benefits: High in Iodine, Selenium, and Omega-3" +
                "\r\nAverage Length: 0.15 m to 4.0 m";
            }
        }

        private void radBrackishwaterfish_CheckedChanged(object sender, EventArgs e)
        {
            if (radBrackishwaterfish.Checked)
            {
                lblFishType.Text = radBrackishwaterfish.Text;
                pcbFishType.Image = Properties.Resources.Brackish_water_fish;
                lblFishTypeInfo.Text = "Name: Brackish water fish" +
                "\r\nPrice: R14.00" +
                "\r\nDanger: Low" +
                "\r\nHealth Benefits: Rich in essential minerals and protein" +
                "\r\nAverage Length: 0.1 m to 1.2 m";
            }
        }

        private void radAnadromousfish_CheckedChanged(object sender, EventArgs e)
        {
            if (radAnadromousfish.Checked)
            {
                lblFishType.Text = radAnadromousfish.Text;
                pcbFishType.Image = Properties.Resources.Anadromous_fish;
                lblFishTypeInfo.Text = "Name: Anadromous fish" +
                "\r\nPrice: R22.50" +
                "\r\nDanger: Low" +
                "\r\nHealth Benefits: Exceptionally high in healthy fatty acids" +
                "\r\nAverage Length: 0.5 m to 1.5 m";
            }
        }

        private void radCatadromousfish_CheckedChanged(object sender, EventArgs e)
        {
            if (radCatadromousfish.Checked)
            {
                lblFishType.Text = radCatadromousfish.Text;
                pcbFishType.Image = Properties.Resources.Catadromous_fish;
                lblFishTypeInfo.Text = "Name: Catadromous fish" +
                "\r\nPrice: R20.00" +
                "\r\nDanger: Low" +
                "\r\nHealth Benefits: High in Vitamin A, Vitamin E, and protein" +
                "\r\nAverage Length: 0.4 m to 1.2 m";
            }
        }

        private void radDeepseafish_CheckedChanged(object sender, EventArgs e)
        {
            if (radDeepseafish.Checked)
            {
                lblFishType.Text = radDeepseafish.Text;
                pcbFishType.Image = Properties.Resources.Deep_sea_fish;
                lblFishTypeInfo.Text = "Name: Deep-sea fish" +
                "\r\nPrice: R28.00" +
                "\r\nDanger: Moderate (sharp teeth and spines)" +
                "\r\nHealth Benefits: High in trace minerals and protein" +
                "\r\nAverage Length: 0.1 m to 2.0 m";
            }
        }

        private void radOilyfish_CheckedChanged(object sender, EventArgs e)
        {
            if (radOilyfish.Checked)
            {
                lblFishType.Text = radOilyfish.Text;
                pcbFishType.Image = Properties.Resources.oily_fish;
                lblFishTypeInfo.Text = "Name: Oily fish" +
                "\r\nPrice: R9.50" +
                "\r\nDanger: Low" +
                "\r\nHealth Benefits: Exceptionally rich in Omega-3 & Vitamin D" +
                "\r\nAverage Length: 0.2 m to 2.0 m";
            }
        }

        private void radPelagicFish_CheckedChanged(object sender, EventArgs e)
        {
            if (radPelagicFish.Checked)
            {
                lblFishType.Text = radPelagicFish.Text;
                pcbFishType.Image = Properties.Resources.Pelagic_fish;
                lblFishTypeInfo.Text = "Name: Pelagic fish" +
                "\r\nPrice: R17.50" +
                "\r\nDanger: Low to Moderate" +
                "\r\nHealth Benefits: High concentrations of Omega-3 and Vitamin D" +
                "\r\nAverage Length: 0.3 m to 3.0 m";
            }
        }

        private void grpFishType_Enter(object sender, EventArgs e)
        {

        }
        //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
    }
}

using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace FruitApplication
{
    public partial class frmFruit : Form
    {
        CFruit fruit;
        string filename;
        public frmFruit()
        {
            InitializeComponent();
        }

        private void radApple_CheckedChanged(object sender, EventArgs e)
        {
            txtFruitCode.Clear();
            nudWeight.Value = 0;
            txtPictureURL.Clear();
            chkIsOrganic.Checked = chkIsRipe.Checked = chkIsSeedless.Checked = false; 
            picFruit.Image = null;
            lblDisplay.Text = "";

            chkIsOrganic.Visible = radApple.Checked; 
            chkIsRipe.Visible = radBanana.Checked; 
            chkIsSeedless.Visible = radOrange.Checked; 
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if(openfile.ShowDialog() == DialogResult.OK)
            {
                filename = openfile.FileName;
                txtPictureURL.Text = filename;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if(string.IsNullOrEmpty(txtPictureURL.Text) || string.IsNullOrEmpty(txtFruitCode.Text))
                {
                    MessageBox.Show("Please enter all required fields");
                }
                else
                {

                    if (radApple.Checked)
                    {
                        fruit = new CApple(txtPictureURL.Text, txtFruitCode.Text, double.Parse(nudWeight.Text), chkIsOrganic.Checked);

                    }
                    else if (radBanana.Checked)
                    {
                        fruit = new CBanana(txtPictureURL.Text, txtFruitCode.Text, double.Parse(nudWeight.Text), chkIsRipe.Checked);

                    }
                    else if (radOrange.Checked)
                    {
                        fruit = new COrange(txtPictureURL.Text, txtFruitCode.Text, double.Parse(nudWeight.Text), chkIsSeedless.Checked);
                    }
                    else
                    {
                        MessageBox.Show("Please Select a Fruit");
                    }
                    lblDisplay.Text = fruit.Details();
                    picFruit.Image = Image.FromFile(txtPictureURL.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //using (FileStream fileStream = new FileStream("FruitStock.txt", FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter("FruitStock.txt"))
            {
                writer.WriteLine(fruit.FileDetails());
            }
            MessageBox.Show("CONTENT SAVED SUCCEFULLY");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

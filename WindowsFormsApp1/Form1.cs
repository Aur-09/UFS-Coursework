using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPetFish : Form
    {
        public frmPetFish()
        {
            InitializeComponent();
            decimal[] fishPrices = new decimal[] { 15.50m, 18.00m, 12.00m, 45.00m, 10.50m, 16.75m,
                                                   14.00m, 22.50m, 20.00m, 17.50m, 13.25m, 28.00m, 11.00m, 
                                                   9.50m };
            string[] Available_Fish = new string[]
            {
                "Jawless fish", "Cartilaginous fish", "Ray-finned fish", "Lobe-finned fish",
                "Freshwater fish", "Saltwater fish", "Brackish water fish",
                "Anadromous fish", "Catadromous fish", "Pelagic fish", "Demersal fish",
                "Deep-sea fish", "White fish", "Oily fish"
            };

            cmbFish.Items.AddRange(Available_Fish);
            lstBox.DisplayMember = "Name";
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lstBox.Items.ToString()))
            {
                MessageBox.Show("No Information found to be submitted", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbFish.SelectedIndex = -1;
            txtName.Clear();
            txtAge.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstBox.SelectedIndex != -1)
            {
                DialogResult delete = MessageBox.Show("Are you sure you want to delete te selected information?", "Deleting Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    lstBox.Items.RemoveAt(lstBox.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("No Item selcted to be Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbFish.SelectedIndex == -1 || string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please fill in all required fields", "MISSING FIELD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string Added_info = $"{txtAge.Text} year old {txtName.Text}\n purchased {cmbFish.Text} on this day: {DateTime.Now.ToString()}";
                lstBox.Items.Add(Added_info);
            }
        }
        private void btnBackFishType_Click(object sender, EventArgs e)
        {
            if(DialogResult == DialogResult.Abort)
            {
                frmPetDetails petDetails = new frmPetDetails();
                petDetails.Show();
                this.Hide();
            }
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                frmMainForm displayDetails = new frmMainForm();
                displayDetails.Show();
                this.Hide();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filePath = @"T:/testing/FishDetails.txt";
            try
            {
                if (File.Exists(filePath))
                {
                    if (!string.IsNullOrEmpty(lstBox.Items.ToString()))
                    {
                        FileInfo fileInfo = new FileInfo(filePath);
                        using (StreamWriter sw = fileInfo.CreateText())
                        {
                            foreach (var orderedfish in lstBox.Items)
                            {
                                sw.WriteLine(orderedfish);
                            }
                        }
                        MessageBox.Show("Filed saved succefully", "Saved File", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("The listbox is empty, Nothing to saved", "Blank Listbox", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("File does not exist!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

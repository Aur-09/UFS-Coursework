using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Learning_Directories
{
    public partial class frmStudentData : Form
    {
        public frmStudentData()
        {
            InitializeComponent();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            int iCount = 0;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lstDisplay.Items.Clear();
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                    {
                        string data = sr.ReadToEnd();
                        string sStudentNumber;
                        string sName;
                        string sResults;
                        string status;
                        if (data != null)
                        {
                            string[] lines = data.Split('\n');
                            foreach (var line in lines)
                            {
                                string[] splitted_data = line.Trim().Split(',');
                                sStudentNumber = splitted_data[0];
                                sName = splitted_data[1];
                                sResults = splitted_data[2];
                                if (int.Parse(sResults) >= 75)
                                {
                                    status = "Pass with Dinstinction";
                                }
                                else if (int.Parse(sResults) >= 50 && int.Parse(sResults) < 75)
                                {
                                    status = "Pass";
                                }
                                else
                                {
                                    if (int.Parse(sResults) >= 45 && int.Parse(sResults) < 50)
                                    {
                                        status = "Fail with ReAssessment";
                                    }
                                    else
                                    {
                                        status = "Fail";
                                    }
                                }
                                lstDisplay.Items.Add($"{sStudentNumber} - {sName} : {sResults}% - [{ status}]");
                                iCount++;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data available to Display");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }    
            }
            lblStatus.Text = $"Loaded {iCount} students succesfully";
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            if (lstDisplay.Items.Count > 0)
            {
                try
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.DefaultExt = "txt";
                    saveFileDialog.Filter = @"Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.AddExtension = true;
                    saveFileDialog.FileName = "Results";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fullpath = saveFileDialog.FileName;
                        using (StreamWriter sw = new StreamWriter(fullpath, true))
                        {
                            foreach (var item in lstDisplay.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }
                        }
                        MessageBox.Show("Summary report saved succefully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No data available to Export!");
            }
        }
    }
}

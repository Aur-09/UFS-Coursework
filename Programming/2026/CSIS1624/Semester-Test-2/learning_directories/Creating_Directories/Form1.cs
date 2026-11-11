using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creating_Directories
{
    public partial class Registration : Form
    {
        int Count = 0;
        public Registration()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:/CSIS_Reports/Archives/";
                DirectoryInfo directory = new DirectoryInfo(path);
                if (!directory.Exists)
                {
                    Directory.CreateDirectory(@"C:/CSIS_Reports/Archives/");
                    MessageBox.Show("DIRECTORY SUCCEFULLY CREATED!");
                }
                string fileName = "StudentReport_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                string filepath = Path.Combine(directory.FullName, fileName);
                using (StreamWriter wr = new StreamWriter(filepath, true))
                {
                    foreach (var item in lstDisplay.Items)
                    {
                        wr.WriteLine(item.ToString());
                    }
                    MessageBox.Show("Content written succefully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnArchives_Click(object sender, EventArgs e)
        {
            string path = @"C:/CSIS_Reports";
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                if (directory.Exists)
                {
                    string[] files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
                    if(files.Length > 0)
                    {
                        lstDisplay.Items.Clear();
                        foreach (var file in files)
                        {
                            lstDisplay.Items.Add(file);
                        }
                        lblStatus.Text = $"Found {lstDisplay.Items.Count} archive files.";
                    }
                    else
                    {
                        MessageBox.Show($"No files found");
                    }
                }
                else
                {
                    MessageBox.Show("Archive directory found missing!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            int count = 0;
            DirectoryInfo dir = new DirectoryInfo(@"C:\CSIS_Reports\Archives");
            if (dir.Exists)
            {
                try
                {
                    foreach(var info in dir.GetFiles("*.txt"))
                    {
                        if(info.CreationTime < DateTime.Now.AddDays(-30))
                        {
                           count++;
                           info.Delete();
                        }
                    }
                    MessageBox.Show($"{count} old files were deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Logs directory found missing!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAge.Text) || cmbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields");
            }
            else
            {
                string info = $"{txtName.Text}: {txtAge.Text} years old taking {cmbCourse.Text}";
                lstDisplay.Items.Add (info);
            }
        }
    }
}

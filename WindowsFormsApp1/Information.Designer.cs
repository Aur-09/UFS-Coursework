namespace WindowsFormsApp1
{
    partial class frmMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnBuyPet = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.lblInfo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(364, 312);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(3, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(108, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Displayed Information";
            // 
            // btnBuyPet
            // 
            this.btnBuyPet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuyPet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBuyPet.Font = new System.Drawing.Font("Palatino Linotype", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyPet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuyPet.Location = new System.Drawing.Point(144, 348);
            this.btnBuyPet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuyPet.Name = "btnBuyPet";
            this.btnBuyPet.Size = new System.Drawing.Size(120, 27);
            this.btnBuyPet.TabIndex = 15;
            this.btnBuyPet.Text = "Book Delivery";
            this.btnBuyPet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuyPet.UseVisualStyleBackColor = false;
            this.btnBuyPet.Click += new System.EventHandler(this.btnBuyPet_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHomePage.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnHomePage.Font = new System.Drawing.Font("Palatino Linotype", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHomePage.Location = new System.Drawing.Point(286, 348);
            this.btnHomePage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(90, 27);
            this.btnHomePage.TabIndex = 16;
            this.btnHomePage.Text = "Home";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnImport.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnImport.Font = new System.Drawing.Font("Palatino Linotype", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImport.Location = new System.Drawing.Point(13, 348);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(110, 27);
            this.btnImport.TabIndex = 17;
            this.btnImport.Text = "Import Data";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImport.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.btnBuyPet);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmMainForm";
            this.Text = "MainForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnBuyPet;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
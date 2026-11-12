namespace FruitApplication
{
    partial class frmFruit
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
            this.grpFruitType = new System.Windows.Forms.GroupBox();
            this.radOrange = new System.Windows.Forms.RadioButton();
            this.radBanana = new System.Windows.Forms.RadioButton();
            this.radApple = new System.Windows.Forms.RadioButton();
            this.lblPictureURL = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.chkIsOrganic = new System.Windows.Forms.CheckBox();
            this.txtPictureURL = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblkg = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpFruitInformation = new System.Windows.Forms.GroupBox();
            this.picFruit = new System.Windows.Forms.PictureBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.dlgPicture = new System.Windows.Forms.OpenFileDialog();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.txtFruitCode = new System.Windows.Forms.TextBox();
            this.lblFruitCode = new System.Windows.Forms.Label();
            this.chkIsRipe = new System.Windows.Forms.CheckBox();
            this.chkIsSeedless = new System.Windows.Forms.CheckBox();
            this.grpFruitType.SuspendLayout();
            this.grpFruitInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFruitType
            // 
            this.grpFruitType.Controls.Add(this.radOrange);
            this.grpFruitType.Controls.Add(this.radBanana);
            this.grpFruitType.Controls.Add(this.radApple);
            this.grpFruitType.Location = new System.Drawing.Point(13, 13);
            this.grpFruitType.Name = "grpFruitType";
            this.grpFruitType.Size = new System.Drawing.Size(265, 46);
            this.grpFruitType.TabIndex = 0;
            this.grpFruitType.TabStop = false;
            this.grpFruitType.Text = "Fruit type";
            // 
            // radOrange
            // 
            this.radOrange.AutoSize = true;
            this.radOrange.Location = new System.Drawing.Point(191, 19);
            this.radOrange.Name = "radOrange";
            this.radOrange.Size = new System.Drawing.Size(60, 17);
            this.radOrange.TabIndex = 2;
            this.radOrange.TabStop = true;
            this.radOrange.Text = "Orange";
            this.radOrange.UseVisualStyleBackColor = true;
            this.radOrange.CheckedChanged += new System.EventHandler(this.radApple_CheckedChanged);
            // 
            // radBanana
            // 
            this.radBanana.AutoSize = true;
            this.radBanana.Location = new System.Drawing.Point(105, 19);
            this.radBanana.Name = "radBanana";
            this.radBanana.Size = new System.Drawing.Size(62, 17);
            this.radBanana.TabIndex = 1;
            this.radBanana.TabStop = true;
            this.radBanana.Text = "Banana";
            this.radBanana.UseVisualStyleBackColor = true;
            this.radBanana.CheckedChanged += new System.EventHandler(this.radApple_CheckedChanged);
            // 
            // radApple
            // 
            this.radApple.AutoSize = true;
            this.radApple.Location = new System.Drawing.Point(19, 19);
            this.radApple.Name = "radApple";
            this.radApple.Size = new System.Drawing.Size(52, 17);
            this.radApple.TabIndex = 0;
            this.radApple.TabStop = true;
            this.radApple.Text = "Apple";
            this.radApple.UseVisualStyleBackColor = true;
            this.radApple.CheckedChanged += new System.EventHandler(this.radApple_CheckedChanged);
            // 
            // lblPictureURL
            // 
            this.lblPictureURL.AutoSize = true;
            this.lblPictureURL.Location = new System.Drawing.Point(13, 68);
            this.lblPictureURL.Name = "lblPictureURL";
            this.lblPictureURL.Size = new System.Drawing.Size(62, 13);
            this.lblPictureURL.TabIndex = 1;
            this.lblPictureURL.Text = "PictureURL";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(14, 156);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight";
            // 
            // chkIsOrganic
            // 
            this.chkIsOrganic.AutoSize = true;
            this.chkIsOrganic.Location = new System.Drawing.Point(16, 183);
            this.chkIsOrganic.Name = "chkIsOrganic";
            this.chkIsOrganic.Size = new System.Drawing.Size(71, 17);
            this.chkIsOrganic.TabIndex = 4;
            this.chkIsOrganic.Tag = " ";
            this.chkIsOrganic.Text = "IsOrganic";
            this.chkIsOrganic.UseVisualStyleBackColor = true;
            // 
            // txtPictureURL
            // 
            this.txtPictureURL.Location = new System.Drawing.Point(16, 87);
            this.txtPictureURL.Multiline = true;
            this.txtPictureURL.Name = "txtPictureURL";
            this.txtPictureURL.Size = new System.Drawing.Size(262, 21);
            this.txtPictureURL.TabIndex = 6;
            // 
            // btnBrowse
            // 
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBrowse.Location = new System.Drawing.Point(284, 87);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(34, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = ".....";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblkg
            // 
            this.lblkg.AutoSize = true;
            this.lblkg.Location = new System.Drawing.Point(150, 156);
            this.lblkg.Name = "lblkg";
            this.lblkg.Size = new System.Drawing.Size(19, 13);
            this.lblkg.TabIndex = 10;
            this.lblkg.Text = "kg";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(196, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(106, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpFruitInformation
            // 
            this.grpFruitInformation.Controls.Add(this.picFruit);
            this.grpFruitInformation.Controls.Add(this.lblDisplay);
            this.grpFruitInformation.Location = new System.Drawing.Point(324, 12);
            this.grpFruitInformation.Name = "grpFruitInformation";
            this.grpFruitInformation.Size = new System.Drawing.Size(203, 220);
            this.grpFruitInformation.TabIndex = 13;
            this.grpFruitInformation.TabStop = false;
            this.grpFruitInformation.Text = "Fruit Information";
            // 
            // picFruit
            // 
            this.picFruit.Location = new System.Drawing.Point(6, 19);
            this.picFruit.Name = "picFruit";
            this.picFruit.Size = new System.Drawing.Size(144, 79);
            this.picFruit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFruit.TabIndex = 1;
            this.picFruit.TabStop = false;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(6, 122);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblDisplay.TabIndex = 0;
            // 
            // dlgPicture
            // 
            this.dlgPicture.FileName = "openFileDialog1";
            // 
            // nudWeight
            // 
            this.nudWeight.Location = new System.Drawing.Point(89, 151);
            this.nudWeight.Margin = new System.Windows.Forms.Padding(2);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(56, 20);
            this.nudWeight.TabIndex = 14;
            // 
            // txtFruitCode
            // 
            this.txtFruitCode.Location = new System.Drawing.Point(89, 121);
            this.txtFruitCode.Name = "txtFruitCode";
            this.txtFruitCode.Size = new System.Drawing.Size(100, 20);
            this.txtFruitCode.TabIndex = 8;
            // 
            // lblFruitCode
            // 
            this.lblFruitCode.AutoSize = true;
            this.lblFruitCode.Location = new System.Drawing.Point(14, 126);
            this.lblFruitCode.Name = "lblFruitCode";
            this.lblFruitCode.Size = new System.Drawing.Size(52, 13);
            this.lblFruitCode.TabIndex = 2;
            this.lblFruitCode.Text = "FruitCode";
            // 
            // chkIsRipe
            // 
            this.chkIsRipe.AutoSize = true;
            this.chkIsRipe.Location = new System.Drawing.Point(15, 183);
            this.chkIsRipe.Name = "chkIsRipe";
            this.chkIsRipe.Size = new System.Drawing.Size(56, 17);
            this.chkIsRipe.TabIndex = 4;
            this.chkIsRipe.Tag = " ";
            this.chkIsRipe.Text = "IsRipe";
            this.chkIsRipe.UseVisualStyleBackColor = true;
            // 
            // chkIsSeedless
            // 
            this.chkIsSeedless.AutoSize = true;
            this.chkIsSeedless.Location = new System.Drawing.Point(15, 183);
            this.chkIsSeedless.Name = "chkIsSeedless";
            this.chkIsSeedless.Size = new System.Drawing.Size(77, 17);
            this.chkIsSeedless.TabIndex = 4;
            this.chkIsSeedless.Tag = " ";
            this.chkIsSeedless.Text = "IsSeedless";
            this.chkIsSeedless.UseVisualStyleBackColor = true;
            // 
            // frmFruit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 249);
            this.Controls.Add(this.nudWeight);
            this.Controls.Add(this.grpFruitInformation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblkg);
            this.Controls.Add(this.txtFruitCode);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPictureURL);
            this.Controls.Add(this.chkIsSeedless);
            this.Controls.Add(this.chkIsRipe);
            this.Controls.Add(this.chkIsOrganic);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblFruitCode);
            this.Controls.Add(this.lblPictureURL);
            this.Controls.Add(this.grpFruitType);
            this.Name = "frmFruit";
            this.Text = "Fruit";
            this.grpFruitType.ResumeLayout(false);
            this.grpFruitType.PerformLayout();
            this.grpFruitInformation.ResumeLayout(false);
            this.grpFruitInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFruitType;
        private System.Windows.Forms.RadioButton radBanana;
        private System.Windows.Forms.RadioButton radOrange;
        private System.Windows.Forms.RadioButton radApple;
        private System.Windows.Forms.Label lblPictureURL;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.CheckBox chkIsOrganic;
        private System.Windows.Forms.TextBox txtPictureURL;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblkg;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpFruitInformation;
        private System.Windows.Forms.PictureBox picFruit;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.OpenFileDialog dlgPicture;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.TextBox txtFruitCode;
        private System.Windows.Forms.Label lblFruitCode;
        private System.Windows.Forms.CheckBox chkIsRipe;
        private System.Windows.Forms.CheckBox chkIsSeedless;
    }
}


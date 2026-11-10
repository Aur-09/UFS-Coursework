namespace WindowsFormsApp1
{
    partial class frmPetDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPetDetails));
            this.lblFishType = new System.Windows.Forms.Label();
            this.grpFishType = new System.Windows.Forms.GroupBox();
            this.radOilyfish = new System.Windows.Forms.RadioButton();
            this.radWhitefish = new System.Windows.Forms.RadioButton();
            this.radDeepseafish = new System.Windows.Forms.RadioButton();
            this.radLobeFinnedfish = new System.Windows.Forms.RadioButton();
            this.radDemersalfish = new System.Windows.Forms.RadioButton();
            this.radRayFinned = new System.Windows.Forms.RadioButton();
            this.radPelagicFish = new System.Windows.Forms.RadioButton();
            this.radCartilaginousfish = new System.Windows.Forms.RadioButton();
            this.radCatadromousfish = new System.Windows.Forms.RadioButton();
            this.radJawlessfish = new System.Windows.Forms.RadioButton();
            this.radAnadromousfish = new System.Windows.Forms.RadioButton();
            this.radFreshwaterfish = new System.Windows.Forms.RadioButton();
            this.radBrackishwaterfish = new System.Windows.Forms.RadioButton();
            this.radSaltwaterfish = new System.Windows.Forms.RadioButton();
            this.pcbFishType = new System.Windows.Forms.PictureBox();
            this.pnlFishType = new System.Windows.Forms.Panel();
            this.lblFishTypeInfo = new System.Windows.Forms.Label();
            this.btnChooseFish = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpFishType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFishType)).BeginInit();
            this.pnlFishType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFishType
            // 
            this.lblFishType.AutoSize = true;
            this.lblFishType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFishType.Location = new System.Drawing.Point(40, 135);
            this.lblFishType.Name = "lblFishType";
            this.lblFishType.Size = new System.Drawing.Size(50, 13);
            this.lblFishType.TabIndex = 0;
            this.lblFishType.Text = "FishType";
            // 
            // grpFishType
            // 
            this.grpFishType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpFishType.Controls.Add(this.radOilyfish);
            this.grpFishType.Controls.Add(this.radWhitefish);
            this.grpFishType.Controls.Add(this.radDeepseafish);
            this.grpFishType.Controls.Add(this.radLobeFinnedfish);
            this.grpFishType.Controls.Add(this.radDemersalfish);
            this.grpFishType.Controls.Add(this.radRayFinned);
            this.grpFishType.Controls.Add(this.radPelagicFish);
            this.grpFishType.Controls.Add(this.radCartilaginousfish);
            this.grpFishType.Controls.Add(this.radCatadromousfish);
            this.grpFishType.Controls.Add(this.radJawlessfish);
            this.grpFishType.Controls.Add(this.radAnadromousfish);
            this.grpFishType.Controls.Add(this.radFreshwaterfish);
            this.grpFishType.Controls.Add(this.radBrackishwaterfish);
            this.grpFishType.Controls.Add(this.radSaltwaterfish);
            this.grpFishType.Location = new System.Drawing.Point(37, 38);
            this.grpFishType.Name = "grpFishType";
            this.grpFishType.Size = new System.Drawing.Size(721, 84);
            this.grpFishType.TabIndex = 1;
            this.grpFishType.TabStop = false;
            this.grpFishType.Text = "Different Types of Fish:";
            this.grpFishType.Enter += new System.EventHandler(this.grpFishType_Enter);
            // 
            // radOilyfish
            // 
            this.radOilyfish.AutoSize = true;
            this.radOilyfish.Location = new System.Drawing.Point(643, 53);
            this.radOilyfish.Name = "radOilyfish";
            this.radOilyfish.Size = new System.Drawing.Size(61, 17);
            this.radOilyfish.TabIndex = 11;
            this.radOilyfish.TabStop = true;
            this.radOilyfish.Text = "Oily fish";
            this.radOilyfish.UseVisualStyleBackColor = true;
            this.radOilyfish.CheckedChanged += new System.EventHandler(this.radOilyfish_CheckedChanged);
            // 
            // radWhitefish
            // 
            this.radWhitefish.AutoSize = true;
            this.radWhitefish.Location = new System.Drawing.Point(643, 30);
            this.radWhitefish.Name = "radWhitefish";
            this.radWhitefish.Size = new System.Drawing.Size(72, 17);
            this.radWhitefish.TabIndex = 10;
            this.radWhitefish.TabStop = true;
            this.radWhitefish.Text = "White fish";
            this.radWhitefish.UseVisualStyleBackColor = true;
            this.radWhitefish.CheckedChanged += new System.EventHandler(this.radWhitefish_CheckedChanged);
            // 
            // radDeepseafish
            // 
            this.radDeepseafish.AutoSize = true;
            this.radDeepseafish.Location = new System.Drawing.Point(536, 53);
            this.radDeepseafish.Name = "radDeepseafish";
            this.radDeepseafish.Size = new System.Drawing.Size(90, 17);
            this.radDeepseafish.TabIndex = 9;
            this.radDeepseafish.TabStop = true;
            this.radDeepseafish.Text = "Deep-sea fish";
            this.radDeepseafish.UseVisualStyleBackColor = true;
            this.radDeepseafish.CheckedChanged += new System.EventHandler(this.radDeepseafish_CheckedChanged);
            // 
            // radLobeFinnedfish
            // 
            this.radLobeFinnedfish.AutoSize = true;
            this.radLobeFinnedfish.Location = new System.Drawing.Point(321, 30);
            this.radLobeFinnedfish.Name = "radLobeFinnedfish";
            this.radLobeFinnedfish.Size = new System.Drawing.Size(100, 17);
            this.radLobeFinnedfish.TabIndex = 3;
            this.radLobeFinnedfish.TabStop = true;
            this.radLobeFinnedfish.Text = "Lobe-finned fish";
            this.radLobeFinnedfish.UseVisualStyleBackColor = true;
            this.radLobeFinnedfish.CheckedChanged += new System.EventHandler(this.radLobeFinnedfish_CheckedChanged);
            // 
            // radDemersalfish
            // 
            this.radDemersalfish.AutoSize = true;
            this.radDemersalfish.Location = new System.Drawing.Point(538, 30);
            this.radDemersalfish.Name = "radDemersalfish";
            this.radDemersalfish.Size = new System.Drawing.Size(88, 17);
            this.radDemersalfish.TabIndex = 8;
            this.radDemersalfish.TabStop = true;
            this.radDemersalfish.Text = "Demersal fish";
            this.radDemersalfish.UseVisualStyleBackColor = true;
            this.radDemersalfish.CheckedChanged += new System.EventHandler(this.radDemersalfish_CheckedChanged);
            // 
            // radRayFinned
            // 
            this.radRayFinned.AutoSize = true;
            this.radRayFinned.Location = new System.Drawing.Point(214, 30);
            this.radRayFinned.Name = "radRayFinned";
            this.radRayFinned.Size = new System.Drawing.Size(101, 17);
            this.radRayFinned.TabIndex = 2;
            this.radRayFinned.TabStop = true;
            this.radRayFinned.Text = "Ray- finned Fish";
            this.radRayFinned.UseVisualStyleBackColor = true;
            this.radRayFinned.CheckedChanged += new System.EventHandler(this.radRayFinned_CheckedChanged);
            // 
            // radPelagicFish
            // 
            this.radPelagicFish.AutoSize = true;
            this.radPelagicFish.Location = new System.Drawing.Point(441, 53);
            this.radPelagicFish.Name = "radPelagicFish";
            this.radPelagicFish.Size = new System.Drawing.Size(79, 17);
            this.radPelagicFish.TabIndex = 7;
            this.radPelagicFish.TabStop = true;
            this.radPelagicFish.Text = "Pelagic fish";
            this.radPelagicFish.UseVisualStyleBackColor = true;
            this.radPelagicFish.CheckedChanged += new System.EventHandler(this.radPelagicFish_CheckedChanged);
            // 
            // radCartilaginousfish
            // 
            this.radCartilaginousfish.AutoSize = true;
            this.radCartilaginousfish.Location = new System.Drawing.Point(99, 30);
            this.radCartilaginousfish.Name = "radCartilaginousfish";
            this.radCartilaginousfish.Size = new System.Drawing.Size(104, 17);
            this.radCartilaginousfish.TabIndex = 1;
            this.radCartilaginousfish.TabStop = true;
            this.radCartilaginousfish.Text = "Cartilaginous fish";
            this.radCartilaginousfish.UseVisualStyleBackColor = true;
            this.radCartilaginousfish.CheckedChanged += new System.EventHandler(this.radCartilaginousfish_CheckedChanged);
            // 
            // radCatadromousfish
            // 
            this.radCatadromousfish.AutoSize = true;
            this.radCatadromousfish.Location = new System.Drawing.Point(321, 53);
            this.radCatadromousfish.Name = "radCatadromousfish";
            this.radCatadromousfish.Size = new System.Drawing.Size(106, 17);
            this.radCatadromousfish.TabIndex = 6;
            this.radCatadromousfish.TabStop = true;
            this.radCatadromousfish.Text = "Catadromous fish";
            this.radCatadromousfish.UseVisualStyleBackColor = true;
            this.radCatadromousfish.CheckedChanged += new System.EventHandler(this.radCatadromousfish_CheckedChanged);
            // 
            // radJawlessfish
            // 
            this.radJawlessfish.AutoSize = true;
            this.radJawlessfish.Location = new System.Drawing.Point(6, 30);
            this.radJawlessfish.Name = "radJawlessfish";
            this.radJawlessfish.Size = new System.Drawing.Size(81, 17);
            this.radJawlessfish.TabIndex = 0;
            this.radJawlessfish.TabStop = true;
            this.radJawlessfish.Text = "Jawless fish";
            this.radJawlessfish.UseVisualStyleBackColor = true;
            this.radJawlessfish.CheckedChanged += new System.EventHandler(this.radJawlessfish_CheckedChanged);
            // 
            // radAnadromousfish
            // 
            this.radAnadromousfish.AutoSize = true;
            this.radAnadromousfish.Location = new System.Drawing.Point(214, 53);
            this.radAnadromousfish.Name = "radAnadromousfish";
            this.radAnadromousfish.Size = new System.Drawing.Size(103, 17);
            this.radAnadromousfish.TabIndex = 5;
            this.radAnadromousfish.TabStop = true;
            this.radAnadromousfish.Text = "Anadromous fish";
            this.radAnadromousfish.UseVisualStyleBackColor = true;
            this.radAnadromousfish.CheckedChanged += new System.EventHandler(this.radAnadromousfish_CheckedChanged);
            // 
            // radFreshwaterfish
            // 
            this.radFreshwaterfish.AutoSize = true;
            this.radFreshwaterfish.Location = new System.Drawing.Point(436, 30);
            this.radFreshwaterfish.Name = "radFreshwaterfish";
            this.radFreshwaterfish.Size = new System.Drawing.Size(96, 17);
            this.radFreshwaterfish.TabIndex = 2;
            this.radFreshwaterfish.TabStop = true;
            this.radFreshwaterfish.Text = "Freshwater fish";
            this.radFreshwaterfish.UseVisualStyleBackColor = true;
            this.radFreshwaterfish.CheckedChanged += new System.EventHandler(this.radFreshwaterfish_CheckedChanged);
            // 
            // radBrackishwaterfish
            // 
            this.radBrackishwaterfish.AutoSize = true;
            this.radBrackishwaterfish.Location = new System.Drawing.Point(99, 53);
            this.radBrackishwaterfish.Name = "radBrackishwaterfish";
            this.radBrackishwaterfish.Size = new System.Drawing.Size(114, 17);
            this.radBrackishwaterfish.TabIndex = 4;
            this.radBrackishwaterfish.TabStop = true;
            this.radBrackishwaterfish.Text = "Brackish water fish";
            this.radBrackishwaterfish.UseVisualStyleBackColor = true;
            this.radBrackishwaterfish.CheckedChanged += new System.EventHandler(this.radBrackishwaterfish_CheckedChanged);
            // 
            // radSaltwaterfish
            // 
            this.radSaltwaterfish.AutoSize = true;
            this.radSaltwaterfish.Location = new System.Drawing.Point(6, 53);
            this.radSaltwaterfish.Name = "radSaltwaterfish";
            this.radSaltwaterfish.Size = new System.Drawing.Size(88, 17);
            this.radSaltwaterfish.TabIndex = 3;
            this.radSaltwaterfish.TabStop = true;
            this.radSaltwaterfish.Text = "Saltwater fish";
            this.radSaltwaterfish.UseVisualStyleBackColor = true;
            this.radSaltwaterfish.CheckedChanged += new System.EventHandler(this.radSaltwaterfish_CheckedChanged);
            // 
            // pcbFishType
            // 
            this.pcbFishType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pcbFishType.Location = new System.Drawing.Point(37, 151);
            this.pcbFishType.Name = "pcbFishType";
            this.pcbFishType.Size = new System.Drawing.Size(401, 278);
            this.pcbFishType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFishType.TabIndex = 2;
            this.pcbFishType.TabStop = false;
            // 
            // pnlFishType
            // 
            this.pnlFishType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlFishType.Controls.Add(this.lblFishTypeInfo);
            this.pnlFishType.Location = new System.Drawing.Point(478, 151);
            this.pnlFishType.Name = "pnlFishType";
            this.pnlFishType.Size = new System.Drawing.Size(280, 234);
            this.pnlFishType.TabIndex = 3;
            // 
            // lblFishTypeInfo
            // 
            this.lblFishTypeInfo.AutoSize = true;
            this.lblFishTypeInfo.Location = new System.Drawing.Point(3, 10);
            this.lblFishTypeInfo.Name = "lblFishTypeInfo";
            this.lblFishTypeInfo.Size = new System.Drawing.Size(102, 13);
            this.lblFishTypeInfo.TabIndex = 0;
            this.lblFishTypeInfo.Text = "DisplayFishTypeInfo";
            // 
            // btnChooseFish
            // 
            this.btnChooseFish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChooseFish.BackgroundImage")));
            this.btnChooseFish.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnChooseFish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChooseFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFish.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseFish.Location = new System.Drawing.Point(513, 406);
            this.btnChooseFish.Name = "btnChooseFish";
            this.btnChooseFish.Size = new System.Drawing.Size(131, 39);
            this.btnChooseFish.TabIndex = 4;
            this.btnChooseFish.Text = "Go Back";
            this.btnChooseFish.UseVisualStyleBackColor = true;
            this.btnChooseFish.Click += new System.EventHandler(this.btnChooseFish_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Location = new System.Drawing.Point(657, 406);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(131, 37);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmPetDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnChooseFish);
            this.Controls.Add(this.pnlFishType);
            this.Controls.Add(this.pcbFishType);
            this.Controls.Add(this.grpFishType);
            this.Controls.Add(this.lblFishType);
            this.Name = "frmPetDetails";
            this.Text = "Pet Details";
            this.grpFishType.ResumeLayout(false);
            this.grpFishType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFishType)).EndInit();
            this.pnlFishType.ResumeLayout(false);
            this.pnlFishType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFishType;
        private System.Windows.Forms.GroupBox grpFishType;
        private System.Windows.Forms.RadioButton radLobeFinnedfish;
        private System.Windows.Forms.RadioButton radRayFinned;
        private System.Windows.Forms.RadioButton radCartilaginousfish;
        private System.Windows.Forms.RadioButton radJawlessfish;
        private System.Windows.Forms.RadioButton radFreshwaterfish;
        private System.Windows.Forms.RadioButton radSaltwaterfish;
        private System.Windows.Forms.RadioButton radBrackishwaterfish;
        private System.Windows.Forms.RadioButton radAnadromousfish;
        private System.Windows.Forms.RadioButton radOilyfish;
        private System.Windows.Forms.RadioButton radWhitefish;
        private System.Windows.Forms.RadioButton radDeepseafish;
        private System.Windows.Forms.RadioButton radPelagicFish;
        private System.Windows.Forms.RadioButton radCatadromousfish;
        private System.Windows.Forms.PictureBox pcbFishType;
        private System.Windows.Forms.Panel pnlFishType;
        private System.Windows.Forms.Label lblFishTypeInfo;
        private System.Windows.Forms.Button btnChooseFish;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton radDemersalfish;
    }
}

namespace prenatal.winUI.PanelDoctor
{
    partial class frmPhotos
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
            this.components = new System.ComponentModel.Container();
            this.imgLst = new System.Windows.Forms.ImageList(this.components);
            this.lst = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medicalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vitalSignsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultrasoundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.therapiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substancesUsedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referralsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousPregnanciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lostPregnanciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glucoseTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLst
            // 
            this.imgLst.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imgLst.ImageSize = new System.Drawing.Size(16, 16);
            this.imgLst.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lst
            // 
            this.lst.HideSelection = false;
            this.lst.Location = new System.Drawing.Point(12, 27);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(344, 411);
            this.lst.TabIndex = 0;
            this.lst.UseCompatibleStateImageBehavior = false;
            this.lst.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lst_ItemSelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicalRecordsToolStripMenuItem,
            this.vitalSignsToolStripMenuItem,
            this.ultrasoundsToolStripMenuItem,
            this.therapiesToolStripMenuItem,
            this.substancesUsedToolStripMenuItem,
            this.referralsToolStripMenuItem,
            this.previousPregnanciesToolStripMenuItem,
            this.prescriptionsToolStripMenuItem,
            this.lostPregnanciesToolStripMenuItem,
            this.photosToolStripMenuItem,
            this.partnersToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.glucoseTestToolStripMenuItem,
            this.filesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1121, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medicalRecordsToolStripMenuItem
            // 
            this.medicalRecordsToolStripMenuItem.Name = "medicalRecordsToolStripMenuItem";
            this.medicalRecordsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.medicalRecordsToolStripMenuItem.Text = "MedicalRecords";
            this.medicalRecordsToolStripMenuItem.Click += new System.EventHandler(this.medicalRecordsToolStripMenuItem_Click);
            // 
            // vitalSignsToolStripMenuItem
            // 
            this.vitalSignsToolStripMenuItem.Name = "vitalSignsToolStripMenuItem";
            this.vitalSignsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.vitalSignsToolStripMenuItem.Text = "VitalSigns";
            this.vitalSignsToolStripMenuItem.Click += new System.EventHandler(this.vitalSignsToolStripMenuItem_Click);
            // 
            // ultrasoundsToolStripMenuItem
            // 
            this.ultrasoundsToolStripMenuItem.Name = "ultrasoundsToolStripMenuItem";
            this.ultrasoundsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.ultrasoundsToolStripMenuItem.Text = "Ultrasounds";
            this.ultrasoundsToolStripMenuItem.Click += new System.EventHandler(this.ultrasoundsToolStripMenuItem_Click);
            // 
            // therapiesToolStripMenuItem
            // 
            this.therapiesToolStripMenuItem.Name = "therapiesToolStripMenuItem";
            this.therapiesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.therapiesToolStripMenuItem.Text = "Therapies";
            this.therapiesToolStripMenuItem.Click += new System.EventHandler(this.therapiesToolStripMenuItem_Click);
            // 
            // substancesUsedToolStripMenuItem
            // 
            this.substancesUsedToolStripMenuItem.Name = "substancesUsedToolStripMenuItem";
            this.substancesUsedToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.substancesUsedToolStripMenuItem.Text = "SubstancesUsed";
            this.substancesUsedToolStripMenuItem.Click += new System.EventHandler(this.substancesUsedToolStripMenuItem_Click);
            // 
            // referralsToolStripMenuItem
            // 
            this.referralsToolStripMenuItem.Name = "referralsToolStripMenuItem";
            this.referralsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.referralsToolStripMenuItem.Text = "Referrals";
            this.referralsToolStripMenuItem.Click += new System.EventHandler(this.referralsToolStripMenuItem_Click);
            // 
            // previousPregnanciesToolStripMenuItem
            // 
            this.previousPregnanciesToolStripMenuItem.Name = "previousPregnanciesToolStripMenuItem";
            this.previousPregnanciesToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.previousPregnanciesToolStripMenuItem.Text = "PreviousPregnancies";
            this.previousPregnanciesToolStripMenuItem.Click += new System.EventHandler(this.previousPregnanciesToolStripMenuItem_Click);
            // 
            // prescriptionsToolStripMenuItem
            // 
            this.prescriptionsToolStripMenuItem.Name = "prescriptionsToolStripMenuItem";
            this.prescriptionsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.prescriptionsToolStripMenuItem.Text = "Prescriptions";
            this.prescriptionsToolStripMenuItem.Click += new System.EventHandler(this.prescriptionsToolStripMenuItem_Click);
            // 
            // lostPregnanciesToolStripMenuItem
            // 
            this.lostPregnanciesToolStripMenuItem.Name = "lostPregnanciesToolStripMenuItem";
            this.lostPregnanciesToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.lostPregnanciesToolStripMenuItem.Text = "LostPregnancies";
            this.lostPregnanciesToolStripMenuItem.Click += new System.EventHandler(this.lostPregnanciesToolStripMenuItem_Click);
            // 
            // photosToolStripMenuItem
            // 
            this.photosToolStripMenuItem.Name = "photosToolStripMenuItem";
            this.photosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.photosToolStripMenuItem.Text = "Photos";
            this.photosToolStripMenuItem.Click += new System.EventHandler(this.photosToolStripMenuItem_Click);
            // 
            // partnersToolStripMenuItem
            // 
            this.partnersToolStripMenuItem.Name = "partnersToolStripMenuItem";
            this.partnersToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.partnersToolStripMenuItem.Text = "Partners";
            this.partnersToolStripMenuItem.Click += new System.EventHandler(this.partnersToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // glucoseTestToolStripMenuItem
            // 
            this.glucoseTestToolStripMenuItem.Name = "glucoseTestToolStripMenuItem";
            this.glucoseTestToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.glucoseTestToolStripMenuItem.Text = "GlucoseTest";
            this.glucoseTestToolStripMenuItem.Click += new System.EventHandler(this.glucoseTestToolStripMenuItem_Click);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofd";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpload.Location = new System.Drawing.Point(362, 27);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(51, 411);
            this.btnUpload.TabIndex = 22;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(419, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 411);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(476, 27);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(616, 411);
            this.picBox.TabIndex = 24;
            this.picBox.TabStop = false;
            // 
            // frmPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1121, 450);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lst);
            this.Name = "frmPhotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhotos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPhotos_FormClosed);
            this.Load += new System.EventHandler(this.frmPhotos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgLst;
        private System.Windows.Forms.ListView lst;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vitalSignsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultrasoundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem therapiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substancesUsedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referralsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousPregnanciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lostPregnanciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem photosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glucoseTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picBox;
    }
}

namespace prenatal.winUI.PanelDoctor
{
    partial class frmPartners
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
            this.dGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RHfactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
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
            this.CRUD = new System.Windows.Forms.GroupBox();
            this.cmbRH = new System.Windows.Forms.ComboBox();
            this.cmbBlood = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRH = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.CRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGrid
            // 
            this.dGrid.AllowUserToAddRows = false;
            this.dGrid.AllowUserToDeleteRows = false;
            this.dGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.PSurname,
            this.BloodType,
            this.RHfactor});
            this.dGrid.Location = new System.Drawing.Point(12, 27);
            this.dGrid.Name = "dGrid";
            this.dGrid.ReadOnly = true;
            this.dGrid.RowHeadersVisible = false;
            this.dGrid.Size = new System.Drawing.Size(506, 319);
            this.dGrid.TabIndex = 0;
            this.dGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrid_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "Name";
            this.PName.HeaderText = "Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // PSurname
            // 
            this.PSurname.DataPropertyName = "Surname";
            this.PSurname.HeaderText = "Surname";
            this.PSurname.Name = "PSurname";
            this.PSurname.ReadOnly = true;
            // 
            // BloodType
            // 
            this.BloodType.DataPropertyName = "BloodType";
            this.BloodType.HeaderText = "BloodType";
            this.BloodType.Name = "BloodType";
            this.BloodType.ReadOnly = true;
            // 
            // RHfactor
            // 
            this.RHfactor.DataPropertyName = "RHFactor";
            this.RHfactor.HeaderText = "RHfactor";
            this.RHfactor.Name = "RHfactor";
            this.RHfactor.ReadOnly = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1127, 24);
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
            // CRUD
            // 
            this.CRUD.Controls.Add(this.cmbRH);
            this.CRUD.Controls.Add(this.cmbBlood);
            this.CRUD.Controls.Add(this.btnClear);
            this.CRUD.Controls.Add(this.btnDelete);
            this.CRUD.Controls.Add(this.btnUpdate);
            this.CRUD.Controls.Add(this.lblName);
            this.CRUD.Controls.Add(this.btnAdd);
            this.CRUD.Controls.Add(this.lblRH);
            this.CRUD.Controls.Add(this.txtSurname);
            this.CRUD.Controls.Add(this.lblBloodType);
            this.CRUD.Controls.Add(this.lblId);
            this.CRUD.Controls.Add(this.lblSurname);
            this.CRUD.Controls.Add(this.txtId);
            this.CRUD.Controls.Add(this.txtName);
            this.CRUD.Location = new System.Drawing.Point(524, 27);
            this.CRUD.Name = "CRUD";
            this.CRUD.Size = new System.Drawing.Size(209, 319);
            this.CRUD.TabIndex = 22;
            this.CRUD.TabStop = false;
            this.CRUD.Text = "CRUD";
            // 
            // cmbRH
            // 
            this.cmbRH.FormattingEnabled = true;
            this.cmbRH.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbRH.Location = new System.Drawing.Point(107, 163);
            this.cmbRH.Name = "cmbRH";
            this.cmbRH.Size = new System.Drawing.Size(88, 21);
            this.cmbRH.TabIndex = 32;
            // 
            // cmbBlood
            // 
            this.cmbBlood.FormattingEnabled = true;
            this.cmbBlood.Items.AddRange(new object[] {
            "A",
            "B",
            "0",
            "AB"});
            this.cmbBlood.Location = new System.Drawing.Point(16, 163);
            this.cmbBlood.Name = "cmbBlood";
            this.cmbBlood.Size = new System.Drawing.Size(88, 21);
            this.cmbBlood.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(16, 277);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(16, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(16, 219);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(16, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRH
            // 
            this.lblRH.AutoSize = true;
            this.lblRH.Location = new System.Drawing.Point(105, 141);
            this.lblRH.Name = "lblRH";
            this.lblRH.Size = new System.Drawing.Size(53, 13);
            this.lblRH.TabIndex = 31;
            this.lblRH.Text = "RH factor";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(16, 116);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(179, 20);
            this.txtSurname.TabIndex = 28;
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(13, 141);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(58, 13);
            this.lblBloodType.TabIndex = 29;
            this.lblBloodType.Text = "BloodType";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 23;
            this.lblId.Text = "Id";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(13, 100);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 27;
            this.lblSurname.Text = "Surname";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(16, 38);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(179, 20);
            this.txtId.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 26;
            // 
            // frmPartners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 354);
            this.Controls.Add(this.CRUD);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dGrid);
            this.Name = "frmPartners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartners";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPartners_FormClosed);
            this.Load += new System.EventHandler(this.frmPartners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CRUD.ResumeLayout(false);
            this.CRUD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
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
        private System.Windows.Forms.GroupBox CRUD;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRH;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbRH;
        private System.Windows.Forms.ComboBox cmbBlood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RHfactor;
    }
}
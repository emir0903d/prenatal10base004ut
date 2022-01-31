
namespace prenatal.winUI.PanelDoctor
{
    partial class frmLostPregnancies
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
            this.dgLostPregnancies = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLostPregnancies)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1117, 24);
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
            // dgLostPregnancies
            // 
            this.dgLostPregnancies.AllowUserToAddRows = false;
            this.dgLostPregnancies.AllowUserToDeleteRows = false;
            this.dgLostPregnancies.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgLostPregnancies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLostPregnancies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Type,
            this.Note});
            this.dgLostPregnancies.Location = new System.Drawing.Point(13, 28);
            this.dgLostPregnancies.MultiSelect = false;
            this.dgLostPregnancies.Name = "dgLostPregnancies";
            this.dgLostPregnancies.ReadOnly = true;
            this.dgLostPregnancies.RowHeadersVisible = false;
            this.dgLostPregnancies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLostPregnancies.Size = new System.Drawing.Size(406, 388);
            this.dgLostPregnancies.TabIndex = 22;
            this.dgLostPregnancies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLostPregnancies_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.dtDate);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblNote);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Location = new System.Drawing.Point(425, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 388);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(18, 38);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(51, 20);
            this.txtId.TabIndex = 25;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(19, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(259, 28);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "Id";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(19, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(259, 28);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(19, 281);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(259, 28);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(19, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(259, 28);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(19, 132);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(259, 109);
            this.txtNote.TabIndex = 29;
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(75, 38);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(203, 20);
            this.dtDate.TabIndex = 25;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(75, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Date";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(16, 107);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(35, 13);
            this.lblNote.TabIndex = 28;
            this.lblNote.Text = "Notes";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(19, 80);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(259, 20);
            this.txtType.TabIndex = 27;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(16, 64);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 26;
            this.lblType.Text = "Type";
            // 
            // frmLostPregnancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgLostPregnancies);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmLostPregnancies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLostPregnancies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLostPregnancies_FormClosed);
            this.Load += new System.EventHandler(this.frmLostPregnancies_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLostPregnancies)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgLostPregnancies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}
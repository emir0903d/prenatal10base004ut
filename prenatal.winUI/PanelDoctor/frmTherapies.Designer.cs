
namespace prenatal.winUI.PanelDoctor
{
    partial class frmTherapies
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
            this.dgTherapies = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicaments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dTPickerBeginning = new System.Windows.Forms.DateTimePicker();
            this.labelBeginning = new System.Windows.Forms.Label();
            this.labelEnding = new System.Windows.Forms.Label();
            this.dTPickerEnding = new System.Windows.Forms.DateTimePicker();
            this.labelMed = new System.Windows.Forms.Label();
            this.textBoxMedicaments = new System.Windows.Forms.TextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.gBcrud = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTherapies)).BeginInit();
            this.gBcrud.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1360, 24);
            this.menuStrip1.TabIndex = 23;
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
            // dgTherapies
            // 
            this.dgTherapies.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgTherapies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTherapies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BeginningDate,
            this.EndingDate,
            this.Medicaments,
            this.Note});
            this.dgTherapies.Location = new System.Drawing.Point(12, 27);
            this.dgTherapies.Name = "dgTherapies";
            this.dgTherapies.RowHeadersVisible = false;
            this.dgTherapies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgTherapies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgTherapies.Size = new System.Drawing.Size(977, 411);
            this.dgTherapies.TabIndex = 24;
            this.dgTherapies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTherapies_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "TherapiesId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 25;
            // 
            // BeginningDate
            // 
            this.BeginningDate.DataPropertyName = "BeginningDate";
            this.BeginningDate.HeaderText = "BeginningDate";
            this.BeginningDate.Name = "BeginningDate";
            this.BeginningDate.Width = 200;
            // 
            // EndingDate
            // 
            this.EndingDate.DataPropertyName = "EndingDate";
            this.EndingDate.HeaderText = "EndingDate";
            this.EndingDate.Name = "EndingDate";
            this.EndingDate.Width = 200;
            // 
            // Medicaments
            // 
            this.Medicaments.DataPropertyName = "Medicaments";
            this.Medicaments.HeaderText = "Medicaments";
            this.Medicaments.Name = "Medicaments";
            this.Medicaments.Width = 250;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.Width = 300;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(14, 39);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 25;
            this.labelId.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(17, 55);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(39, 20);
            this.textBoxId.TabIndex = 26;
            // 
            // dTPickerBeginning
            // 
            this.dTPickerBeginning.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerBeginning.Location = new System.Drawing.Point(62, 55);
            this.dTPickerBeginning.Name = "dTPickerBeginning";
            this.dTPickerBeginning.Size = new System.Drawing.Size(127, 20);
            this.dTPickerBeginning.TabIndex = 27;
            // 
            // labelBeginning
            // 
            this.labelBeginning.AutoSize = true;
            this.labelBeginning.Location = new System.Drawing.Point(62, 39);
            this.labelBeginning.Name = "labelBeginning";
            this.labelBeginning.Size = new System.Drawing.Size(77, 13);
            this.labelBeginning.TabIndex = 28;
            this.labelBeginning.Text = "BeginningDate";
            // 
            // labelEnding
            // 
            this.labelEnding.AutoSize = true;
            this.labelEnding.Location = new System.Drawing.Point(195, 39);
            this.labelEnding.Name = "labelEnding";
            this.labelEnding.Size = new System.Drawing.Size(63, 13);
            this.labelEnding.TabIndex = 29;
            this.labelEnding.Text = "EndingDate";
            // 
            // dTPickerEnding
            // 
            this.dTPickerEnding.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerEnding.Location = new System.Drawing.Point(195, 55);
            this.dTPickerEnding.Name = "dTPickerEnding";
            this.dTPickerEnding.Size = new System.Drawing.Size(127, 20);
            this.dTPickerEnding.TabIndex = 30;
            // 
            // labelMed
            // 
            this.labelMed.AutoSize = true;
            this.labelMed.Location = new System.Drawing.Point(14, 84);
            this.labelMed.Name = "labelMed";
            this.labelMed.Size = new System.Drawing.Size(70, 13);
            this.labelMed.TabIndex = 31;
            this.labelMed.Text = "Medicaments";
            // 
            // textBoxMedicaments
            // 
            this.textBoxMedicaments.Location = new System.Drawing.Point(14, 100);
            this.textBoxMedicaments.Name = "textBoxMedicaments";
            this.textBoxMedicaments.Size = new System.Drawing.Size(308, 20);
            this.textBoxMedicaments.TabIndex = 32;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(14, 126);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(30, 13);
            this.labelNote.TabIndex = 33;
            this.labelNote.Text = "Note";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(14, 142);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(308, 93);
            this.textBoxNote.TabIndex = 34;
            // 
            // gBcrud
            // 
            this.gBcrud.Controls.Add(this.buttonClear);
            this.gBcrud.Controls.Add(this.buttonDelete);
            this.gBcrud.Controls.Add(this.buttonUpdate);
            this.gBcrud.Controls.Add(this.buttonAdd);
            this.gBcrud.Controls.Add(this.textBoxNote);
            this.gBcrud.Controls.Add(this.labelNote);
            this.gBcrud.Controls.Add(this.textBoxMedicaments);
            this.gBcrud.Controls.Add(this.labelMed);
            this.gBcrud.Controls.Add(this.dTPickerEnding);
            this.gBcrud.Controls.Add(this.labelEnding);
            this.gBcrud.Controls.Add(this.labelBeginning);
            this.gBcrud.Controls.Add(this.dTPickerBeginning);
            this.gBcrud.Controls.Add(this.textBoxId);
            this.gBcrud.Controls.Add(this.labelId);
            this.gBcrud.Location = new System.Drawing.Point(995, 27);
            this.gBcrud.Name = "gBcrud";
            this.gBcrud.Size = new System.Drawing.Size(338, 366);
            this.gBcrud.TabIndex = 35;
            this.gBcrud.TabStop = false;
            this.gBcrud.Text = "CRUD";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Location = new System.Drawing.Point(14, 328);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(308, 23);
            this.buttonClear.TabIndex = 38;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(14, 299);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(308, 23);
            this.buttonDelete.TabIndex = 37;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Location = new System.Drawing.Point(14, 270);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(308, 23);
            this.buttonUpdate.TabIndex = 36;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(14, 241);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(308, 23);
            this.buttonAdd.TabIndex = 35;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // frmTherapies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 450);
            this.Controls.Add(this.gBcrud);
            this.Controls.Add(this.dgTherapies);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmTherapies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTherapies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTherapies_FormClosed);
            this.Load += new System.EventHandler(this.frmTherapies_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTherapies)).EndInit();
            this.gBcrud.ResumeLayout(false);
            this.gBcrud.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgTherapies;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DateTimePicker dTPickerBeginning;
        private System.Windows.Forms.Label labelBeginning;
        private System.Windows.Forms.Label labelEnding;
        private System.Windows.Forms.DateTimePicker dTPickerEnding;
        private System.Windows.Forms.Label labelMed;
        private System.Windows.Forms.TextBox textBoxMedicaments;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.GroupBox gBcrud;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicaments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}
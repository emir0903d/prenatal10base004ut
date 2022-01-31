
namespace prenatal.winUI.PanelDoctor
{
    partial class frmPrevPregnancies
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
            this.dgPrevPreg = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PregnancyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GestationWeeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outcome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxOutcome = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelOutcome = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxComplications = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelComplications = new System.Windows.Forms.Label();
            this.comboBoxDeliveryType = new System.Windows.Forms.ComboBox();
            this.labelDeliveryType = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxGestationWeeks = new System.Windows.Forms.TextBox();
            this.dTpPregDate = new System.Windows.Forms.DateTimePicker();
            this.labelGestationWeeks = new System.Windows.Forms.Label();
            this.labelPregDate = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrevPreg)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
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
            // dgPrevPreg
            // 
            this.dgPrevPreg.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgPrevPreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrevPreg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PregnancyDate,
            this.GestationWeeks,
            this.DeliveryType,
            this.Complications,
            this.Outcome});
            this.dgPrevPreg.Location = new System.Drawing.Point(12, 27);
            this.dgPrevPreg.MultiSelect = false;
            this.dgPrevPreg.Name = "dgPrevPreg";
            this.dgPrevPreg.ReadOnly = true;
            this.dgPrevPreg.RowHeadersVisible = false;
            this.dgPrevPreg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgPrevPreg.Size = new System.Drawing.Size(783, 393);
            this.dgPrevPreg.TabIndex = 22;
            this.dgPrevPreg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPrevPreg_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 25;
            // 
            // PregnancyDate
            // 
            this.PregnancyDate.DataPropertyName = "PregnancyDate";
            this.PregnancyDate.HeaderText = "PregnancyDate";
            this.PregnancyDate.Name = "PregnancyDate";
            this.PregnancyDate.ReadOnly = true;
            // 
            // GestationWeeks
            // 
            this.GestationWeeks.DataPropertyName = "GestationWeeks";
            this.GestationWeeks.HeaderText = "GestationWeeks";
            this.GestationWeeks.Name = "GestationWeeks";
            this.GestationWeeks.ReadOnly = true;
            // 
            // DeliveryType
            // 
            this.DeliveryType.DataPropertyName = "DeliveryType";
            this.DeliveryType.HeaderText = "DeliveryType";
            this.DeliveryType.Name = "DeliveryType";
            this.DeliveryType.ReadOnly = true;
            // 
            // Complications
            // 
            this.Complications.DataPropertyName = "Complications";
            this.Complications.HeaderText = "Complications";
            this.Complications.Name = "Complications";
            this.Complications.ReadOnly = true;
            this.Complications.Width = 200;
            // 
            // Outcome
            // 
            this.Outcome.DataPropertyName = "Outcome";
            this.Outcome.HeaderText = "Outcome";
            this.Outcome.Name = "Outcome";
            this.Outcome.ReadOnly = true;
            this.Outcome.Width = 255;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.textBoxOutcome);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.labelOutcome);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.textBoxComplications);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.labelComplications);
            this.groupBox1.Controls.Add(this.comboBoxDeliveryType);
            this.groupBox1.Controls.Add(this.labelDeliveryType);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.textBoxGestationWeeks);
            this.groupBox1.Controls.Add(this.dTpPregDate);
            this.groupBox1.Controls.Add(this.labelGestationWeeks);
            this.groupBox1.Controls.Add(this.labelPregDate);
            this.groupBox1.Location = new System.Drawing.Point(801, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 393);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Location = new System.Drawing.Point(21, 351);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(246, 23);
            this.buttonClear.TabIndex = 27;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxOutcome
            // 
            this.textBoxOutcome.Location = new System.Drawing.Point(21, 240);
            this.textBoxOutcome.Name = "textBoxOutcome";
            this.textBoxOutcome.Size = new System.Drawing.Size(246, 20);
            this.textBoxOutcome.TabIndex = 25;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(21, 324);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(246, 23);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelOutcome
            // 
            this.labelOutcome.AutoSize = true;
            this.labelOutcome.Location = new System.Drawing.Point(21, 225);
            this.labelOutcome.Name = "labelOutcome";
            this.labelOutcome.Size = new System.Drawing.Size(50, 13);
            this.labelOutcome.TabIndex = 24;
            this.labelOutcome.Text = "Outcome";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Location = new System.Drawing.Point(21, 295);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(246, 23);
            this.buttonUpdate.TabIndex = 25;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxComplications
            // 
            this.textBoxComplications.Location = new System.Drawing.Point(21, 129);
            this.textBoxComplications.Multiline = true;
            this.textBoxComplications.Name = "textBoxComplications";
            this.textBoxComplications.Size = new System.Drawing.Size(246, 93);
            this.textBoxComplications.TabIndex = 25;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(21, 266);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(246, 23);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelComplications
            // 
            this.labelComplications.AutoSize = true;
            this.labelComplications.Location = new System.Drawing.Point(21, 113);
            this.labelComplications.Name = "labelComplications";
            this.labelComplications.Size = new System.Drawing.Size(72, 13);
            this.labelComplications.TabIndex = 24;
            this.labelComplications.Text = "Complications";
            // 
            // comboBoxDeliveryType
            // 
            this.comboBoxDeliveryType.FormattingEnabled = true;
            this.comboBoxDeliveryType.Items.AddRange(new object[] {
            "Vaginal Birth",
            "Natural Birth",
            "Scheduled Cesarean",
            "Unplanned Cesarean",
            "Vaginal Birth after C-Section (VBAC)",
            "Scheduled Induction"});
            this.comboBoxDeliveryType.Location = new System.Drawing.Point(21, 84);
            this.comboBoxDeliveryType.Name = "comboBoxDeliveryType";
            this.comboBoxDeliveryType.Size = new System.Drawing.Size(246, 21);
            this.comboBoxDeliveryType.TabIndex = 31;
            // 
            // labelDeliveryType
            // 
            this.labelDeliveryType.AutoSize = true;
            this.labelDeliveryType.Location = new System.Drawing.Point(21, 68);
            this.labelDeliveryType.Name = "labelDeliveryType";
            this.labelDeliveryType.Size = new System.Drawing.Size(69, 13);
            this.labelDeliveryType.TabIndex = 30;
            this.labelDeliveryType.Text = "DeliveryType";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(21, 42);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(38, 20);
            this.textBoxId.TabIndex = 25;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(21, 26);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 24;
            this.labelId.Text = "Id";
            // 
            // textBoxGestationWeeks
            // 
            this.textBoxGestationWeeks.Location = new System.Drawing.Point(167, 42);
            this.textBoxGestationWeeks.Name = "textBoxGestationWeeks";
            this.textBoxGestationWeeks.Size = new System.Drawing.Size(100, 20);
            this.textBoxGestationWeeks.TabIndex = 29;
            // 
            // dTpPregDate
            // 
            this.dTpPregDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTpPregDate.Location = new System.Drawing.Point(65, 42);
            this.dTpPregDate.Name = "dTpPregDate";
            this.dTpPregDate.Size = new System.Drawing.Size(96, 20);
            this.dTpPregDate.TabIndex = 27;
            // 
            // labelGestationWeeks
            // 
            this.labelGestationWeeks.AutoSize = true;
            this.labelGestationWeeks.Location = new System.Drawing.Point(164, 26);
            this.labelGestationWeeks.Name = "labelGestationWeeks";
            this.labelGestationWeeks.Size = new System.Drawing.Size(86, 13);
            this.labelGestationWeeks.TabIndex = 28;
            this.labelGestationWeeks.Text = "GestationWeeks";
            // 
            // labelPregDate
            // 
            this.labelPregDate.AutoSize = true;
            this.labelPregDate.Location = new System.Drawing.Point(62, 26);
            this.labelPregDate.Name = "labelPregDate";
            this.labelPregDate.Size = new System.Drawing.Size(81, 13);
            this.labelPregDate.TabIndex = 26;
            this.labelPregDate.Text = "PregnancyDate";
            // 
            // frmPrevPregnancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgPrevPreg);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrevPregnancies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrevPregnancies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrevPregnancies_FormClosed);
            this.Load += new System.EventHandler(this.frmPrevPregnancies_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrevPreg)).EndInit();
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
        private System.Windows.Forms.DataGridView dgPrevPreg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PregnancyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GestationWeeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complications;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxOutcome;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelOutcome;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxComplications;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelComplications;
        private System.Windows.Forms.ComboBox comboBoxDeliveryType;
        private System.Windows.Forms.Label labelDeliveryType;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxGestationWeeks;
        private System.Windows.Forms.DateTimePicker dTpPregDate;
        private System.Windows.Forms.Label labelGestationWeeks;
        private System.Windows.Forms.Label labelPregDate;
    }
}
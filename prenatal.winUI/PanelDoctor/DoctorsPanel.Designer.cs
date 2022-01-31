namespace prenatal.winUI.PanelDoctor
{
    partial class DoctorsPanel
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
            this.comboBoxPatients = new System.Windows.Forms.ComboBox();
            this.groupBoxPersonal = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.checkBoxMR = new System.Windows.Forms.CheckBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonCreateMR = new System.Windows.Forms.Button();
            this.groupBoxMRInfo = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxRH = new System.Windows.Forms.ComboBox();
            this.labelRH = new System.Windows.Forms.Label();
            this.labelBloodType = new System.Windows.Forms.Label();
            this.comboBoxBloodType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelMaidenName = new System.Windows.Forms.Label();
            this.comboBoxMartial = new System.Windows.Forms.ComboBox();
            this.labelMartial = new System.Windows.Forms.Label();
            this.textBoxMaidenName = new System.Windows.Forms.TextBox();
            this.textBoxPINumber = new System.Windows.Forms.TextBox();
            this.labelPIN = new System.Windows.Forms.Label();
            this.labelMRNumber = new System.Windows.Forms.Label();
            this.textBoxMRNumber = new System.Windows.Forms.TextBox();
            this.labelPatients = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBoxPersonal.SuspendLayout();
            this.groupBoxMRInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPatients
            // 
            this.comboBoxPatients.FormattingEnabled = true;
            this.comboBoxPatients.Location = new System.Drawing.Point(97, 17);
            this.comboBoxPatients.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPatients.Name = "comboBoxPatients";
            this.comboBoxPatients.Size = new System.Drawing.Size(194, 21);
            this.comboBoxPatients.TabIndex = 1;
            this.comboBoxPatients.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPatients_SelectionChangeCommitted);
            // 
            // groupBoxPersonal
            // 
            this.groupBoxPersonal.Controls.Add(this.labelEmail);
            this.groupBoxPersonal.Controls.Add(this.labelPhone);
            this.groupBoxPersonal.Controls.Add(this.labelGender);
            this.groupBoxPersonal.Controls.Add(this.labelSurname);
            this.groupBoxPersonal.Controls.Add(this.labelName);
            this.groupBoxPersonal.Controls.Add(this.checkBoxMR);
            this.groupBoxPersonal.Controls.Add(this.textBoxEmail);
            this.groupBoxPersonal.Controls.Add(this.textBoxPhone);
            this.groupBoxPersonal.Controls.Add(this.textBoxGender);
            this.groupBoxPersonal.Controls.Add(this.textBoxSurname);
            this.groupBoxPersonal.Controls.Add(this.textBoxName);
            this.groupBoxPersonal.Location = new System.Drawing.Point(54, 115);
            this.groupBoxPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPersonal.Name = "groupBoxPersonal";
            this.groupBoxPersonal.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPersonal.Size = new System.Drawing.Size(310, 176);
            this.groupBoxPersonal.TabIndex = 16;
            this.groupBoxPersonal.TabStop = false;
            this.groupBoxPersonal.Text = "Patient\'s Info";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(16, 127);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 18;
            this.labelEmail.Text = "Email";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(16, 102);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(75, 13);
            this.labelPhone.TabIndex = 18;
            this.labelPhone.Text = "PhoneNumber";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(16, 76);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 13);
            this.labelGender.TabIndex = 18;
            this.labelGender.Text = "Gender";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(16, 51);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 18;
            this.labelSurname.Text = "Surname";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 26);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Name";
            // 
            // checkBoxMR
            // 
            this.checkBoxMR.AutoCheck = false;
            this.checkBoxMR.AutoSize = true;
            this.checkBoxMR.Location = new System.Drawing.Point(246, 145);
            this.checkBoxMR.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxMR.Name = "checkBoxMR";
            this.checkBoxMR.Size = new System.Drawing.Size(49, 17);
            this.checkBoxMR.TabIndex = 17;
            this.checkBoxMR.Text = "MR?";
            this.checkBoxMR.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(97, 123);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(194, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(97, 98);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(194, 20);
            this.textBoxPhone.TabIndex = 3;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(97, 72);
            this.textBoxGender.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.Size = new System.Drawing.Size(194, 20);
            this.textBoxGender.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(97, 47);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(194, 20);
            this.textBoxSurname.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(97, 22);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(194, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // buttonCreateMR
            // 
            this.buttonCreateMR.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCreateMR.FlatAppearance.BorderSize = 0;
            this.buttonCreateMR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateMR.Location = new System.Drawing.Point(250, 23);
            this.buttonCreateMR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateMR.Name = "buttonCreateMR";
            this.buttonCreateMR.Size = new System.Drawing.Size(56, 40);
            this.buttonCreateMR.TabIndex = 17;
            this.buttonCreateMR.Text = "Create";
            this.buttonCreateMR.UseVisualStyleBackColor = false;
            this.buttonCreateMR.Click += new System.EventHandler(this.buttonCreateMR_Click);
            // 
            // groupBoxMRInfo
            // 
            this.groupBoxMRInfo.Controls.Add(this.buttonDelete);
            this.groupBoxMRInfo.Controls.Add(this.buttonCreateMR);
            this.groupBoxMRInfo.Controls.Add(this.buttonUpdate);
            this.groupBoxMRInfo.Controls.Add(this.comboBoxRH);
            this.groupBoxMRInfo.Controls.Add(this.labelRH);
            this.groupBoxMRInfo.Controls.Add(this.labelBloodType);
            this.groupBoxMRInfo.Controls.Add(this.comboBoxBloodType);
            this.groupBoxMRInfo.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBoxMRInfo.Controls.Add(this.labelBirthDate);
            this.groupBoxMRInfo.Controls.Add(this.labelMaidenName);
            this.groupBoxMRInfo.Controls.Add(this.comboBoxMartial);
            this.groupBoxMRInfo.Controls.Add(this.labelMartial);
            this.groupBoxMRInfo.Controls.Add(this.textBoxMaidenName);
            this.groupBoxMRInfo.Controls.Add(this.textBoxPINumber);
            this.groupBoxMRInfo.Controls.Add(this.labelPIN);
            this.groupBoxMRInfo.Controls.Add(this.labelMRNumber);
            this.groupBoxMRInfo.Controls.Add(this.textBoxMRNumber);
            this.groupBoxMRInfo.Location = new System.Drawing.Point(369, 62);
            this.groupBoxMRInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMRInfo.Name = "groupBoxMRInfo";
            this.groupBoxMRInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMRInfo.Size = new System.Drawing.Size(323, 230);
            this.groupBoxMRInfo.TabIndex = 17;
            this.groupBoxMRInfo.TabStop = false;
            this.groupBoxMRInfo.Text = "MR Info";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(250, 141);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(56, 40);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Location = new System.Drawing.Point(250, 82);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(56, 40);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxRH
            // 
            this.comboBoxRH.FormattingEnabled = true;
            this.comboBoxRH.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBoxRH.Location = new System.Drawing.Point(90, 162);
            this.comboBoxRH.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRH.Name = "comboBoxRH";
            this.comboBoxRH.Size = new System.Drawing.Size(155, 21);
            this.comboBoxRH.TabIndex = 45;
            // 
            // labelRH
            // 
            this.labelRH.AutoSize = true;
            this.labelRH.Location = new System.Drawing.Point(13, 163);
            this.labelRH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRH.Name = "labelRH";
            this.labelRH.Size = new System.Drawing.Size(56, 13);
            this.labelRH.TabIndex = 44;
            this.labelRH.Text = "RH Factor";
            // 
            // labelBloodType
            // 
            this.labelBloodType.AutoSize = true;
            this.labelBloodType.Location = new System.Drawing.Point(13, 141);
            this.labelBloodType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBloodType.Name = "labelBloodType";
            this.labelBloodType.Size = new System.Drawing.Size(58, 13);
            this.labelBloodType.TabIndex = 43;
            this.labelBloodType.Text = "BloodType";
            // 
            // comboBoxBloodType
            // 
            this.comboBoxBloodType.FormattingEnabled = true;
            this.comboBoxBloodType.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "0"});
            this.comboBoxBloodType.Location = new System.Drawing.Point(90, 138);
            this.comboBoxBloodType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBloodType.Name = "comboBoxBloodType";
            this.comboBoxBloodType.Size = new System.Drawing.Size(155, 21);
            this.comboBoxBloodType.TabIndex = 42;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(90, 115);
            this.dateTimePickerBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(155, 20);
            this.dateTimePickerBirthDate.TabIndex = 41;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(13, 118);
            this.labelBirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(51, 13);
            this.labelBirthDate.TabIndex = 40;
            this.labelBirthDate.Text = "BirthDate";
            // 
            // labelMaidenName
            // 
            this.labelMaidenName.AutoSize = true;
            this.labelMaidenName.Location = new System.Drawing.Point(13, 95);
            this.labelMaidenName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaidenName.Name = "labelMaidenName";
            this.labelMaidenName.Size = new System.Drawing.Size(70, 13);
            this.labelMaidenName.TabIndex = 39;
            this.labelMaidenName.Text = "MaidenName";
            // 
            // comboBoxMartial
            // 
            this.comboBoxMartial.FormattingEnabled = true;
            this.comboBoxMartial.Items.AddRange(new object[] {
            "Single",
            "Divorced",
            "Married",
            "Widowed"});
            this.comboBoxMartial.Location = new System.Drawing.Point(90, 68);
            this.comboBoxMartial.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMartial.Name = "comboBoxMartial";
            this.comboBoxMartial.Size = new System.Drawing.Size(155, 21);
            this.comboBoxMartial.TabIndex = 38;
            // 
            // labelMartial
            // 
            this.labelMartial.AutoSize = true;
            this.labelMartial.Location = new System.Drawing.Point(13, 72);
            this.labelMartial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMartial.Name = "labelMartial";
            this.labelMartial.Size = new System.Drawing.Size(68, 13);
            this.labelMartial.TabIndex = 37;
            this.labelMartial.Text = "MartialStatus";
            // 
            // textBoxMaidenName
            // 
            this.textBoxMaidenName.Location = new System.Drawing.Point(90, 93);
            this.textBoxMaidenName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaidenName.Name = "textBoxMaidenName";
            this.textBoxMaidenName.Size = new System.Drawing.Size(155, 20);
            this.textBoxMaidenName.TabIndex = 36;
            // 
            // textBoxPINumber
            // 
            this.textBoxPINumber.Location = new System.Drawing.Point(90, 46);
            this.textBoxPINumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPINumber.Name = "textBoxPINumber";
            this.textBoxPINumber.Size = new System.Drawing.Size(155, 20);
            this.textBoxPINumber.TabIndex = 35;
            // 
            // labelPIN
            // 
            this.labelPIN.AutoSize = true;
            this.labelPIN.Location = new System.Drawing.Point(13, 50);
            this.labelPIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPIN.Name = "labelPIN";
            this.labelPIN.Size = new System.Drawing.Size(54, 13);
            this.labelPIN.TabIndex = 34;
            this.labelPIN.Text = "PINumber";
            // 
            // labelMRNumber
            // 
            this.labelMRNumber.AutoSize = true;
            this.labelMRNumber.Location = new System.Drawing.Point(13, 27);
            this.labelMRNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMRNumber.Name = "labelMRNumber";
            this.labelMRNumber.Size = new System.Drawing.Size(61, 13);
            this.labelMRNumber.TabIndex = 33;
            this.labelMRNumber.Text = "MRNumber";
            // 
            // textBoxMRNumber
            // 
            this.textBoxMRNumber.Location = new System.Drawing.Point(90, 23);
            this.textBoxMRNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMRNumber.Name = "textBoxMRNumber";
            this.textBoxMRNumber.ReadOnly = true;
            this.textBoxMRNumber.Size = new System.Drawing.Size(155, 20);
            this.textBoxMRNumber.TabIndex = 32;
            // 
            // labelPatients
            // 
            this.labelPatients.AutoSize = true;
            this.labelPatients.Location = new System.Drawing.Point(16, 20);
            this.labelPatients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPatients.Name = "labelPatients";
            this.labelPatients.Size = new System.Drawing.Size(40, 13);
            this.labelPatients.TabIndex = 18;
            this.labelPatients.Text = "Patient";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPatients);
            this.groupBox1.Controls.Add(this.comboBoxPatients);
            this.groupBox1.Location = new System.Drawing.Point(54, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 54);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
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
            this.menuStrip1.Size = new System.Drawing.Size(1394, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medicalRecordsToolStripMenuItem
            // 
            this.medicalRecordsToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
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
            // DoctorsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1394, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxMRInfo);
            this.Controls.Add(this.groupBoxPersonal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DoctorsPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorsPanel";
            this.Load += new System.EventHandler(this.DoctorsPanel_Load);
            this.groupBoxPersonal.ResumeLayout(false);
            this.groupBoxPersonal.PerformLayout();
            this.groupBoxMRInfo.ResumeLayout(false);
            this.groupBoxMRInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxPatients;
        private System.Windows.Forms.GroupBox groupBoxPersonal;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxMR;
        private System.Windows.Forms.Button buttonCreateMR;
        private System.Windows.Forms.GroupBox groupBoxMRInfo;
        private System.Windows.Forms.ComboBox comboBoxRH;
        private System.Windows.Forms.Label labelRH;
        private System.Windows.Forms.Label labelBloodType;
        private System.Windows.Forms.ComboBox comboBoxBloodType;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelMaidenName;
        private System.Windows.Forms.ComboBox comboBoxMartial;
        private System.Windows.Forms.Label labelMartial;
        private System.Windows.Forms.TextBox textBoxMaidenName;
        private System.Windows.Forms.TextBox textBoxPINumber;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.Label labelMRNumber;
        private System.Windows.Forms.TextBox textBoxMRNumber;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPatients;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}
namespace prenatal.winUI.PanelAdmin
{
    partial class AdminPanel
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLastLogin = new System.Windows.Forms.TextBox();
            this.textBoxRegistration = new System.Windows.Forms.TextBox();
            this.groupBoxSetPassword = new System.Windows.Forms.GroupBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.buttonUsername = new System.Windows.Forms.Button();
            this.buttonSetPassword = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.labelLastLogin = new System.Windows.Forms.Label();
            this.labelLogins = new System.Windows.Forms.Label();
            this.textBoxLoginCount = new System.Windows.Forms.TextBox();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.comboBoxDoctors = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxAccType = new System.Windows.Forms.ComboBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAccType = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxCRUD = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxTFilter = new System.Windows.Forms.GroupBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.checkBoxPatient = new System.Windows.Forms.CheckBox();
            this.checkBoxDoctor = new System.Windows.Forms.CheckBox();
            this.checkBoxLabAssis = new System.Windows.Forms.CheckBox();
            this.checkBoxNurse = new System.Windows.Forms.CheckBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.groupBoxSFilter = new System.Windows.Forms.GroupBox();
            this.checkBoxRejected = new System.Windows.Forms.CheckBox();
            this.checkBoxApproved = new System.Windows.Forms.CheckBox();
            this.groupBoxNSFilter = new System.Windows.Forms.GroupBox();
            this.textBoxNameSurname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxSetPassword.SuspendLayout();
            this.groupBoxCRUD.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxTFilter.SuspendLayout();
            this.groupBoxSFilter.SuspendLayout();
            this.groupBoxNSFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dgName,
            this.Surname,
            this.Gender,
            this.Email,
            this.PhoneNumber,
            this.Username,
            this.Status,
            this.AccType,
            this.Doctor,
            this.Logins,
            this.Registration,
            this.LastLogin});
            this.dataGridViewUsers.Location = new System.Drawing.Point(21, 24);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1218, 272);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // dgName
            // 
            this.dgName.DataPropertyName = "Name";
            this.dgName.HeaderText = "Name";
            this.dgName.MinimumWidth = 6;
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            this.dgName.Width = 125;
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 125;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 125;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // AccType
            // 
            this.AccType.DataPropertyName = "Type";
            this.AccType.HeaderText = "AccType";
            this.AccType.MinimumWidth = 6;
            this.AccType.Name = "AccType";
            this.AccType.ReadOnly = true;
            this.AccType.Width = 125;
            // 
            // Doctor
            // 
            this.Doctor.DataPropertyName = "DoctorId";
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.MinimumWidth = 6;
            this.Doctor.Name = "Doctor";
            this.Doctor.ReadOnly = true;
            this.Doctor.Width = 125;
            // 
            // Logins
            // 
            this.Logins.DataPropertyName = "LoginCount";
            this.Logins.HeaderText = "Logins";
            this.Logins.MinimumWidth = 6;
            this.Logins.Name = "Logins";
            this.Logins.ReadOnly = true;
            this.Logins.Width = 125;
            // 
            // Registration
            // 
            this.Registration.DataPropertyName = "Registration";
            this.Registration.HeaderText = "Registration";
            this.Registration.MinimumWidth = 6;
            this.Registration.Name = "Registration";
            this.Registration.ReadOnly = true;
            this.Registration.Width = 125;
            // 
            // LastLogin
            // 
            this.LastLogin.DataPropertyName = "LastLogin";
            this.LastLogin.HeaderText = "LastLogin";
            this.LastLogin.MinimumWidth = 6;
            this.LastLogin.Name = "LastLogin";
            this.LastLogin.ReadOnly = true;
            this.LastLogin.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxLastLogin);
            this.panel1.Controls.Add(this.textBoxRegistration);
            this.panel1.Controls.Add(this.groupBoxSetPassword);
            this.panel1.Controls.Add(this.labelRegistration);
            this.panel1.Controls.Add(this.labelLastLogin);
            this.panel1.Controls.Add(this.labelLogins);
            this.panel1.Controls.Add(this.textBoxLoginCount);
            this.panel1.Controls.Add(this.labelDoctor);
            this.panel1.Controls.Add(this.comboBoxDoctors);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.comboBoxAccType);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.textBoxSurname);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxGender);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelAccType);
            this.panel1.Controls.Add(this.labelGender);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.labelSurname);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Location = new System.Drawing.Point(16, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 202);
            this.panel1.TabIndex = 1;
            // 
            // textBoxLastLogin
            // 
            this.textBoxLastLogin.Location = new System.Drawing.Point(536, 44);
            this.textBoxLastLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastLogin.Name = "textBoxLastLogin";
            this.textBoxLastLogin.ReadOnly = true;
            this.textBoxLastLogin.Size = new System.Drawing.Size(152, 20);
            this.textBoxLastLogin.TabIndex = 28;
            // 
            // textBoxRegistration
            // 
            this.textBoxRegistration.Location = new System.Drawing.Point(536, 11);
            this.textBoxRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegistration.Name = "textBoxRegistration";
            this.textBoxRegistration.ReadOnly = true;
            this.textBoxRegistration.Size = new System.Drawing.Size(152, 20);
            this.textBoxRegistration.TabIndex = 27;
            // 
            // groupBoxSetPassword
            // 
            this.groupBoxSetPassword.Controls.Add(this.labelPass);
            this.groupBoxSetPassword.Controls.Add(this.buttonUsername);
            this.groupBoxSetPassword.Controls.Add(this.buttonSetPassword);
            this.groupBoxSetPassword.Controls.Add(this.textBoxPassword);
            this.groupBoxSetPassword.Location = new System.Drawing.Point(468, 72);
            this.groupBoxSetPassword.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSetPassword.Name = "groupBoxSetPassword";
            this.groupBoxSetPassword.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSetPassword.Size = new System.Drawing.Size(241, 119);
            this.groupBoxSetPassword.TabIndex = 26;
            this.groupBoxSetPassword.TabStop = false;
            this.groupBoxSetPassword.Text = "OVERRIDE";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(10, 27);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(53, 13);
            this.labelPass.TabIndex = 15;
            this.labelPass.Text = "Password";
            // 
            // buttonUsername
            // 
            this.buttonUsername.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonUsername.FlatAppearance.BorderSize = 0;
            this.buttonUsername.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUsername.Location = new System.Drawing.Point(68, 83);
            this.buttonUsername.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUsername.Name = "buttonUsername";
            this.buttonUsername.Size = new System.Drawing.Size(151, 28);
            this.buttonUsername.TabIndex = 26;
            this.buttonUsername.Text = "Set Username";
            this.buttonUsername.UseVisualStyleBackColor = false;
            this.buttonUsername.Click += new System.EventHandler(this.buttonUsername_Click);
            // 
            // buttonSetPassword
            // 
            this.buttonSetPassword.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSetPassword.FlatAppearance.BorderSize = 0;
            this.buttonSetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetPassword.Location = new System.Drawing.Point(68, 50);
            this.buttonSetPassword.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetPassword.Name = "buttonSetPassword";
            this.buttonSetPassword.Size = new System.Drawing.Size(151, 28);
            this.buttonSetPassword.TabIndex = 25;
            this.buttonSetPassword.Text = "Set Password";
            this.buttonSetPassword.UseVisualStyleBackColor = false;
            this.buttonSetPassword.Click += new System.EventHandler(this.buttonSetPassword_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(68, 24);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(152, 20);
            this.textBoxPassword.TabIndex = 24;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Location = new System.Drawing.Point(466, 16);
            this.labelRegistration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(63, 13);
            this.labelRegistration.TabIndex = 23;
            this.labelRegistration.Text = "Registration";
            // 
            // labelLastLogin
            // 
            this.labelLastLogin.AutoSize = true;
            this.labelLastLogin.Location = new System.Drawing.Point(466, 46);
            this.labelLastLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastLogin.Name = "labelLastLogin";
            this.labelLastLogin.Size = new System.Drawing.Size(53, 13);
            this.labelLastLogin.TabIndex = 21;
            this.labelLastLogin.Text = "LastLogin";
            // 
            // labelLogins
            // 
            this.labelLogins.AutoSize = true;
            this.labelLogins.Location = new System.Drawing.Point(238, 145);
            this.labelLogins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogins.Name = "labelLogins";
            this.labelLogins.Size = new System.Drawing.Size(38, 13);
            this.labelLogins.TabIndex = 19;
            this.labelLogins.Text = "Logins";
            // 
            // textBoxLoginCount
            // 
            this.textBoxLoginCount.Location = new System.Drawing.Point(298, 141);
            this.textBoxLoginCount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLoginCount.Name = "textBoxLoginCount";
            this.textBoxLoginCount.ReadOnly = true;
            this.textBoxLoginCount.Size = new System.Drawing.Size(152, 20);
            this.textBoxLoginCount.TabIndex = 18;
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(238, 112);
            this.labelDoctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(45, 13);
            this.labelDoctor.TabIndex = 17;
            this.labelDoctor.Text = "Doctor?";
            // 
            // comboBoxDoctors
            // 
            this.comboBoxDoctors.FormattingEnabled = true;
            this.comboBoxDoctors.Location = new System.Drawing.Point(298, 107);
            this.comboBoxDoctors.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDoctors.Name = "comboBoxDoctors";
            this.comboBoxDoctors.Size = new System.Drawing.Size(152, 21);
            this.comboBoxDoctors.TabIndex = 16;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(298, 43);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(152, 21);
            this.comboBoxStatus.TabIndex = 6;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(238, 47);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status";
            // 
            // comboBoxAccType
            // 
            this.comboBoxAccType.FormattingEnabled = true;
            this.comboBoxAccType.Location = new System.Drawing.Point(298, 74);
            this.comboBoxAccType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAccType.Name = "comboBoxAccType";
            this.comboBoxAccType.Size = new System.Drawing.Size(152, 21);
            this.comboBoxAccType.TabIndex = 5;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(298, 11);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(152, 20);
            this.textBoxUsername.TabIndex = 15;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(70, 77);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(152, 20);
            this.textBoxSurname.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(70, 46);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(152, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(70, 14);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(152, 20);
            this.textBoxId.TabIndex = 12;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(70, 172);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(152, 20);
            this.textBoxPhone.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(70, 141);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(152, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(70, 109);
            this.textBoxGender.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(152, 20);
            this.textBoxGender.TabIndex = 8;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(16, 176);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Phone";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(16, 145);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "E-mail";
            // 
            // labelAccType
            // 
            this.labelAccType.AutoSize = true;
            this.labelAccType.Location = new System.Drawing.Point(238, 80);
            this.labelAccType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccType.Name = "labelAccType";
            this.labelAccType.Size = new System.Drawing.Size(50, 13);
            this.labelAccType.TabIndex = 5;
            this.labelAccType.Text = "AccType";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(16, 113);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 13);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(238, 15);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(16, 81);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Surname";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 50);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(16, 18);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(750, 76);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(53, 45);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Location = new System.Drawing.Point(750, 128);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(53, 45);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(750, 180);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(53, 45);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Location = new System.Drawing.Point(750, 24);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(53, 45);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBoxCRUD
            // 
            this.groupBoxCRUD.Controls.Add(this.panel1);
            this.groupBoxCRUD.Controls.Add(this.buttonClear);
            this.groupBoxCRUD.Controls.Add(this.buttonAdd);
            this.groupBoxCRUD.Controls.Add(this.buttonDelete);
            this.groupBoxCRUD.Controls.Add(this.buttonUpdate);
            this.groupBoxCRUD.Location = new System.Drawing.Point(21, 298);
            this.groupBoxCRUD.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCRUD.Name = "groupBoxCRUD";
            this.groupBoxCRUD.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCRUD.Size = new System.Drawing.Size(808, 244);
            this.groupBoxCRUD.TabIndex = 6;
            this.groupBoxCRUD.TabStop = false;
            this.groupBoxCRUD.Text = "CRUD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxTFilter);
            this.groupBox1.Controls.Add(this.buttonApply);
            this.groupBox1.Controls.Add(this.groupBoxSFilter);
            this.groupBox1.Controls.Add(this.groupBoxNSFilter);
            this.groupBox1.Location = new System.Drawing.Point(850, 298);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(389, 244);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTERS";
            // 
            // groupBoxTFilter
            // 
            this.groupBoxTFilter.Controls.Add(this.checkBoxAdmin);
            this.groupBoxTFilter.Controls.Add(this.checkBoxPatient);
            this.groupBoxTFilter.Controls.Add(this.checkBoxDoctor);
            this.groupBoxTFilter.Controls.Add(this.checkBoxLabAssis);
            this.groupBoxTFilter.Controls.Add(this.checkBoxNurse);
            this.groupBoxTFilter.Location = new System.Drawing.Point(16, 83);
            this.groupBoxTFilter.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTFilter.Name = "groupBoxTFilter";
            this.groupBoxTFilter.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTFilter.Size = new System.Drawing.Size(355, 66);
            this.groupBoxTFilter.TabIndex = 14;
            this.groupBoxTFilter.TabStop = false;
            this.groupBoxTFilter.Text = "by Type";
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(14, 28);
            this.checkBoxAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(55, 17);
            this.checkBoxAdmin.TabIndex = 4;
            this.checkBoxAdmin.Text = "Admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // checkBoxPatient
            // 
            this.checkBoxPatient.AutoSize = true;
            this.checkBoxPatient.Location = new System.Drawing.Point(290, 27);
            this.checkBoxPatient.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxPatient.Name = "checkBoxPatient";
            this.checkBoxPatient.Size = new System.Drawing.Size(59, 17);
            this.checkBoxPatient.TabIndex = 8;
            this.checkBoxPatient.Text = "Patient";
            this.checkBoxPatient.UseVisualStyleBackColor = true;
            // 
            // checkBoxDoctor
            // 
            this.checkBoxDoctor.AutoSize = true;
            this.checkBoxDoctor.Location = new System.Drawing.Point(75, 28);
            this.checkBoxDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDoctor.Name = "checkBoxDoctor";
            this.checkBoxDoctor.Size = new System.Drawing.Size(58, 17);
            this.checkBoxDoctor.TabIndex = 5;
            this.checkBoxDoctor.Text = "Doctor";
            this.checkBoxDoctor.UseVisualStyleBackColor = true;
            // 
            // checkBoxLabAssis
            // 
            this.checkBoxLabAssis.AutoSize = true;
            this.checkBoxLabAssis.Location = new System.Drawing.Point(198, 28);
            this.checkBoxLabAssis.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLabAssis.Name = "checkBoxLabAssis";
            this.checkBoxLabAssis.Size = new System.Drawing.Size(86, 17);
            this.checkBoxLabAssis.TabIndex = 7;
            this.checkBoxLabAssis.Text = "LabAssistant";
            this.checkBoxLabAssis.UseVisualStyleBackColor = true;
            // 
            // checkBoxNurse
            // 
            this.checkBoxNurse.AutoSize = true;
            this.checkBoxNurse.Location = new System.Drawing.Point(138, 28);
            this.checkBoxNurse.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxNurse.Name = "checkBoxNurse";
            this.checkBoxNurse.Size = new System.Drawing.Size(54, 17);
            this.checkBoxNurse.TabIndex = 6;
            this.checkBoxNurse.Text = "Nurse";
            this.checkBoxNurse.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonApply.FlatAppearance.BorderSize = 0;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonApply.Location = new System.Drawing.Point(16, 201);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(355, 27);
            this.buttonApply.TabIndex = 11;
            this.buttonApply.Text = "ApplyFilters";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // groupBoxSFilter
            // 
            this.groupBoxSFilter.Controls.Add(this.checkBoxRejected);
            this.groupBoxSFilter.Controls.Add(this.checkBoxApproved);
            this.groupBoxSFilter.Location = new System.Drawing.Point(216, 17);
            this.groupBoxSFilter.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSFilter.Name = "groupBoxSFilter";
            this.groupBoxSFilter.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSFilter.Size = new System.Drawing.Size(155, 66);
            this.groupBoxSFilter.TabIndex = 13;
            this.groupBoxSFilter.TabStop = false;
            this.groupBoxSFilter.Text = "by Status";
            // 
            // checkBoxRejected
            // 
            this.checkBoxRejected.AutoSize = true;
            this.checkBoxRejected.Location = new System.Drawing.Point(84, 26);
            this.checkBoxRejected.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRejected.Name = "checkBoxRejected";
            this.checkBoxRejected.Size = new System.Drawing.Size(69, 17);
            this.checkBoxRejected.TabIndex = 11;
            this.checkBoxRejected.Text = "Rejected";
            this.checkBoxRejected.UseVisualStyleBackColor = true;
            // 
            // checkBoxApproved
            // 
            this.checkBoxApproved.AutoSize = true;
            this.checkBoxApproved.Location = new System.Drawing.Point(11, 26);
            this.checkBoxApproved.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxApproved.Name = "checkBoxApproved";
            this.checkBoxApproved.Size = new System.Drawing.Size(72, 17);
            this.checkBoxApproved.TabIndex = 10;
            this.checkBoxApproved.Text = "Approved";
            this.checkBoxApproved.UseVisualStyleBackColor = true;
            // 
            // groupBoxNSFilter
            // 
            this.groupBoxNSFilter.Controls.Add(this.textBoxNameSurname);
            this.groupBoxNSFilter.Location = new System.Drawing.Point(16, 17);
            this.groupBoxNSFilter.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxNSFilter.Name = "groupBoxNSFilter";
            this.groupBoxNSFilter.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxNSFilter.Size = new System.Drawing.Size(195, 66);
            this.groupBoxNSFilter.TabIndex = 12;
            this.groupBoxNSFilter.TabStop = false;
            this.groupBoxNSFilter.Text = "by Name||Surname";
            // 
            // textBoxNameSurname
            // 
            this.textBoxNameSurname.Location = new System.Drawing.Point(11, 25);
            this.textBoxNameSurname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameSurname.Name = "textBoxNameSurname";
            this.textBoxNameSurname.Size = new System.Drawing.Size(173, 20);
            this.textBoxNameSurname.TabIndex = 1;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCRUD);
            this.Controls.Add(this.dataGridViewUsers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.frmCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxSetPassword.ResumeLayout(false);
            this.groupBoxSetPassword.PerformLayout();
            this.groupBoxCRUD.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxTFilter.ResumeLayout(false);
            this.groupBoxTFilter.PerformLayout();
            this.groupBoxSFilter.ResumeLayout(false);
            this.groupBoxSFilter.PerformLayout();
            this.groupBoxNSFilter.ResumeLayout(false);
            this.groupBoxNSFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelAccType;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxAccType;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBoxCRUD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxTFilter;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.CheckBox checkBoxPatient;
        private System.Windows.Forms.CheckBox checkBoxDoctor;
        private System.Windows.Forms.CheckBox checkBoxLabAssis;
        private System.Windows.Forms.CheckBox checkBoxNurse;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.GroupBox groupBoxSFilter;
        private System.Windows.Forms.CheckBox checkBoxRejected;
        private System.Windows.Forms.CheckBox checkBoxApproved;
        private System.Windows.Forms.GroupBox groupBoxNSFilter;
        private System.Windows.Forms.TextBox textBoxNameSurname;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.ComboBox comboBoxDoctors;
        private System.Windows.Forms.TextBox textBoxLoginCount;
        private System.Windows.Forms.Label labelLogins;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Label labelLastLogin;
        private System.Windows.Forms.GroupBox groupBoxSetPassword;
        private System.Windows.Forms.Button buttonSetPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registration;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastLogin;
        private System.Windows.Forms.TextBox textBoxLastLogin;
        private System.Windows.Forms.TextBox textBoxRegistration;
        private System.Windows.Forms.Button buttonUsername;
        private System.Windows.Forms.Label labelPass;
    }
}
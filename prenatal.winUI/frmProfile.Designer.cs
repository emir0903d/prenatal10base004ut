
namespace prenatal.winUI
{
    partial class frmProfile
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cmbBoxGender = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxLastLogin = new System.Windows.Forms.TextBox();
            this.textBoxRegistration = new System.Windows.Forms.TextBox();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.labelLastLogin = new System.Windows.Forms.Label();
            this.labelLogins = new System.Windows.Forms.Label();
            this.textBoxLoginCount = new System.Windows.Forms.TextBox();
            this.grpBoxAccInfo = new System.Windows.Forms.GroupBox();
            this.lblManualEntryKey = new System.Windows.Forms.Label();
            this.btnEnableDisable = new System.Windows.Forms.Button();
            this.textBoxInputCode = new System.Windows.Forms.TextBox();
            this.pctBoxQRCode = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEnabledDisabled = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpBoxAccInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxQRCode)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.cmbBoxGender);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(14, 279);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 31);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(14, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(77, 20);
            this.txtId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(10, 100);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 242);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(157, 20);
            this.txtPhone.TabIndex = 20;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(13, 117);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(156, 20);
            this.txtSurname.TabIndex = 6;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 201);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gender";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(9, 227);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone";
            // 
            // cmbBoxGender
            // 
            this.cmbBoxGender.FormattingEnabled = true;
            this.cmbBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbBoxGender.Location = new System.Drawing.Point(13, 160);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(156, 21);
            this.cmbBoxGender.TabIndex = 8;
            this.cmbBoxGender.SelectedValueChanged += new System.EventHandler(this.cmbBoxGender_SelectedValueChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 186);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "E-mail";
            // 
            // textBoxLastLogin
            // 
            this.textBoxLastLogin.Location = new System.Drawing.Point(17, 74);
            this.textBoxLastLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastLogin.Name = "textBoxLastLogin";
            this.textBoxLastLogin.ReadOnly = true;
            this.textBoxLastLogin.Size = new System.Drawing.Size(201, 20);
            this.textBoxLastLogin.TabIndex = 38;
            // 
            // textBoxRegistration
            // 
            this.textBoxRegistration.Location = new System.Drawing.Point(17, 34);
            this.textBoxRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegistration.Name = "textBoxRegistration";
            this.textBoxRegistration.ReadOnly = true;
            this.textBoxRegistration.Size = new System.Drawing.Size(201, 20);
            this.textBoxRegistration.TabIndex = 37;
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Location = new System.Drawing.Point(14, 19);
            this.labelRegistration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(63, 13);
            this.labelRegistration.TabIndex = 36;
            this.labelRegistration.Text = "Registration";
            // 
            // labelLastLogin
            // 
            this.labelLastLogin.AutoSize = true;
            this.labelLastLogin.Location = new System.Drawing.Point(14, 59);
            this.labelLastLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastLogin.Name = "labelLastLogin";
            this.labelLastLogin.Size = new System.Drawing.Size(53, 13);
            this.labelLastLogin.TabIndex = 35;
            this.labelLastLogin.Text = "LastLogin";
            // 
            // labelLogins
            // 
            this.labelLogins.AutoSize = true;
            this.labelLogins.Location = new System.Drawing.Point(14, 95);
            this.labelLogins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogins.Name = "labelLogins";
            this.labelLogins.Size = new System.Drawing.Size(38, 13);
            this.labelLogins.TabIndex = 34;
            this.labelLogins.Text = "Logins";
            // 
            // textBoxLoginCount
            // 
            this.textBoxLoginCount.Location = new System.Drawing.Point(17, 110);
            this.textBoxLoginCount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLoginCount.Name = "textBoxLoginCount";
            this.textBoxLoginCount.ReadOnly = true;
            this.textBoxLoginCount.Size = new System.Drawing.Size(201, 20);
            this.textBoxLoginCount.TabIndex = 33;
            // 
            // grpBoxAccInfo
            // 
            this.grpBoxAccInfo.Controls.Add(this.textBoxLastLogin);
            this.grpBoxAccInfo.Controls.Add(this.textBoxRegistration);
            this.grpBoxAccInfo.Controls.Add(this.labelRegistration);
            this.grpBoxAccInfo.Controls.Add(this.labelLastLogin);
            this.grpBoxAccInfo.Controls.Add(this.labelLogins);
            this.grpBoxAccInfo.Controls.Add(this.textBoxLoginCount);
            this.grpBoxAccInfo.Location = new System.Drawing.Point(205, 12);
            this.grpBoxAccInfo.Name = "grpBoxAccInfo";
            this.grpBoxAccInfo.Size = new System.Drawing.Size(236, 150);
            this.grpBoxAccInfo.TabIndex = 39;
            this.grpBoxAccInfo.TabStop = false;
            this.grpBoxAccInfo.Text = "Account Information";
            // 
            // lblManualEntryKey
            // 
            this.lblManualEntryKey.AutoSize = true;
            this.lblManualEntryKey.Location = new System.Drawing.Point(23, 204);
            this.lblManualEntryKey.Name = "lblManualEntryKey";
            this.lblManualEntryKey.Size = new System.Drawing.Size(0, 13);
            this.lblManualEntryKey.TabIndex = 43;
            // 
            // btnEnableDisable
            // 
            this.btnEnableDisable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEnableDisable.FlatAppearance.BorderSize = 0;
            this.btnEnableDisable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnableDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnableDisable.ForeColor = System.Drawing.Color.Red;
            this.btnEnableDisable.Location = new System.Drawing.Point(20, 251);
            this.btnEnableDisable.Name = "btnEnableDisable";
            this.btnEnableDisable.Size = new System.Drawing.Size(198, 29);
            this.btnEnableDisable.TabIndex = 42;
            this.btnEnableDisable.Text = "ENABLE";
            this.btnEnableDisable.UseVisualStyleBackColor = false;
            this.btnEnableDisable.Click += new System.EventHandler(this.btnEnableDisable_Click);
            // 
            // textBoxInputCode
            // 
            this.textBoxInputCode.Location = new System.Drawing.Point(21, 225);
            this.textBoxInputCode.Name = "textBoxInputCode";
            this.textBoxInputCode.Size = new System.Drawing.Size(198, 20);
            this.textBoxInputCode.TabIndex = 41;
            // 
            // pctBoxQRCode
            // 
            this.pctBoxQRCode.Location = new System.Drawing.Point(20, 46);
            this.pctBoxQRCode.Name = "pctBoxQRCode";
            this.pctBoxQRCode.Size = new System.Drawing.Size(198, 150);
            this.pctBoxQRCode.TabIndex = 40;
            this.pctBoxQRCode.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEnabledDisabled);
            this.groupBox2.Controls.Add(this.lblManualEntryKey);
            this.groupBox2.Controls.Add(this.btnEnableDisable);
            this.groupBox2.Controls.Add(this.textBoxInputCode);
            this.groupBox2.Controls.Add(this.pctBoxQRCode);
            this.groupBox2.Location = new System.Drawing.Point(447, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 294);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TwoFactorAuthentication";
            // 
            // lblEnabledDisabled
            // 
            this.lblEnabledDisabled.AutoSize = true;
            this.lblEnabledDisabled.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEnabledDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnabledDisabled.ForeColor = System.Drawing.Color.Red;
            this.lblEnabledDisabled.Location = new System.Drawing.Point(89, 21);
            this.lblEnabledDisabled.Name = "lblEnabledDisabled";
            this.lblEnabledDisabled.Size = new System.Drawing.Size(70, 15);
            this.lblEnabledDisabled.TabIndex = 44;
            this.lblEnabledDisabled.Text = "DISABLED";
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 357);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBoxAccInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfile";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxAccInfo.ResumeLayout(false);
            this.grpBoxAccInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxQRCode)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBoxLastLogin;
        private System.Windows.Forms.TextBox textBoxRegistration;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Label labelLastLogin;
        private System.Windows.Forms.Label labelLogins;
        private System.Windows.Forms.TextBox textBoxLoginCount;
        private System.Windows.Forms.GroupBox grpBoxAccInfo;
        private System.Windows.Forms.Label lblManualEntryKey;
        private System.Windows.Forms.Button btnEnableDisable;
        private System.Windows.Forms.TextBox textBoxInputCode;
        private System.Windows.Forms.PictureBox pctBoxQRCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEnabledDisabled;
    }
}
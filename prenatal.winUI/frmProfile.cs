using prenatal.model;
using prenatal.winUI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prenatal.winUI
{
    public partial class frmProfile : Form
    {
        APIservice _users = new APIservice("User");
        _2FAService _2FA = new _2FAService();

        public int _currentUserId { get; set; }
        public frmProfile()
        {
            APIservice.Username = AuthService.Username;
            APIservice.Password = AuthService.Password;
            _2FAService.Username = AuthService.Username;
            _2FAService.Password = AuthService.Password;
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private bool ValidateData(object data)
        {
            ValidationContext context = new ValidationContext(data, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(data, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                    MessageBox.Show(result.ErrorMessage);

                return false;
            }
            else
            {
                MessageBox.Show("Success!!!");
                return true;
            }
        }
        private void PopulatePersonalInfo(User _currentUser)
        {
            txtId.Text = _currentUser.Id.ToString();
            txtName.Text = _currentUser.Name;
            txtSurname.Text = _currentUser.Surname;

            DataTable dt = new DataTable();
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Value", typeof(string));
            var row1 = dt.NewRow();
            row1["Key"] ="1";
            row1["Value"] = "Male";
            dt.Rows.Add(row1);
            var row2 = dt.NewRow();
            row2["Key"] = "2";
            row2["Value"] = "Female";
            dt.Rows.Add(row2);

            cmbBoxGender.DataSource = dt;
            cmbBoxGender.DisplayMember = "Value";
            cmbBoxGender.ValueMember = "Key";

            //cmbBoxGender.DataBindings.Clear();
            if(_currentUser.Gender == "Male")
            {
                cmbBoxGender.SelectedIndex = 0;
            }
            if (_currentUser.Gender == "Female")
            {
                cmbBoxGender.SelectedIndex = 1;
            }

            txtPhone.Text = _currentUser.PhoneNumber;
            txtEmail.Text = _currentUser.Email;
            btnUpdate.Enabled = false;
        }
        private void PopulateAccountInfo(User _currentUser)
        {
            textBoxRegistration.Text = _currentUser.Registration.ToString();
            textBoxLastLogin.Text = _currentUser.LastLogin.ToString();
            textBoxLoginCount.Text = _currentUser.LoginCount.ToString();
        }
        private void EnableDisable2FA(bool x)
        {
            if (x == true)
            {
                btnEnableDisable.Text = "DISABLE";
                lblEnabledDisabled.Text = "ENABLED";
                lblEnabledDisabled.BorderStyle = BorderStyle.None;
                
            }
            if(x == false){
                btnEnableDisable.Text = "ENABLE";
                lblEnabledDisabled.Text = "DISABLED";
                lblEnabledDisabled.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        private async void Load2FA(User _currentUser)
        {
            _2FAReturnCodes x = await _2FA.Activate(_currentUser);

            string QRCode = x.QrCodeSetupImageUrl.Substring(22);
            byte[] imageBytes = Convert.FromBase64String(QRCode);

            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                pctBoxQRCode.Image = Image.FromStream(ms, true);
            }

            lblManualEntryKey.Text = x.ManualEntryKey;
        }
        private async void frmProfile_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.WindowState = FormWindowState.Normal;
            User _currentUser = await _users.GetById<User>(_currentUserId);
            PopulatePersonalInfo(_currentUser);
            PopulateAccountInfo(_currentUser);
            EnableDisable2FA(_currentUser.TwoFactorEnabled);
            Load2FA(_currentUser);

        }

        private async void btnEnableDisable_Click(object sender, EventArgs e)
        {
            if (textBoxInputCode.Text == "") return;

            User _currentUser = await _users.GetById<User>(_currentUserId);
            if (_currentUser == null) return;

            if (btnEnableDisable.Text == "ENABLE")
            {
                if(await _2FA.Enable(_currentUser.Id, textBoxInputCode.Text) == true)
                {
                    User _refreshUser = await _users.GetById<User>(_currentUserId);
                    EnableDisable2FA(_refreshUser.TwoFactorEnabled);
                    Load2FA(_refreshUser);
                }
                
            }
            else //(btnEnableDisable.Text == "DISABLE")
            {
                if(await _2FA.Disable(_currentUser.Id, textBoxInputCode.Text) == true)
                {
                    User _refreshUser = await _users.GetById<User>(_currentUserId);
                    EnableDisable2FA(_refreshUser.TwoFactorEnabled);
                    Load2FA(_refreshUser);
                }
                    
            }
        }
        private async void UpdatePersonalInfo(User _currentUser)
        {
            _currentUser.Name = txtName.Text;
            _currentUser.Surname = txtSurname.Text;

            DataRowView key = cmbBoxGender.SelectedItem as DataRowView;
            _currentUser.Gender = key.Row.ItemArray[1].ToString();

            _currentUser.Email = txtEmail.Text;
            _currentUser.PhoneNumber = txtPhone.Text;

            if (ValidateData(_currentUser))
            {
                await _users.Update<User>(_currentUser.Id, _currentUser);

                PopulatePersonalInfo(_currentUser);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "") return;

            btnUpdate.Enabled = true;
            
            
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (txtSurname.Text == "") return;

            btnUpdate.Enabled = true;
            
        }

        private void cmbBoxGender_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbBoxGender.Text == "") return;

            btnUpdate.Enabled = true;
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "") return;

            btnUpdate.Enabled = true;
            
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text == "") return;

            btnUpdate.Enabled = true;
            
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            User _currentUser = await _users.GetById<User>(_currentUserId);
            UpdatePersonalInfo(_currentUser);
            User _refreshUser = await _users.GetById<User>(_currentUserId);
            PopulatePersonalInfo(_refreshUser);
        }
    }
}

using prenatal.model;
using prenatal.winUI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prenatal.winUI
{
    public partial class frm2FALogin : Form
    {
        _2FAService _2FA = new _2FAService();
        public User _currentUser { get; set; }
        public frm2FALogin()
        {
            _2FAService.Username = AuthService.Username;
            _2FAService.Password = AuthService.Password;
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private async void btnVerify_Click(object sender, EventArgs e)
        {
            if (await _2FA.Login2FA(_currentUser.Id, txtBoxInputCode.Text) == true)
            {
                if (System.Windows.Forms.Application.OpenForms["frmLogin"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["frmLogin"] as frmLogin).Authorized(_currentUser);
                    this.Close();
                }
            }
        }

        private void frm2FALogin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
        }
    }
}

using Flurl.Http.Testing;
using prenatal.model;
using prenatal.model.Enumerations;
using prenatal.model.Requests;
using prenatal.winUI;
using prenatal.winUI.PanelAdmin;
using prenatal.winUI.PanelDoctor;
using prenatal.winUI.PanelPatient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prenatal.winUI
{
    public partial class frmLogin : Form
    {
        AuthService _authService = new AuthService();
        public User auth { get; set; } = null;
        public frmLogin()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == " " || textBoxUsername.TextLength == 0 || textBoxUsername.Text == null) return;
            if (textBoxPassword.Text == " " || textBoxPassword.TextLength == 0 || textBoxPassword.Text == null) return;

            AuthService.Username = textBoxUsername.Text;
            AuthService.Password = textBoxPassword.Text;
            UserAuthenticationRequest request = new UserAuthenticationRequest();
            request.username = AuthService.Username;
            request.password = AuthService.Password;
           
            auth= await _authService.Authenticate<User>(request);
            if (auth == null) return;
            
            auth.LoginCount++;
            auth.LastLogin = DateTime.Now;
            APIservice _users = new APIservice("User");
            APIservice.Username = AuthService.Username;
            APIservice.Password = AuthService.Password;
            await _users.Update<User>(auth.Id, auth);
            _users = null;

            foreach (ToolStripMenuItem x in this.MdiParent.MainMenuStrip.Items)
            {
                if (x.Name== "authenticateToolStripMenuItem")
                {
                    foreach(ToolStripMenuItem y in x.DropDownItems)
                    {
                        if (y.Name == "loginToolStripMenuItem")
                        {
                            y.Enabled = false;
                            y.Visible = false;
                        }
                        if(y.Name == "registerToolStripMenuItem")
                        {
                            y.Enabled = false;
                            y.Visible = false;
                        }
                        if (y.Name == "myProfileToolStripMenuItem")
                        {
                            y.Enabled = true;
                            y.Visible = true;
                            (this.MdiParent as FrontPanel)._currentUserId = auth.Id;
                        }
                        if (y.Name == "logoutToolStripMenuItem")
                        {
                            y.Text = "Logout, /" + auth.Id+" ,"+auth.Name+" "+auth.Surname;
                            y.Enabled = true;
                            y.Visible = true;
                            
                        }
                    }
                    
                }
    
            }

            if (auth != null)
            {

                if(auth.TwoFactorEnabled == true)
                {
                    groupBoxLogin.Enabled = false;
                    frm2FALogin frm2FALog = new frm2FALogin();
                    frm2FALog._currentUser = auth;
                    frm2FALog.ShowDialog();                  
                }
                else
                {
                    Authorized(auth);
                }
                
            }
                
        }       
        public void Authorized(User user)
        {
            if (user.Type == UserType.Type.Admin)
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel._currentUserId = auth.Id;
                adminPanel.WindowState = FormWindowState.Maximized;
                adminPanel.MdiParent = this.MdiParent;
                adminPanel.Show();
                this.Close();
                this.Dispose();
            }
            if (user.Type == UserType.Type.Doctor)
            {
                DoctorsPanel docPanel = new DoctorsPanel();
                docPanel._currentUserId = auth.Id;
                docPanel.WindowState = FormWindowState.Maximized;
                docPanel.MdiParent = this.MdiParent;
                docPanel.Show();
                this.Close();
                this.Dispose();
            }
            if (user.Type == UserType.Type.Patient)
            {
                PatientsPanel patPanel = new PatientsPanel();
                patPanel._currentUserId = auth.Id;
                patPanel.WindowState = FormWindowState.Maximized;
                patPanel.MdiParent = this.MdiParent;
                patPanel.Show();
                this.Close();
                this.Dispose();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            
        }
        //private void frmWelcome_Load(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Normal;
        //}
    }
}

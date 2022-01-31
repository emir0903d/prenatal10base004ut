using prenatal.winUI.PanelDoctor;
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
    public partial class FrontPanel : Form
    {
        frmLogin login = null;
        public int _currentUserId { get; set; }
        public FrontPanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
            this.WindowState = FormWindowState.Maximized;
        }
        

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Dispose();
            login = null;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrontPanel.ActiveForm.HasChildren)
            {
                foreach (Form x in FrontPanel.ActiveForm.MdiChildren)
                {
                    x.Close();
                    x.Dispose();
                }
            }

            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Visible = false;

            loginToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Visible = true;

            myProfileToolStripMenuItem.Enabled = false;
            myProfileToolStripMenuItem.Visible = false;

            //registerToolStripMenuItem.Enabled = true;
            //registerToolStripMenuItem.Visible = true;
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            login = new frmLogin();
            
            login.MdiParent = this;
            login.WindowState = FormWindowState.Normal;
            login.StartPosition = FormStartPosition.CenterScreen;

            login.Show();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile();
            profile._currentUserId = _currentUserId;
            //profile.MdiParent = this;
            profile.WindowState = FormWindowState.Normal;
            profile.StartPosition = FormStartPosition.CenterScreen;

            profile.ShowDialog();
        }
    }
}

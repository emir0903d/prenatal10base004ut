using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prenatal.winUI.PanelPatient
{
    public partial class PatientsPanel : Form
    {
        public int _currentUserId { get; set; } = -1;
        public PatientsPanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._currentUserId == -1) return;

            frmChrtTemperature frm = new frmChrtTemperature();
            frm._currentUserId = this._currentUserId;
            frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Normal;
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void pressureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._currentUserId == -1) return;

            frmChrtPressure frm = new frmChrtPressure();
            frm._currentUserId = this._currentUserId;
            frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Normal;
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void ratesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._currentUserId == -1) return;

            frmChrtRates frm = new frmChrtRates();
            frm._currentUserId = this._currentUserId;
            frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Normal;
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void heightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._currentUserId == -1) return;

            frmChrtHeightWeight frm = new frmChrtHeightWeight();
            frm._currentUserId = this._currentUserId;
            frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Normal;
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void PatientsPanel_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();

            this.menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            this.menuStrip1.Padding = Padding.Empty;
            this.menuStrip1.Margin = Padding.Empty;
            this.menuStrip1.Stretch = false;
        }
    }
}

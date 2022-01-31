using prenatal.model;
using prenatal.model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prenatal.winUI.PanelDoctor
{
    public partial class frmGlucose : Form
    {
        APIservice _glucose = new APIservice("GlucoseTest");
        public int _choosenPatientId { get; set; } = -1;
        public int _currentUserId { get; set; } = -1;
        public frmGlucose()
        {
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
        private async void LoadGrid()
        {
            if (_choosenPatientId < 0) return;

            GlucoseTestSearchRequest request = new GlucoseTestSearchRequest();
            request.MedicalRecordId = _choosenPatientId;
            dgData.AutoGenerateColumns = false;
            dgData.DataSource = await _glucose.Get<List<GlucoseTest>>(request);
        }
        private void Clear()
        {
            txtId.Text = "";
            dtpDate.Value = DateTime.Now;
            cmbType.Text = "";
            txtResults.Text = "";
            cmbUnits.Text = "";
        }
        private void frmGlucose_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();

            this.medicalRecordsToolStripMenuItem.BackColor = Color.LightSkyBlue;
            this.glucoseTestToolStripMenuItem.BackColor = Color.IndianRed;
            this.menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            this.menuStrip1.Padding = Padding.Empty;
            this.menuStrip1.Margin = Padding.Empty;
            this.menuStrip1.Stretch = false;
            LoadGrid();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (_choosenPatientId < 0) return;

            GlucoseTestUpsertRequest request = new GlucoseTestUpsertRequest();
            request.MedicalRecordsId = _choosenPatientId;
            request.Date = dtpDate.Value;
            request.TypeOfTest = (GlucoseTest.GlucoseTestType)cmbType.SelectedIndex;
            if(txtResults.Text.Length>0 && txtResults.Text.All(char.IsNumber))
            {
                int Res = Int32.Parse(txtResults.Text);
                request.Results = Res;
            }
            request.Units = cmbUnits.Text;

            if (ValidateData(request))
            {
                await _glucose.Insert<GlucoseTest>(request);
                LoadGrid();
                Clear();
            }
            
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_choosenPatientId <= 0) return;
            if (txtId.Text.Length <= 0) return;
            int Id = Int32.Parse(txtId.Text);

            GlucoseTestUpsertRequest request = new GlucoseTestUpsertRequest();
            request.Id = Id;
            request.MedicalRecordsId = _choosenPatientId;
            request.Date = dtpDate.Value;
            request.TypeOfTest = (GlucoseTest.GlucoseTestType)cmbType.SelectedIndex;
            if (txtResults.Text.Length > 0 && txtResults.Text.All(char.IsNumber))
            {
                int Res = Int32.Parse(txtResults.Text);
                request.Results = Res;
            }
            request.Units = cmbUnits.Text;

            if (ValidateData(request))
            {
                await _glucose.Update<GlucoseTest>(Id, request);
                LoadGrid();
                Clear();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_choosenPatientId <= 0) return;
            if (txtId.Text.Length <= 0) return;

            int Id = Int32.Parse(txtId.Text);
            
            await _glucose.Delete<GlucoseTest>(Id);
            LoadGrid();
            Clear();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e == null) return;

            txtId.Text = dgData.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpDate.Value = Convert.ToDateTime(dgData.Rows[e.RowIndex].Cells[1].Value);
            cmbType.Text = dgData.Rows[e.RowIndex].Cells[2].Value.ToString();
            
            cmbUnits.Text = dgData.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dgData.Rows[e.RowIndex].Cells[4].Value != null)
            {
                txtResults.Text = dgData.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            
        }

        private void medicalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._choosenPatientId == -1 || this._currentUserId == -1) return;

            DoctorsPanel frm = new DoctorsPanel();
            frm._currentUserId = this._currentUserId;
            frm._choosenPatientId = this._choosenPatientId;

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void ultrasoundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._choosenPatientId == -1 || this._currentUserId == -1) return;

            frmUltrasounds frm = new frmUltrasounds();
            frm._currentUserId = this._currentUserId;
            frm._choosenPatientId = this._choosenPatientId;

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();

        }

        private void referralsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._choosenPatientId == -1 || this._currentUserId == -1) return;

            frmReferrals frm = new frmReferrals();
            frm._currentUserId = this._currentUserId;
            frm._choosenPatientId = this._choosenPatientId;

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void vitalSignsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._choosenPatientId == -1 || this._currentUserId == -1) return;

            frmVitalSign frm = new frmVitalSign();
            frm._currentUserId = this._currentUserId;
            frm._choosenPatientId = this._choosenPatientId;

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void therapiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._choosenPatientId == -1 || this._currentUserId == -1) return;

            frmTherapies frm = new frmTherapies();
            frm._currentUserId = this._currentUserId;
            frm._choosenPatientId = this._choosenPatientId;

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void substancesUsedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._choosenPatientId == -1 || this._currentUserId == -1) return;

            frmSubstances frm = new frmSubstances();
            frm._currentUserId = this._currentUserId;
            frm._choosenPatientId = this._choosenPatientId;

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void previousPregnanciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._choosenPatientId == -1 || this._currentUserId == -1) return;

            frmPrevPregnancies frm = new frmPrevPregnancies();
            frm._currentUserId = this._currentUserId;
            frm._choosenPatientId = this._choosenPatientId;

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void prescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._choosenPatientId == -1 || this._currentUserId == -1) return;

            frmPrescriptions frm = new frmPrescriptions();
            frm._currentUserId = this._currentUserId;
            frm._choosenPatientId = this._choosenPatientId;

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void lostPregnanciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._choosenPatientId == -1 || this._currentUserId == -1) return;

            frmLostPregnancies frm = new frmLostPregnancies();
            frm._currentUserId = this._currentUserId;
            frm._choosenPatientId = this._choosenPatientId;

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void photosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._choosenPatientId == -1 || this._currentUserId == -1) return;

            frmPhotos frm = new frmPhotos();
            frm._currentUserId = this._currentUserId;
            frm._choosenPatientId = this._choosenPatientId;

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void partnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._choosenPatientId == -1 || this._currentUserId == -1) return;

            frmPartners frm = new frmPartners();
            frm._currentUserId = this._currentUserId;
            frm._choosenPatientId = this._choosenPatientId;

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._choosenPatientId == -1 || this._currentUserId == -1) return;

            frmHistory frm = new frmHistory();
            frm._currentUserId = this._currentUserId;
            frm._choosenPatientId = this._choosenPatientId;

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void glucoseTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._choosenPatientId == -1 || this._currentUserId == -1) return;

            frmFiles frm = new frmFiles();
            frm._currentUserId = this._currentUserId;
            frm._choosenPatientId = this._choosenPatientId;

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void frmGlucose_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.glucoseTestToolStripMenuItem.BackColor = Color.LightSkyBlue;
        }
    }
}

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
    public partial class frmHistory : Form
    {
        APIservice _history = new APIservice("MedicalHistory");
        public int _choosenPatientId { get; set; } = -1;
        public int _currentUserId { get; set; } = -1;
        public frmHistory()
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
            if (_choosenPatientId <= 0) return;
            
            MedicalHistorySearchRequest request = new MedicalHistorySearchRequest();
            request.MedicalRecordId = _choosenPatientId;
            
            dGrid.AutoGenerateColumns = false;
            dGrid.DataSource  = await _history.Get<List<MedicalHistory>>(request);

        }
        private void Clear()
        {
            txtId.Text = "";
            dtpDate.Value = DateTime.Now;
            txtDiag.Text = "";
            txtNote.Text = "";
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();

            this.historyToolStripMenuItem.BackColor = Color.IndianRed;
            this.medicalRecordsToolStripMenuItem.BackColor = Color.LightSkyBlue;
            this.menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            this.menuStrip1.Padding = Padding.Empty;
            this.menuStrip1.Margin = Padding.Empty;
            this.menuStrip1.Stretch = false;
            LoadGrid();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (_choosenPatientId < 0) return;
            
            MedicalHistoryUpsertRequest request = new MedicalHistoryUpsertRequest();
            request.MedicalRecordsId = _choosenPatientId;
            request.Date = dtpDate.Value;
            request.Diagnosis = txtDiag.Text;
            request.Note = txtNote.Text;

            if (ValidateData(request))
            {
                await _history.Insert<MedicalHistory>(request);
                LoadGrid();
                Clear();
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_choosenPatientId < 0) return;
            if (txtId == null || txtId.Text == "") return;
            int Id = Int32.Parse(txtId.Text);
            if (Id <= 0) return;

            MedicalHistoryUpsertRequest request = new MedicalHistoryUpsertRequest();
            request.Id = Id;
            request.MedicalRecordsId = _choosenPatientId;
            request.Date = dtpDate.Value;
            request.Diagnosis = txtDiag.Text;
            request.Note = txtNote.Text;

            if (ValidateData(request))
            {
                await _history.Update<MedicalHistory>(Id, request);
                LoadGrid();
                Clear();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_choosenPatientId < 0) return;
            if (txtId == null || txtId.Text == "") return;
            int Id = Int32.Parse(txtId.Text);
            if (Id > 0)
            {
                await _history.Delete<MedicalHistory>(Id);
                LoadGrid();
                Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpDate.Value =Convert.ToDateTime(dGrid.Rows[e.RowIndex].Cells[1].Value);
            txtDiag.Text = dGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNote.Text = dGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
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
            this.Refresh();
        }

        private void glucoseTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._choosenPatientId == -1 || this._currentUserId == -1) return;

            frmGlucose frm = new frmGlucose();
            frm._currentUserId = this._currentUserId;
            frm._choosenPatientId = this._choosenPatientId;

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
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

        private void frmHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.historyToolStripMenuItem.BackColor = Color.LightSkyBlue;
        }
    }
}

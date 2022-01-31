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
    public partial class frmLostPregnancies : Form
    {
        APIservice _lossPregnancy = new APIservice("PregnancyLoss");
        public int _choosenPatientId { get; set; } = -1;
        public int _currentUserId { get; set; } = -1;
        public frmLostPregnancies()
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
            PregnancyLossSearchRequest request = new PregnancyLossSearchRequest();
            request.MedicalRecordId = _choosenPatientId;
            dgLostPregnancies.AutoGenerateColumns = false;
            dgLostPregnancies.DataSource = await _lossPregnancy.Get<List<PregnancyLoss>>(request);
            
        }
        private void Clear()
        {
            txtId.Text = "";
            txtType.Text = "";
            dtDate.Value = DateTime.Now;
            txtNote.Text = "";
        }
        private void frmLostPregnancies_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();

            this.medicalRecordsToolStripMenuItem.BackColor = Color.LightSkyBlue;
            this.lostPregnanciesToolStripMenuItem.BackColor = Color.IndianRed;
            this.menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            this.menuStrip1.Padding = Padding.Empty;
            this.menuStrip1.Margin = Padding.Empty;
            this.menuStrip1.Stretch = false;
            LoadGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgLostPregnancies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            txtId.Text = dgLostPregnancies.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtType.Text = dgLostPregnancies.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtDate.Value = Convert.ToDateTime(dgLostPregnancies.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtNote.Text = dgLostPregnancies.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId == null || txtId.Text == "") return;

            PregnancyLossUpsertRequest request = new PregnancyLossUpsertRequest();
            request.MedicalRecordsId = _choosenPatientId;
            request.Date = dtDate.Value;
            request.Type = txtType.Text;
            request.Note = txtNote.Text;

            if (ValidateData(request) == true)
            {
                await _lossPregnancy.Insert<PregnancyLoss>(request);
                LoadGrid();
                Clear();
            }
            
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId == null || txtId.Text == "") return;

            PregnancyLossUpsertRequest request = new PregnancyLossUpsertRequest();
            request.MedicalRecordsId = _choosenPatientId;
            request.Date = dtDate.Value;
            request.Type = txtType.Text;
            request.Note = txtNote.Text;

            if (ValidateData(request) == true)
            {
                if (txtId == null || txtId.Text == "") return;

                int Id = Int32.Parse(txtId.Text);

                if (Id <= 0) return;

                await _lossPregnancy.Update<PregnancyLoss>(Id, request);
                LoadGrid();
                Clear();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId == null || txtId.Text == "") return;

            int Id = Int32.Parse(txtId.Text);
            
            if (Id <= 0) return;

            await _lossPregnancy.Delete<PregnancyLoss>(Id);
            Clear();
            LoadGrid();
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
            this.Refresh();
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

        private void frmLostPregnancies_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.lostPregnanciesToolStripMenuItem.BackColor = Color.LightSkyBlue;
        }
    }
}

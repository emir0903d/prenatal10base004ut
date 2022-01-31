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
    public partial class frmTherapies : Form
    {
        private readonly APIservice _therapies = new APIservice("Therapy");
        public int _choosenPatientId { get; set; }
        public int _currentUserId { get; set; }
        public frmTherapies()
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
            SearchTherapiesRequest request = new SearchTherapiesRequest();
            request.MedicalRecordId = _choosenPatientId;
            if (await _therapies.Get<List<Therapy>>(request) != null)
            {
                dgTherapies.AutoGenerateColumns = false;
                dgTherapies.DataSource = await _therapies.Get<List<Therapy>>(request);
            }
            
        }
        private void frmTherapies_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();

            this.medicalRecordsToolStripMenuItem.BackColor = Color.LightSkyBlue;
            this.therapiesToolStripMenuItem.BackColor = Color.IndianRed;
            this.menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            this.menuStrip1.Padding = Padding.Empty;
            this.menuStrip1.Margin = Padding.Empty;
            this.menuStrip1.Stretch = false;
            LoadGrid();
        }

        private void dgTherapies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            textBoxId.Text = dgTherapies.Rows[e.RowIndex].Cells[0].Value.ToString();
            dTPickerBeginning.Value = Convert.ToDateTime(dgTherapies.Rows[e.RowIndex].Cells[1].Value.ToString());
            dTPickerEnding.Value = Convert.ToDateTime(dgTherapies.Rows[e.RowIndex].Cells[2].Value.ToString());
            textBoxMedicaments.Text = dgTherapies.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxNote.Text = dgTherapies.Rows[e.RowIndex].Cells[4].Value.ToString();

        }
        private void Clear()
        {
            textBoxId.Text = "";
            dTPickerBeginning.Value = DateTime.Now;
            dTPickerEnding.Value = DateTime.Now;
            textBoxMedicaments.Text = "";
            textBoxNote.Text = "";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
            LoadGrid();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            
            if (textBoxId.Text != "")
            {
                int _thId = Int32.Parse(textBoxId.Text);
                await _therapies.Delete<Therapy>(_thId);
                LoadGrid();
                Clear();
            }

        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxId.TextLength == 0 || textBoxId.Text == null) return;

            TherapyUpsertRequest request = new TherapyUpsertRequest();
            request.BeginningDate = dTPickerBeginning.Value;
            request.EndingDate = dTPickerEnding.Value;
            request.MedicalRecordsId = _choosenPatientId;
            request.Medicaments = textBoxMedicaments.Text;
            request.Note = textBoxNote.Text;

            if (ValidateData(request))
            {
                int _thId = Int32.Parse(textBoxId.Text);
                await _therapies.Update<Therapy>(_thId, request);
                Clear();
                LoadGrid();
            }
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            TherapyUpsertRequest request = new TherapyUpsertRequest();
            request.BeginningDate = dTPickerBeginning.Value;
            request.EndingDate = dTPickerEnding.Value;
            request.MedicalRecordsId = _choosenPatientId;
            request.Medicaments = textBoxMedicaments.Text;
            request.Note = textBoxNote.Text;
            if (ValidateData(request))
            {                
                await _therapies.Insert<Therapy>(request);
                Clear();
                LoadGrid();
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
            this.Refresh();
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

        private void frmTherapies_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.therapiesToolStripMenuItem.BackColor = Color.LightSkyBlue;
        }
    }
}

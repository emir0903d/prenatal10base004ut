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
    public partial class frmPrevPregnancies : Form
    {
        APIservice _prevPregnancy = new APIservice("PreviousPregnancy");
        public int _choosenPatientId { get; set; } = -1;
        public int _currentUserId { get; set; } = -1;
        public frmPrevPregnancies()
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
            PreviousPregnancySearchRequest request = new PreviousPregnancySearchRequest();
            request.MedicalRecordId = _choosenPatientId;
            dgPrevPreg.DataSource =await _prevPregnancy.Get<List<PreviousPregnancy>>(request);
            dgPrevPreg.AutoGenerateColumns = false;
        }
        private void Clear()
        {
            textBoxId.Text = "";
            dTpPregDate.Value = DateTime.Now;
            textBoxGestationWeeks.Text = "";
            comboBoxDeliveryType.SelectedItem = null;
            textBoxComplications.Text = "";
            textBoxOutcome.Text = "";
        }

        private void frmPrevPregnancies_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();

            this.medicalRecordsToolStripMenuItem.BackColor = Color.LightSkyBlue;
            this.previousPregnanciesToolStripMenuItem.BackColor = Color.IndianRed;
            this.menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            this.menuStrip1.Padding = Padding.Empty;
            this.menuStrip1.Margin = Padding.Empty;
            this.menuStrip1.Stretch = false;
            LoadGrid();
            Clear();
        }

        private void dgPrevPreg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            textBoxId.Text = dgPrevPreg.Rows[e.RowIndex].Cells[0].Value.ToString();
            dTpPregDate.Value =Convert.ToDateTime(dgPrevPreg.Rows[e.RowIndex].Cells[1].Value.ToString());
            textBoxGestationWeeks.Text = dgPrevPreg.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxDeliveryType.SelectedItem = dgPrevPreg.Rows[e.RowIndex].Cells[3].Value;
            textBoxComplications.Text = dgPrevPreg.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxOutcome.Text = dgPrevPreg.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            PreviousPregnancyUpsertRequest request = new PreviousPregnancyUpsertRequest();
            request.MedicalRecordsId = _choosenPatientId;
            request.PregnancyDate = dTpPregDate.Value;
            request.Outcome = textBoxOutcome.Text;
            if(textBoxGestationWeeks.Text != "" && textBoxGestationWeeks.TextLength!=0 && textBoxGestationWeeks.Text != null)
            {
                request.GestationWeeks = Int32.Parse(textBoxGestationWeeks.Text);
            }
            if (comboBoxDeliveryType.Text != "")
            {
                request.DeliveryType = comboBoxDeliveryType.SelectedItem.ToString();
            }
            
            request.Complications = textBoxComplications.Text;

            if (ValidateData(request))
            {
                await _prevPregnancy.Insert<PreviousPregnancy>(request);
                LoadGrid();
                Clear();
            }

        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "" || textBoxId.TextLength == 0 || textBoxId.Text == null) return;

            int pp_Id = Int32.Parse(textBoxId.Text);
            PreviousPregnancyUpsertRequest request = new PreviousPregnancyUpsertRequest();
            request.MedicalRecordsId = _choosenPatientId;
            request.PregnancyDate = dTpPregDate.Value;
            request.Outcome = textBoxOutcome.Text;
            if (textBoxGestationWeeks.Text != "" && textBoxGestationWeeks.TextLength != 0 && textBoxGestationWeeks.Text != null)
            {
                request.GestationWeeks = Int32.Parse(textBoxGestationWeeks.Text);
            }
            if (comboBoxDeliveryType.Text != "")
            {
                request.DeliveryType = comboBoxDeliveryType.SelectedItem.ToString();
            }
                
            request.Complications = textBoxComplications.Text;

            if (ValidateData(request))
            {
                await _prevPregnancy.Update<PreviousPregnancy>(pp_Id, request);
                LoadGrid();
                Clear();
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "" || textBoxId.TextLength == 0 || textBoxId.Text == null) return;

            int pp_Id = Int32.Parse(textBoxId.Text);
            await _prevPregnancy.Delete<PreviousPregnancy>(pp_Id);
            LoadGrid();
            Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
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
            this.Refresh();
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

        private void frmPrevPregnancies_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.previousPregnanciesToolStripMenuItem.BackColor = Color.LightSkyBlue;
        }
    }
}

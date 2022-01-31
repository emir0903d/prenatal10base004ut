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
    public partial class frmSubstances : Form
    {
        private APIservice _substances = new APIservice("SubstanceUse");
        public int _choosenPatientId { get; set; } = -1;
        public int _currentUserId { get; set; } = -1;
        public frmSubstances()
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
            dgSubstances.AutoGenerateColumns = false;
            SearchSubstancesRequest request = new SearchSubstancesRequest();
            request.MedicalRecordId = _choosenPatientId;
            dgSubstances.DataSource = await _substances.Get<List<SubstanceUse>>(request);
            
        }
        private void Clear()
        {
            textBoxId.Text = "";
            textBoxDesc.Text = "";
            checkBoxPrior.Checked = false;
            checkBoxStillUsing.Checked = false;
            textBoxYears.Text = "";
            textBoxNote.Text = "";
        }
        private void dgSubstances_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            textBoxId.Text = dgSubstances.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxDesc.Text = dgSubstances.Rows[e.RowIndex].Cells[1].Value.ToString();
            checkBoxPrior.Checked =Convert.ToBoolean(dgSubstances.Rows[e.RowIndex].Cells[2].Value);
            checkBoxStillUsing.Checked = Convert.ToBoolean(dgSubstances.Rows[e.RowIndex].Cells[3].Value);
            textBoxYears.Text = dgSubstances.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxNote.Text = dgSubstances.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void frmSubstances_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();

            this.medicalRecordsToolStripMenuItem.BackColor = Color.LightSkyBlue;
            this.substancesUsedToolStripMenuItem.BackColor = Color.IndianRed;
            this.menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            this.menuStrip1.Padding = Padding.Empty;
            this.menuStrip1.Margin = Padding.Empty;
            this.menuStrip1.Stretch = false;
            LoadGrid();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            SubstanceUseUpsertRequest request = new SubstanceUseUpsertRequest();
            request.MedicalRecordsId = _choosenPatientId;
            request.Description = textBoxDesc.Text;
            request.Note = textBoxNote.Text;
            
            int num_years = -1;
            Int32.TryParse(textBoxYears.Text, out num_years);
            if (num_years != -1)
            {
                request.NumberOfYears = num_years;
                //request.NumberOfYears = Int32.Parse(textBoxYears.Text);
            }          
            
            request.PriorToPregnancy = checkBoxPrior.Checked;
            request.StillUsing = checkBoxStillUsing.Checked;

            if (ValidateData(request))
            {
                await _substances.Insert<SubstanceUse>(request);
                Clear();
                LoadGrid();
            }

        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxId.TextLength == 0 || textBoxId.Text==null) return;

            SubstanceUseUpsertRequest request = new SubstanceUseUpsertRequest();
            request.MedicalRecordsId = _choosenPatientId;
            request.Description = textBoxDesc.Text;
            request.Note = textBoxNote.Text;
            int num_years = -1;
            Int32.TryParse(textBoxYears.Text, out num_years);
            if (num_years != -1)
            {
                request.NumberOfYears = num_years;
                //request.NumberOfYears = Int32.Parse(textBoxYears.Text);
            }
            request.PriorToPregnancy = checkBoxPrior.Checked;
            request.StillUsing = checkBoxStillUsing.Checked;

            if (ValidateData(request))
            {
                int _subId = Int32.Parse(textBoxId.Text);
                await _substances.Update<SubstanceUse>(_subId, request);
                Clear();
                LoadGrid();
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                int _subId = Int32.Parse(textBoxId.Text);
                await _substances.Delete<SubstanceUse>(_subId);
                LoadGrid();
                Clear();
            }
            
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

        private void frmSubstances_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.substancesUsedToolStripMenuItem.BackColor = Color.LightSkyBlue;
        }
    }
}

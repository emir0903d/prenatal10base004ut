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
    public partial class frmVitalSign : Form
    {
        APIservice _vs = new APIservice("VitalSign");
        public int _choosenPatientId { get; set; }
        public int _currentUserId { get; set; }
        public frmVitalSign()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private async void LoadGrid()
        {
            VitalSignSearchRequest tsearch = new VitalSignSearchRequest();
            tsearch.MedicalRecordId = _choosenPatientId;
            if (await _vs.Get<List<VitalSign>>(tsearch) != null)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = await _vs.Get<List<VitalSign>>(tsearch);
            }

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

        private void frmVitalSign_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();

            this.medicalRecordsToolStripMenuItem.BackColor = Color.LightSkyBlue;
            this.vitalSignsToolStripMenuItem.BackColor = Color.IndianRed;
            this.menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            this.menuStrip1.Padding = Padding.Empty;
            this.menuStrip1.Margin = Padding.Empty;
            this.menuStrip1.Stretch = false;
            LoadGrid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            textBoxId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

            textBoxTemp.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxSystolic.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxDiastolic.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxHeartBeats.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxRespiratory.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxHeight.Text= dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBoxWeight.Text= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBoxNote.Text= dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void vitalSignsToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void Clear()
        {
            dateTimePicker1.Value = DateTime.Now;
            textBoxDiastolic.Text = "";
            textBoxHeartBeats.Text = "";
            textBoxHeight.Text = "";
            textBoxId.Text = "";
            textBoxNote.Text = "";
            textBoxRespiratory.Text = "";
            textBoxSystolic.Text = "";
            textBoxTemp.Text = "";
            textBoxWeight.Text = "";
            
        }
        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            VitalSignUpsertRequest x =new VitalSignUpsertRequest();
            x.Date = dateTimePicker1.Value;
            if (textBoxDiastolic.Text != "" && textBoxDiastolic.TextLength!=0)
            {
                x.DiastolicPressure = Int32.Parse(textBoxDiastolic.Text);
            }
            if (textBoxHeartBeats.Text != "")
            {
                x.HeartBeats = Int32.Parse(textBoxHeartBeats.Text);
            }
            if (textBoxHeight.Text != "")
            {
                x.Height =float.Parse(textBoxHeight.Text);
            }
            x.MedicalRecordsId = _choosenPatientId;
            x.Note = textBoxNote.Text;
            if (textBoxRespiratory.Text != "")
            {
                x.RespiratoryRate = Int32.Parse(textBoxRespiratory.Text);
            }
            if (textBoxSystolic.Text != "")
            {
                x.SystolicPressure = Int32.Parse(textBoxSystolic.Text);
            }
            if (textBoxTemp.Text != "")
            {
                x.Temperature = float.Parse(textBoxTemp.Text);
            }
            if (textBoxWeight.Text != "")
            {
                x.Weight = float.Parse(textBoxWeight.Text);
            }


            if (ValidateData(x))
            {
                await _vs.Insert<VitalSign>(x);
                LoadGrid();
                Clear();
                
            }
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "" || textBoxId.TextLength == 0 || textBoxId.Text == null) return;

            VitalSignUpsertRequest x = new VitalSignUpsertRequest();
            x.Date = dateTimePicker1.Value;
            if (textBoxDiastolic.Text != "")
            {
                x.DiastolicPressure = Int32.Parse(textBoxDiastolic.Text);
            }
            if (textBoxHeartBeats.Text != "")
            {
                x.HeartBeats = Int32.Parse(textBoxHeartBeats.Text);
            }
            if (textBoxHeight.Text != "")
            {
                x.Height = float.Parse(textBoxHeight.Text);
            }
            x.MedicalRecordsId = _choosenPatientId;
            x.Note = textBoxNote.Text;
            if (textBoxRespiratory.Text != "")
            {
                x.RespiratoryRate = Int32.Parse(textBoxRespiratory.Text);
            }
            if (textBoxSystolic.Text != "")
            {
                x.SystolicPressure = Int32.Parse(textBoxSystolic.Text);
            }
            if (textBoxTemp.Text != "")
            {
                x.Temperature = float.Parse(textBoxTemp.Text);
            }
            if (textBoxWeight.Text != "")
            {
                x.Weight = float.Parse(textBoxWeight.Text);
            }
            int vsId = -1;
            if (textBoxId.Text != "")
            {
                vsId = Int32.Parse(textBoxId.Text);
            }

            if (ValidateData(x))
            {
                await _vs.Update<VitalSign>(vsId,x);
                LoadGrid();
                Clear();

            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            int vsId = -1;
            if (textBoxId.Text != "")
            {
                vsId = Int32.Parse(textBoxId.Text);
                await _vs.Delete<VitalSign>(vsId);
                LoadGrid();
                Clear();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
            LoadGrid();
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

        private void frmVitalSign_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.vitalSignsToolStripMenuItem.BackColor = Color.LightSkyBlue;
        }
    }
}

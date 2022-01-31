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
    public partial class DoctorsPanel : Form
    {
        APIservice _users = new APIservice("User");
        APIservice _mr = new APIservice("MedicalRecord");


        public int _choosenPatientId { get; set; } = -1;
        public int _currentUserId { get; set; } = -1;

        public DoctorsPanel()
        {
            APIservice.Username = AuthService.Username;
            APIservice.Password = AuthService.Password;
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private async void LoadPatients()
        {
            SearchUsersRequest tsearch = new SearchUsersRequest();
            tsearch.DoctorsId = _currentUserId;
            List<User> Patients = await _users.Get<List<User>>(tsearch);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Key", typeof(int));
            dataTable.Columns.Add("Value", typeof(string));

            var empty = dataTable.NewRow();
            empty["Key"] = -1;
            empty["Value"] = " ";
            dataTable.Rows.Add(empty);

            foreach (User x in Patients)
            {
                var row = dataTable.NewRow();
                row["Key"] = x.Id;
                row["Value"] = x.Name + " " + x.Surname;
                dataTable.Rows.Add(row);
            }
            


            comboBoxPatients.DataSource = dataTable;
            comboBoxPatients.DisplayMember = "Value";
            comboBoxPatients.ValueMember = "Key";
            comboBoxPatients.DataBindings.Clear();
            comboBoxPatients.Text = "";

            if (_choosenPatientId != -1)
            {
                string sId =_choosenPatientId.ToString();
                string snMe = "";
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row.ItemArray[0].ToString() == sId)
                    {
                        snMe = row.ItemArray[1].ToString();
                    }
                }

                var toBeSet = new KeyValuePair<string, string>(sId, snMe);
                comboBoxPatients.Text = toBeSet.Value;
                PopulatePersonalInfo(_choosenPatientId);
                PopulateMRInfo(_choosenPatientId);
            }
        }
        
        private async void PopulateMRInfo(int Id)
        {
            MedicalRecord x = await _mr.GetById<MedicalRecord>(Id);
            if (Id == -1 || x == null)
            {
                textBoxMRNumber.Text = "";
                textBoxPINumber.Text = "";
                comboBoxMartial.SelectedItem = null;
                textBoxMaidenName.Text = "";
                dateTimePickerBirthDate.Value = DateTime.Today;
                comboBoxBloodType.SelectedItem = null;
                comboBoxRH.SelectedItem = null;
                checkBoxMR.Checked = false;
            }
            if (Id != -1 && x!=null)
            {
                textBoxMRNumber.Text = x.MedicalRecordNumber;
                textBoxPINumber.Text = x.PersonalIdentificationNumber;

                comboBoxMartial.SelectedItem = x.MartialStatus;

                textBoxMaidenName.Text = x.MaidenName;

                dateTimePickerBirthDate.Value = x.BirthDate;

                comboBoxBloodType.SelectedItem = x.BloodType;
                comboBoxRH.SelectedItem = x.RHFactor;
                checkBoxMR.Checked = true;
            }
        }
        private async void PopulatePersonalInfo(int Id)
        {
            if (Id == -1)
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxGender.Text = "";
                textBoxEmail.Text = "";
                textBoxPhone.Text = "";
            }
            if (Id != -1)
            {
                User x = await _users.GetById<User>(Id);
                textBoxName.Text = x.Name;
                textBoxSurname.Text = x.Surname;
                textBoxGender.Text = x.Gender;
                textBoxEmail.Text = x.Email;
                textBoxPhone.Text = x.PhoneNumber;
                
                if (x.HasMR==true)
                {
                    checkBoxMR.Checked = true;
                    buttonCreateMR.Enabled = false;
                    buttonUpdate.Enabled = true;
                    buttonDelete.Enabled = true;
                   

                }
                else
                {
                    checkBoxMR.Checked = false;
                    buttonCreateMR.Enabled=true;
                    buttonUpdate.Enabled=false;
                    buttonDelete.Enabled = false;
                    
                }
                             
            }                                

        }
        private void DoctorsPanel_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();

            this.menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            this.menuStrip1.Padding = Padding.Empty;
            this.menuStrip1.Margin = Padding.Empty;
            this.menuStrip1.Stretch = false;

            this.medicalRecordsToolStripMenuItem.BackColor = Color.IndianRed;
            LoadPatients();
          
        }

        private void comboBoxPatients_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRowView key = comboBoxPatients.SelectedItem as DataRowView;
            _choosenPatientId = Int32.Parse(key.Row.ItemArray[0].ToString());
            PopulatePersonalInfo(_choosenPatientId);
            PopulateMRInfo(_choosenPatientId);
          
        }

        private async void buttonCreateMR_Click(object sender, EventArgs e)
        {
            if (_choosenPatientId == -1) return;

            MedicalRecordUpsertRequest x = new MedicalRecordUpsertRequest();
            x.Id = _choosenPatientId;
            x.MedicalRecordNumber = "MRN000" + x.Id.ToString();
            x.PersonalIdentificationNumber = textBoxPINumber.Text;
            if (comboBoxMartial.SelectedItem != null)
            {
                x.MartialStatus = comboBoxMartial.SelectedItem.ToString();
            }
            
            x.MaidenName = textBoxMaidenName.Text;
            x.BirthDate = dateTimePickerBirthDate.Value;
            if(comboBoxBloodType.SelectedItem!=null)
            {
                x.BloodType = comboBoxBloodType.SelectedItem.ToString();
            }
            if (comboBoxRH.SelectedItem != null)
            {
                x.RHFactor = comboBoxRH.SelectedItem.ToString();
            }

            if (ValidateData(x))
            {
                var result = await _mr.Insert<MedicalRecord>(x);
                if (result != null)
                {
                    User y = await _users.GetById<User>(_choosenPatientId);
                    y.HasMR = true;
                    await _users.Update<User>(_choosenPatientId, y);
                    checkBoxMR.Checked = true;
                    
                    PopulateMRInfo(_choosenPatientId);
                    buttonCreateMR.Enabled = false;
                    buttonUpdate.Enabled = true;
                    buttonDelete.Enabled = true;

                }
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

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (_choosenPatientId == -1) return;

            MedicalRecordUpsertRequest x = new MedicalRecordUpsertRequest();
            x.Id = _choosenPatientId;
            x.MedicalRecordNumber = textBoxMRNumber.Text;
            x.BirthDate = dateTimePickerBirthDate.Value;
            x.BloodType = comboBoxBloodType.Text;
            x.MaidenName = textBoxMaidenName.Text;
            x.MartialStatus = comboBoxMartial.SelectedItem.ToString();
            x.PersonalIdentificationNumber = textBoxPINumber.Text;
            x.RHFactor = comboBoxRH.SelectedItem.ToString();
            if (ValidateData(x))
            {
                await _mr.Update<MedicalRecordUpsertRequest>(_choosenPatientId, x);
                PopulateMRInfo(_choosenPatientId);
            }
            
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_choosenPatientId == -1) return;

            var result = await _mr.Delete<MedicalRecord>(_choosenPatientId);
            if (result != null)
            {
                User y = await _users.GetById<User>(_choosenPatientId);
                y.HasMR = false;
                if (ValidateData(y))
                {
                    await _users.Update<User>(_choosenPatientId, y);
                    checkBoxMR.Checked = false;
                    buttonCreateMR.Enabled = true;
                    buttonUpdate.Enabled = false;
                    buttonDelete.Enabled = false;
                    PopulateMRInfo(_choosenPatientId);
                }
            }
            

        }
        

        private void medicalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
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
    }
}

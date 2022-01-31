using Flurl;
using Flurl.Util;
using prenatal.model;
using prenatal.model.Enumerations;
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

namespace prenatal.winUI.PanelAdmin
{
    public partial class AdminPanel : Form
    {

        private readonly APIservice _users = new APIservice("User");
        private readonly AuthService _auth = new AuthService();
        public int _currentUserId {get;set;} = -1;
        //private readonly APIservice _auth = new APIservice("Authenticate");
        public AdminPanel()
        {

            APIservice.Username = AuthService.Username;
            APIservice.Password = AuthService.Password;
            InitializeComponent();

        }
        private async Task<T> LoadData<T>(object tsearch = null)
        {
            return await _users.Get<T>(tsearch);
        }
        private async void frmCRUD_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();

            dataGridViewUsers.AutoGenerateColumns = false;
            dataGridViewUsers.DataSource = await LoadData<List<User>>();
            LoadTypeList();
            LoadStatusList();
            LoadDoctorsList();
            ValidateColumnUsername();

        }
        private void LoadTypeList()
        {
            comboBoxAccType.DataSource = Enum.GetValues(typeof(UserType.Type));
            comboBoxAccType.DataBindings.Clear();
            comboBoxAccType.Text = "";

        }
        private void LoadStatusList()
        {
            comboBoxStatus.DataSource = Enum.GetValues(typeof(UserStatus.Status));
            comboBoxStatus.DataBindings.Clear();
            comboBoxStatus.Text = "";
        }
        private void LoadDoctorsList()
        {

            List<string> doctorsName =new List<string>();
            List<int> doctorsId = new List<int>();

            int i = 0;
            foreach (DataGridViewRow row in dataGridViewUsers.Rows)
            {
                
                if (row.Cells[8].Value.ToString() == UserType.Type.Doctor.ToString())
                {

                    doctorsName.Add(row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString());
                    doctorsId.Add((int)row.Cells[0].Value);
                    i++;

                }
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Value", typeof(string));
            for (int z = 0; z < i; z++)
            {
                var row = dt.NewRow();
                row["Key"] = doctorsId[z].ToString();
                row["Value"] = doctorsName[z];
                dt.Rows.Add(row);
            }
            comboBoxDoctors.DataSource = dt;
            comboBoxDoctors.DisplayMember = "Value";
            comboBoxDoctors.ValueMember = "Key";

            comboBoxDoctors.DataBindings.Clear();
            comboBoxDoctors.Text = "";


        }
        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxSurname.Text= dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxGender.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
           
            textBoxEmail.Text= dataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxPhone.Text= dataGridViewUsers.Rows[e.RowIndex].Cells[5].Value.ToString();


            textBoxUsername.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[6].Value.ToString();
            
            LoadStatusList();
            comboBoxStatus.SelectedItem = dataGridViewUsers.Rows[e.RowIndex].Cells[7].Value;

            LoadTypeList();
            comboBoxAccType.SelectedItem = dataGridViewUsers.Rows[e.RowIndex].Cells[8].Value;

            LoadDoctorsList();
            if (dataGridViewUsers.Rows[e.RowIndex].Cells[9].Value != null)
            {
                string sId = dataGridViewUsers.Rows[e.RowIndex].Cells[9].Value.ToString();
                string snMe = "";
                foreach (DataGridViewRow data in dataGridViewUsers.Rows)
                {
                    if (data.Cells[0].Value.ToString() == sId)
                    {
                        snMe = data.Cells[1].Value.ToString() + " " + data.Cells[2].Value.ToString();
                    }
                }

                var toBeSet = new KeyValuePair<string, string>(sId, snMe);
                comboBoxDoctors.Text = toBeSet.Value;
            }           

            textBoxLoginCount.Text= dataGridViewUsers.Rows[e.RowIndex].Cells[10].Value.ToString();
            
            textBoxRegistration.Text= dataGridViewUsers.Rows[e.RowIndex].Cells[11].Value.ToString();
            textBoxLastLogin.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[12].Value.ToString();

        }
        private void ClearBoxes()
        {
            foreach(Control c in this.panel1.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
                if(c is ComboBox)
                {
                    c.DataBindings.Clear();
                    c.Text = "";

                }
            }
        }
        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "" || textBoxId.TextLength == 0 || textBoxId.Text == null) return;

            int Id = Int32.Parse(textBoxId.Text);
            int? DocId = null;
            if (comboBoxDoctors.Text != "")
            {
                DataRowView key = comboBoxDoctors.SelectedItem as DataRowView;
                DocId = Int32.Parse(key.Row.ItemArray[0].ToString());
            }

            UserUpsertRequest x = new UserUpsertRequest() {

                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                Gender = textBoxGender.Text,
                Username = textBoxUsername.Text,
                Email = textBoxEmail.Text,
                PhoneNumber = textBoxPhone.Text,
                Status = (UserStatus.Status)comboBoxStatus.SelectedIndex,
                Type = (UserType.Type)comboBoxAccType.SelectedIndex                      
            };
            
            if (x.Type == UserType.Type.Patient)
            {
                x.DoctorId = DocId;
            }
            else
            {
                x.DoctorId = null;
            }
            


            if(ValidateData(x)==true)
            {
                await _users.Update<UserUpsertRequest>(Id, x);
                ClearBoxes();
                dataGridViewUsers.DataSource = await LoadData<List<User>>();
            }
       
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            int? DocId = null;
            if (comboBoxDoctors.Text != "")
            {
                DataRowView key = comboBoxDoctors.SelectedItem as DataRowView;
                DocId = Int32.Parse(key.Row.ItemArray[0].ToString());
            }
            UserUpsertRequest x = new UserUpsertRequest()
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                Gender = textBoxGender.Text,
                Email = textBoxEmail.Text,
                PhoneNumber = textBoxPhone.Text,
                
                Registration=DateTime.Now,
                LoginCount=0
                
                
            };
            if(textBoxSurname.Text!="" && textBoxName.Text != "")
            {
                x.Username = textBoxSurname.Text.ToLower() + textBoxName.Text.ToLower().Substring(0, 1);
            }
            if (comboBoxAccType.Text != "")
            {
                x.Type = (UserType.Type)comboBoxAccType.SelectedIndex;
            }
            if (comboBoxStatus.Text != "")
            {
                x.Status = (UserStatus.Status)comboBoxStatus.SelectedIndex;
            }
            if (x.Type == UserType.Type.Patient)
            {
                x.DoctorId = DocId;
            }
            else
            {
                x.DoctorId = null;
            }
            if (ValidateData(x)==true)
            {
                await _users.Insert<UserUpsertRequest>(x);
                ClearBoxes();
                dataGridViewUsers.DataSource = await LoadData<List<User>>();
                ValidateColumnUsername();
            }
            
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "" || textBoxId.TextLength == 0 || textBoxId.Text == null) return;

            int Id = Int32.Parse(textBoxId.Text);
            await _users.Delete<User>(Id);
            ClearBoxes();
            dataGridViewUsers.DataSource = await LoadData<List<User>>();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearBoxes();
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
        private async void buttonApply_Click(object sender, EventArgs e)
        {
            SearchUsersRequest tsearch = null;
            int s = 0;
            foreach (CheckBox chkbx in this.groupBoxSFilter.Controls)
            {
                if (chkbx is CheckBox)
                {
                    if (chkbx.Checked)
                    {
                        s++;
                    }
                }
            }
            int t = 0;
            foreach (CheckBox chkbx in this.groupBoxTFilter.Controls)
            {
                if (chkbx is CheckBox)
                {
                    if (chkbx.Checked)
                    {
                        t++;
                    }
                }
            }

            if (s > 0 || t > 0 || !string.IsNullOrWhiteSpace(textBoxNameSurname.Text))
            {
                tsearch = new SearchUsersRequest();
            }

            if (!string.IsNullOrWhiteSpace(textBoxNameSurname.Text))
            {
                tsearch.NameSurname = textBoxNameSurname.Text;
            }


            if (s > 0)
            {
                tsearch.Status = new UserStatus.Status[s];
            }
            int ss = 0;
            if (checkBoxApproved.Checked)
            {
                tsearch.Status[ss] = UserStatus.Status.Approved;
                ss++;
            }
            if (checkBoxRejected.Checked)
            {
                tsearch.Status[ss] = UserStatus.Status.Rejected;
                ss++;
            }
            //

            if (t > 0)
            {
                tsearch.Type = new UserType.Type[t];
            }
            int tt = 0;
            if (checkBoxAdmin.Checked)
            {
                tsearch.Type[tt] = UserType.Type.Admin;
                tt++;
            }
            if (checkBoxDoctor.Checked)
            {
                tsearch.Type[tt] = UserType.Type.Doctor;
                tt++;
            }
            if (checkBoxNurse.Checked)
            {
                tsearch.Type[tt] = UserType.Type.Nurse;
                tt++;
            }
            if (checkBoxLabAssis.Checked)
            {
                tsearch.Type[tt] = UserType.Type.LabAssistant;
                tt++;
            }
            if (checkBoxPatient.Checked)
            {
                tsearch.Type[tt] = UserType.Type.Patient;
                tt++;
            }
            dataGridViewUsers.DataSource = await LoadData<List<User>>(tsearch);

        }

        private void buttonSetPassword_Click(object sender, EventArgs e)
        {
                       
            int Id = 0;
            Int32.TryParse(textBoxId.Text,out Id);
            

            if (Id != 0 )
            {
                
                _auth.OverridePassword(Id, textBoxPassword.Text);
                MessageBox.Show("Success!");
                textBoxPassword.Text = "";
                
            }
            else
            {
                MessageBox.Show("User not selected or Password empty!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void buttonUsername_Click(object sender, EventArgs e)
        {
            if(textBoxId.Text!=null || textBoxId.Text != "")
            {
                int Id = Int32.Parse(textBoxId.Text);

                await _auth.GenerateUsername(Id);
                ClearBoxes();
                dataGridViewUsers.DataSource = await LoadData<List<User>>();
                ValidateColumnUsername();
            }
            else
            {
                MessageBox.Show("User not selected!");
            }

        }

        private void ValidateColumnUsername()
        {
            int _u = 6;
            for(int r=1; r<dataGridViewUsers.Rows.Count; r++)
            {
                string value = dataGridViewUsers.Rows[r].Cells[_u].Value.ToString();
                for(int i=r+1; i < dataGridViewUsers.Rows.Count; i++)
                {
                    string value2 = dataGridViewUsers.Rows[i].Cells[_u].Value.ToString();
                    if (r != i)
                    {
                        if (value == value2)
                        {
                            HighlightCell(r, _u);
                            HighlightCell(i, _u);
                        }
                    }
                }


            }
        }

        private void HighlightCell(int r,int c)
        {
            //DataGridViewCellStyle m_hilightStyle = dataGridViewUsers.DefaultCellStyle.Clone();
            //m_hilightStyle.ForeColor = Color.Red;
            //m_hilightStyle.BackColor = Color.Yellow;
            //dataGridViewUsers.Columns[c].DefaultCellStyle = m_hilightStyle;

            dataGridViewUsers.Rows[r].Cells[c].Style.ForeColor = Color.Red;
            dataGridViewUsers.Rows[r].Cells[c].Style.BackColor = Color.Yellow;
        }
    }
}

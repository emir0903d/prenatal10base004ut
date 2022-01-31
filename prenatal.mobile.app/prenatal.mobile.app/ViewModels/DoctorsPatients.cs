using prenatal.model;
using prenatal.model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace prenatal.mobile.app.ViewModels
{
    public class DoctorsPatients
    {
        public int _currentUserId { get; set; }
        public string _username { get; set; }
        public string _password { get; set; }

        private readonly APIservice _users = new APIservice("User");
        public ObservableCollection<User> Patients { get; set; } = new ObservableCollection<User>();
        public ICommand InitCommand { get; set; }

        public DoctorsPatients()
        {
            InitCommand = new Command(async () => await Init());
        }
        

        public async Task Init()
        {
            APIservice.Username = _username;
            APIservice.Password = _password;
            SearchUsersRequest request = null;
            if (_currentUserId != -1)
            {
                request = new SearchUsersRequest();
                request.DoctorsId = _currentUserId;
            }
                        
            List<User> users = await _users.Get<List<User>>(request);
            Patients.Clear();
            foreach (User u in users)
            {
                Patients.Add(u);
            }
        }
    }
}

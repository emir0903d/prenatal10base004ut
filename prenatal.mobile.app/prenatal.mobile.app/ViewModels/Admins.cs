using prenatal.model;
using prenatal.model.Enumerations;
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
    public class Admins:BaseViewModel
    {
        private readonly APIservice _users = new APIservice("User");
        public string _username;
        public string _password;
        public Admins()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
        public ObservableCollection<UserStatus.Status> userStatuses { get; set; } = new ObservableCollection<UserStatus.Status>();
        
        private UserStatus.Status _selectedStatus;
        public UserStatus.Status SelectedStatus
        {
            get { return _selectedStatus; }
            set
            {
                SetProperty(ref _selectedStatus, value);
                //OnPropertyChanged();
                if (value != default)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            APIservice.Username = _username;
            APIservice.Password = _password;
            
            if (userStatuses.Count == 0)
            {
                userStatuses.Add(UserStatus.Status.None);
                
                userStatuses.Add(UserStatus.Status.Approved);
                userStatuses.Add(UserStatus.Status.Rejected);
            }

            SearchUsersRequest request = null;
            if (SelectedStatus != UserStatus.Status.None)
            {
                request = new SearchUsersRequest();
                request.Status = new UserStatus.Status[1];
                request.Status[0] = SelectedStatus;
            }
            if (SelectedStatus == UserStatus.Status.None)
            {
                request = null;
            }
            
            
            List<User> users = await _users.Get<List<User>>(request);
            Users.Clear();
            foreach(User u in users)
            {
                Users.Add(u);               
            }
        }

    }
}

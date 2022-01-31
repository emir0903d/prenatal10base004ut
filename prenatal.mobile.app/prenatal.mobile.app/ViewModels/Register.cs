using prenatal.model;
using prenatal.model.Enumerations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace prenatal.mobile.app.ViewModels
{
    
    public class Register:BaseViewModel
    {
        private readonly RegService _regService = new RegService();
        public ObservableCollection<User> Doctors { get; set; } = new ObservableCollection<User>();
        public ICommand Populate { get; set; }
        private bool _isPatient;
        public bool IsPatient
        {
            get { return _isPatient; }
            set
            {
                SetProperty(ref _isPatient, value);
                OnPropertyChanged();
            }
        }
        public Register()
        {
            Populate = new Command(async () => await PopulateData());
            userTypes.Add(UserType.Type.Admin);
            userTypes.Add(UserType.Type.Doctor);
            userTypes.Add(UserType.Type.Patient);
        }
        public async Task PopulateData()
        {
            List<User> _doctors = await _regService.GetDoctors();
            if (_doctors != null)
            {
                Doctors.Clear();
                //Doctors = new ObservableCollection<User>();
                foreach(User d in _doctors)
                {
                    Doctors.Add(d);
                }
                
            }
            
            
        }

        public ObservableCollection<UserType.Type> userTypes { get; set; } = new ObservableCollection<UserType.Type>();

        private UserType.Type _selectedType;
        public UserType.Type SelectedType
        {
            get { return _selectedType; }
            set
            {
                SetProperty(ref _selectedType, value);
                //OnPropertyChanged();
                if (value == UserType.Type.Patient)
                {
                    IsPatient = true;
                    Populate.Execute(null);
                }
                else
                {
                    //Doctors = null;
                    IsPatient = false;
                }

            }
        }
    }
}

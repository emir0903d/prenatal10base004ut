using prenatal.mobile.app.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prenatal.mobile.app.Views.Doctor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DoctorPatients : ContentPage
    {
        private DoctorsPatients _patients = null;
        public DoctorPatients(string _username, string _password, int _currentUserId)
        {
                       
            InitializeComponent();

            _patients = new DoctorsPatients();
            _patients._username = _username;
            _patients._password = _password;
            _patients._currentUserId = _currentUserId;

            BindingContext = _patients;

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await _patients.Init();
        }
    }
}
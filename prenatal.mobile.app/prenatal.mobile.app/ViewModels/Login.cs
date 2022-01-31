using Flurl.Http;
using prenatal.mobile.app.Views;
using prenatal.mobile.app.Views.Admin;
using prenatal.mobile.app.Views.Doctor;
using prenatal.mobile.app.Views.Patient;
using prenatal.model;
using prenatal.model.Enumerations;
using prenatal.model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace prenatal.mobile.app.ViewModels
{
    public class Login : BaseViewModel
    {
        
        private readonly AuthService _authService = new AuthService();

        public Login()
        {
            LoginCommand = new Command(async () => await LoginAttempt());
        }
        private string _username = string.Empty;
        private string _password = string.Empty;
        public string Username
        {
            get { return _username; }
            set => SetProperty(ref _username, value);

        }
        public string Password
        {
            get { return _password; }
            set
            {
                SetProperty(ref _password, value);
            }
        }
        
        public ICommand LoginCommand { get; set; }
        public async Task LoginAttempt()
        {
            IsBusy = true;
            AuthService.Username = Username;
            AuthService.Password = Password;
            UserAuthenticationRequest request = new UserAuthenticationRequest();
            request.username = AuthService.Username;
            request.password = AuthService.Password;
            try
            {
                var result = await _authService.Authenticate<User>(request);
                // IsBusy = false;
                if (result != null)
                {
                    if(result.Type == UserType.Type.Admin)
                    {
                        Application.Current.MainPage = new AdminPage(request.username, request.password);

                    }
                    if (result.Type == UserType.Type.Doctor)
                    {
                        //Application.Current.MainPage = new DoctorPage(request.username, request.password, result.Id);
                        //Application.Current.MainPage = new CalendarPage(request.username, request.password, result.Id);
                        Application.Current.MainPage = new DocPage(request.username, request.password, result.Id);

                    }
                    if (result.Type == UserType.Type.Patient)
                    {
                        Application.Current.MainPage = new Calendar(request.username, request.password, result.Id);

                    }

                }
                

            }catch(FlurlHttpException ex)
            {
                await Application.Current.MainPage.DisplayAlert("Auth error", ex.Message, "Ok");
            }
            

        }
    }
    

}


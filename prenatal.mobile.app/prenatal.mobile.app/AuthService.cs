using Flurl.Http;
using prenatal.model;
using prenatal.model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prenatal.mobile.app
{
    public class AuthService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        
        private readonly string _route = "Authenticate";
#if DEBUG
        //private readonly string _base = "http://127.0.0.1:54798/api";
        //private readonly string _base = "http://localhost:54798/api";
        private readonly string _base = "http://10.0.2.2:54798/api";
#endif
#if RELEASE
      private readonly string _base = "http://10.0.2.2:54798/api";
#endif
        public AuthService()
        {

        }
        public async Task<User> GenerateUsername(int Id)
        {
            var _full = _base + "/" + _route;

            try
            {
                return await _full.WithBasicAuth(Username, Password).PutJsonAsync(Id).ReceiveJson<User>();

            }
            catch (FlurlHttpException ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }

            return default;
        }
        public async Task<User> Authenticate<User>(UserAuthenticationRequest request)
        {
            var _full = _base + "/" + _route;

            try
            {
                return await _full.WithBasicAuth(request.username, request.password).PostJsonAsync(request).ReceiveJson<User>();

            }
            catch (FlurlHttpException ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }

            return default;


        }
        public async void OverridePassword(int Id, string _newPassword)
        {
            var _full = _base + "/" + _route + "/" + Id;
            try
            {
                await _full.WithBasicAuth(Username, Password).PutJsonAsync(_newPassword).ReceiveJson<User>();
            }
            catch (FlurlHttpException ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");

            }

            return;
        }
    }
}

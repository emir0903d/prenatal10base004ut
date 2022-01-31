using Flurl.Http;
using System.Threading.Tasks;
using prenatal.model.Extension;
using prenatal.model.Requests;
using prenatal.model;
using System.Windows.Forms;
using Flurl.Http.Testing;
using System.Net.Http;

namespace prenatal.winUI
{

    public class AuthService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        private readonly string _base = Properties.Settings.Default.API.ToString();
        private readonly string _route = "Authenticate";
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
                MessageBox.Show(ex.Message);
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
            catch(FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
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
            catch(FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
                
            }

            return;
        }
    }
}

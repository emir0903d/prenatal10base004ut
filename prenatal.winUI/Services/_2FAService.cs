using Flurl.Http;
using prenatal.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prenatal.winUI.Services
{
    public class _2FAService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        private readonly string _base = Properties.Settings.Default.API.ToString();
        private readonly string _route = "TwoFactorAuth";
        public _2FAService()
        {

        }
        public async Task<_2FAReturnCodes> Activate(User request)
        {
            var _full = _base + "/" + _route+"/Activate";
            //
            try
            {
                return await _full.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<_2FAReturnCodes>();

            }
            catch (FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return default;
        }
        public async Task<bool> Login2FA(int userId, string InputCode)
        {
            var _full = _base + "/" + _route + "/Login2FA/"+userId;
            //
            try
            {
                return await _full.WithBasicAuth(Username, Password).PutJsonAsync(InputCode).ReceiveJson<bool>();

            }
            catch (FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return default;
        }
        public async Task<bool> Enable(int userId, string InputCode)
        {
            var _full = _base + "/" + _route + "/Enable/" + userId;
            //WithBasicAuth(request.username, request.password)
            try
            {
                return await _full.WithBasicAuth(Username, Password).PutJsonAsync(InputCode).ReceiveJson<bool>();

            }
            catch (FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return default;
        }
        public async Task<bool> Disable(int userId, string InputCode)
        {
            var _full = _base + "/" + _route + "/Disable/" + userId;
            //WithBasicAuth(request.username, request.password)
            try
            {
                return await _full.WithBasicAuth(Username, Password).PutJsonAsync(InputCode).ReceiveJson<bool>();

            }
            catch (FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return default;

        }

    }
}

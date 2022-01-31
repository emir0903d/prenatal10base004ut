using Flurl.Http;
using prenatal.model.Extension;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prenatal.mobile.app
{
    public class APIservice
    {
        public static string Username { get; set; }
        public static string Password { get; set; }


#if DEBUG
        //private readonly string _base = "http://127.0.0.1:54798/api";
        //private readonly string _base = "http://localhost:54798/api";
        private readonly string _base = "http://10.0.2.2:54798/api";
#endif
#if RELEASE
      private readonly string _base = "http://10.0.2.2:54798/api";
#endif
        private readonly string _route = null;
        public APIservice(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object search)
        {
            var _full = _base + "/" + _route;

            if (search != null)
            {
                _full += "?";
                _full += await search.ToQueryString();
            }

            try
            {
                return await _full.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error",ex.Message,"Ok");
            }
            return default;

        }
        public async Task<T> GetById<T>(object id)
        {
            var _full = _base + "/" + _route + "/" + id;

            return await _full.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }
        public async Task<T> Insert<T>(object request)
        {
            var _full = _base + "/" + _route;
            return await _full.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Update<T>(int Id, object request)
        {
            var _full = _base + "/" + _route + "/" + Id;
            return await _full.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Delete<T>(object Id)
        {
            var _full = _base + "/" + _route + "/" + Id;
            return await _full.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
        }

    }
}

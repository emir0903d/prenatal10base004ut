using Flurl.Http;
using System.Threading.Tasks;
using prenatal.model.Extension;
using prenatal.model.Requests;
using prenatal.model;
using System.Windows.Forms;

namespace prenatal.winUI
{

    public class APIservice
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        private readonly string _base = Properties.Settings.Default.API.ToString();
        private readonly string _route = null;
        public APIservice(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object search)
        {
            var _full = _base+"/"+_route;

            if(search != null)
            {
                _full += "?";
                _full += await search.ToQueryString();
            }
            try
            {
                return await _full.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch(FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
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
            var _full = _base + "/" + _route+"/"+Id;
            return await _full.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Delete<T>(object Id)
        {
            var _full = _base + "/" + _route+"/"+Id;
            return await _full.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
        }

    }
}

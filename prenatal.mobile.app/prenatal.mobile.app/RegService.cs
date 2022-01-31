using prenatal.model;
using System;
using System.Collections.Generic;
using System.Text;
using Flurl.Http;
using System.Threading.Tasks;

namespace prenatal.mobile.app
{
    public class RegService
    {
        private readonly string _route = "Register";
#if DEBUG
        //private readonly string _base = "http://127.0.0.1:54798/api";
        //private readonly string _base = "http://localhost:54798/api";
        private readonly string _base = "http://10.0.2.2:54798/api";
#endif
#if RELEASE
      private readonly string _base = "http://10.0.2.2:54798/api";
#endif
        public RegService()
        {

        }
        public async Task<List<User>> GetDoctors()
        {
            var _full = _base + "/" + _route;
            return await _full.GetJsonAsync<List<User>>();
        }
        public async Task<User> Register(object request)
        {
            var _full = _base + "/" + _route;
            return await _full.PostJsonAsync(request).ReceiveJson<User>();
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public interface IEmailService
    {
        public bool Send(string to_name, string to_address, string msg);
    }
}

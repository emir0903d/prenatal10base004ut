using prenatal.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public interface ITwoFactorAuthService
    {
        public _2FAReturnCodes Activate(User user);
        public bool Login2FA(int userId, string InputCode);
        public bool Enable(int userId, string InputCode);
        public bool Disable(int userId, string InputCode);

    }
}

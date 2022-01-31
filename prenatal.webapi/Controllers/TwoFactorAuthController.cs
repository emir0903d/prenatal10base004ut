using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prenatal.model;
using prenatal.webapi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Controllers
{
    [Authorize]
    // [Route("api/[controller]")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TwoFactorAuthController : ControllerBase
    {
        private readonly ITwoFactorAuthService _2FA;
        public TwoFactorAuthController(ITwoFactorAuthService twoFactor)
        {
            _2FA = twoFactor;
        }
        [ActionName("Activate")]
        [HttpPost]
        public _2FAReturnCodes Activate([FromBody] User user)
        {
            return _2FA.Activate(user);
        }
        [ActionName("Login2FA")]
        [HttpPut("{userId}")]
        public bool Login2FA(int userId, [FromBody] string InputCode)
        {
            return _2FA.Login2FA(userId, InputCode);
        }
        [ActionName("Enable")]
        [HttpPut("{userId}")]
        public bool Enable(int userId, [FromBody] string InputCode)
        {
            return _2FA.Enable(userId, InputCode);
        }
        [ActionName("Disable")]
        [HttpPut("{userId}")]
        public bool Disable(int userId, [FromBody] string InputCode)
        {
            return _2FA.Disable(userId, InputCode);
        }
    }
}

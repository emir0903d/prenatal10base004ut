using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prenatal.model;
using prenatal.model.Requests;
using prenatal.webapi.Services;

namespace prenatal.webapi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IAuthenticateService _authenticateService;
        public AuthenticateController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        [HttpPost]
        [AllowAnonymous]
        public User Authenticate(UserAuthenticationRequest request)
        {
            return _authenticateService.Authenticate(request);
        }
        [HttpPut("{Id}")]
        public User OverridePassword(int Id,[FromBody] string _newPassword)
        {
            return _authenticateService.OverridePassword(Id, _newPassword);
        }

        [HttpPut]
        public User GenerateUsername([FromBody]int Id)
        {
            return _authenticateService.GenerateUsername(Id);
        }
        
        //[HttpGet]
        //public string GeneratePassword()
        //{
        //    return _authenticateService.GeneratePassword();
        //}
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prenatal.model;
using prenatal.model.Requests;
using prenatal.webapi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterService _register;
        public RegisterController(IRegisterService registerService)
        {
            _register = registerService;
        }
        [HttpPost]
        public User Register(UserRegisterRequest request)
        {
            return _register.Register(request);
        }
        [HttpGet]
        public List<User> GetDoctors()
        {
            return _register.GetDoctors();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prenatal.webapi.Services;

namespace prenatal.webapi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TModel, TSearch, TDatabase> : ControllerBase
    {
        private readonly IBaseService<TModel, TSearch, TDatabase> _baseService;
        public BaseController(IBaseService<TModel, TSearch, TDatabase> baseService)
        {
            _baseService = baseService;
        }
        [HttpGet]
        public IList<TModel> Get([FromQuery] TSearch tsearch)
        {
            return _baseService.Get(tsearch);
        }
        [HttpGet("{Id}")]
        public TModel GetById(int Id)
        {
            return _baseService.GetById(Id);
        }

    }
}

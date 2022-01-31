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
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class PredictController : ControllerBase
    {
        private readonly IPredictService _predict;
        public PredictController(IPredictService predict)
        {
            _predict = predict;
        }

        [HttpPost]
        public PredictionData Predict([FromBody] PredictionData _data)
        {
            return _predict.Predict(_data);
        }
    }
}

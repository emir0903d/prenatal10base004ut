using Microsoft.AspNetCore.Mvc;
using prenatal.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public interface IPredictService
    {
        public PredictionData Predict(PredictionData _data);
    }
}

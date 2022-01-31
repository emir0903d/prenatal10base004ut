using Microsoft.AspNetCore.Mvc;
using prenatal.model;
using Prenatal_webapi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public class PredictService :IPredictService
    {
        public PredictionData Predict(PredictionData _data)
        {
            var data = new MLModel.ModelInput()
            {
                Heart = _data.HeartBeats,
                Movement = _data.Movement,
                Nuchal = _data.Nuchal,
                Note = _data.Note
            };

            var result = MLModel.Predict(data);
            if (result.Prediction == true)
            {
                _data.Anomaly = true;
                return _data;
            }
            else
            {
                _data.Anomaly = false;
                return _data;
            }
        }
    }
}

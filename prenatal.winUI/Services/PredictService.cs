using Flurl.Http;
using prenatal.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prenatal.winUI.Services
{
    public class PredictService
    {
        private readonly string _base = Properties.Settings.Default.API.ToString();
        private readonly string _route = "Predict";
        public PredictService() { }

        public async Task<PredictionData> Predict(PredictionData request)
        {
            var _full = _base + "/" + _route;
            //
            try
            {
                return await _full.PostJsonAsync(request).ReceiveJson<PredictionData>();

            }
            catch (FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return default;
        }
    }
}

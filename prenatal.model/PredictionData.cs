using System;
using System.Collections.Generic;
using System.Text;

namespace prenatal.model
{
    public class PredictionData
    {
        public float HeartBeats { get; set; }
        public bool Movement { get; set; }
        public bool Nuchal { get; set; }
        public string Note { get; set; }
        public bool? Anomaly { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace prenatal.model.Requests
{
    public class AllergyUpsertRequest
    {
        public string Type { get; set; }
        public string Note { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

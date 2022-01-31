using System;
using System.Collections.Generic;
using System.Text;

namespace prenatal.model.Requests
{
    public class AllergySearchRequest
    {
        public int MedicalRecordId { get; set; }
        public string Type { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model
{
    public class Allergy
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

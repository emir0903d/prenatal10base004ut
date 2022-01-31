using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model.Requests
{
    public class CoombsTestUpsertRequest
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public CoombsTest.CoombsTestType TypeOfTest { get; set; }
        public bool Result { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

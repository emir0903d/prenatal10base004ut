using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model.Requests
{
    public class GlucoseTestUpsertRequest
    {
        public int Id { get; set; }
        public GlucoseTest.GlucoseTestType TypeOfTest { get; set; }
        public string Units { get; set; }
        public int? Results { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

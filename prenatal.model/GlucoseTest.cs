using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model
{
    public class GlucoseTest
    {
        public int Id { get; set; }
        public GlucoseTestType TypeOfTest { get; set; }
        public enum GlucoseTestType
        {
            OneStepTesting,
            TwoStepTesting
        }
        public string Units { get; set; }
        public int? Results { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

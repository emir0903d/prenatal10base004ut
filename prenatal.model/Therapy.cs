using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model
{
    public class Therapy
    {
        public int TherapiesId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BeginningDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndingDate { get; set; }
        [MaxLength(100, ErrorMessage = "MaxLength is 100 charachters!")]
        public string Medicaments { get; set; }
        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Note { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

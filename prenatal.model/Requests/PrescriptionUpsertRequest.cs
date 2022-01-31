using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model.Requests
{
    public class PrescriptionUpsertRequest
    {
        [Required]
        public string Description { get; set; }
        [Required]
        public string Dose { get; set; }
        [Required]
        public string Usage { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

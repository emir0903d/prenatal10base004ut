using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Dose { get; set; }
        public string Usage { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

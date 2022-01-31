using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model
{
    public class PreviousPregnancy
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PregnancyDate { get; set; }

        public int GestationWeeks { get; set; }

        [MaxLength(30, ErrorMessage = "MaxLength is 30 charachters!")]
        public string DeliveryType { get; set; }

        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Complications { get; set; }

        [MaxLength(50, ErrorMessage = "MaxLength is 50 charachters!")]
        public string Outcome { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

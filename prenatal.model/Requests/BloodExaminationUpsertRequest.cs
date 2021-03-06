using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model.Requests
{
    public class BloodExaminationUpsertRequest
    {
        public double? Results { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [MaxLength(50, ErrorMessage = "MaxLength is 50 charachters!")]
        public string BloodTest { get; set; }
        [MaxLength(10, ErrorMessage = "MaxLength is 10 charachters!")]
        public string Unit { get; set; }
        public double Low { get; set; }
        public double High { get; set; }
        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Note { get; set; }
        [Required]
        public int ReferralsId { get; set; }
    }
}

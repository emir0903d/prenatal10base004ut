using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model.Requests
{
    public class UrineExaminationUpsertRequest
    {
        public string Results { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [MaxLength(50, ErrorMessage = "MaxLength is 50 charachters!")]
        [Required(ErrorMessage = "This field is required!")]
        public string UrineTest { get; set; }

        [MaxLength(10, ErrorMessage = "MaxLength is 10 charachters!")]
        [Required(ErrorMessage = "This field is required!")]
        public string Unit { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string ReferenceInterval { get; set; }
        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Note { get; set; }
        public int ReferralsId { get; set; }
    }
}

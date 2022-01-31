using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Database
{
    public class BloodExaminations
    {
        [Key]
        public int Id { get; set; }
        public double? Results { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [MaxLength(50, ErrorMessage = "MaxLength is 50 charachters!")]
        [Required(ErrorMessage = "This field is required!")]
        public string BloodTest { get; set; }

        [MaxLength(10, ErrorMessage = "MaxLength is 10 charachters!")]
        [Required(ErrorMessage = "This field is required!")]
        public string Unit { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public double Low { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public double High { get; set; }

        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Note { get; set; }

        [ForeignKey(nameof(ReferralsId))]
        public virtual Referrals Referrals { get; set; }
        public int ReferralsId { get; set; }
    }
}

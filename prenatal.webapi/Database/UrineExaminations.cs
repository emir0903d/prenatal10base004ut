using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Database
{
    public class UrineExaminations
    {
        [Key]
        public int Id { get; set; }
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


        [ForeignKey(nameof(ReferralsId))]
        public virtual Referrals Referrals { get; set; }
        public int ReferralsId { get; set; }
    }
}

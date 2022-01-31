using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Database
{
    public class MedicalRecords
    {
        [ForeignKey("User")]
        public int Id { get; set; }
        public virtual Users Users { get; set; }

        [MaxLength(15, ErrorMessage = "MaxLength 15 characters")]
        [Required(ErrorMessage = "This field is required!")]
        public string MedicalRecordNumber { get; set; }

        [MaxLength(30, ErrorMessage = "MaxLength is 30 characters")]
        public string MaidenName { get; set; }

        [StringLength(13, ErrorMessage = "Length must be 13 numbers", MinimumLength = 13)]
        [Required(ErrorMessage = "This field is required!")]
        public string PersonalIdentificationNumber { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "MaxLength 10 characters")]
        public string MartialStatus { get; set; }


        [DataType(DataType.Date)]
        [Required(ErrorMessage = "This field is required!")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [MaxLength(2, ErrorMessage = "MaxLength 2 characters")]
        [Required(ErrorMessage = "This field is required!")]
        public string BloodType { get; set; }

        [MaxLength(1, ErrorMessage = "MaxLength 1 characters")]
        [Required(ErrorMessage = "This field is required!")]
        public string RHFactor { get; set; }
    }
}

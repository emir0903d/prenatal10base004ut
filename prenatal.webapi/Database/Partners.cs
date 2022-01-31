using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Database
{
    public class Partners
    {
        [Key]
        public int Id { get; set; }

        [StringLength(15, ErrorMessage = "Length must be between 2 and 15 characters", MinimumLength = 2)]
        [Required(ErrorMessage = "This field is required!")]
        public string Name { get; set; }

        [StringLength(30, ErrorMessage = "Length must be between 2 and 15 characters", MinimumLength = 2)]
        [Required(ErrorMessage = "This field is required!")]
        public string Surname { get; set; }

        [MaxLength(2, ErrorMessage = "MaxLength 2 characters")]
        public string BloodType { get; set; }

        [MaxLength(1, ErrorMessage = "MaxLength 1 characters")]
        public string RHFactor { get; set; }

        [ForeignKey(nameof(MedicalRecordsId))]
        [Required(ErrorMessage = "This field is required!")]
        public virtual MedicalRecords MedicalRecords { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

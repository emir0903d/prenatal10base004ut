using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model
{
    public class Partner
    {
        public int Id { get; set; }
        [StringLength(15, ErrorMessage = "Length must be between 2 and 15 characters", MinimumLength = 2)]
        [Required]
        public string Name { get; set; }
        [StringLength(30, ErrorMessage = "Length must be between 2 and 15 characters", MinimumLength = 2)]
        [Required]
        public string Surname { get; set; }
        [MaxLength(2, ErrorMessage = "MaxLength 2 characters")]
        public string BloodType { get; set; }
        [MaxLength(1, ErrorMessage = "MaxLength 1 characters")]
        public string RHFactor { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

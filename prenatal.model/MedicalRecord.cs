using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model
{
    public class MedicalRecord
    {

        public int Id { get; set; }
        [Required]
        public string MedicalRecordNumber { get; set; }
        [Required]
        public string MaidenName { get; set; }
        [Required]
        public string PersonalIdentificationNumber { get; set; }
        [Required]
        public string MartialStatus { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string BloodType { get; set; }
        [Required]
        public string RHFactor { get; set; }
    }
}

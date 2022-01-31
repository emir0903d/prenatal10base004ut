using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model.Requests
{
    public class VitalSignUpsertRequest
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Required]
        [Range(0.01, 999)]
        public float Temperature { get; set; }
        [Range(0.01, 999)]
        [Required]
        public int SystolicPressure { get; set; }
        [Range(0.01, 999)]
        [Required]
        public int DiastolicPressure { get; set; }
        [Range(0.01, 999)]
        [Required]
        public int HeartBeats { get; set; }
        [Range(0.01, 999)]
        [Required]
        public int RespiratoryRate { get; set; }
        [Range(0.01, 999)]
        [Required]
        public float Height { get; set; }
        [Range(0.01, 999)]
        [Required]
        public float Weight { get; set; }

        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Note { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

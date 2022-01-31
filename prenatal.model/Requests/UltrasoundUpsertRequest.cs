using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model.Requests
{
    public class UltrasoundUpsertRequest
    {

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "This field is required!")]
        public DateTime Date { get; set; }
        [Required]
        [Range(0.01, 999)]
        public int HeartBeats { get; set; }
        [Required]
        public bool Movement { get; set; }
        [Range(0.01, 999)]
        public float Length { get; set; }
        [Required]
        public bool NuchalScan { get; set; }
        [Required]
        public bool Anomalies { get; set; }
        [Range(0.01, 999)]
        public float HeadDiameter { get; set; }
        [Range(0.01, 999)]
        public float HeadCircumference { get; set; }
        [Range(0.01, 999)]
        public float AbdominalCircumference { get; set; }
        [Range(0.01, 999)]
        public float FemurLength { get; set; }

        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Note { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

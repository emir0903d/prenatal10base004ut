using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model
{
    public class Ultrasound
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "This field is required!")]
        public DateTime Date { get; set; }

        public int HeartBeats { get; set; }

        public bool Movement { get; set; }

        public float Length { get; set; }

        public bool NuchalScan { get; set; }

        public bool Anomalies { get; set; }

        public float HeadDiameter { get; set; }

        public float HeadCircumference { get; set; }

        public float AbdominalCircumference { get; set; }

        public float FemurLength { get; set; }

        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Note { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

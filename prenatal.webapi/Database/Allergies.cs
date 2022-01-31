using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Database
{
    public class Allergies
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "MaxLength is 100 charachters!")]
        [Required(ErrorMessage = "This field is required!")]
        public string Type { get; set; }

        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Note { get; set; }

        [ForeignKey(nameof(MedicalRecordsId))]
        [Required(ErrorMessage = "This field is required!")]
        public int MedicalRecordsId { get; set; }
        public virtual MedicalRecords MedicalRecords { get; set; }
    }
}

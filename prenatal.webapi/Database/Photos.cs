using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Database
{
    public class Photos
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public byte[] Data { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [ForeignKey(nameof(MedicalRecordsId))]
        [Required(ErrorMessage = "This field is required!")]
        public virtual MedicalRecords MedicalRecords { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

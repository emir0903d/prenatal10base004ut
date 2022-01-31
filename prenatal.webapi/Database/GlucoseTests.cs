using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Database
{
    public class GlucoseTests
    {
        [Key]
        public int Id { get; set; }
        public GlucoseTestType TypeOfTest { get; set; }
        public enum GlucoseTestType
        {
            OneStepTesting,
            TwoStepTesting
        }
        public string Units { get; set; }
        public int? Results { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [ForeignKey(nameof(MedicalRecordsId))]
        [Required(ErrorMessage = "This field is required!")]
        public virtual MedicalRecords MedicalRecords { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

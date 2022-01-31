using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model
{
    public class CoombsTest
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public CoombsTestType TypeOfTest { get; set; }
        public enum CoombsTestType
        {
            DirectAntiglobulinTest,
            IndirectAntiglobulinTest
        }
        public bool Result { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

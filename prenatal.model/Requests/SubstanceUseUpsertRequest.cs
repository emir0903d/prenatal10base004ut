using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model.Requests
{
    public class SubstanceUseUpsertRequest
    {
        [Required]
        [MaxLength(30, ErrorMessage = "MaxLength is 30 charachters!")]
        public string Description { get; set; }
        [Required]
        public bool PriorToPregnancy { get; set; }
        [Required]
        public bool StillUsing { get; set; }
        [Range(1, 99)]
        [Required]
        public int NumberOfYears { get; set; }
        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Note { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

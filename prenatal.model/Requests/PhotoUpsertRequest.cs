using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model.Requests
{
    public class PhotoUpsertRequest
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public byte[] Data { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public int MedicalRecordsId { get; set; }
    }
}

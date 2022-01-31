using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model.Requests
{
    public class SearchAppointmentRequest
    {
        [DataType(DataType.Date)]
        public DateTime? date { get; set; }
        public int? _docId { get; set; }
        public int? _patientId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model
{
    public class Appointment
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public DateTime Time { get; set; }

        public string Note { get; set; }
        public int PatientId { get; set; }
        public User Patient {get;set;}
        public int DoctorId { get; set; }
        public User Doctor { get; set; }
        public SlotStatus Status { get; set; }
        public enum SlotStatus
        {
            Free,
            Reserved
        }
    }
}

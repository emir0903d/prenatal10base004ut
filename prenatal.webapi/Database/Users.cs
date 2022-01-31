using prenatal.model.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prenatal.webapi.Database
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual MedicalRecords MedicalRecords { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public UserStatus.Status Status { get; set; }
        public UserType.Type Type { get; set; }
        public int? DoctorId { get; set; }
        public int LoginCount { get; set; }
        public DateTime Registration { get; set; }
        public DateTime LastLogin { get; set; }
        public virtual ICollection<UsersRoles> UsersRoles { get; set; }
        public bool HasMR { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public virtual ICollection<Appointments> DoctorAppointments { get; set; }
        public virtual ICollection<Appointments> PatientAppointments { get; set; }

    }
}

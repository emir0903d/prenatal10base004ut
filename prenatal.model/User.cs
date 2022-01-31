using prenatal.model.Enumerations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace prenatal.model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public UserStatus.Status Status { get; set; }
        public UserType.Type Type { get; set; }
        public int? DoctorId { get; set; }
        public int LoginCount { get; set; }
        public DateTime Registration { get; set; }
        public DateTime LastLogin { get; set; }
        public bool HasMR { get; set; }
        public bool TwoFactorEnabled { get; set; }

    }
}

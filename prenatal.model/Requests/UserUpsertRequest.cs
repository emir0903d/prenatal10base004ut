using prenatal.model.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model.Requests
{
    public class UserUpsertRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Gender { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public UserStatus.Status Status { get; set; }
        public UserType.Type Type { get; set; }
        public int? DoctorId { get; set; }
        public int LoginCount { get; set; }
        public DateTime Registration { get; set; }
        public DateTime LastLogin { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public bool HasMR { get; set; }
    }
}

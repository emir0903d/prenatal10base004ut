using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prenatal.model.Requests
{
    public class RoleUpsertRequest
    {
        [Required]
        public string Name { get; set; }
        public int? NumberOfUsers { get; set; }
    }
}

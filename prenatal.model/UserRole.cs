using System;
using System.Collections.Generic;
using System.Text;

namespace prenatal.model
{
    public class UserRole
    {
        public int Id { get; set; }
        public DateTime Change { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}

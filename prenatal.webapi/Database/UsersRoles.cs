using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Database
{
    public class UsersRoles
    {
        [Key]
        public int Id { get; set; }
        public DateTime Change { get; set; }
        public int UserId { get; set; }
        public virtual Users Users { get; set; }
        public int RoleId { get; set; }
        public virtual Roles Roles { get; set; }
    }
}

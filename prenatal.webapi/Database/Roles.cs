using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Database
{
    public class Roles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? NumberOfUsers { get; set; }
        public virtual ICollection<UsersRoles> UsersRoles { get; set; }
    }
}

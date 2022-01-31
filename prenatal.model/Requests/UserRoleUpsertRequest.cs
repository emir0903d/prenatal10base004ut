using System;
using System.Collections.Generic;
using System.Text;

namespace prenatal.model.Requests
{
    public class UserRoleUpsertRequest
    {
        public DateTime Change { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}

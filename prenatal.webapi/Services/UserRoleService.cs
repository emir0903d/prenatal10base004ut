using AutoMapper;
using prenatal.model;
using prenatal.model.Requests;
using prenatal.webapi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public class UserRoleService :
        CRUDservice<UserRole, SearchUserRoleRequest, UserRoleUpsertRequest, UserRoleUpsertRequest, UsersRoles>, IUserRoleService
    {
        public UserRoleService(Context context, IMapper mapper) : base(context, mapper)
        {
        }
        protected internal override IQueryable<UsersRoles> ApplyFilter(IQueryable<UsersRoles> query, SearchUserRoleRequest tsearch)
        {
            if (!string.IsNullOrWhiteSpace(tsearch.UserName))
            {
                query = query.Where(x => tsearch.UserName.Contains(x.Users.Name));
            }
            if (!string.IsNullOrWhiteSpace(tsearch.RoleName))
            {
                query = query.Where(x => tsearch.RoleName.Contains(x.Roles.Name));
            }
            return query;
        }
    }
}

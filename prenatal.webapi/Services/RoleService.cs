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
    public class RoleService :
        CRUDservice<Role, SearchRoleRequest, RoleUpsertRequest, RoleUpsertRequest, Roles>, IRoleService
    {
        public RoleService(Context context, IMapper mapper) : base(context, mapper)
        {
        }
        protected internal override IQueryable<Roles> ApplyFilter(IQueryable<Roles> query, SearchRoleRequest tsearch)
        {
            if (!string.IsNullOrWhiteSpace(tsearch.Name))
            {
                query = query.Where(x => tsearch.Name.Contains(x.Name));
            }
            return query;
        }
    }
}

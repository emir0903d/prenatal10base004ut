using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prenatal.model;
using prenatal.model.Requests;
using prenatal.webapi.Database;
using prenatal.webapi.Services;

namespace prenatal.webapi.Controllers
{

    public class RoleController
        : CRUDController<Role, object, RoleUpsertRequest, RoleUpsertRequest, Roles>
    {
        public RoleController(ICRUDservice<Role, object, RoleUpsertRequest, RoleUpsertRequest, Roles> baseService) : base(baseService)
        {
        }
    }
}
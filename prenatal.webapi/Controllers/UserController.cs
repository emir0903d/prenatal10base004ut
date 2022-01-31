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
    public class UserController
        : CRUDController<User, SearchUsersRequest, UserUpsertRequest, UserUpsertRequest, Users>
    {
        public UserController(ICRUDservice<User, SearchUsersRequest, UserUpsertRequest, UserUpsertRequest, Users> baseService) : base(baseService)
        {

        }
    }
}
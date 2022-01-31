using prenatal.model;
using prenatal.model.Requests;
using prenatal.webapi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public interface IUserService
        :ICRUDservice<User, SearchUsersRequest, UserUpsertRequest, UserUpsertRequest, Users>
    {
    }
}

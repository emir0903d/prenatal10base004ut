using AutoMapper;
using prenatal.model;
using prenatal.model.Requests;
using prenatal.webapi.Database;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace prenatal.webapi.Services
{
    public class UserService :
         CRUDservice<User, SearchUsersRequest, UserUpsertRequest, UserUpsertRequest, Users>, IUserService

    {
        public UserService(Context context, IMapper mapper) : base(context, mapper)
        {
        }

        internal protected override IQueryable<Users> ApplyFilter(IQueryable<Users> query, SearchUsersRequest tsearch)
        {
            if (tsearch.DoctorsId != null)
            {
                query = query.Where(x => x.DoctorId == tsearch.DoctorsId);
            }
            if (!string.IsNullOrWhiteSpace(tsearch.NameSurname))
            {
                query = query.Where(x => x.Name.StartsWith(tsearch.NameSurname) || x.Surname.StartsWith(tsearch.NameSurname));
            }

            if (tsearch.Status != null)
            {
                query = query.Where(x => tsearch.Status.Contains(x.Status));
            }

            if (tsearch.Type != null)
            {
                query = query.Where(x => tsearch.Type.Contains(x.Type));
            }

            return query;
        }
    }



    
}

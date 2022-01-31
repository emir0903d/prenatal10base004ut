using AutoMapper;
using Microsoft.EntityFrameworkCore;
using prenatal.model;
using prenatal.model.Requests;
using prenatal.webapi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public class BirthExpectedService : CRUDservice<BirthExpected, object, BirthExpectedUpsertRequest, BirthExpectedUpsertRequest,ExpectedBirth>
    {
        public BirthExpectedService(Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override BirthExpected Insert(BirthExpectedUpsertRequest model)
        {
            ExpectedBirth item = _autoMapper.Map<ExpectedBirth>(model);
            item.ExpectedDate = item.LastMenstrualDate.AddDays(280);
            var results = _db.Set<ExpectedBirth>().Add(item);

            if (results.State == EntityState.Added)
            {
                _db.SaveChanges();
                _db.Dispose();
            }

            return _autoMapper.Map<BirthExpected>(item);
        }

        public override BirthExpected Update(int Id, BirthExpectedUpsertRequest model)
        {
            ExpectedBirth item = _db.Set<ExpectedBirth>().Find(Id);

            _autoMapper.Map(model, item);
            item.ExpectedDate = item.LastMenstrualDate.AddDays(280);

            var results = _db.Set<ExpectedBirth>().Update(item);

            if (results.GetDatabaseValues() == null)
            {
                return default;
            }

            if (results.State == EntityState.Modified)
            {
                _db.SaveChanges();
                _db.Dispose();
                return _autoMapper.Map<BirthExpected>(item);
            }
            else return default;


        }


    }
}

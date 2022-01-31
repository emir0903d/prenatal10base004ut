using AutoMapper;
using Microsoft.EntityFrameworkCore;
using prenatal.webapi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public class CRUDservice<TModel, TSearch, TInsert, TUpdate, TDatabase>
        :
        BaseService<TModel, TSearch, TDatabase>,
        ICRUDservice<TModel, TSearch, TInsert, TUpdate, TDatabase> where TDatabase:class
    {
        public CRUDservice(Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual TModel Insert(TInsert model)
        {
            TDatabase item = _autoMapper.Map<TDatabase>(model);
            var results = _db.Set<TDatabase>().Add(item);

            if (results.State == EntityState.Added)
            {
                _db.SaveChanges();
                _db.Dispose();
            }
            
            return _autoMapper.Map<TModel>(item); 
        }

        public virtual TModel Update(int Id, TUpdate model)
        {
            TDatabase item = _db.Set<TDatabase>().Find(Id);
            
            _autoMapper.Map(model, item);
            
            var results = _db.Set<TDatabase>().Update(item);
            
            if (results.GetDatabaseValues() == null)
            {
                return default;
            }
            
            if (results.State == EntityState.Modified)
            {
                _db.SaveChanges();
                _db.Dispose();
                return _autoMapper.Map<TModel>(item);
            }else return default;
            

        }
        public virtual TModel Delete(int Id)
        {
            var item = _db.Set<TDatabase>().Find(Id);
            
            var results = _db.Set<TDatabase>().Remove(item);
            if (results.GetDatabaseValues() == null)
            {
                return default;
            }
            if (results.State == EntityState.Deleted)
            {
                _db.SaveChanges();
                _db.Dispose();
                return _autoMapper.Map<TModel>(item);
            }
            else return default;
        }
    }
}

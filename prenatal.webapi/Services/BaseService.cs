using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using prenatal.model.Requests;
using prenatal.webapi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IBaseService<TModel, TSearch, TDatabase> where TDatabase : class
    {
        protected readonly Context _db;
        protected readonly IMapper _autoMapper;
        public BaseService(Context context, IMapper mapper)
        {
            _db = context;
            _autoMapper = mapper;
        }

        public virtual IList<TModel> Get(TSearch tsearch = default)
        {
            if (_db.Set<TDatabase>().Any() == false)
            {
                return null;
            }

            IQueryable<TDatabase> query = _db.Set<TDatabase>()
                //.AsNoTracking()
                .AsQueryable();

            if (tsearch != null)
            {
                query = ApplyFilter(query, tsearch);
            }

            IList<TDatabase> items = query.ToList();

            return _autoMapper.Map<IList<TModel>>(items);

            
        }

        public virtual TModel GetById(int Id)
        {
            var results = _db.Set<TDatabase>().Find(Id);
            if(results == null)
            {
                return default;
            }
            else
            {
                TDatabase item = _db.Set<TDatabase>().Find(Id);
                return _autoMapper.Map<TModel>(item);
            }
            
            
        }
        internal protected virtual IQueryable<TDatabase> ApplyFilter(IQueryable<TDatabase> query, TSearch tsearch)
        {
            return query;
        }

    }
}

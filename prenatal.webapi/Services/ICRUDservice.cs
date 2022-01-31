using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public interface ICRUDservice<TModel, TSearch, TInsert, TUpdate, TDatabase>:IBaseService<TModel, TSearch, TDatabase>
    {
        public TModel Insert(TInsert model);
        public TModel Update(int Id, TUpdate model);
        public TModel Delete(int Id);
    }
}

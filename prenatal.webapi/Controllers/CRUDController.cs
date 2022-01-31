using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using prenatal.webapi.Services;

namespace prenatal.webapi.Controllers
{
    [Authorize]
    public class CRUDController<TModel, TSearch, TInsert, TUpdate, TDatabase> : BaseController<TModel, TSearch, TDatabase>
    {
        private readonly ICRUDservice<TModel, TSearch, TInsert, TUpdate, TDatabase> _service=null;
        public CRUDController(ICRUDservice<TModel, TSearch, TInsert, TUpdate, TDatabase> baseService) : base(baseService)
        {
            _service = baseService;
        }
        [HttpPost]
        public TModel Insert(TInsert insert)
        {
            return _service.Insert(insert);
        }
        [HttpPut("{Id}")]
        public TModel Update(int Id, TUpdate update)
        {
            return _service.Update(Id, update);
        }

        [HttpDelete("{Id}")]
        public TModel Delete(int Id)
        {
            return _service.Delete(Id);
                        
        }

    }
}

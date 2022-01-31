using prenatal.model.Requests;
using prenatal.webapi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace prenatal.webapi.Services
{
    public interface IBaseService<TModel, TSearch, TDatabase>
    {
        public IList<TModel> Get(TSearch tsearch = default(TSearch));
        public TModel GetById(int Id);

    }
}

using AutoMapper;
using prenatal.model;
using prenatal.model.Requests;
using prenatal.webapi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public class SubstancesUsedService : CRUDservice<SubstanceUse, SearchSubstancesRequest, SubstanceUseUpsertRequest, SubstanceUseUpsertRequest, SubstancesUse>
    {
        public SubstancesUsedService(Context context, IMapper mapper) : base(context, mapper)
        {
        }
        internal protected override IQueryable<SubstancesUse> ApplyFilter(IQueryable<SubstancesUse> query, SearchSubstancesRequest tsearch)
        {
            if (tsearch.MedicalRecordId != 0)
            {
                query = query.Where(x => x.MedicalRecordsId == tsearch.MedicalRecordId);
            }

            return query;
        }
    }
}

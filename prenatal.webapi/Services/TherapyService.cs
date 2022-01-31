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
    public class TherapyService : CRUDservice<Therapy, SearchTherapiesRequest, TherapyUpsertRequest, TherapyUpsertRequest, Therapies>
    {
        public TherapyService(Context context, IMapper mapper) : base(context, mapper)
        {
        }
        internal protected override IQueryable<Therapies> ApplyFilter(IQueryable<Therapies> query, SearchTherapiesRequest tsearch)
        {
            if (tsearch.MedicalRecordId != 0)
            {
                query = query.Where(x => x.MedicalRecordsId == tsearch.MedicalRecordId);
            }

            return query;
        }
    }
}

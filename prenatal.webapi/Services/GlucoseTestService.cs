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
    public class GlucoseTestService : CRUDservice<GlucoseTest, GlucoseTestSearchRequest, GlucoseTestUpsertRequest, GlucoseTestUpsertRequest, GlucoseTests>
    {
        public GlucoseTestService(Context context, IMapper mapper) : base(context, mapper)
        {
        }

        protected internal override IQueryable<GlucoseTests> ApplyFilter(IQueryable<GlucoseTests> query, GlucoseTestSearchRequest tsearch)
        {
            if(tsearch != null || tsearch.MedicalRecordId > 0)
            {
                query = query.Where(x => x.MedicalRecordsId == tsearch.MedicalRecordId);
                return query;
            }
            return query;
        }
    }
}

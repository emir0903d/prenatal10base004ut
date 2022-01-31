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
    public class PartnerService : CRUDservice<Partner, PartnerSearchRequest, PartnerUpsertRequest, PartnerUpsertRequest, Partners>
    {
        public PartnerService(Context context, IMapper mapper) : base(context, mapper)
        {
        }

        protected internal override IQueryable<Partners> ApplyFilter(IQueryable<Partners> query, PartnerSearchRequest tsearch)
        {
            if (tsearch == null || tsearch.MedicalRecordId <= 0) return query;

            query = query.Where(x => x.MedicalRecordsId == tsearch.MedicalRecordId);
            return query;
            
        }
    }
}

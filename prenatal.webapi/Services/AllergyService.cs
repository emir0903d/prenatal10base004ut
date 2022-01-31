using AutoMapper;
using Microsoft.AspNetCore.Mvc.Filters;
using prenatal.model;
using prenatal.model.Requests;
using prenatal.webapi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public class AllergyService 
        : CRUDservice<Allergy, AllergySearchRequest, AllergyUpsertRequest, AllergyUpsertRequest, Allergies>
    {
        public AllergyService(Context context, IMapper mapper) : base(context, mapper)
        {
        }
        internal protected override IQueryable<Allergies> ApplyFilter(IQueryable<Allergies> query, AllergySearchRequest tsearch)
        {
            if (tsearch.MedicalRecordId!=0)
            {
                query = query.Where(x => x.MedicalRecordsId == tsearch.MedicalRecordId);
            }
            if (string.IsNullOrWhiteSpace(tsearch.Type) == false)
            {
                query = query.Where(x => tsearch.Type.Contains(x.Type));
            }
            
            return query;
        }
    }
}

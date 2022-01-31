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
    public class UltrasoundService : CRUDservice<Ultrasound, UltrasoundSearchRequest, UltrasoundUpsertRequest, UltrasoundUpsertRequest, Ultrasounds>
    {
        public UltrasoundService(Context context, IMapper mapper) : base(context, mapper)
        {
        }
        internal protected override IQueryable<Ultrasounds> ApplyFilter(IQueryable<Ultrasounds> query, UltrasoundSearchRequest tsearch)
        {
            if (tsearch.MedicalRecordId != 0)
            {
                query = query.Where(x => x.MedicalRecordsId == tsearch.MedicalRecordId);
            }

            return query;
        }
    }
}

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
    public class PhotoService : CRUDservice<Photo, PhotoSearchRequest, PhotoUpsertRequest, PhotoUpsertRequest, Photos>
    {
        public PhotoService(Context context, IMapper mapper) : base(context, mapper)
        {
        }

        protected internal override IQueryable<Photos> ApplyFilter(IQueryable<Photos> query, PhotoSearchRequest tsearch)
        {
            if (tsearch.MedicalRecordId != 0)
            {
                query = query.Where(x => x.MedicalRecordsId == tsearch.MedicalRecordId);
            }
            return query;
        }
    }
}

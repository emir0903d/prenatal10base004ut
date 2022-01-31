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
    public class FileService : CRUDservice<File, FileSearchRequest, FileUpsertRequest, FileUpsertRequest, Files>
    {
        public FileService(Context context, IMapper mapper) : base(context, mapper)
        {
        }

        protected internal override IQueryable<Files> ApplyFilter(IQueryable<Files> query, FileSearchRequest tsearch)
        {
            if(tsearch!=null && tsearch.MedicalRecordId > 0)
            {
                query = query.Where(x => x.MedicalRecordsId == tsearch.MedicalRecordId);
                return query;
            }
            return query;
        }
    }
}

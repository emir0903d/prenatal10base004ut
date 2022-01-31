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
    public class AppointmentService : CRUDservice<Appointment, SearchAppointmentRequest, AppointmentUpsertRequest, AppointmentUpsertRequest, Appointments>
    {
        public AppointmentService(Context context, IMapper mapper) : base(context, mapper)
        {
        }
        internal protected override IQueryable<Appointments> ApplyFilter(IQueryable<Appointments> query, SearchAppointmentRequest tsearch)
        {
            if (tsearch.date!=null)
            {
                query = query.Where(x => x.Date.Year==tsearch.date.Value.Year && x.Date.Month==tsearch.date.Value.Month && x.Date.Day==tsearch.date.Value.Day);
            }
            if (tsearch._docId != null)
            {
                query = query.Where(x => x.DoctorId == tsearch._docId);
            }
            if (tsearch._patientId != null)
            {
                query = query.Where(x => x.PatientId == tsearch._patientId);
            }
            return query;
        }
    }
}

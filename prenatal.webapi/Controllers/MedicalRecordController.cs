using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prenatal.model;
using prenatal.model.Requests;
using prenatal.webapi.Database;
using prenatal.webapi.Filters;
using prenatal.webapi.Services;

namespace prenatal.webapi.Controllers
{
    public class MedicalRecordController
        : CRUDController<MedicalRecord, object, MedicalRecordUpsertRequest, MedicalRecordUpsertRequest, MedicalRecords>
    {
        public MedicalRecordController(ICRUDservice<MedicalRecord, object, MedicalRecordUpsertRequest, MedicalRecordUpsertRequest, MedicalRecords> baseService) : base(baseService)
        {
        }
    }
}
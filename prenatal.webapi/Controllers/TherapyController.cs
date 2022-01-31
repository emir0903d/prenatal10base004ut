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

    public class TherapyController
        : CRUDController<Therapy, SearchTherapiesRequest, TherapyUpsertRequest, TherapyUpsertRequest, Therapies>
    {
        public TherapyController(ICRUDservice<Therapy, SearchTherapiesRequest, TherapyUpsertRequest, TherapyUpsertRequest, Therapies> baseService) : base(baseService)
        {
        }
    }
}
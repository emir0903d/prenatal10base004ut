using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using prenatal.model;
using prenatal.model.Requests;
using prenatal.webapi.Controllers;
using prenatal.webapi.Database;
using prenatal.webapi.Filters;
using prenatal.webapi.Mapper;
using prenatal.webapi.Security;
using prenatal.webapi.Services;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace prenatal.webapi
{
    public class AuthOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var isAuthorized = context.MethodInfo.DeclaringType.GetCustomAttributes(true).OfType<AuthorizeAttribute>().Any() ||
                               context.MethodInfo.GetCustomAttributes(true).OfType<AuthorizeAttribute>().Any();
            if (isAuthorized==false) return;

            

            operation.Responses.TryAdd("401", new OpenApiResponse { Description = "Unauthorized" });
            operation.Responses.TryAdd("403", new OpenApiResponse { Description = "Forbidden" });
            var basicSecurityScheme = new OpenApiSecurityScheme()
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basic" },
                Type=SecuritySchemeType.Http
            };
            operation.Security.Add(new OpenApiSecurityRequirement()
            {
                [basicSecurityScheme] = new string[] { }
            });
        }
    }

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>
                    ("BasicAuthentication", null);

            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Latest)
            .AddNewtonsoftJson(o=>o.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter()));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()); //This line

                c.AddSecurityDefinition("basic",
                    new OpenApiSecurityScheme()
                    {
                        Name = "Authorization",
                        Type = SecuritySchemeType.Http,
                        Scheme = "basic",
                        In = ParameterLocation.Header,
                        Description = "Basic authentication header"
                    });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });
                c.OperationFilter<AuthOperationFilter>();
            });
            //services.AddSwaggerGen();//swagger registration
            services.AddAutoMapper(typeof(Startup));//mapper config - easy!         

            var connection = Configuration.GetConnectionString("prenatal_db");
            services.AddDbContext<Context>(options => options.UseLazyLoadingProxies().UseSqlServer(connection));

            //servis je implementiran putem mrservice clase

            //
            //services.AddScoped<ICRUDservice<Allergy, AllergySearchRequest,AllergyUpsertRequest,AllergyUpsertRequest, Allergies>, CRUDservice<Allergy, AllergySearchRequest,AllergyUpsertRequest,AllergyUpsertRequest,Allergies>>();  
            services.AddScoped<ICRUDservice<Allergy, AllergySearchRequest, AllergyUpsertRequest, AllergyUpsertRequest, Allergies>, AllergyService>();
            //services.AddScoped<IAllergyService, AllergyService>();


            //services.AddScoped<ICRUDservice<Appointment, object, AppointmentUpsertRequest, AppointmentUpsertRequest, Appointments>, CRUDservice<Appointment, object, AppointmentUpsertRequest, AppointmentUpsertRequest, Appointments>>();        
            services.AddScoped<ICRUDservice<Appointment, SearchAppointmentRequest, AppointmentUpsertRequest, AppointmentUpsertRequest, Appointments>, AppointmentService>();
            services.AddScoped<ICRUDservice<BirthExpected, object, BirthExpectedUpsertRequest, BirthExpectedUpsertRequest,ExpectedBirth>, BirthExpectedService>();
            services.AddScoped<ICRUDservice<BloodExamination, object, BloodExaminationUpsertRequest, BloodExaminationUpsertRequest, BloodExaminations>, CRUDservice<BloodExamination, object, BloodExaminationUpsertRequest, BloodExaminationUpsertRequest, BloodExaminations>>();
            services.AddScoped<ICRUDservice<CoombsTest, object, CoombsTestUpsertRequest, CoombsTestUpsertRequest,CoombsTests>, CRUDservice<CoombsTest, object, CoombsTestUpsertRequest, CoombsTestUpsertRequest, CoombsTests>>();
            
            services.AddScoped<ICRUDservice<File, FileSearchRequest, FileUpsertRequest, FileUpsertRequest, Files>, FileService>();
            //services.AddScoped<ICRUDservice<File, object, FileUpsertRequest, FileUpsertRequest,Files>, CRUDservice<File, object, FileUpsertRequest, FileUpsertRequest, Files>>();

            services.AddScoped<ICRUDservice<GlucoseTest, GlucoseTestSearchRequest, GlucoseTestUpsertRequest, GlucoseTestUpsertRequest, GlucoseTests>, GlucoseTestService>();
            //services.AddScoped<ICRUDservice<GlucoseTest, object, GlucoseTestUpsertRequest, GlucoseTestUpsertRequest, GlucoseTests>, CRUDservice<GlucoseTest, object, GlucoseTestUpsertRequest, GlucoseTestUpsertRequest, GlucoseTests>>();

            services.AddScoped<ICRUDservice<MedicalHistory, MedicalHistorySearchRequest, MedicalHistoryUpsertRequest, MedicalHistoryUpsertRequest, MedicalHistories>, MedicalHistoryService>();
            //services.AddScoped<ICRUDservice<MedicalHistory, object, MedicalHistoryUpsertRequest, MedicalHistoryUpsertRequest, MedicalHistories>, CRUDservice<MedicalHistory, object, MedicalHistoryUpsertRequest, MedicalHistoryUpsertRequest, MedicalHistories>>();

            services.AddScoped<ICRUDservice<MedicalRecord, object, MedicalRecordUpsertRequest, MedicalRecordUpsertRequest, MedicalRecords>, CRUDservice<MedicalRecord, object, MedicalRecordUpsertRequest, MedicalRecordUpsertRequest, MedicalRecords>>();
            
            services.AddScoped<ICRUDservice<Partner, PartnerSearchRequest, PartnerUpsertRequest, PartnerUpsertRequest, Partners>, PartnerService>();
            //services.AddScoped<ICRUDservice<Partner, object, PartnerUpsertRequest, PartnerUpsertRequest, Partners>, CRUDservice<Partner, object, PartnerUpsertRequest, PartnerUpsertRequest, Partners>>();

            services.AddScoped<ICRUDservice<Photo, PhotoSearchRequest, PhotoUpsertRequest, PhotoUpsertRequest, Photos>, PhotoService>();
            //services.AddScoped<ICRUDservice<Photo, object, PhotoUpsertRequest, PhotoUpsertRequest, Photos>, CRUDservice<Photo, object, PhotoUpsertRequest, PhotoUpsertRequest, Photos>>();

            services.AddScoped<ICRUDservice<PregnancyLoss, PregnancyLossSearchRequest, PregnancyLossUpsertRequest, PregnancyLossUpsertRequest, PregnanciesLoss>, LostPregnancyService>();
            //services.AddScoped<ICRUDservice<PregnancyLoss, object, PregnancyLossUpsertRequest, PregnancyLossUpsertRequest, PregnanciesLoss>, CRUDservice<PregnancyLoss, object, PregnancyLossUpsertRequest, PregnancyLossUpsertRequest, PregnanciesLoss>>();

            //services.AddScoped<ICRUDservice<Prescription, object, PrescriptionUpsertRequest, PrescriptionUpsertRequest, Prescriptions>, CRUDservice<Prescription, object, PrescriptionUpsertRequest, PrescriptionUpsertRequest, Prescriptions>>();
            services.AddScoped<ICRUDservice<Prescription, PrescriptionSearchRequest, PrescriptionUpsertRequest, PrescriptionUpsertRequest, Prescriptions>, PrescriptionService>();

            //services.AddScoped<ICRUDservice<PreviousPregnancy, object, PreviousPregnancyUpsertRequest, PreviousPregnancyUpsertRequest, PreviousPregnancies>, CRUDservice<PreviousPregnancy, object, PreviousPregnancyUpsertRequest, PreviousPregnancyUpsertRequest, PreviousPregnancies>>();
            services.AddScoped<ICRUDservice<PreviousPregnancy, PreviousPregnancySearchRequest, PreviousPregnancyUpsertRequest, PreviousPregnancyUpsertRequest, PreviousPregnancies>, PreviousPregnancyService>();

            //services.AddScoped<ICRUDservice<Referral, object, ReferralUpsertRequest, ReferralUpsertRequest,Referrals>, CRUDservice<Referral, object, ReferralUpsertRequest, ReferralUpsertRequest, Referrals>>();
            services.AddScoped<ICRUDservice<Referral, ReferralSearchRequest, ReferralUpsertRequest, ReferralUpsertRequest, Referrals>, ReferralService>();


            services.AddScoped<ICRUDservice<Role, SearchRoleRequest, RoleUpsertRequest, RoleUpsertRequest, Roles>, RoleService>();

            //services.AddScoped<ICRUDservice<SubstanceUse, object, SubstanceUseUpsertRequest, SubstanceUseUpsertRequest, SubstancesUse>, CRUDservice<SubstanceUse, object, SubstanceUseUpsertRequest, SubstanceUseUpsertRequest, SubstancesUse>>();
            services.AddScoped<ICRUDservice<SubstanceUse, SearchSubstancesRequest, SubstanceUseUpsertRequest, SubstanceUseUpsertRequest, SubstancesUse>, SubstancesUsedService>();


            //services.AddScoped<ICRUDservice<Therapy, object, TherapyUpsertRequest, TherapyUpsertRequest,Therapies>, CRUDservice<Therapy, object, TherapyUpsertRequest, TherapyUpsertRequest, Therapies>>();
            services.AddScoped<ICRUDservice<Therapy, SearchTherapiesRequest, TherapyUpsertRequest, TherapyUpsertRequest, Therapies>, TherapyService>();

            //services.AddScoped<ICRUDservice<Ultrasound, object, UltrasoundUpsertRequest, UltrasoundUpsertRequest, Ultrasounds>, CRUDservice<Ultrasound, object, UltrasoundUpsertRequest, UltrasoundUpsertRequest, Ultrasounds>>();
            services.AddScoped<ICRUDservice<Ultrasound, UltrasoundSearchRequest, UltrasoundUpsertRequest, UltrasoundUpsertRequest, Ultrasounds>, UltrasoundService>();


            services.AddScoped<ICRUDservice<UrineExamination, object, UrineExaminationUpsertRequest, UrineExaminationUpsertRequest,UrineExaminations>, CRUDservice<UrineExamination, object, UrineExaminationUpsertRequest, UrineExaminationUpsertRequest, UrineExaminations>>();
                        
            services.AddScoped<ICRUDservice<User, SearchUsersRequest, UserUpsertRequest, UserUpsertRequest, Users>, UserService>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IDatabaseService, DatabaseService>();

            services.AddScoped<IUserRoleService, UserRoleService>();
            services.AddScoped<IRoleService, RoleService>();

            services.AddScoped<ICRUDservice<UserRole, SearchUserRoleRequest, UserRoleUpsertRequest, UserRoleUpsertRequest, UsersRoles>, UserRoleService>();


            //services.AddScoped<ICRUDservice<VitalSign, object, VitalSignUpsertRequest, VitalSignUpsertRequest, VitalSigns>, CRUDservice<VitalSign, object, VitalSignUpsertRequest, VitalSignUpsertRequest, VitalSigns>>();
            services.AddScoped<ICRUDservice<VitalSign, VitalSignSearchRequest, VitalSignUpsertRequest, VitalSignUpsertRequest, VitalSigns>, VitalSignService>();


            services.AddScoped<IAuthenticateService, AuthenticateService>();
            services.AddScoped<IRegisterService, RegisterService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IPredictService, PredictService>();
            services.AddScoped<ITwoFactorAuthService, TwoFactorAuthService>();
            //DI->>
            //tri nivoa ->
            //scoped - dok traje sam request instanca zivi
            //transient - da bilo ko ko trazi ovaj servis dobice novu instancu servisa
            //singleton - dok zivi aplikacija
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("./v1/swagger.json", "My API V1"); //originally "./swagger/v1/swagger.json"
                
                //c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

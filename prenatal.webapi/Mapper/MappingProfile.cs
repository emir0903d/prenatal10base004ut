using AutoMapper;
using prenatal.model;
using prenatal.model.Requests;
using prenatal.webapi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace prenatal.webapi.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Allergy, AllergyUpsertRequest>().ReverseMap();
            CreateMap<Allergies, AllergyUpsertRequest>().ReverseMap();
            CreateMap<Allergies, Allergy>().ReverseMap();

            CreateMap<Users, User>().ReverseMap();
            //CreateMap<Users, UserUpsertRequest>().ForAllMembers(x => x.Condition((source, target, sourceValue, targetValue) => sourceValue != null));
            //CreateMap<UserUpsertRequest, Users>().ForAllMembers(x => x.Condition((source, target, sourceValue, targetValue) => sourceValue != null ));
            CreateMap<UserUpsertRequest, Users>().ForMember(x => x.DoctorId, o => o.AllowNull()).ForAllOtherMembers(x => x.Condition((source, target, sourceValue, targetValue) => sourceValue != null));
            CreateMap<User, UserUpsertRequest>().ReverseMap();
            CreateMap<UserRegisterRequest, Users>().ForAllMembers(x => x.Condition((source, target, sourceValue, targetValue) => sourceValue != null));

            //CreateMap<Users, Appointment>();
            CreateMap<Appointment, AppointmentUpsertRequest>().ReverseMap();
            CreateMap<Appointments, AppointmentUpsertRequest>().ReverseMap();
            CreateMap<Appointments, Appointment>()
                .ForMember(x => x.Patient, o => o.MapFrom(y => y.Patient))
                .ForMember(x => x.Doctor, o => o.MapFrom(y => y.Doctor))
                .ForAllOtherMembers(x => x.Condition((source, target, sourceValue, targetValue) => sourceValue != null));

            CreateMap<ExpectedBirth, BirthExpected>().ReverseMap();
            CreateMap<BirthExpected, BirthExpectedUpsertRequest>().ReverseMap();
            CreateMap<ExpectedBirth, BirthExpectedUpsertRequest>().ReverseMap();

            CreateMap<BloodExaminations, BloodExamination>().ReverseMap();
            CreateMap<BloodExaminations, BloodExaminationUpsertRequest>().ReverseMap();
            CreateMap<BloodExamination, BloodExaminationUpsertRequest>().ReverseMap();

            CreateMap<CoombsTests, CoombsTest>().ReverseMap();
            CreateMap<CoombsTests, CoombsTestUpsertRequest>().ReverseMap();
            CreateMap<CoombsTest, CoombsTestUpsertRequest>().ReverseMap();

            CreateMap<Files, File>().ForMember(dest => dest.Id, o => o.MapFrom(src => src.FileId)).ReverseMap();
            CreateMap<Files, FileUpsertRequest>().ForMember(dest => dest.Id, o => o.MapFrom(src => src.FileId)).ReverseMap();
            
            CreateMap<File, FileUpsertRequest>().ReverseMap();

            CreateMap<GlucoseTests, GlucoseTest>().ReverseMap();
            CreateMap<GlucoseTestUpsertRequest, GlucoseTests>().ForAllMembers(x => x.Condition((source, target, sourceValue, targetValue) => sourceValue != null));
            CreateMap<GlucoseTest, GlucoseTestUpsertRequest>().ReverseMap();

            CreateMap<MedicalHistories, MedicalHistory>().ReverseMap();
            CreateMap<MedicalHistory, MedicalHistoryUpsertRequest>().ReverseMap();
            CreateMap<MedicalHistoryUpsertRequest, MedicalHistories>().ReverseMap();

            CreateMap<MedicalRecords, MedicalRecord>().ReverseMap();
            //CreateMap<MedicalRecords, MedicalRecordUpsertRequest>().ForMember(x => x.Id, o => o.Ignore()).ForAllOtherMembers(x => x.Condition((source, target, sourceValue, targetValue) => sourceValue != null));
            //CreateMap<MedicalRecordUpsertRequest, MedicalRecords>().ForMember(x => x.Id, o => o.Ignore()).ForAllOtherMembers(x => x.Condition((source, target, sourceValue, targetValue) => sourceValue != null));
            CreateMap<MedicalRecordUpsertRequest, MedicalRecords>().ForAllMembers(x => x.Condition((source, target, sourceValue, targetValue) => sourceValue != null));


            //CreateMap<MedicalRecords, MedicalRecordUpsertRequest>().ReverseMap();
            //CreateMap<MedicalRecord, MedicalRecordUpsertRequest>().ReverseMap();

            CreateMap<Partners, Partner>().ReverseMap();
            CreateMap<Partners, PartnerUpsertRequest>().ReverseMap();
            CreateMap<Partner, PartnerUpsertRequest>().ReverseMap();

            CreateMap<Photos, Photo>().ReverseMap();
            CreateMap<Photos, PhotoUpsertRequest>().ReverseMap();
            CreateMap<Photo, PhotoUpsertRequest>().ReverseMap();

            CreateMap<PregnanciesLoss, PregnancyLoss>().ForMember(dest => dest.Date, o => o.MapFrom(src => src.PregnancyLossDate))
                .ForMember(dest => dest.Id, o => o.MapFrom(src => src.PregnancyLossHistoryId))
                .ReverseMap();
            CreateMap<PregnanciesLoss, PregnancyLossUpsertRequest>().ForMember(dest => dest.Date, o => o.MapFrom(src => src.PregnancyLossDate))
                .ForMember(dest => dest.Id, o => o.MapFrom(src => src.PregnancyLossHistoryId))
                .ReverseMap();
            CreateMap<PregnancyLossUpsertRequest, PregnanciesLoss>().ForMember(dest => dest.PregnancyLossDate, o => o.MapFrom(src => src.Date))
                .ForMember(dest => dest.PregnancyLossHistoryId, o => o.MapFrom(src => src.Id))
                .ReverseMap();
            CreateMap<PregnancyLoss, PregnancyLossUpsertRequest>().ForMember(dest => dest.Date, o => o.MapFrom(src => src.Date))
                .ForMember(dest => dest.Id, o => o.MapFrom(src => src.Id))
                .ReverseMap();

            CreateMap<Prescriptions, Prescription>().ReverseMap();
            CreateMap<Prescriptions, PrescriptionUpsertRequest>().ReverseMap();
            CreateMap<Prescription, PrescriptionUpsertRequest>().ReverseMap();

            CreateMap<PreviousPregnancies, PreviousPregnancy>().ReverseMap();
            CreateMap<PreviousPregnancies, PreviousPregnancyUpsertRequest>().ReverseMap();
            CreateMap<PreviousPregnancy, PreviousPregnancyUpsertRequest>().ReverseMap();

            CreateMap<Referrals, Referral>().ReverseMap();
            CreateMap<Referrals, ReferralUpsertRequest>().ReverseMap();
            CreateMap<Referral, ReferralUpsertRequest>().ReverseMap();

            CreateMap<Roles, Role>().ReverseMap();
            CreateMap<Roles, RoleUpsertRequest>().ReverseMap();
            CreateMap<Roles, RoleUpsertRequest>().ReverseMap();

            CreateMap<SubstancesUse, SubstanceUse>().ReverseMap();
            CreateMap<SubstancesUse, SubstanceUseUpsertRequest>().ReverseMap();
            CreateMap<SubstanceUse, SubstanceUseUpsertRequest>().ReverseMap();

            CreateMap<Therapies, Therapy>().ReverseMap();
            CreateMap<Therapies, TherapyUpsertRequest>().ReverseMap();
            CreateMap<Therapy, TherapyUpsertRequest>().ReverseMap();

            CreateMap<Ultrasounds, Ultrasound>().ReverseMap();
            CreateMap<Ultrasounds, UltrasoundUpsertRequest>().ReverseMap();
            CreateMap<Ultrasound, UltrasoundUpsertRequest>().ReverseMap();

            CreateMap<UrineExaminations, UrineExamination>().ReverseMap();
            CreateMap<UrineExaminations, UrineExaminationUpsertRequest>().ReverseMap();
            CreateMap<UrineExamination, UrineExaminationUpsertRequest>().ReverseMap();



            CreateMap<UsersRoles, UserRole>().ReverseMap();
            CreateMap<UsersRoles, UserRoleUpsertRequest>().ReverseMap();
            CreateMap<UserRole, UserRoleUpsertRequest>().ReverseMap();

            CreateMap<VitalSigns, VitalSign>().ReverseMap();
            CreateMap<VitalSigns, VitalSignUpsertRequest>().ReverseMap();
            CreateMap<VitalSign, VitalSignUpsertRequest>().ReverseMap();
        }
    }
}

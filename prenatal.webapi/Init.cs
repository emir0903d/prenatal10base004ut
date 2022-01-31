using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using prenatal.model;
using prenatal.model.Enumerations;
using prenatal.model.Requests;
using prenatal.webapi.Database;
using prenatal.webapi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2
{
    public class Init
    {
        public static void Assign(IAuthenticateService authenticateService, IDatabaseService databaseService)
        {
            //Adding admin account
            if (databaseService.IsUsername("admin") == false)
            {
                Users admin = new Users() { 
                Name="admin",
                Surname="admin",
                Username="admin",  
                Type=UserType.Type.Admin,
                Status=UserStatus.Status.Approved,
                Registration=DateTime.Now,
                Email="admin@prental.ba",
                Gender="Female",
                PhoneNumber="+38762448015"
                };
                admin.PasswordSalt = authenticateService.GenerateSalt();
                admin.PasswordHash = authenticateService.GenerateHash(admin.PasswordSalt, "admin");

                databaseService.InsertUser(admin);

            }
            if (databaseService.IsRole("admin")==false)
            {
                Roles role = new Roles()
                {
                    Name = "admin",
                    NumberOfUsers = 0

                };
                databaseService.InsertRole(role);
            }
            
            if (databaseService.IsUserInRole("admin", "admin")==false)
            {
                databaseService.InsertUserInRole("admin", "admin");
            }


            //Adding doctor account
            if (databaseService.IsUsername("doctor") == false)
            {
                Users usr = new Users()
                {
                    Name = "Doctor",
                    Surname = "Doctor",
                    Username = "doctor",
                    Type = UserType.Type.Doctor,
                    Status = UserStatus.Status.Approved,
                    Registration = DateTime.Now,
                    Email = "doctor@prental.ba",
                    Gender = "Female",
                    PhoneNumber = "+38761727745"
                };
                usr.PasswordSalt = authenticateService.GenerateSalt();
                usr.PasswordHash = authenticateService.GenerateHash(usr.PasswordSalt, "doctor");

                databaseService.InsertUser(usr);

            }
            if (databaseService.IsRole("doctor") == false)
            {
                Roles role = new Roles()
                {
                    Name = "doctor",
                    NumberOfUsers = 0

                };
                databaseService.InsertRole(role);
            }

            if (databaseService.IsUserInRole("doctor", "doctor") == false)
            {
                databaseService.InsertUserInRole("doctor", "doctor");
            }

            //Adding a patient account
            if (databaseService.IsUsername("patient") == false)
            {
                var myDocId = databaseService.GetUserId("doctor");

                Users usr = new Users()
                {
                    Name = "Patient",
                    Surname = "Patient",
                    Username = "patient",
                    Type = UserType.Type.Patient,
                    Status = UserStatus.Status.Approved,
                    Registration = DateTime.Now,
                    Email = "patient@prental.ba",
                    Gender = "Female",
                    PhoneNumber = "+38760727745",
                    DoctorId = myDocId,
                    HasMR=false
                };
                usr.PasswordSalt = authenticateService.GenerateSalt();
                usr.PasswordHash = authenticateService.GenerateHash(usr.PasswordSalt, "patient");

                databaseService.InsertUser(usr);

            }
            if (databaseService.IsRole("patient") == false)
            {
                Roles role = new Roles()
                {
                    Name = "patient",
                    NumberOfUsers = 0

                };
                databaseService.InsertRole(role);
            }

            if (databaseService.IsUserInRole("patient", "patient") == false)
            {
                databaseService.InsertUserInRole("patient", "patient");
            }

            
            bool patientHasMR = databaseService.HasPatientMRN("patient");
            if (patientHasMR == false)
            {
                int myPatientId = databaseService.GetUserId("patient");
                MedicalRecords mr = new MedicalRecords()
                {
                    Id=myPatientId,
                    MedicalRecordNumber="MRN0001",
                    MaidenName="XXX",
                    BirthDate=Convert.ToDateTime("1983-01-01"),
                    BloodType="A",
                    RHFactor="-",
                    MartialStatus="Single",
                    PersonalIdentificationNumber="111111111111"
                };

                databaseService.InsertMR(mr);
                databaseService.SetHasMR("patient");
            }

            //databaseService.DisposeConn();
                                  
        }               
    }
}

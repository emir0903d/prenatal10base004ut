using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace prenatal.webapi.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    NumberOfUsers = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    DoctorId = table.Column<int>(nullable: true),
                    LoginCount = table.Column<int>(nullable: false),
                    Registration = table.Column<DateTime>(nullable: false),
                    LastLogin = table.Column<DateTime>(nullable: false),
                    HasMR = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
                    PatientId = table.Column<int>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Users_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Appointments_Users_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    MedicalRecordNumber = table.Column<string>(maxLength: 15, nullable: false),
                    MaidenName = table.Column<string>(maxLength: 30, nullable: true),
                    PersonalIdentificationNumber = table.Column<string>(maxLength: 13, nullable: false),
                    MartialStatus = table.Column<string>(maxLength: 15, nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BloodType = table.Column<string>(maxLength: 2, nullable: false),
                    RHFactor = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UsersRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Change = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UsersRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Allergies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(maxLength: 100, nullable: false),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Allergies_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoombsTests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    TypeOfTest = table.Column<int>(nullable: false),
                    Result = table.Column<bool>(nullable: false),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoombsTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoombsTests_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpectedBirth",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastMenstrualDate = table.Column<DateTime>(nullable: false),
                    ExpectedDate = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpectedBirth", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpectedBirth_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    FileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Type = table.Column<string>(maxLength: 100, nullable: true),
                    Data = table.Column<byte[]>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.FileId);
                    table.ForeignKey(
                        name: "FK_Files_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GlucoseTests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfTest = table.Column<int>(nullable: false),
                    Units = table.Column<string>(nullable: true),
                    Results = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlucoseTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GlucoseTests_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Diagnosis = table.Column<string>(maxLength: 100, nullable: true),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalHistories_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    Surname = table.Column<string>(maxLength: 30, nullable: false),
                    BloodType = table.Column<string>(maxLength: 2, nullable: true),
                    RHFactor = table.Column<string>(maxLength: 1, nullable: true),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partners_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 255, nullable: true),
                    Data = table.Column<byte[]>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PregnanciesLoss",
                columns: table => new
                {
                    PregnancyLossHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PregnancyLossDate = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(maxLength: 30, nullable: true),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PregnanciesLoss", x => x.PregnancyLossHistoryId);
                    table.ForeignKey(
                        name: "FK_PregnanciesLoss_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Dose = table.Column<string>(nullable: true),
                    Usage = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescriptions_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreviousPregnancies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PregnancyDate = table.Column<DateTime>(nullable: false),
                    GestationWeeks = table.Column<int>(nullable: false),
                    DeliveryType = table.Column<string>(maxLength: 30, nullable: true),
                    Complications = table.Column<string>(maxLength: 255, nullable: true),
                    Outcome = table.Column<string>(maxLength: 50, nullable: true),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreviousPregnancies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreviousPregnancies_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Referrals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Facility = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referrals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referrals_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubstancesUse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 30, nullable: true),
                    PriorToPregnancy = table.Column<bool>(nullable: false),
                    StillUsing = table.Column<bool>(nullable: false),
                    NumberOfYears = table.Column<int>(nullable: false),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubstancesUse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubstancesUse_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Therapies",
                columns: table => new
                {
                    TherapiesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginningDate = table.Column<DateTime>(nullable: false),
                    EndingDate = table.Column<DateTime>(nullable: false),
                    Medicaments = table.Column<string>(maxLength: 100, nullable: true),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapies", x => x.TherapiesId);
                    table.ForeignKey(
                        name: "FK_Therapies_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ultrasounds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    HeartBeats = table.Column<int>(nullable: false),
                    Movement = table.Column<bool>(nullable: false),
                    Length = table.Column<float>(nullable: false),
                    NuchalScan = table.Column<bool>(nullable: false),
                    Anomalies = table.Column<bool>(nullable: false),
                    HeadDiameter = table.Column<float>(nullable: false),
                    HeadCircumference = table.Column<float>(nullable: false),
                    AbdominalCircumference = table.Column<float>(nullable: false),
                    FemurLength = table.Column<float>(nullable: false),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ultrasounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ultrasounds_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VitalSigns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Temperature = table.Column<float>(nullable: false),
                    SystolicPressure = table.Column<int>(nullable: false),
                    DiastolicPressure = table.Column<int>(nullable: false),
                    HeartBeats = table.Column<int>(nullable: false),
                    RespiratoryRate = table.Column<int>(nullable: false),
                    Height = table.Column<float>(nullable: false),
                    Weight = table.Column<float>(nullable: false),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
                    MedicalRecordsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VitalSigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VitalSigns_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BloodExaminations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Results = table.Column<double>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    BloodTest = table.Column<string>(maxLength: 50, nullable: false),
                    Unit = table.Column<string>(maxLength: 10, nullable: false),
                    Low = table.Column<double>(nullable: false),
                    High = table.Column<double>(nullable: false),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
                    ReferralsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodExaminations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BloodExaminations_Referrals_ReferralsId",
                        column: x => x.ReferralsId,
                        principalTable: "Referrals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UrineExaminations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Results = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    UrineTest = table.Column<string>(maxLength: 50, nullable: false),
                    Unit = table.Column<string>(maxLength: 10, nullable: false),
                    ReferenceInterval = table.Column<string>(nullable: false),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
                    ReferralsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrineExaminations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UrineExaminations_Referrals_ReferralsId",
                        column: x => x.ReferralsId,
                        principalTable: "Referrals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Allergies_MedicalRecordsId",
                table: "Allergies",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodExaminations_ReferralsId",
                table: "BloodExaminations",
                column: "ReferralsId");

            migrationBuilder.CreateIndex(
                name: "IX_CoombsTests_MedicalRecordsId",
                table: "CoombsTests",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpectedBirth_MedicalRecordsId",
                table: "ExpectedBirth",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_MedicalRecordsId",
                table: "Files",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_GlucoseTests_MedicalRecordsId",
                table: "GlucoseTests",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHistories_MedicalRecordsId",
                table: "MedicalHistories",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Partners_MedicalRecordsId",
                table: "Partners",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_MedicalRecordsId",
                table: "Photos",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_PregnanciesLoss_MedicalRecordsId",
                table: "PregnanciesLoss",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_MedicalRecordsId",
                table: "Prescriptions",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_PreviousPregnancies_MedicalRecordsId",
                table: "PreviousPregnancies",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Referrals_MedicalRecordsId",
                table: "Referrals",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubstancesUse_MedicalRecordsId",
                table: "SubstancesUse",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Therapies_MedicalRecordsId",
                table: "Therapies",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ultrasounds_MedicalRecordsId",
                table: "Ultrasounds",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_UrineExaminations_ReferralsId",
                table: "UrineExaminations",
                column: "ReferralsId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersRoles_RoleId",
                table: "UsersRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersRoles_UserId",
                table: "UsersRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VitalSigns_MedicalRecordsId",
                table: "VitalSigns",
                column: "MedicalRecordsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "BloodExaminations");

            migrationBuilder.DropTable(
                name: "CoombsTests");

            migrationBuilder.DropTable(
                name: "ExpectedBirth");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "GlucoseTests");

            migrationBuilder.DropTable(
                name: "MedicalHistories");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "PregnanciesLoss");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "PreviousPregnancies");

            migrationBuilder.DropTable(
                name: "SubstancesUse");

            migrationBuilder.DropTable(
                name: "Therapies");

            migrationBuilder.DropTable(
                name: "Ultrasounds");

            migrationBuilder.DropTable(
                name: "UrineExaminations");

            migrationBuilder.DropTable(
                name: "UsersRoles");

            migrationBuilder.DropTable(
                name: "VitalSigns");

            migrationBuilder.DropTable(
                name: "Referrals");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

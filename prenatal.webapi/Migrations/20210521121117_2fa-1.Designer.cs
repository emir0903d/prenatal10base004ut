// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using prenatal.webapi.Database;

namespace prenatal.webapi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210521121117_2fa-1")]
    partial class _2fa1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("prenatal.webapi.Database.Allergies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("prenatal.webapi.Database.Appointments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("prenatal.webapi.Database.BloodExaminations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloodTest")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("High")
                        .HasColumnType("float");

                    b.Property<double>("Low")
                        .HasColumnType("float");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("ReferralsId")
                        .HasColumnType("int");

                    b.Property<double?>("Results")
                        .HasColumnType("float");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("ReferralsId");

                    b.ToTable("BloodExaminations");
                });

            modelBuilder.Entity("prenatal.webapi.Database.CoombsTests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<bool>("Result")
                        .HasColumnType("bit");

                    b.Property<int>("TypeOfTest")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("CoombsTests");
                });

            modelBuilder.Entity("prenatal.webapi.Database.ExpectedBirth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpectedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastMenstrualDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("ExpectedBirth");
                });

            modelBuilder.Entity("prenatal.webapi.Database.Files", b =>
                {
                    b.Property<int>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Data")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("FileId");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("prenatal.webapi.Database.GlucoseTests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<int?>("Results")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfTest")
                        .HasColumnType("int");

                    b.Property<string>("Units")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("GlucoseTests");
                });

            modelBuilder.Entity("prenatal.webapi.Database.MedicalHistories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnosis")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("MedicalHistories");
                });

            modelBuilder.Entity("prenatal.webapi.Database.MedicalRecords", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BloodType")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("MaidenName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("MartialStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("MedicalRecordNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("PersonalIdentificationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("RHFactor")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("prenatal.webapi.Database.Partners", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloodType")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("RHFactor")
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("prenatal.webapi.Database.Photos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Data")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("prenatal.webapi.Database.PregnanciesLoss", b =>
                {
                    b.Property<int>("PregnancyLossHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("PregnancyLossDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("PregnancyLossHistoryId");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("PregnanciesLoss");
                });

            modelBuilder.Entity("prenatal.webapi.Database.Prescriptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("prenatal.webapi.Database.PreviousPregnancies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Complications")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("DeliveryType")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("GestationWeeks")
                        .HasColumnType("int");

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<string>("Outcome")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("PregnancyDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("PreviousPregnancies");
                });

            modelBuilder.Entity("prenatal.webapi.Database.Referrals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("Referrals");
                });

            modelBuilder.Entity("prenatal.webapi.Database.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfUsers")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("prenatal.webapi.Database.SubstancesUse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("NumberOfYears")
                        .HasColumnType("int");

                    b.Property<bool>("PriorToPregnancy")
                        .HasColumnType("bit");

                    b.Property<bool>("StillUsing")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("SubstancesUse");
                });

            modelBuilder.Entity("prenatal.webapi.Database.Therapies", b =>
                {
                    b.Property<int>("TherapiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginningDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<string>("Medicaments")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("TherapiesId");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("Therapies");
                });

            modelBuilder.Entity("prenatal.webapi.Database.Ultrasounds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AbdominalCircumference")
                        .HasColumnType("real");

                    b.Property<bool>("Anomalies")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("FemurLength")
                        .HasColumnType("real");

                    b.Property<float>("HeadCircumference")
                        .HasColumnType("real");

                    b.Property<float>("HeadDiameter")
                        .HasColumnType("real");

                    b.Property<int>("HeartBeats")
                        .HasColumnType("int");

                    b.Property<float>("Length")
                        .HasColumnType("real");

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<bool>("Movement")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<bool>("NuchalScan")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("Ultrasounds");
                });

            modelBuilder.Entity("prenatal.webapi.Database.UrineExaminations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("ReferenceInterval")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReferralsId")
                        .HasColumnType("int");

                    b.Property<string>("Results")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("UrineTest")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ReferralsId");

                    b.ToTable("UrineExaminations");
                });

            modelBuilder.Entity("prenatal.webapi.Database.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasMR")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoginCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registration")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("prenatal.webapi.Database.UsersRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Change")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersRoles");
                });

            modelBuilder.Entity("prenatal.webapi.Database.VitalSigns", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DiastolicPressure")
                        .HasColumnType("int");

                    b.Property<int>("HeartBeats")
                        .HasColumnType("int");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("RespiratoryRate")
                        .HasColumnType("int");

                    b.Property<int>("SystolicPressure")
                        .HasColumnType("int");

                    b.Property<float>("Temperature")
                        .HasColumnType("real");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("VitalSigns");
                });

            modelBuilder.Entity("prenatal.webapi.Database.Allergies", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.Appointments", b =>
                {
                    b.HasOne("prenatal.webapi.Database.Users", "Doctor")
                        .WithMany("DoctorAppointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("prenatal.webapi.Database.Users", "Patient")
                        .WithMany("PatientAppointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.BloodExaminations", b =>
                {
                    b.HasOne("prenatal.webapi.Database.Referrals", "Referrals")
                        .WithMany()
                        .HasForeignKey("ReferralsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.CoombsTests", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.ExpectedBirth", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.Files", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.GlucoseTests", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.MedicalHistories", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.MedicalRecords", b =>
                {
                    b.HasOne("prenatal.webapi.Database.Users", "Users")
                        .WithOne("MedicalRecords")
                        .HasForeignKey("prenatal.webapi.Database.MedicalRecords", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.Partners", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.Photos", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.PregnanciesLoss", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.Prescriptions", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.PreviousPregnancies", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.Referrals", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.SubstancesUse", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.Therapies", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.Ultrasounds", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.UrineExaminations", b =>
                {
                    b.HasOne("prenatal.webapi.Database.Referrals", "Referrals")
                        .WithMany()
                        .HasForeignKey("ReferralsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.UsersRoles", b =>
                {
                    b.HasOne("prenatal.webapi.Database.Roles", "Roles")
                        .WithMany("UsersRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("prenatal.webapi.Database.Users", "Users")
                        .WithMany("UsersRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("prenatal.webapi.Database.VitalSigns", b =>
                {
                    b.HasOne("prenatal.webapi.Database.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace prenatal.webapi.Database
{
    public class Context:DbContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Users>().HasOne(mr => mr.MedicalRecords).WithOne(u => u.Users)
                .HasForeignKey<MedicalRecords>(c => c.Id);
            
            modelBuilder.Entity<UsersRoles>()
                .HasOne(u => u.Users)
                .WithMany(r => r.UsersRoles)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<UsersRoles>()
                .HasOne(r => r.Roles)
                .WithMany(u => u.UsersRoles)
                .HasForeignKey(u => u.RoleId);

            modelBuilder.Entity<Appointments>(cfg =>
            {
                cfg.HasOne<Users>(p => p.Patient).WithMany(u => u.PatientAppointments).HasForeignKey(k => k.PatientId);
                cfg.HasOne<Users>(p => p.Doctor).WithMany(u => u.DoctorAppointments).HasForeignKey(k => k.DoctorId);
            });

            
        }
        
        public DbSet<Allergies> Allergies { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<BloodExaminations> BloodExaminations { get; set; }
        public DbSet<CoombsTests> CoombsTests { get; set; }
        public DbSet<ExpectedBirth> ExpectedBirth { get; set; }
        public DbSet<Files> Files { get; set; }
        public DbSet<GlucoseTests> GlucoseTests { get; set; }
        public DbSet<MedicalHistories> MedicalHistories { get; set; }
        public DbSet<MedicalRecords> MedicalRecords { get; set; }
        public DbSet<Partners> Partners { get; set; }
        public DbSet<Photos> Photos { get; set; }
        public DbSet<PregnanciesLoss> PregnanciesLoss { get; set; }
        public DbSet<Prescriptions> Prescriptions { get; set; }
        public DbSet<PreviousPregnancies> PreviousPregnancies { get; set; }
        public DbSet<Referrals> Referrals { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<SubstancesUse> SubstancesUse { get; set; }
        public DbSet<Therapies> Therapies { get; set; }
        public DbSet<Ultrasounds> Ultrasounds { get; set; }
        public DbSet<UrineExaminations> UrineExaminations { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UsersRoles> UsersRoles { get; set; }
        public DbSet<VitalSigns> VitalSigns { get; set; }

    }
}

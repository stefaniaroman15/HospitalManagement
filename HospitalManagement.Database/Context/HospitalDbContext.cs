using HospitalManagement.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Database.Context
{
    public class HospitalDbContext : DbContext // Am schimbat numele clasei pentru a corespunde numelui bazei de date
    {
        public DbSet<Patient> Patients { get; set; } // DbSet pentru entitatea Patients

        public DbSet<MedicalHistory> MedicalHistories { get; set; } // DbSet pentru entitatea MedicalHistory

        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definim relația între tabelele Patients și MedicalHistory
            modelBuilder.Entity<MedicalHistory>()
                .HasOne(mh => mh.Patient) // Un istoric medical aparține unui singur pacient
                .WithMany(p => p.MedicalHistories) // Un pacient poate avea mai multe istorice medicale
                .HasForeignKey(mh => mh.PatientId); // Cheia externă din MedicalHistory care face referire la Patients

            // Configurăm cheia primară pentru MedicalHistory
            modelBuilder.Entity<MedicalHistory>()
                .HasKey(mh => mh.HistoryId);

            // Configurăm cheia primară pentru Patients
            modelBuilder.Entity<Patient>()
                .HasKey(p => p.PatientId);
        }
    }
}

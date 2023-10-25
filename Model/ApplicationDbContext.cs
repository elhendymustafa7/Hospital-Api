global using Microsoft.EntityFrameworkCore;
global using Hospital_Api.Model;

namespace Hospital_Api.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>()
           .HasKey(d => d.Id);

            modelBuilder.Entity<Doctor>()
           .Property(d => d.SSN)
            .IsRequired();

            //=======================================

            modelBuilder.Entity<Procedure>()
                .HasIndex(p => p.Cost)
                .IsUnique();

            //=======================================

            modelBuilder.Entity<trained_in>()
                .HasKey(t => new { t.ProcedureID, t.DoctorID });

            modelBuilder.Entity<trained_in>()
               .HasOne(p => p.Doctor)
               .WithMany(p => p.trained_ins)
               .HasForeignKey(p => p.DoctorID)
               .HasPrincipalKey(a => a.Id).OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<trained_in>()
               .HasOne(p => p.Procedure)
               .WithMany(p => p.trained_ins)
               .HasForeignKey(p => p.ProcedureID)
               .HasPrincipalKey(a => a.Id).OnDelete(DeleteBehavior.Restrict);

            //=======================================

            modelBuilder.Entity<Patient>()
                .HasKey(p => p.SSN);


            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Doctor)
                .WithMany(p => p.Patients)
                .HasForeignKey(p => p.DoctorID)
                .HasPrincipalKey(a => a.Id).OnDelete(DeleteBehavior.Restrict);
            
            

            //=======================================

            modelBuilder.Entity<Nurse>()
                .HasKey(n => n.NurseID);

            modelBuilder.Entity<Nurse>()
                .HasIndex(n => n.SSN)
                .IsUnique();

            //=======================================

            modelBuilder.Entity<Appointment>()
               .HasKey(n => n.AppointmentID);

            modelBuilder.Entity<Appointment>()
              .HasOne(a => a.Patient)
              .WithMany(a => a.appointments)
              .HasForeignKey(a => a.PatientID)
              .HasPrincipalKey(a => a.SSN).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Appointment>()
              .HasOne(a => a.nurse)
              .WithMany(a => a.appointments)
              .HasForeignKey(a => a.PreNurseID)
              .HasPrincipalKey(a => a.NurseID).OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<Appointment>()
              .HasOne(a => a.doctor)
              .WithMany(a => a.appointments)
              .HasForeignKey(a => a.DoctorID)
              .HasPrincipalKey(a => a.Id).OnDelete(DeleteBehavior.Restrict);

            //=======================================

            modelBuilder.Entity<Medication>()
                .HasKey(m => m.Code);

            //=======================================

            modelBuilder.Entity<Prescribe>()
                .HasKey(p => new { p.DoctorID, p.PatientID, p.MedicationID, p.Date });

            modelBuilder.Entity<Prescribe>()
                .HasOne(p => p.doctor)
                .WithMany(p => p.prescribes)
                .HasForeignKey(p => p.DoctorID)
                .HasPrincipalKey(p => p.Id).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Prescribe>()
                .HasOne(p => p.medication)
                .WithMany(p => p.prescribes)
                .HasForeignKey(p => p.MedicationID)
                .HasPrincipalKey(p => p.Code).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Prescribe>()
                .HasOne(p => p.patient)
                .WithMany(p => p.prescribes)
                .HasForeignKey(p => p.PatientID)
                .HasPrincipalKey(p => p.SSN).OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<Prescribe>()
                .HasOne(p => p.appointment)
                .WithMany(p => p.prescribes)
                .HasForeignKey(p => p.AppointmentID)
                .HasPrincipalKey(p => p.AppointmentID).OnDelete(DeleteBehavior.Restrict);

            //=======================================

            modelBuilder.Entity<Block>()
                .HasKey(b => new { b.BlockCodeID, b.BlockFloorID });

            //=======================================

            modelBuilder.Entity<Room>()
                .HasKey(r => r.RoomNumber);

            modelBuilder.Entity<Room>()
                .HasOne(r => r.block)
                .WithMany(r => r.rooms)
                .HasForeignKey(r => r.BlockCodeID)
                .HasPrincipalKey(r => r.BlockCodeID).OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<Room>()
                .HasOne(r => r.block)
                .WithMany(r => r.rooms)
                .HasForeignKey(r => r.BlockFloorID)
                .HasPrincipalKey(r => r.BlockFloorID).OnDelete(DeleteBehavior.Restrict);

            //=======================================

            modelBuilder.Entity<on_call>()
                .HasKey(c => new {c.NurseID , c.BlockCodeID , c.BlockFloorID ,c.OnCallEnd , c.OnCallStart });

            modelBuilder.Entity<on_call>()
                .HasOne(r => r.nurse)
                .WithMany(r => r.on_Calls)
                .HasForeignKey(r => r.NurseID)
                .HasPrincipalKey(r => r.SSN).OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<on_call>()
                .HasOne(r => r.block)
                .WithMany(r => r.on_Calls)
                .HasForeignKey(r => r.BlockCodeID)
                .HasPrincipalKey(r => r.BlockCodeID).OnDelete(DeleteBehavior.Restrict);

              modelBuilder.Entity<on_call>()
                .HasOne(r => r.block)
                .WithMany(r => r.on_Calls)
                .HasForeignKey(r => r.BlockFloorID)
                .HasPrincipalKey(r => r.BlockFloorID).OnDelete(DeleteBehavior.Restrict);

            //=======================================

            modelBuilder.Entity<Stay>()
                .HasOne(s => s.patient)
                .WithMany(s => s.staies)
                .HasForeignKey(s => s.PatientID)
                .HasPrincipalKey(s => s.SSN).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Stay>()
                .HasOne(s => s.room)
                .WithMany(s => s.staies)
                .HasForeignKey(s => s.RoomId)
                .HasPrincipalKey(s => s.BlockCodeID).OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<Stay>()
                .HasOne(s => s.room)
                .WithMany(s => s.staies)
                .HasForeignKey(s => s.RoomId)
                .HasPrincipalKey(s => s.BlockFloorID).OnDelete(DeleteBehavior.Restrict);


        }
    }
}

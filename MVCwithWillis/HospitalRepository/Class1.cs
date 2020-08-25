using Microsoft.EntityFrameworkCore;
using PatientLibrary;
using System;

namespace HospitalRepository
{
    public class HospitalDbContext : DbContext
    {
        //event or method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Patient>()
                .ToTable("tblPatient");
        }
        public DbSet<Patient> patients { get; set; }
    }
}

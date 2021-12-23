using HospitalApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalApp.Entities
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions dbContextOptions)
            :base (dbContextOptions)
        {
        
        }

        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}

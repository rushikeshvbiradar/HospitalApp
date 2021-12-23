using HospitalApp.Entities;
using HospitalApp.Interfaces;
using HospitalApp.Models;

namespace HospitalApp.Repository
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        public PatientRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}

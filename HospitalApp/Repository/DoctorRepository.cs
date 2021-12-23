using HospitalApp.Entities;
using HospitalApp.Interfaces;
using HospitalApp.Models;

namespace HospitalApp.Repository
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}

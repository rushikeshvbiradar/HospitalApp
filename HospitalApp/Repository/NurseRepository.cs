using HospitalApp.Entities;
using HospitalApp.Interfaces;
using HospitalApp.Models;

namespace HospitalApp.Repository
{
    public class NurseRepository : BaseRepository<Nurse>, INurseRepository
    {
        public NurseRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}

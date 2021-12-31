using HospitalApp.Entities;
using HospitalApp.Interfaces;
using HospitalApp.Models;

namespace HospitalApp.Repository
{
    public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            
        }

        public IQueryable<Appointment> GetAppointmentsByDoctorId(Guid doctorId)
        {
            throw new NotImplementedException();
        }

        public Appointment SearchAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public override void Add(Appointment appointment)
        {
            repositoryContext.Set<Appointment>().Add(appointment);
        }
    }
}

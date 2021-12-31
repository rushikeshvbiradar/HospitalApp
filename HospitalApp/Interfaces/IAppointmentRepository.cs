using HospitalApp.Models;

namespace HospitalApp.Interfaces
{
    public interface IAppointmentRepository: IBaseRepository<Appointment>
    {
        IQueryable<Appointment> GetAppointmentsByDoctorId(Guid doctorId);

        Appointment SearchAppointment(Appointment appointment);
    }
}

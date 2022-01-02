using HospitalApp.Models;
using HospitalApp.DTOModels;

namespace HospitalApp.Interfaces
{
    public interface IAppointmentRepository: IBaseRepository<Appointment>
    {
        IQueryable<Appointment> GetAll(Guid doctorId);

        Appointment? SearchAppointment(Appointment appointment);

        IEnumerable<Slot> GetAllFreeSlots(Guid doctorId);
    }
}

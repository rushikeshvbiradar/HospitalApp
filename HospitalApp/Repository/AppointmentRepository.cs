using HospitalApp.DTOModels;
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

        public override void Add(Appointment appointment)
        {
            if (appointment.From.Hour < 9 || appointment.From.Hour > 16 || appointment.From.Hour == 12)
            {
                throw new Exception("Appointment can be scheduled between 9 - 12 and 13 to 17 only");
            }
            // correct date
            appointment.From = GetValidDate(appointment.From);
            appointment.To = GetValidDate(appointment.To);

            //check if appointment exist
            Appointment? appointmentExist = SearchAppointment(appointment);
            if (appointmentExist == null)
            {
                repositoryContext.Set<Appointment>().Add(appointment);
                repositoryContext.SaveChanges();
            }
            else
            {
                throw new Exception("Appointment already exist at given slot From : " + appointment.From + " To : " + appointment.To);
            }
        }

        //Get All Appointments for next 7 days
        public IQueryable<Appointment> GetAll(Guid doctorId)
        {
            var startDate = GetValidDate(DateTime.Now);
            var endDate = GetValidDate(DateTime.Now.AddDays(7));
            return repositoryContext.Set<Appointment>()
                .Where(app => app.DoctorId == doctorId &&
                    app.From >= startDate &&
                    app.To <= endDate);
        }

        // Get all free slots available
        public IEnumerable<Slot> GetAllFreeSlots(Guid doctorId)
        {
            List<Appointment> existingSlots = GetAll(doctorId).ToList();
            return FetchFreeSlots(existingSlots);
        }

        // Search appointment
        public Appointment? SearchAppointment(Appointment appointment)
        {
            return repositoryContext.Set<Appointment>()
                .Where(app => app.DoctorId == appointment.DoctorId &&
                    app.From == appointment.From &&
                    app.To == appointment.To)
                .FirstOrDefault();
        }

        // get valid date
        private DateTime GetValidDate(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, date.Hour, 00, 00);
        }

        private IEnumerable<Slot> FetchFreeSlots(List<Appointment> existingAppointments)
        {
            int limitDays = 5;
            DateTime startDate = DateTime.Now.AddDays(1);
            int startHour = 9;
            int endHour = 16;
            List<Slot> slots = new List<Slot>();

            while (limitDays != 0)
            {
                // No appointments on Weekend
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    for (int i = startHour; i <= endHour; i++)
                    {
                        if (i == 12)
                        {
                            // lunch time
                            continue;
                        }

                        //create appointment and check if it exists
                        Appointment appointment = CreateAppointment(startDate, i);
                        bool appExist = existingAppointments.Where(app => app.From == appointment.From).Any();
                        if (!appExist)
                        {
                            // create slot if appointment does not exist
                            Slot slot = new Slot();
                            slot.Date = appointment.From;
                            slot.From = appointment.From.Hour;
                            slot.To = appointment.To.Hour;
                            slots.Add(slot);
                        }
                    }

                    limitDays = limitDays - 1;
                }
                startDate = startDate.AddDays(1);
            }

            return slots;
        }

        // create appointment object
        private Appointment CreateAppointment(DateTime startDate, int hour)
        {
            Appointment appointment = new Appointment();
            appointment.From = new DateTime(startDate.Year, startDate.Month, startDate.Day, hour, 00, 00);
            appointment.To = appointment.From.AddHours(1);
            return appointment;
        }
    }
}

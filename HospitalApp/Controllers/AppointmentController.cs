using HospitalApp.Interfaces;
using HospitalApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController: ControllerBase
    {
        private readonly IAppointmentRepository appointmentRepository;

        public AppointmentController(IAppointmentRepository _appointmentRepository)
        {
            appointmentRepository = _appointmentRepository;
        }

        [HttpPost]
        public IResult Add(Appointment appointment)
        {
            appointmentRepository.Add(appointment);
            appointmentRepository.Save();
            return Results.Ok();
        }

        [HttpPut]
        public IResult Put(Appointment appointment)
        {
            appointmentRepository.Update(appointment);
            appointmentRepository.Save();
            return Results.Ok();
        }

        [HttpDelete]
        public IResult Delete(Appointment appointment)
        {
            appointmentRepository.Delete(appointment);
            appointmentRepository.Save();
            return Results.Ok();
        }
    }
}

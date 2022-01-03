using HospitalApp.Interfaces;
using HospitalApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository doctorRepository;

        public DoctorController(IDoctorRepository _doctorRepository)
        {
            doctorRepository = _doctorRepository;
        }

        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return doctorRepository.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public Doctor Get([FromRoute] Guid id)
        {
            return doctorRepository.Get(id);
        }

        [HttpPost]
        public IResult Post(Doctor doctor)
        {
            try
            {
                doctorRepository.Add(doctor);
                doctorRepository.Save();
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex);
            }
        }

        [HttpPut]
        public IResult Put(Doctor doctor)
        {
            try
            {
                doctorRepository.Update(doctor);
                doctorRepository.Save();
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex);
            }
        }

        [HttpDelete]
        public IResult Delete(Doctor doctor)
        {
            try
            {
                doctorRepository.Delete(doctor);
                doctorRepository.Save();
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex);
            }
        }
    }
}

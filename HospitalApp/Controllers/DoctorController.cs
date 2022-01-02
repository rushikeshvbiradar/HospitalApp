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
            doctorRepository.Add(doctor);
            doctorRepository.Save();
            return Results.Ok();
        }

        [HttpPut]
        public IResult Put(Doctor doctor)
        {
            doctorRepository.Update(doctor);
            doctorRepository.Save();
            return Results.Ok();
        }

        [HttpDelete]
        public IResult Delete(Doctor doctor)
        {
            doctorRepository.Delete(doctor);
            doctorRepository.Save();
            return Results.Ok();
        }
    }
}

using HospitalApp.Interfaces;
using HospitalApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository repository;

        public DoctorController(IDoctorRepository _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return repository.GetAll();
        }

        [HttpPost]
        public IResult Post(Doctor doctor)
        {
            return Results.Ok();
        }

        [HttpPut]
        public IResult Put(Doctor doctor)
        {
            repository.Update(doctor);
            return Results.Ok();
        }

        [HttpDelete]
        public IResult Delete(Doctor doctor)
        {
            repository.Delete(doctor);
            return Results.Ok();
        }
    }
}

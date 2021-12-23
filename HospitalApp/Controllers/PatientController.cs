using HospitalApp.Interfaces;
using HospitalApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository repository;

        public PatientController(IPatientRepository _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return repository.GetAll();
        }

        [HttpPost]
        public IResult Post(Patient patient)
        {
            repository.Add(patient);
            return Results.Ok();
        }

        [HttpPut]
        public IResult Put(Patient patient)
        {
            repository.Update(patient);
            return Results.Ok();
        }

        [HttpDelete]
        public IResult Delete(Patient patient)
        {
            repository.Delete(patient);
            return Results.Ok();
        }
    }
}

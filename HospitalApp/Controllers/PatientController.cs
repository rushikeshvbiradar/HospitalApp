using HospitalApp.Interfaces;
using HospitalApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository patientRepository;

        public PatientController(IPatientRepository _repository)
        {
            patientRepository = _repository;
        }

        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return patientRepository.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public Patient Get([FromRoute] Guid id)
        {
            return patientRepository.Get(id);
        }

        [HttpPost]
        public IResult Post(Patient patient)
        {
            patientRepository.Add(patient);
            patientRepository.Save();
            return Results.Ok();
        }

        [HttpPut]
        public IResult Put(Patient patient)
        {
            patientRepository.Update(patient);
            patientRepository.Save();
            return Results.Ok();
        }

        [HttpDelete]
        public IResult Delete(Patient patient)
        {
            patientRepository.Delete(patient);
            patientRepository.Save();
            return Results.Ok();
        }
    }
}

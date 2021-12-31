using HospitalApp.Interfaces;
using HospitalApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NurseController : ControllerBase
    {
        private readonly INurseRepository nurseRepository;

        public NurseController(INurseRepository _nurseRepository)
        {
            nurseRepository = _nurseRepository;
        }

        [HttpGet]
        public IEnumerable<Nurse> Get()
        {
            return nurseRepository.GetAll();
        }

        [HttpGet]
        [Route("getbyid")]
        public Nurse GetById(Guid id)
        {
            return nurseRepository.Get(id);
        }

        [HttpPost]
        public IResult Post(Nurse nurse)
        {
            nurseRepository.Add(nurse);
            nurseRepository.Save();
            return Results.Ok();
        }

        [HttpPut]
        public IResult Put(Nurse nurse)
        {
            nurseRepository.Update(nurse);
            nurseRepository.Save();
            return Results.Ok();
        }

        [HttpDelete]
        public IResult Delete(Nurse nurse)
        {
            nurseRepository.Delete(nurse);
            nurseRepository.Save();
            return Results.Ok();
        }
    }
}

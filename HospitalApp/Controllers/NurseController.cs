using HospitalApp.Interfaces;
using HospitalApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NurseController : ControllerBase
    {
        private readonly INurseRepository repository;

        public NurseController(INurseRepository _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public IEnumerable<Nurse> Get()
        {
            return repository.GetAll();
        }

        [HttpPost]
        public IResult Post(Nurse nurse)
        {
            return Results.Ok();
        }

        [HttpPut]
        public IResult Put(Nurse nurse)
        {
            repository.Update(nurse);
            return Results.Ok();
        }

        [HttpDelete]
        public IResult Delete(Nurse nurse)
        {
            repository.Delete(nurse);
            return Results.Ok();
        }
    }
}

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
        [Route("{id}")]
        public Nurse Get([FromRoute] Guid id)
        {
            return nurseRepository.Get(id);
        }

        [HttpPost]
        public IResult Post(Nurse nurse)
        {
            try
            {
                nurseRepository.Add(nurse);
                nurseRepository.Save();
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex);
            }
        }

        [HttpPut]
        public IResult Put(Nurse nurse)
        {
            try
            {
                nurseRepository.Update(nurse);
                nurseRepository.Save();
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex);
            }
        }

        [HttpDelete]
        public IResult Delete(Nurse nurse)
        {
            try
            {
                nurseRepository.Delete(nurse);
                nurseRepository.Save();
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex);
            }
        }
    }
}

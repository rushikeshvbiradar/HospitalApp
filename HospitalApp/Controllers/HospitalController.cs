using HospitalApp.Interfaces;
using HospitalApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalRepository hospitalRepository;

        public HospitalController(IHospitalRepository _hospitalRepository)
        {
            hospitalRepository = _hospitalRepository;
        }

        [HttpGet]
        public IEnumerable<Hospital> Get()
        {
            return hospitalRepository.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public Hospital Get([FromRoute] Guid id)
        {
            return hospitalRepository.Get(id);
        }

        [HttpPost]
        public IResult Post(Hospital hospital)
        {
            try
            {
                hospitalRepository.Add(hospital);
                hospitalRepository.Save();
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex);
            }
        }

        [HttpPut]
        public IResult Put(Hospital hospital)
        {
            try
            {
                hospitalRepository.Update(hospital);
                hospitalRepository.Save();
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex);
            }
        }

        [HttpDelete]
        public IResult Delete(Hospital hospital)
        {
            try
            {
                hospitalRepository.Delete(hospital);
                hospitalRepository.Save();
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex);
            }
        }
    }
}

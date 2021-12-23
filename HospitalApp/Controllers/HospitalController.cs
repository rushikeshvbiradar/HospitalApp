using HospitalApp.Interfaces;
using HospitalApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalRepository repository;

        public HospitalController(IHospitalRepository _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public IEnumerable<Hospital> Get()
        {

            //Hospital h1 = new Hospital();
            //h1.Name = "General Hospital 2";

            //Hospital h2 = new Hospital();
            //h1.Name = "General Hospital 1";

            //repository.Add(h1);
            //repository.Add(h2);

            //repository.Save();
            
            return repository.GetAll();
        }

        [HttpPost]
        public IResult Post(Hospital hospital)
        {
            return Results.Ok();
        }
    }
}

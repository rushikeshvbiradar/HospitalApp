using HospitalApp.Interfaces;
using HospitalApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospitalController : ControllerBase
    {
        private readonly IServices<Hospital> hospitalService;

        public HospitalController(IServices<Hospital> _hospitalService) {
            hospitalService = _hospitalService;

            Hospital h1 = new Hospital("General Hospital 1");
            h1.city = "Pune";
            h1.street = "Abc";
            h1.pincode = 123;

            Hospital h2 = new Hospital("General Hospital 2");
            h1.city = "Pune city";
            h1.street = "Pqr";
            h1.pincode = 124;

            hospitalService.Add(h1);
            hospitalService.Add(h2);
        }

        [HttpGet(Name = "GetAll")]
        public IEnumerable<Hospital> Get() {
            return hospitalService.GetAll();
        }
    }
}

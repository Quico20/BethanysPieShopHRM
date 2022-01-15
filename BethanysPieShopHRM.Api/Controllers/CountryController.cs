using BethanysPieShopHRM.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShopHRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        readonly ICountryRepository countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        // GET: api/<CountryController>
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(countryRepository.GetAllCountries());
        }

        // GET api/<CountryController>/5
        [HttpGet("{id}")]
        public IActionResult GetCountryById(int countryId)
        {
            return Ok(countryRepository.GetCountryById(countryId));
        }
    }
}

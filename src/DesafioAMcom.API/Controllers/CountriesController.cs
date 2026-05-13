using DesafioAMcom.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioAMcom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _service;
        public CountriesController(ICountryService service) => _service = service;

        [HttpGet]
        public IActionResult Get() => Ok(_service.GetCountries());
    }
}

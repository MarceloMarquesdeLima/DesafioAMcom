using DesafioAMcom.Application.Interfaces;
using DesafioAMcom.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioAMcom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperaturasController : ControllerBase
    {
        private readonly ITemperatureService _service;
        public TemperaturasController(ITemperatureService service) => _service = service;

        [HttpPost("converter")]
        public IActionResult Converter([FromBody] Temperature temp) => Ok(_service.Converter(temp));
    }
}

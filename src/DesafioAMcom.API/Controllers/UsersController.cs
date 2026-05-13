using DesafioAMcom.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioAMcom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _service;
        public UsersController(IUsersService service) => _service = service;

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string? name, [FromQuery] string? email)
            => Ok(await _service.GetUsersAsync(name, email));
    }
}

using Microsoft.AspNetCore.Mvc;
using Core.Interfaces;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PingController : ControllerBase
    {
        private readonly IPingService _service;
        public PingController(IPingService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.Ping());
        }
    }
}
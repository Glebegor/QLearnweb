using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Pong");
        }
    }
}
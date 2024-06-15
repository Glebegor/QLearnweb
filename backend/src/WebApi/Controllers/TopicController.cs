using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TopicController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("Hello World");
        }
        
        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Hello World");
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok("Hello World");
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Hello World");
        }
    }
};

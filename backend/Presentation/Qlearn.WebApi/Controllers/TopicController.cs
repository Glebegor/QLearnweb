using Microsoft.AspNetCore.Mvc;

namespace Qlearn.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    
    public class TopicController : ControllerBase
    {

        public TopicController()
        {
            
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }
        
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok();
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
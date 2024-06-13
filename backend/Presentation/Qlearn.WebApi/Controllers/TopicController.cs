using Microsoft.AspNetCore.Mvc;
using Qlearn.Usecases;
    
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
            return Ok("All topics fetched successfully.");
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Topic with ID {id} fetched successfully.");
        }
        
        [HttpPost]
        public IActionResult Post()
        {
            return Ok("New topic created successfully.");
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok($"Topic with ID {id} updated successfully.");
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Topic with ID {id} deleted successfully.");
        }
    }
}
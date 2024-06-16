using Microsoft.AspNetCore.Mvc;
using Core.Interfaces;
using Core.Entities;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TopicController : ControllerBase
    {
        private readonly ITopicService _service;
        public TopicController(ITopicService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.TestMethod() + " Get");
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.TestMethod() + " Get");
        }
        
        [HttpPost]
        public IActionResult Post()
        {
            return Ok(_service.TestMethod() + " Post");
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok(_service.TestMethod() + " Put");
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_service.TestMethod() + " Delete");
        }
    }
};

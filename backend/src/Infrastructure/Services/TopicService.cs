using Core.Interfaces;
using Core.Entities;

namespace Infrastructure.Services
{
    
    public class TopicService : ITopicService
    {
        public ApplicationDbContext _context;
        public TopicService(ApplicationDbContext context)
        {
            _context = context;
        }
        public string TestMethod()
        {
            return "Hello World";
        }
    }
}
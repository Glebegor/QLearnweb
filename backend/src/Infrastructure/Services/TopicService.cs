using Core.Interfaces;

namespace Infrastructure.Services
{
    public class TopicService : ITopicService
    {
        public string TestMethod()
        {
            return "Hello World";
        }
    }
}
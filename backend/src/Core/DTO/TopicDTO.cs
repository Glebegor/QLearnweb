using Microsoft.EntityFrameworkCore;
namespace Core.DTO
{
    public class TopicDTO
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public int UserId { set; get; }
    }
}


using Core.Interfaces;

namespace Infrastructure.Services
{
    public class PingService : IPingService
    {
        public string Ping()
        {
            return "Pong";
        }
    }
}
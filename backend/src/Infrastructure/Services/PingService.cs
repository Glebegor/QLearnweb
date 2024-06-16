using Core.Interfaces;
using Core.Entities;

using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Services
{
    public class PingService : IPingService
    {
        public ApplicationDbContext _context;
        public PingService(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Ping()
        {
            try
            {
                _context.Topics.FirstOrDefaultAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
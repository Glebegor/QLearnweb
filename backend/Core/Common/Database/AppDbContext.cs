using Microsoft.EntityFrameworkCore;

namespace backend.Core.Common.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Define DbSets for your entities
    public DbSet<User> UsersEntities { get; set; }
}
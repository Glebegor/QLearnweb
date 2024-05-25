using backend.Core.Interface.Database;
namespace backend.Core.Common.Database;

public class DbService : IDbService
{
    private readonly AppDbContext context;

    public DbService(AppDbContext context)
    {
        context = context;
    }

    // User-related methods
    public async Task<List<User>> GetAllUsersAsync()
    {
        return null;
    }

    public async Task<User> GetUserByIdAsync(int id)
    {
        return null;
    }

    public async Task AddUserAsync(User user)
    {

    }

    public async Task UpdateUserAsync(User user)
    {

    }

    public async Task DeleteUserAsync(int id)
    {

    }

}
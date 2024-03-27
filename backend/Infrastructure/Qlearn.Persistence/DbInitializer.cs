
namespace Persistence;

public class DbInitializer
{
    public class DbInitializer
    {
        public static void Initialize(WorkspaceDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
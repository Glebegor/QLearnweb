using Qlearn.Domain;

namespace Qlearn.Application.Interfaces;

public interface IWorkspaceDbContext
{
    DbSet<Workspace> Workspaces { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
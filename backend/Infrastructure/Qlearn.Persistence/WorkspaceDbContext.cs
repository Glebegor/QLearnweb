using Microsoft.EntityFrameworkCore;
using Qlearn.Domain;
using Qlearn.Application.Interfaces;
using Qlearn.Infrastructure.Persistence.EntityTypeConfigurations;

namespace Persistence;

public class WorkspaceDbContext : DbContext, IWorkspaceDbContext
{
    public DbSet<Workspace> Workspaces { get; set; }
    
    public WorkspaceDbContext(DbContextOptions<WorkspaceDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new WorkspaceEntityTypeConfiguration());
        base.OnModelCreating(modelBuilder);
    }
    
}
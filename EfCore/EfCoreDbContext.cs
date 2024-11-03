using EfCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EfCore;

public class EfCoreDbContext: DbContext
{
    public EfCoreDbContext(DbContextOptions<EfCoreDbContext> dbContextOptions): base(dbContextOptions)
    {
        
    }
    public DbSet<Car> Cars { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

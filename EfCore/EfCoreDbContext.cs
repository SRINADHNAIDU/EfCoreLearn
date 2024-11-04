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
    public DbSet<Engine> Engines { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>()
            .HasOne(o => o.Engine)
            .WithOne(e => e.Car)
            .HasForeignKey<Car>(d => d.EngineId);  
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

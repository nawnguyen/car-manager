using CarManager.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CarManager.Infrastructure.Configuration;

public class DatabaseContext(DbContextOptions<DatabaseContext> options)  : DbContext(options)
{
    public DbSet<Car> Cars { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("app");
        
        modelBuilder.Entity<Car>().ToTable("Car");
    }
}
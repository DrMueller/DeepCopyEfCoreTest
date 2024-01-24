using DeepCopyEfCoreTest.Models.Configs;
using Microsoft.EntityFrameworkCore;

namespace DeepCopyEfCoreTest.Data;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseInMemoryDatabase(Guid.NewGuid().ToString());

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AgendaConfig).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
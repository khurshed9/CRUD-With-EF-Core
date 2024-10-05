using CrudWithEfCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudWithEfCore.DataContext;

public class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=web_db;Username=postgres;Password=Galchaew05;");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Program).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
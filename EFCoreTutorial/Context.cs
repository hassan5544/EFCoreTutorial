using EFCoreTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTutorial;

public class Context : DbContext
{
    public Context(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Users> Users { get; set; }
    public DbSet<Patients> Patients { get; set; }
    public DbSet<Tests> Test { get; set; }
    public DbSet<Results> Results { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=.;database=EfCoreTutorial;trusted_connection=true;TrustServerCertificate=true;");
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patients>()
            .HasMany(e => e.TestsList)
            .WithOne(e => e.Patient)
            .HasForeignKey(e => e.PatientId)
            .IsRequired();
    }
    
    
}
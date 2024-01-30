using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFCoreTutorial.Models;

public class ContextFactory: IDesignTimeDbContextFactory<Context>
{
    public Context CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<Context>();
        optionsBuilder.UseSqlServer("server=.;database=EfCoreTutorial;trusted_connection=true;TrustServerCertificate=true;");

        return new Context(optionsBuilder.Options);    }
}
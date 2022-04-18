using Microsoft.EntityFrameworkCore;

namespace Data_Access_Layer.DAL.Data;

public class GeoContext : DbContext
{
    public GeoContext(DbContextOptions<GeoContext> options) : base(options)
    {        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("IconsConnection");
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}

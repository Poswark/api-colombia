using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api;
public class DBContext : DbContext
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<President> Presidents { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<TouristAttraction> TouristAttractions { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Paramo> Paramos { get; set; }

    public DBContext(DbContextOptions<DBContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CountryConfig());
        builder.ApplyConfiguration(new DepartamentConfig());
        builder.ApplyConfiguration(new CityConfig());
        builder.ApplyConfiguration(new PresidentConfig());
        builder.ApplyConfiguration(new TouristAttractionConfig());
        builder.ApplyConfiguration(new RegionConfig());
        builder.ApplyConfiguration(new ParamoConfig());

        base.OnModelCreating(builder);
    }
}

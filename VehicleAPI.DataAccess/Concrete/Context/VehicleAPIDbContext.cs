using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using VehicleAPI.Entities.Concrete;

namespace VehicleAPI.DataAccess.Concrete.Context;

public class VehicleAPIDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string ConnetDeveloper = "server=localhost ;port=3306;database=VehicleAPIDb ;user=root;password=0987654321;Charset=utf8;";
        optionsBuilder.UseLazyLoadingProxies()
            .UseMySql(ConnetDeveloper, ServerVersion.AutoDetect(ConnetDeveloper))
            .EnableSensitiveDataLogging()
            .ConfigureWarnings(warnings =>
            {
                warnings.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning);
            });
    }

    public DbSet<BoatModel> Boats { get; set; }
    public DbSet<BusModel> Buses { get; set; }
    public DbSet<CarModel> Cars { get; set; }
}

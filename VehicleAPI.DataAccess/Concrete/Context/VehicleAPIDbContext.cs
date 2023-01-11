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
    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
        #region Creation of Car
        var Car1 = new CarModel()
		{
			Id = 1,
            Headlights = true,
            Color = "red",
            Wheels = 2
		};
        var Car2 = new CarModel()
		{
			Id = 2,
            Headlights = true,
            Color = "blue",
            Wheels = 3
		};
        var Car3= new CarModel()
		{
			Id = 3,
            Headlights = true,
            Color = "black",
            Wheels = 4
		};
        var Car4 = new CarModel()
		{
			Id = 4,
            Headlights = true,
            Color = "white",
            Wheels = 5
		};
        modelBuilder.Entity<CarModel>().HasData(Car1,Car2,Car3,Car4);
		base.OnModelCreating(modelBuilder);
        #endregion

        #region Creation of Boat
        var Boat1 = new BoatModel()
		{
			Id = 1,
            Capacity = 1000,
            Color = "red"
		};
        var Boat2 = new BoatModel()
		{
			Id = 2,
            Capacity = 100,
            Color = "blue"
		};
        var Boat3 = new BoatModel()
		{
			Id = 3,
            Capacity = 40,
            Color = "black"
		};
        var Boat4 = new BoatModel()
		{
			Id = 4,
            Capacity = 50,
            Color = "white"
		};
        
		modelBuilder.Entity<BoatModel>().HasData(Boat1,Boat2,Boat3,Boat4);
		base.OnModelCreating(modelBuilder);

        #endregion

        #region Creation of Bus
        var Bus1 = new BusModel()
		{
			Id = 1,
            LuggageCapacity = 50,
            Color = "red",
            Wheels = 2,

		};
         var Bus2 = new BusModel()
		{
			Id = 2,
            LuggageCapacity = 30,
            Color = "blue",
            Wheels = 2,

		};
         var Bus3 = new BusModel()
		{
			Id = 3,
            LuggageCapacity = 20,
            Color = "black",
            Wheels = 2,

		};
         var Bus4 = new BusModel()
		{
			Id = 4,
            LuggageCapacity = 25,
            Color = "white",
            Wheels = 2,

		};
        
		modelBuilder.Entity<BusModel>().HasData(Bus1,Bus2,Bus3,Bus4);
		base.OnModelCreating(modelBuilder);
        #endregion
    }

    public DbSet<BoatModel> Boats { get; set; }
    public DbSet<BusModel> Buses { get; set; }
    public DbSet<CarModel> Cars { get; set; }
}

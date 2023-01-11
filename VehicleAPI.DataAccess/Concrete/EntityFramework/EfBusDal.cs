using VehicleAPI.Core.DataAccess.EntityFramework;
using VehicleAPI.DataAccess.Abstract;
using VehicleAPI.DataAccess.Concrete.Context;
using VehicleAPI.Entities.Concrete;

namespace VehicleAPI.DataAccess.Concrete.EntityFramework;

public class EfBusDal : EfEntityRepositoryBaseAsync<BusModel, VehicleAPIDbContext>, IBusDal
{

}

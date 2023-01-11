using VehicleAPI.Entities.Concrete;

namespace VehicleAPI.Business.Abstract;

public interface IBusService
{
  Task<IList<BusModel>> GetBusByColor(string Color);
}

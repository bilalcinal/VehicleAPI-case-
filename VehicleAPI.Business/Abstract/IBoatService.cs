using VehicleAPI.Entities.Concrete;

namespace VehicleAPI.Business.Abstract;

public interface IBoatService
{
   Task<IList<BoatModel>> GetBoatByColor(string Color);
}

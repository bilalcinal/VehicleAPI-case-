using VehicleAPI.Entities.Concrete;

namespace VehicleAPI.Business.Abstract;

public interface ICarService
{
    Task<IList<CarModel>> GetCarsByColor(string Color);
    Task TurnOnOffHeadlights (int carId, bool status);
    Task DeleteCar(int carId);
}

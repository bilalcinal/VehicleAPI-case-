using VehicleAPI.Business.Abstract;
using VehicleAPI.DataAccess.Abstract;
using VehicleAPI.Entities.Concrete;

namespace VehicleAPI.Business.Concrete;

public class CarManager : ICarService
{
   private readonly ICarDal _carDal;

   public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public async Task<IList<CarModel>> GetCarsByColor(string Color)
    {
        return await _carDal.GetListAsync(x => x.Color == Color);
    }

    public async Task TurnOnOffHeadlights(int carId, bool status)
    {
        var car = await _carDal.GetAsync(x => x.Id == carId);
            car.Headlights = status;
            await _carDal.UpdateAsync(car);
    }
     public async Task DeleteCar(int carId)
    {
        var car = await _carDal.GetAsync(x => x.Id == carId);
        await _carDal.DeleteAsync(car);
    }

}

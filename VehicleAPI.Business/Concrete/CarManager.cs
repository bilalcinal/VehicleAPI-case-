using VehicleAPI.Business.Abstract;
using VehicleAPI.DataAccess.Abstract;

namespace VehicleAPI.Business.Concrete;

public class CarManager : ICarService
{
   private readonly ICarDal _carDal;

   public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }
    
}

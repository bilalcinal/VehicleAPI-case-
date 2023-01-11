using VehicleAPI.Business.Abstract;
using VehicleAPI.DataAccess.Abstract;
using VehicleAPI.Entities.Concrete;

namespace VehicleAPI.Business.Concrete;

public class BoatManager : IBoatService
{
   private readonly IBoatDal _boatDal;

   public BoatManager(IBoatDal boatDal)
   {
      _boatDal = boatDal;
   }

   public async Task<IList<BoatModel>> GetBoatByColor(string Color)
    {
        return await _boatDal.GetListAsync(x => x.Color == Color);
    }
}

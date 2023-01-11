using VehicleAPI.Business.Abstract;
using VehicleAPI.DataAccess.Abstract;
using VehicleAPI.Entities.Concrete;

namespace VehicleAPI.Business.Concrete;

public class BusManager : IBusService
{
   private readonly IBusDal _busDal;
   
   public BusManager(IBusDal busDal)
    {
        _busDal = busDal;
    }

    public async Task<IList<BusModel>> GetBusByColor(string Color)
    {
        return await _busDal.GetListAsync(x => x.Color == Color);
    }
}

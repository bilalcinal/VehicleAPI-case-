using VehicleAPI.Core.Entities;

namespace VehicleAPI.Entities.Concrete;

public class BusModel : Vehicle
{
   public int LuggageCapacity { get; set; }

   public int Wheels { get; set; }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleAPI.Core.DataAccess;
using VehicleAPI.Entities.Concrete;

namespace VehicleAPI.DataAccess.Abstract
{
    public interface ICarDal : IEntityRepositoryAsync<CarModel>
    {
        
    }
}
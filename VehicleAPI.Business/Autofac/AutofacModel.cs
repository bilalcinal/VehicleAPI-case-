using Autofac;
using VehicleAPI.Business.Abstract;
using VehicleAPI.Business.Concrete;
using VehicleAPI.DataAccess.Abstract;
using VehicleAPI.DataAccess.Concrete;
using VehicleAPI.DataAccess.Concrete.EntityFramework;

namespace VehicleAPI.Business.Autofac;

public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        #region Car
        builder.RegisterType<CarManager>().As<ICarService>();
        builder.RegisterType<EfCarDal>().As<ICarDal>();
        #endregion

        #region Bus
        builder.RegisterType<BusManager>().As<IBusService>();
        builder.RegisterType<EfBusDal>().As<IBusDal>();
        #endregion

       #region Boat
        builder.RegisterType<BoatManager>().As<IBoatService>();
        builder.RegisterType<EfBoatDal>().As<IBoatDal>();
        #endregion
    }
}

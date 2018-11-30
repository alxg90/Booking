using Booking.DataAccess.Repositories;
using BookingWeb.Services;
using Ninject.Modules;

namespace BookingWeb.App_Start
{
    public class NinjectBinding : NinjectModule
    {
        public override void Load()
        {
            Bind<ITrainRepository>().To<TrainRepository>();
            Bind<ITrainService>().To<TrainService>();
        }
    }
}
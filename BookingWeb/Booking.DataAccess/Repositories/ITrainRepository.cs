using Booking.Models;
using System.Collections.Generic;

namespace Booking.DataAccess.Repositories
{
    public interface ITrainRepository
    {
        IList<Train> GetTrains();
        Train GetTrain(int number);
    }
}

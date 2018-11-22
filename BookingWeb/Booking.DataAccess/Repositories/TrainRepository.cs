using Booking.Models;
using System.Collections.Generic;
using System.Linq;

namespace Booking.DataAccess.Repositories
{
    public class TrainRepository : ITrainRepository
    {
        private readonly DbContext _dbContext;

        public TrainRepository()
        {
            _dbContext = new DbContext();
        }

        public IList<Train> GetTrains()
        {
            return _dbContext.Trains;
        }

        public Train GetTrain(int number)
        {
            return _dbContext.Trains.FirstOrDefault(t => t.Number == number);
        }
    }
}
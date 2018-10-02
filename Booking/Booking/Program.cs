using Booking.DataAccess.Repositories;

namespace Booking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Можна винести в конструктор?
            ITrainRepository trainRepository = new TrainRepository();

            var trains = trainRepository.GetTrains();
        }
    }
}

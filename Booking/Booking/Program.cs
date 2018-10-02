using Booking.DataAccess.Repositories;

namespace Booking
{
    //TODO: 3. Вивести на екран відправлення/прибуття, тривалість, кількість вільних місць по типу вагонів.
    class Program
    {
        static void Main(string[] args)
        {
            // Можна винести в конструктор?
            ITrainRepository trainRepository = new TrainRepository();

            var train = trainRepository.GetTrain(143);
        }
    }
}

using Booking.Models;

namespace BookingWeb.Models
{
    public class TrainDetailModel
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public Train CurrentTrain { get; set; }
    }
}
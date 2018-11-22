using Booking.Models;
using System.Collections.Generic;

namespace BookingWeb.Models
{
    public class TrainsModel
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public IList<Train> CurrentTrains { get; set; }
    }
}
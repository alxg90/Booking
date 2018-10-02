using System;

namespace Booking.Models
{
    public class Station
    {
        public string Name { get; private set; }
        public TimeSpan Arrival { get; set; }

        public Station(string name, TimeSpan arrival)
        {
            Name = name;
            Arrival = arrival;
        }
    }
}

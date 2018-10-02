using System.Collections.Generic;

namespace Booking.Models
{
    public class Train
    {
        public int Number { get; private set; }
        public string Name { get; private set; }

        public List<Station> Stations { get; private set; }

        public Train(int number, string name)
        {
            Number = number;
            Name = name;
            Stations = new List<Station>();
        }
    }
}

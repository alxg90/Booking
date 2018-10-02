using System.Collections.Generic;

namespace Booking.Models
{
    //TODO: 2. Додати вагони. Має бути 3 типи вагонів: плацкарт, купе, люкс.
    // К-ть місць та вартість, залежить від типу вагона
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

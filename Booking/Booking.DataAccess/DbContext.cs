using Booking.Models;
using System;
using System.Collections.Generic;

namespace Booking.DataAccess
{
    //TODO: 1. Singleton
    public class DbContext
    {
        public IList<Train> Trains { get; private set; }

        public DbContext()
        {
            InitTrains();
        }

        private void InitTrains()
        {
            var train1 = new Train(143, "Kyiv - Ivano-Frankivsk");
            train1.Stations.Add(new Station("Kyiv", new TimeSpan(8, 15, 0)));
            train1.Stations.Add(new Station("Ivano-Frankivsk", new TimeSpan(18, 15, 0)));

            var train2 = new Train(776, "Kyiv - Kharkiv");
            train2.Stations.Add(new Station("Kyiv", new TimeSpan(00, 22, 0)));
            train2.Stations.Add(new Station("Konotop", new TimeSpan(3, 12, 0)));
            train2.Stations.Add(new Station("Sumy", new TimeSpan(5, 33, 0)));
            train2.Stations.Add(new Station("Kharkiv", new TimeSpan(8, 30, 0)));

            var train3 = new Train(776, "Kyiv - Odesa");
            train3.Stations.Add(new Station("Kyiv", new TimeSpan(21, 15, 0)));
            train3.Stations.Add(new Station("Vinnytsa", new TimeSpan(0, 23, 0)));
            train3.Stations.Add(new Station("Odesa", new TimeSpan(6, 18, 0)));

            Trains = new List<Train>
            {
                train1,
                train2,
                train3
            };
        }
    }
}

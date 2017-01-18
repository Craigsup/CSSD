using System;
using System.Collections.Generic;

namespace TicketingSystem
{
    public class DepartureList {
        private List<Departure> _listOfDepartures;

        public void AddRoute(Departure x) {
            _listOfDepartures.Add(x);
        }

        public Departure GetDeparture(Station x, DateTime y) {
            return null;
        }
    }
}

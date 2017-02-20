using System;
using System.Collections.Generic;
using System.Linq;

namespace TicketingSystem
{
    public class DepartureList {
        private List<Departure> _listOfDepartures;

        public DepartureList() {
            _listOfDepartures = new List<Departure>();
        }

        public void AddDeparture(Departure x) {
            _listOfDepartures.Add(x);
        }

        public Departure GetDeparture(Station x, DateTime y) {
            return _listOfDepartures.First(z => z.GetStation().GetLocation() == x.GetLocation() && z.GetDepartureTime() >= y);
        }
    }
}

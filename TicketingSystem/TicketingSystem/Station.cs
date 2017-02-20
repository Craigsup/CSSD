using System;
using System.Collections.Generic;

namespace TicketingSystem {
    [Serializable]
    public class Station {
        protected DepartureList _departureList;
        protected readonly string _location;

        public Station(DepartureList departureList, string location) {
            _departureList = departureList;
            _location = location;
        }

        public Station(string Location) {
            _location = Location;
        }

        public DepartureList GetDepartures() {
            return _departureList;
        }

        public string GetLocation() {
            return _location;
        }
    }
}

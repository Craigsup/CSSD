using System.Collections.Generic;

namespace TicketingSystem {
    public class Station {
        private List<Departure> _departureList;
        private string _location;

        public Station(List<Departure> departureList, string location) {
            _departureList = departureList;
            _location = location;
        }

        public List<Departure> GetDepartures() {
            return null;
        }

        public string GetLocation() {
            return _location;
        }
    }
}

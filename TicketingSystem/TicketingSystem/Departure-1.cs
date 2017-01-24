using System;

namespace TicketingSystem {
    public class Departure {
        private readonly Station _station;
        private DateTime _departureTime;

        public Departure(Station station) {
            _station = station;
        }

        public int GetDepartureId() {
            return 0;
        }

        public Station GetStation() {
            return _station;
        }

        public DateTime GetDepartureTime() {
            return _departureTime;
        }

        public bool IsPeakDeparture() {
            return false;
        }

        public void SetDepartureTime(DateTime time) {
            _departureTime = time;
        }
    }
}

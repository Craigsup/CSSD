using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketingSystem {
    public class Departure {
        private Station _station;
        private DateTime _departureTime;

        public Departure(Station station, DateTime departureTime) {
            _station = station;
            _departureTime = departureTime;
        }

        public int GetDepartureID() {
            return 0;
        }

        public Station GetStation() {
            return _station;
        }

        public DateTime GetDepartureTime() {
            return _departureTime;
        }

        public bool IsPeakDeparture() {
            return _departureTime.ToLocalTime().Hour > 8 && _departureTime.ToLocalTime().Hour < 19;
        }

        public void SetDepartureTime(DateTime time) {
            _departureTime = time;
        }
    }
}

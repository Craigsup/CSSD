using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketingSystem {
    public class Departure {
        private Station Station;
        private DateTime DepartureTime;

        public int GetDepartureID() {
            return 0;
        }

        public Station GetStation() {
            return Station;
        }

        public DateTime GetDepartureTime() {
            return DepartureTime;
        }

        public bool IsPeakDeparture() {
            return false;
        }

        public void SetDepartureTime(DateTime time) {
            DepartureTime = time;
        }
    }
}

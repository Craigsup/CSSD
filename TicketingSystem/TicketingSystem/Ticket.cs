using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketingSystem {
    class Ticket {
        private int TicketID;
        private Departure Departure;
        private Route ARoute;
        private bool isValid;
        private DateTime PrintTime;
        private string SeatReservaton;
        private string TicketType;
        private DateTime ExpiryDate;

        public int TicketId() {
            return 0;
        }

        public Departure GetDeparture() {
            return null;
        }

        public Route GetRoute() {
            return null;
        }

        public void SetIsValid() {
            
        }

        public bool GetIsValid() {
            return false;
        }

        public DateTime GetPrintTime() {
            return DateTime.Now;
        }

        public String GetSeatReservation() {
            return "";
        }

        public DateTime GetExpiryDate() {
            return DateTime.Now;
        }
    }
}

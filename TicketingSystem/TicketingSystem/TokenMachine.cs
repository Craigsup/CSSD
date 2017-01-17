using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem {
    class TokenMachine {
        private CustomerAccount AnAccount;
        private CardReader Reader;
        private Ticket Ticket;
        private SmartCard Card;
        private DateTime DateTimePrint;
        private Payment Payment;
        private float DayPassPrice;

        public void PrintTicket() {

        }

        public Ticket DispenseTicket() {
            return null;
        }

        public void PrintCard() {

        }

        public SmartCard DispenseCard() {
            return null;
        }

        public float NumberOfDaysPrice(int days) {
            return 0;
        }

        public float GetDayPassPrice() {
            return 0;
        }

        public bool MakeCashPayment(float x, float y) {
            return true;
        }

        public void MakeCardPayment(float x) {
            
        }
    }
}

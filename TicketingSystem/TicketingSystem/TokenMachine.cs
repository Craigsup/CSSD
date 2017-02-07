using System;

namespace TicketingSystem {
    class TokenMachine {
        private CustomerAccount _anAccount;
        private CardReader _reader;
        private Ticket _ticket;
        private SmartCard _card;
        private DateTime _dateTimePrint;
        private Payment _payment;
        private float _dayPassPrice;

        public TokenMachine(float dayPassPrice, Payment payment, DateTime dateTimePrint, SmartCard card, Ticket ticket, CardReader reader, CustomerAccount anAccount) {
            _dayPassPrice = dayPassPrice;
            _payment = payment;
            _dateTimePrint = dateTimePrint;
            _card = card;
            _ticket = ticket;
            _reader = reader;
            _anAccount = anAccount;
        }

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

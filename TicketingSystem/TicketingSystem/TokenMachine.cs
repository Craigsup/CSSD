using System;

namespace TicketingSystem {
    class TokenMachine {
        private CustomerAccount _anAccount;
        private CardReader _reader;
        private Ticket _ticket;
        private SmartCard _card;
        private DateTime _dateTimePrint;
        private Payment _payment;
        private decimal _dayPassPrice;

        public TokenMachine(decimal dayPassPrice) {
            _dayPassPrice = dayPassPrice;
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

        public decimal NumberOfDaysPrice(int days) {
            return GetDayPassPrice() * days;
        }

        public decimal GetDayPassPrice() {
            return _dayPassPrice;
        }

        public bool MakeCashPayment(decimal due, decimal given) {
            if (_payment == null) {
                _payment = new Payment(due);
            }
            else {
                _payment.CashPayment(given);
                _payment = new Payment(_payment.GetBalance());
            }

            
            return true;
        }

        public void MakeCardPayment(float x) {
            
        }
    }
}

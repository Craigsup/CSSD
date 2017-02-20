
using System;

namespace TicketingSystem {
    public class Payment {
        private CustomerAccount _account;
        private decimal _amountPayed;
        private decimal _amountOwed;
        private DateTime _dateTime;

        public Payment(decimal amountOwed, decimal amountPaid) {
            _amountOwed = amountOwed;
            _amountPayed = amountPaid;
            _dateTime = DateTime.Now;
        }

        public float AddBalance(float x, float y) {
            return 0;
        }

        public float SubtractBalance(float x, float y) {
            return 0;
        }

        public void CashPayment(decimal x) {
            _amountOwed -= x;
            _amountPayed += x;
        }

        public void SetAmountPayed(float x) {

        }

        public void SetAccount(CustomerAccount account) {

        }

        public float GetAmountPaid() {
            return 0;
        }

        public decimal GetBalance() {
            return _amountOwed;
        }
    }
}

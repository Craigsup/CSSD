using System;
using System.Collections.Generic;

namespace ModifiedTicketingSystem
{
    [Serializable]
    public class PaymentList {
        private List<Payment> _listOfPayments;

        public PaymentList() {
            _listOfPayments = new List<Payment>();
        }

        public void AddPayment(Payment x) {
            _listOfPayments.Add(x);
        }

        public Payment GetPaymentByIndex(int index) {
            return _listOfPayments[index];
        }

        public int GetSize() {
            return _listOfPayments.Count;
        }

        public Payment GetPaymentsByDateAndAcc(CustomerAccount x, DateTime y) {
            return null;
        }
    }
}

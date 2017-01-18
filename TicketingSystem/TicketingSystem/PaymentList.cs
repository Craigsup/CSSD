using System;
using System.Collections.Generic;

namespace TicketingSystem
{
    public class PaymentList {
        private List<Payment> _listOfPayments;

        public void AddPayment(Payment x) {
            _listOfPayments.Add(x);
        }

        public Payment GetPaymentsByDateAndAcc(CustomerAccount x, DateTime y) {
            return null;
        }
    }
}

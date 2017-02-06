using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem
{
    public class PaymentCard
    {
        private int _cardNumber;
        private DateTime _expiryDate;
        private DateTime? _startDate;
        private string _cardHolderName;

        public PaymentCard (int cardnumber, DateTime expiryDate, DateTime? startDate, string cardHolderName) {
            _cardNumber = cardnumber;
            _expiryDate = expiryDate;
            _startDate = startDate;
            _cardHolderName = cardHolderName;
        }

        public string GetLastFourDigits() {
            return "**** **** **** "+_cardNumber.ToString().Substring(11);
        }
    }
}

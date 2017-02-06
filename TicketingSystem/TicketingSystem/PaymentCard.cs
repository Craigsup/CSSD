using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem
{
    [Serializable]
    public class PaymentCard
    {
        [DataMember]
        private int _cardNumber;
        [DataMember]
        private DateTime _expiryDate;
        [DataMember]
        private DateTime? _startDate;
        [DataMember]
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

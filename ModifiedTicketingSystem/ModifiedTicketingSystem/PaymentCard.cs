using System;
using System.Runtime.Serialization;

namespace ModifiedTicketingSystem
{
    [Serializable]
    public class PaymentCard
    {
        [DataMember]
        private string _cardNumber;
        [DataMember]
        private DateTime _expiryDate;
        [DataMember]
        private DateTime? _startDate;
        [DataMember]
        private string _cardHolderName;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardnumber"></param>
        /// <param name="expiryDate"></param>
        /// <param name="startDate"></param>
        /// <param name="cardHolderName"></param>
        public PaymentCard (string cardnumber, DateTime expiryDate, string cardHolderName) {
            _cardNumber = cardnumber;
            _expiryDate = expiryDate;
            _cardHolderName = cardHolderName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetLastFourDigits() {
            return "**** **** **** "+_cardNumber.Substring(11);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace TicketingSystem {
    [Serializable]
    [DataContract]
    public class CustomerAccount : Account {
        [DataMember]
        protected int _cardId;
        [DataMember]
        protected decimal _balance;
        [DataMember]
        protected List<PaymentCard> _savedPaymentMethods;
        [DataMember]
        protected JourneyList _JourneyList;
        [DataMember]
        protected Station _startStation;
        [DataMember]
        protected Station _endStation;
        [DataMember]
        protected PaymentList _paymentList;

        public CustomerAccount(int cardId, decimal balance, int accountId, string username, string password, string fullName, bool loginStatus) : base(accountId, username, password, fullName, loginStatus) {
            _cardId = cardId;
            _balance = balance;
            _savedPaymentMethods = new List<PaymentCard>();
            _JourneyList = new JourneyList();
            _paymentList = new PaymentList();
        }

        public CustomerAccount() {
        }

        public int GetCardId() {
            return _cardId;
        }

        public T GetXByAccountId<T>(int accountId, string x)
        {
            var accs = ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt");
            foreach (var account in accs)
            {
                if (accountId == account._accountId)
                {
                    switch(x){
                        case "balance":
                            return (T)Convert.ChangeType(account._balance, typeof(T));
                        case "cardid":
                            return (T)Convert.ChangeType(account._cardId, typeof(T));
                        case "fullname":
                            return (T)Convert.ChangeType(account._fullName, typeof(T));
                        case "username":
                            return (T)Convert.ChangeType(account._username, typeof(T));
                        case "paymentoptions":
                            return (T) Convert.ChangeType(account.GetSavedPaymentDigits(), typeof(T));
                    }
                }
            }
            return default(T);
        }

        public decimal GetBalance() {
            return _balance;
        }

        public void GetAllJourneys() {

        }

        public void UpdateBalance(decimal x) {
            _balance += x;
        }

        public void SetStartPoint(Station x) {
            _startStation = x;
        }

        public void SetEndPoint(Station x) {
            _endStation = x;
        }

        public Station GetStartPoint() {
            return _startStation;
        }

        public Station GetEndPoint() {
            return _endStation;
        }

        public void SetFreeTravel(bool x) {
            
        }

        public bool GetFreeTravel() {
            return false;
        }

	    public void TopUpBalance(int accountId, decimal topUp){
            new AccountList().UpdateData(accountId, topUp);
        }

        public List<string> GetSavedPaymentDigits() {
            return _savedPaymentMethods.Select(x => x.GetLastFourDigits()).ToList();
        }

        



    }
}

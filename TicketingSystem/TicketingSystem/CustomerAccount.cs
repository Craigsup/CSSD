using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TicketingSystem {
    [Serializable]
    [DataContract]
    public class CustomerAccount : Account {
        [DataMember]
        protected int _cardId;
        [DataMember]
        protected float _balance;

        public CustomerAccount(int cardId, float balance, int accountId, string username, string password, string fullName, bool loginStatus) : base(accountId, username, password, fullName, loginStatus) {
            _cardId = cardId;
            _balance = balance;
        }

        public CustomerAccount() {
        }

        public int GetCardId() {
            return 0;
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
                    }
                }
            }
            return default(T);
        }

        public float GetBalance() {
            return _balance;
        }

        public void GetAllJourneys() {

        }

        public void UpdateBalance(float x) {
            _balance += x;
        }

        public void SetStartPoint(Station x) {

        }

        public void SetEndPoint(Station x) {

        }

        public Station GetStartPoint() {
            return null;
        }

        public Station GetEndPoint() {
            return null;
        }

        public void SetFreeTravel(bool x) {

        }

        public bool GetFreeTravel() {
            return false;
        }

	public void TopUpBalance(int accountId, float topUp){
            new AccountList().UpdateData(accountId, topUp);
        }
    }
}

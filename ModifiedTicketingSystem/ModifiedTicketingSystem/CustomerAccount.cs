using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace ModifiedTicketingSystem {
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
        [DataMember]
        protected List<PaymentList> _transactionList;
        [DataMember]
        protected bool _freeTravel;

        /// <summary>
        /// A constructor for the CustomerAccount class that takes parameters
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="balance"></param>
        /// <param name="accountId"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="loginStatus"></param>
        public CustomerAccount(int cardId, decimal balance, int accountId, string username, string password, string fullName, bool loginStatus) : base(accountId, username, password, fullName, loginStatus) {
            _cardId = cardId;
            _balance = balance;
            _savedPaymentMethods = new List<PaymentCard>();
            _JourneyList = new JourneyList();
            _paymentList = new PaymentList();
            _transactionList = new List<PaymentList>();
            _freeTravel = false;
        }

        /// <summary>
        /// a constructor for the CustomerAccount class
        /// </summary>
        public CustomerAccount() {
        }

        public CustomerAccount(int id) {
            var temp = new AccountList(false).GetAccountById(id);

            _cardId = temp._cardId;
            _balance = temp._balance;
            _savedPaymentMethods = temp._savedPaymentMethods;
            _JourneyList = temp._JourneyList;
            _paymentList = temp._paymentList;
            _transactionList = temp._transactionList;
            _endStation = temp._endStation;
            _startStation = temp._startStation;
            _loginStatus = temp._loginStatus;
            _accountId = temp._accountId;
            _fullName = temp._fullName;
            _password = temp._password;
            _username = temp._username;
        }

        /// <summary>
        /// a method that returns cardId
        /// </summary>
        /// <returns>a cardId</returns>
        public int GetCardId() {
            return _cardId;
        }

        /// <summary>
        /// a method that loops through all of the accounts and checks them against the accountId parameter and then uses the command stored in the x parameter to decide what to return from the account
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="accountId"></param>
        /// <param name="x"></param>
        /// <returns>depending on the x parameter: balance, cardId, fullName, username or the payment digits </returns>
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

        /// <summary>
        /// a method that returns the balance
        /// </summary>
        /// <returns>the balance</returns>
        public decimal GetBalance() {
            return _balance;
        }

        /// <summary>
        /// a method that does nothing
        /// </summary>
        public void GetAllJourneys() {

        }

        /// <summary>
        /// a method that adds the parameter x to the balance of the customeraccount
        /// </summary>
        /// <param name="x"></param>
        public void UpdateBalance(decimal x) {
            _balance += x;
            new AccountList(false).UpdateAccount(this);
        }

        /// <summary>
        /// a method that sets the start station to the parameter x
        /// </summary>
        /// <param name="x"></param>
        public void SetStartPoint(Station x) {
            _startStation = x;
        }

        /// <summary>
        /// a method that sets the end station to the parameter x
        /// </summary>
        /// <param name="x"></param>
        public void SetEndPoint(Station x) {
            _endStation = x;
        }

        /// <summary>
        /// a method that returns the start station
        /// </summary>
        /// <returns>the start station</returns>
        public Station GetStartPoint() {
            return _startStation;
        }

        /// <summary>
        /// a method that returns the end station
        /// </summary>
        /// <returns>the end station</returns>
        public Station GetEndPoint() {
            return _endStation;
        }

        /// <summary>
        /// a method that does nothing
        /// </summary>
        /// <param name="x"></param>
        public void SetFreeTravel(bool x) {
            _freeTravel = x;
        }

        /// <summary>
        /// a method that returns false
        /// </summary>
        /// <returns>false</returns>
        public bool GetFreeTravel() {
            return _freeTravel;
        }

        /// <summary>
        /// a method that creates a new accountlist and then calls the UpdateData method with the required parameters
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="topUp"></param>
	    public void TopUpBalance(int accountId, decimal topUp){
            new AccountList(false).UpdateData(accountId, topUp);
        }

        public void AddPaymentCard(int accountId, string cardId, string expDate, string accName) {
            var card = cardId;

            var expiryDate = new DateTime(int.Parse(expDate.Substring(3)), int.Parse(expDate.Substring(0, 2)), 1);

            PaymentCard newCard = new PaymentCard(card , expiryDate , accName );
            _savedPaymentMethods.Add(newCard);
            new AccountList(false).UpdateAccount(this);

        }

        public void AddTransaction(PaymentList transaction) {
            if (_transactionList == null) {
                _transactionList = new List<PaymentList>();
            }

            _transactionList.Add(transaction);
            new AccountList(false).UpdateAccount(this);
        }


        /// <summary>
        /// a method that returns the last four digits of each payment card in a list of payment cards
        /// </summary>
        /// <returns></returns>
        public List<string> GetSavedPaymentDigits() {
            return _savedPaymentMethods.Select(x => x.GetLastFourDigits()).ToList();
        }


        public decimal GetTotalPaidByDate(DateTime date) {
            return _paymentList.GetPaymentsByDate(date).Sum(x => x.GetAmountPaid());
        }

        public int GetId() {
            return _accountId;
        }

        public override string ToString() {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}", this._cardId.ToString(), 
                this._balance, this._savedPaymentMethods, this._JourneyList, this._startStation, this._endStation, this._paymentList, 
                this._transactionList, this._freeTravel, base._accountId, base._fullName, base._loginStatus, base._password, base._username);
        }

    }
}

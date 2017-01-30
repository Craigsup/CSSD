using System;
using System.Runtime.Serialization;

namespace TicketingSystem {
    [Serializable]
    [DataContract]
    public class CustomerAccount : Account {
        [DataMember]
        private int _cardId { get; }
        [DataMember]
        private float _balance { get; }

        public CustomerAccount(int cardId, float balance, int accountId, string username, string password, string fullName, bool loginStatus) : base(accountId, username, password, fullName, loginStatus) {
            _cardId = cardId;
            _balance = balance;
        }

        public CustomerAccount() {
        }

        public int GetCardId() {
            return 0;
        }

        public float GetBalance() {
            return 0f;
        }

        public void GetAllJourneys() {

        }

        public void UpdateBalance(float x) {

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
    }
}

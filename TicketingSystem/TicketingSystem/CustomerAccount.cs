namespace TicketingSystem {
    public class CustomerAccount : Account {
        private int _cardId;
        private float _balance;

        public CustomerAccount(int cardId, float balance, int accountId, string fullName, string password, bool loginStatus, string username) : base(accountId, fullName, password, loginStatus, username) {
            _cardId = cardId;
            _balance = balance;
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

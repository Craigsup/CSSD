namespace TicketingSystem {
    class CustomerAccount : Account {
        private int _cardId;
        private float _balance;

        public CustomerAccount(int cardId, float balance) {
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

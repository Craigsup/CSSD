namespace TicketingSystem {
    class Payment {
        private CustomerAccount _anAccount;
        private float _amountPayed;

        public Payment(CustomerAccount anAccount, float amountPayed) {
            _anAccount = anAccount;
            _amountPayed = amountPayed;
        }

        public float AddBalance(float x, float y) {
            return 0;
        }

        public float SubtractBalance(float x, float y) {
            return 0;
        }

        public void CashPayment(float x) {

        }

        public void SetAmountPayed(float x) {

        }

        public void SetAccount(CustomerAccount account) {

        }

        public float GetAmountPaid() {
            return 0;
        }
    }
}

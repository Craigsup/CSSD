namespace TicketingSystem {
    public class MobileApp {
        private int _anAccount;
        private Payment _payment;

        public MobileApp(int anAccount) {
            _anAccount = anAccount;
        }

        public bool MakePayment(float x) {
            new CustomerAccount().TopUpBalance(_anAccount, x);
            return true;
        }
    }
}
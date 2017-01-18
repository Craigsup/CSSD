namespace TicketingSystem {
    public class MobileApp {
        private CustomerAccount _anAccount;
        private Payment _payment;

        public MobileApp(Payment payment, CustomerAccount anAccount) {
            _payment = payment;
            _anAccount = anAccount;
        }

        public bool MakePayment(float x) {
            return false;
        }
    }
}
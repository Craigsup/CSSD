using System;
using System.Threading;

namespace TicketingSystem
{
    class Scanner {
        private SmartCard _aSmartCard;
        private Ticket _aTicket;
        private TokenValidator _validator;
        private Barrier _aBarrier;
        private ScannerFeedback _feedback;
        private DateTime _scanTime;
        private Payment _payment;
        private string _location;
        private CustomerAccount _account;
        private AccountList _accounts;
        private float _dayPassPrice;

        public void AddScannedCard(SmartCard x) {
            
        }

        public void AddScannedTicket(Ticket x) {
            
        }

        public bool ValidateCard(SmartCard x) {
            return false;
        }

        public bool ValidateTicket(Ticket x) {
            return false;
        }

        public DateTime GetScannedTime() {
            return _scanTime;
        }

        public void SetScannedTime() {
            
        }

        public void MakePayment() {
            
        }

        public bool IsStartPointDefined() {
            return false;
        }

        public void SetActiveAccount(CustomerAccount x) {
            
        }

        public float TotalDailyPayment() {
            return 0f;
        }
    }
}

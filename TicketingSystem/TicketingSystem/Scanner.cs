using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace TicketingSystem
{
    public class Scanner {
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

        public Scanner() {
            _accounts = new AccountList(ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt"));
        }

        public void AddScannedCard(SmartCard x) {
            SetActiveAccount(_accounts.GetAccountByCardId(x.GetCardId()));

        }

        public void AddScannedTicket(Ticket x) {
            _aTicket = x;
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
            _scanTime = DateTime.Now;
        }

        public void MakePayment() {
            
        }

        public bool IsStartPointDefined() {
            return false;
        }

        public void SetActiveAccount(CustomerAccount x) {
            _account = x;
        }

        public float TotalDailyPayment() {
            return 0f;
        }
        
        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ModifiedTicketingSystem
{
    public class Scanner {
        private SmartCard _aSmartCard;
        private bool _entry;
        private Ticket _aTicket;
        private TokenValidator _validator;
        private Barrier _aBarrier;
        private ScannerFeedback _feedback;
        private DateTime _scanTime;
        private PaymentList _payment;
        private Station _location;
        private CustomerAccount _account;
        private AccountList _accounts;
        private float _dayPassPrice;
        private RouteList _routeList;

        public Scanner(Station location, bool entry) {
            _location = location;
            _entry = entry;
            _accounts = new AccountList(ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt"));

            _routeList = new RouteList();

        }

        public Scanner(Station location, bool entry, AccountList a, RouteList b) {
            _location = location;
            _entry = entry;
            _accounts = a;

            _routeList = new RouteList();
            _routeList = b;

        }

        public void AddScannedCard(SmartCard x) {
            if (_entry) {
                x.SetScannedTime();
            }

            _scanTime = DateTime.Now;
            SetActiveAccount(_accounts.GetAccountByCardId(x.GetCardId()));
            _aSmartCard = x;
            IsStartPointDefined();
            MakePayment();
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
            var start = _account.GetStartPoint();
            var end = _account.GetEndPoint();
            var route = _routeList.GetRouteByStations(start, end);
            var price = route.GetPrice();
//            if (_aSmartCard.GetScannedTime().ToLocalTime().Hour > 9 &&
//                _aSmartCard.GetScannedTime().ToLocalTime().Hour < 17) {
//                price *= 1.3m;
//            }

            if (start.GetDepartures().GetDeparture(end, _aSmartCard.GetScannedTime()).IsPeakDeparture()) {
                price *= 1.3m;
            }

            //_account


            // PAYMENT SHIT GOES HERE.
            //_account.

            /*PaymentList payList = new PaymentList();
            Payment payment1 = new Payment(price, 0);
            payList.AddPayment(payment1);
            payList.AddPayment(new Payment(payList.GetPaymentByIndex(0).GetBalance()-price, price));

            var temp = payList;*/
            // Basing _scanTime as time they scanned the exit 
            //hold departure time in smart card so that the scanner can know if the journey was a peak time journey.
        }

        public bool IsStartPointDefined() {
            if (_entry) {
                return false;
            }

            if (_account.GetStartPoint() == null) {
                return false;
            }
            _account.SetEndPoint(_location);
            return true;
        }

        public void SetActiveAccount(CustomerAccount x) {
            _account = x;
        }

        public float TotalDailyPayment() {
            return 0f;
        }
        
        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}

namespace TicketingSystem {
    public class Language {
        private string _nameOfLang;
        private string _ticketType;
        private string _route;
        private string _guestOptions;
        private string _departure;
        private string _starterOption;
        private string _paymentOptions;
        private string _finalMessage;
        
        public Language(string nameOfLang, string ticketType, string route, string guestOptions, string departure, string starterOption, string paymentOptions, string finalMessage) {
            _nameOfLang = nameOfLang;
            _ticketType = ticketType;
            _route = route;
            _guestOptions = guestOptions;
            _departure = departure;
            _starterOption = starterOption;
            _paymentOptions = paymentOptions;
            _finalMessage = finalMessage;
        }

        public string GetNameOfLang() {
            return _nameOfLang;
        }

        public string GetLogin() {
            return "";
        }

        public string GetTicketType() {
            return _ticketType ;
        }

        public string GetRoute() {
            return _route;
        }

        public string GetGuestOptions() {
            return _guestOptions;
        }

        public string GetDeparture() {
            return _departure;
        }

        public string GetStarterOption() {
            return _starterOption;
        }

        public string GetPaymentOptions() {
            return _paymentOptions;
        }

        public string GetFinalMessage() {
            return _finalMessage;
        }
    }
}

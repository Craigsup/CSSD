namespace TicketingSystem {
    public class Language {
        private readonly string _nameOfLang;
        private readonly string _ticketType;
        private readonly string _route;
        private readonly string _guestOptions;
        private readonly string _departure;
        private readonly string _starterOption;
        private readonly string _paymentOptions;
        private readonly string _finalMessage;
        
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

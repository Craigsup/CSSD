﻿using System.Collections.Generic;

namespace TicketingSystem {
    public class Language {
        private readonly string _nameOfLang;
        private readonly List<string> _ticketType;
        private readonly List<string> _route;
        private readonly List<string> _guestOptions;
        private readonly List<string> _loginOptions;
        private readonly List<string> _departure;
        private readonly string _starterOption;
        private readonly List<string> _paymentOptions;
        private readonly List<string> _finalMessage;
        private readonly string _optionText;
        
        public Language(string nameOfLang, List<string> ticketType, List<string> route, List<string> guestOptions, List<string> departure, string starterOption, List<string> paymentOptions, List<string> finalMessage, string optionText) {
            _nameOfLang = nameOfLang;
            _ticketType = ticketType;
            _route = route;
            _guestOptions = guestOptions;
            _departure = departure;
            _starterOption = starterOption;
            _paymentOptions = paymentOptions;
            _finalMessage = finalMessage;
            _optionText = optionText;
        }

        public string GetNameOfLang() {
            return _nameOfLang;
        }

        public List<string> GetLogin() {
            return _loginOptions;
        }

        public List<string> GetTicketType() {
            return _ticketType ;
        }

        public List<string> GetRoute() {
            return _route;
        }

        public List<string> GetGuestOptions() {
            return _guestOptions;
        }

        public List<string> GetDeparture() {
            return _departure;
        }

        public string GetStarterOption() {
            return _starterOption;
        }

        public List<string> GetPaymentOptions() {
            return _paymentOptions;
        }

        public List<string> GetFinalMessage() {
            return _finalMessage;
        }

        public string GetOptionText() {
            return _optionText;
        }

        public override string ToString() {
            return _nameOfLang;
        }
    }
}

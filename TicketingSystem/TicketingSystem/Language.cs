using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem {
    public class Language {
        private string NameOfLang;
        private string TicketType;
        private string Route;
        private string GuestOptions;
        private string Departure;
        private string StarterOption;
        private string PaymentOptions;
        private string FinalMessage;
        
        public Language() {
        }

        public string GetNameOfLang() {
            return NameOfLang;
        }

        public string GetLogin() {
            return "";
        }

        public string GetTicketType() {
            return TicketType ;
        }

        public string GetRoute() {
            return Route;
        }

        public string GetGuestOptions() {
            return GuestOptions;
        }

        public string GetDeparture() {
            return Departure;
        }

        public string GetStarterOption() {
            return StarterOption;
        }

        public string GetPaymentOptions() {
            return PaymentOptions;
        }

        public string GetFinalMessage() {
            return FinalMessage;
        }
    }
}

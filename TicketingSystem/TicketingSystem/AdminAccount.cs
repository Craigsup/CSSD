using System;

namespace TicketingSystem {
    [Serializable]
    public class AdminAccount : Account {
        private readonly RouteList _routes;
        public AdminAccount(RouteList routes, int accountId, string fullName, string password, string username, bool loginStatus)
            : base(accountId, username, password, fullName, loginStatus) {
            _routes = routes;
        }

        public PurchasedTicketList GetTicketList() {
            return null;
        }

        public RouteList GetRoutes() {
            return _routes;
        }

        public JourneyList GetJourneyList() {
            return null;
        }

        public void NewDeparture(Station x, DateTime y) {

        }

        public void NewRoute(Station x, Station y, DepartureList z) {

        }
    }
}

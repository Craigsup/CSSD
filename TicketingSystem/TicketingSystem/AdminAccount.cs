using System;

namespace TicketingSystem {
    /// <summary>
    /// 
    /// </summary>
    /// 
    [Serializable]
    public class AdminAccount : Account {
        private readonly RouteList _routes;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="routes"></param>
        /// <param name="accountId"></param>
        /// <param name="fullName"></param>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="loginStatus"></param>
        public AdminAccount(RouteList routes, int accountId, string fullName, string password, string username, bool loginStatus)
            : base(accountId, username, password, fullName, loginStatus) {
            _routes = routes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public PurchasedTicketList GetTicketList() {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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

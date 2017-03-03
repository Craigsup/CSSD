using System;

namespace ModifiedTicketingSystem {
    /// <summary>
    /// 
    /// </summary>
    /// 
    [Serializable]
    public class AdminAccount : Account {
        private readonly RouteList _routes;

        /// <summary>
        /// Constructor for the AdminAccount class
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
        /// A method that returns null
        /// </summary>
        /// <returns>null</returns>
        public PurchasedTicketList GetTicketList() {
            return null;
        }

        /// <summary>
        /// A method that returns the list of routes
        /// </summary>
        /// <returns>list of routes</returns>
        public RouteList GetRoutes() {
            return _routes;
        }

        /// <summary>
        /// A method that returns null
        /// </summary>
        /// <returns>null</returns>
        public JourneyList GetJourneyList() {
            return null;
        }

        /// <summary>
        /// A method that does nothing
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void NewDeparture(Station x, DateTime y) {

        }
        
        /// <summary>
        /// A method that does nothing
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public void NewRoute(Station x, Station y, DepartureList z) {

        }
    }
}

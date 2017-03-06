using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace ModifiedTicketingSystem {
    /// <summary>
    /// 
    /// </summary>
    /// 
    [Serializable]
    [DataContract]
    public class AdminAccount : Account {
        [DataMember]
        protected RouteList _routes;
        [DataMember]
        protected StationList _stations;
        /// <summary>
        /// Constructor for the AdminAccount class
        /// </summary>
        /// <param name="routes"></param>
        /// <param name="accountId"></param>
        /// <param name="fullName"></param>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="loginStatus"></param>
        public AdminAccount(int accountId, string fullName, string password, string username, bool loginStatus)
            : base(accountId, username, password, fullName, loginStatus) {
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

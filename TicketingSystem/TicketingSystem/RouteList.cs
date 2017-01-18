using System.Collections.Generic;

namespace TicketingSystem
{
    public  class RouteList {
        private List<Route> _listOfRoutes;

        public void AddRoute(Route x) {
            _listOfRoutes.Add(x);
        }

        public Route GetRouteByStations(Station x, Station y) {
            return null;
        }
    }
}
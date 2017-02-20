using System.Collections.Generic;
using System.Linq;

namespace TicketingSystem
{
    public  class RouteList {
        private List<Route> _listOfRoutes;

        public void AddRoute(Route x) {
            if (_listOfRoutes == null) {
                _listOfRoutes = new List<Route>();
            }

            _listOfRoutes.Add(x);
        }

        public Route GetRouteByStations(Station x, Station y) {
            return _listOfRoutes.FirstOrDefault(z => z.GetStartPoint() == x && z.GetEndPoint() == y);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketingSystem {
    public class Route {
        private Station RouteStartPoint;
        private Station RouteEndPoint;
        private float Price;

        public Station GetStartPoint() {
            return RouteStartPoint;
        }

        public Station GetEndPoint() {
            return RouteEndPoint;
        }

        public float GetPrice() {
            return Price;
        }

        public void SetRouteStartPoint(Station station) {
            RouteStartPoint = station;
        }

        public void SetRouteEndPoint(Station station) {
            RouteEndPoint = station;
        }

        public void SetPrice(float price) {
            Price = price;
        }
    }
}

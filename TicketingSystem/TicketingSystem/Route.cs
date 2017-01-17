namespace TicketingSystem {
    public class Route {
        private Station _routeStartPoint;
        private Station _routeEndPoint;
        private float _price;

        public Station GetStartPoint() {
            return _routeStartPoint;
        }

        public Station GetEndPoint() {
            return _routeEndPoint;
        }

        public float GetPrice() {
            return _price;
        }

        public void SetRouteStartPoint(Station station) {
            _routeStartPoint = station;
        }

        public void SetRouteEndPoint(Station station) {
            _routeEndPoint = station;
        }

        public void SetPrice(float price) {
            _price = price;
        }
    }
}

using System;

namespace TicketingSystem
{
    [Serializable]
    public class Journey {
        protected readonly DateTime _routeCompletion;
        protected readonly Route _theRoute;
        protected readonly CustomerAccount _customer;

        public Journey(CustomerAccount customer, Route theRoute, DateTime routeCompletion) {
            _customer = customer;
            _theRoute = theRoute;
            _routeCompletion = routeCompletion;
        }

        public Route GetRoute() {
            return _theRoute;
        }

        public DateTime GetCompletionTime() {
            return _routeCompletion;
        }

        public CustomerAccount GetCustomer() {
            return _customer;
        }
    }
}

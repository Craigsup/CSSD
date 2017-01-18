using System;

namespace TicketingSystem
{
    public class Journey {
        private readonly DateTime _routeCompletion;
        private readonly Route _theRoute;
        private readonly CustomerAccount _customer;

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

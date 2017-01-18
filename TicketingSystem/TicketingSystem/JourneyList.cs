using System;
using System.Collections.Generic;

namespace TicketingSystem
{
    public class JourneyList {
        private List<Journey> _listOfJourneys;

        public void AddJourney(Journey x) {
            _listOfJourneys.Add(x);
        }

        public List<Journey> GetJourneys(Route x, DateTime y, DateTime z) {
            return _listOfJourneys;
        }

        public List<Journey> GetJourneysForAccount(CustomerAccount x) {
            return null;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TicketingSystem
{
    [Serializable]
    public class JourneyList {
        [DataMember]
        protected List<Journey> _listOfJourneys;

        public JourneyList() {
            _listOfJourneys = new List<Journey>();
        }

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
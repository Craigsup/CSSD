using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedTicketingSystem {
    public class StationList {
        private List<Station> _listOfStations;

        public StationList() {
            _listOfStations = new List<Station>();
        }
        
        public void AddStation(string x) {
            _listOfStations.Add(new Station(new DepartureList(), x));
        }
    }
}

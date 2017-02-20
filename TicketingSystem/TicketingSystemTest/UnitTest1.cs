using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketingSystem;

namespace TicketingSystemTest {
    [TestClass]
    public class UnitTest1 {
        /*
         * This unit test will create two barriers for which a user will be loaded in 
         * and scanned through the barriers to simulate them taking a train ride.
         */
        [TestMethod]
        public void TestMethod1() {
            // Bob's smart card
            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);
            SmartCard bobSmartCard = new SmartCard(bobAccount.GetCardId());
            bobSmartCard.SetScannedTime(new DateTime(2017, 02, 20, 14, 0, 0));

            DepartureList departureList = new DepartureList();
            departureList.AddDeparture(new Departure(new Station("Sheffield"), new DateTime(2017, 02, 20, 15, 05, 0)));

            Station startStation = new Station(departureList, "Newcastle");
            Station endStation = new Station(new DepartureList(), "Sheffield");
            RouteList startStationRouteList = new RouteList();
            startStationRouteList.AddRoute(new Route(startStation, endStation, 52.70m));
            Scanner scannerA = new Scanner(endStation, false, new AccountList(new List<CustomerAccount> { bobAccount }), startStationRouteList);
            bobAccount.SetStartPoint(startStation);


            scannerA.AddScannedCard(bobSmartCard);









           
        }
    }
}

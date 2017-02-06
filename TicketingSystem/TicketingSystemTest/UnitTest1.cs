using System;
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
            SmartCard bobSmartCard = new SmartCard(1);
            Scanner scannerA = new Scanner();
            scannerA.AddScannedCard(bobSmartCard);
            scannerA.
            
        }
    }
}

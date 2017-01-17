using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketingSystem {
    class CustomerAccount : Account {
        private int CardID;
        private float Balance;

        public int GetCardID() {
            return 0;
        }

        public float GetBalance() {
            return 0f;
        }

        public void GetAllJourneys() {

        }

        public void UpdateBalance(float x) {

        }

        public void SetStartPoint(Station x) {

        }

        public void SetEndPoint(Station x) {

        }

        public Station GetStartPoint() {
            return null;
        }

        public Station GetEndPoint() {
            return null;
        }

        public void SetFreeTravel(bool x) {
            
        }

        public bool GetFreeTravel() {
            return false;
        }
    }
}

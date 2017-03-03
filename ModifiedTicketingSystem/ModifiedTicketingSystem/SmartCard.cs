using System;

namespace ModifiedTicketingSystem {
    public class SmartCard {
        private readonly int _cardId;
        private DateTime _scannedTime;

        public SmartCard(int cardId) {
            _cardId = cardId;
        }

        public int GetCardId() {
            return _cardId;
        }

        public void SetScannedTime() {
            _scannedTime = DateTime.Now;
        }

        public void SetScannedTime(DateTime x) {
            _scannedTime = x;
        }

        public DateTime GetScannedTime() {
            return _scannedTime;
        }
    }
}

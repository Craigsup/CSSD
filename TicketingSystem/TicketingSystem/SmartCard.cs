namespace TicketingSystem {
    class SmartCard {
        private readonly int _cardId;

        public SmartCard(int cardId) {
            _cardId = cardId;
        }

        public int GetCardId() {
            return _cardId;
        }
    }
}

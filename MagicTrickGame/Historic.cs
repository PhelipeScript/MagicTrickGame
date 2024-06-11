namespace MagicTrickGame
{
    public class Historic
    {
        public int round;
        public Card card;

        public Historic(int round, string cardSuitLetter, int cardValue, string cardIndex)
        {
            this.round = round;
            this.card = new Card(cardIndex, cardSuitLetter, PlayerPosition.BOTTOM);
            card.value = cardValue;
        }

        public Historic(int round, Card playerCard)
        {
            this.round = round;
            this.card = playerCard;
        }
    }
}

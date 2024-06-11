namespace MagicTrickGame
{
    public class Bet
    {
        string playerId;
        char cardSuitLetter;
        int cardValue;
        int round;
        int index;

        public string PlayerId { get { return this.playerId; } }
        public char CardSuitLetter { get { return this.cardSuitLetter; } }
        public int CardValue { get { return this.cardValue; } }
        public int Round { get { return this.round; } }
        public int Index { get { return this.index; } }

        public Bet(string playerId, char cardSuitLetter, int cardNumber, int round, int index)
        {
            this.playerId = playerId;
            this.cardSuitLetter = cardSuitLetter;
            this.cardValue = cardNumber;
            this.round = round;
            this.index = index;
        }
    }
}

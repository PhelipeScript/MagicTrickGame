using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTrickGame
{
    internal class History
    {
        public int round;
        public string playerId;
        public char cardSuitLetter;
        public int cardValue;

        public History(string historyData)
        {
            string[] data = historyData.Split(',');
            this.round = Convert.ToInt32(data[0]);
            this.playerId = data[1];
            this.cardSuitLetter = Convert.ToChar(data[2]);
            this.cardValue = Convert.ToInt32(data[3]);
        }
    }
}

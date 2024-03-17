using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicTrickServer;

namespace MagicTrickGame
{
    public enum PlayerPosition
    {
        BOTTOM,
        LEFT,
        TOP,
        RIGHT,
    };

    public class Player
    {
        public string id;
        public string name;
        public int score;
        public string password;
        public List<Card> cards = new List<Card>();
        public List<Button> btnCards = new List<Button>();
        public PlayerPosition playerPosition;

        public Player(string playerData = "")
        {
            if (playerData == "")
            {
                this.id = null;
                this.name = null;
                this.score = 0;
            } else
            {
                string[] data = playerData.Split(',');
                this.id = data[0];
                this.name = data[1];
                this.score = Convert.ToInt32(data[2]);
            }
        }

        public void fetchCards(int matchId) 
        {
            string response = Jogo.ConsultarMao(matchId);
            if (response.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            response = response.Replace("\r", "");
            response = response.Substring(0, response.Length - 1);
            string[] cards = response.Split('\n');

            foreach (var card in cards)
            {
                string[] cardData = card.Split(',');

                if (cardData[0] == this.id)
                {
                    this.cards.Add(new Card(cardData[1], cardData[2], this.playerPosition));
                }
            }
        } 

        public void distributeCards()
        {
            foreach (var btn in btnCards)
            {
                btn.Enabled = false;
                btn.BackgroundImage = null;
                btn.Text = null;
            }

            for (int i = 0; i < this.cards.Count; i++)
            {
                this.btnCards[i].BackgroundImage = this.cards[i].img;
                this.btnCards[i].Enabled = true;
            }
        }
    }
}

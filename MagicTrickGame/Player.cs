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

        public void AddClickEventToButtons()
        {
            foreach (var btn in this.btnCards)
            {
                btn.Click += this.BtnCardClickEventHandler;
            }
        }

        private void BtnCardClickEventHandler(object sender, EventArgs e)
        {
            Button btnCard = (Button)sender;
            int btnCardIndex = this.btnCards.IndexOf(btnCard);

            int cardValue = this.PlayCard(Convert.ToInt32(this.id), this.password, this.cards[btnCardIndex].index);

            if (cardValue != -1) 
            {
                this.cards[btnCardIndex].value = cardValue;
                btnCard.Text = cardValue.ToString();
            }
        }

        private int PlayCard(int playerId, string playerPassword, int cardIndex)
        {
            string response = Jogo.Jogar(playerId, playerPassword, cardIndex);
            if (response.Length >= 4 && response.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            return Convert.ToInt32(response);
        }

        public void SkipBet()
        {
            string response = Jogo.Apostar(Convert.ToInt32(this.id), this.password, 0);
            if (response.Length >= 4 && response.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

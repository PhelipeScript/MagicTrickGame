using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicTrickGame.Controllers;
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

    public enum PlayerStatus
    {
        Play,
        Bet,
        Wait,
    };

    public class Player
    {
        public string id;
        public string name;
        public int score;
        public int finalScore;
        public string password;
        public Bet bet;
        public List<Card> cards = new List<Card>();
        public List<Button> btnCards = new List<Button>();
        public PlayerPosition playerPosition;
        public PlayerStatus status;

        public Player(string playerData = "")
        {
            if (playerData == "")
            {
                this.id = null;
                this.name = null;
                this.score = 0;
                this.finalScore = 0;
                this.bet = null;
                this.status = PlayerStatus.Wait;
            } else
            {
                string[] data = playerData.Split(',');
                this.id = data[0];
                this.name = data[1];
                this.score = Convert.ToInt32(data[2]);
                this.finalScore = 0;
                this.bet = null;
                this.status = PlayerStatus.Wait;
            }
        }

        public void fetchCards(string playersCardsData) 
        {
            if (playersCardsData == null) return;

            this.cards.Clear();

            foreach (string line in playersCardsData.Split('\n'))
            {
                string[] cardData = line.Split(',');

                if (cardData[0] == this.id)
                {
                    this.cards.Add(new Card(cardData[1], cardData[2], this.playerPosition));
                }
            }
        } 

        public void distributeCards()
        {
            foreach (Button btn in btnCards)
            {
                btn.BackgroundImage = null;
                btn.Text = null;
                btn.Enabled = false;
            }

            for (int i = 0; i < this.cards.Count; i++)
            {
                this.btnCards[i].Text = this.cards[i].value.Equals(-1) ? "" : this.cards[i].value.ToString();
                this.btnCards[i].BackgroundImage = this.cards[i].img;
                this.btnCards[i].Enabled = true;
            }
        }

        public void AddClickEventToButtons()
        {
            foreach (Button btn in this.btnCards)
            {
                btn.Click += this.BtnCardClickEventHandler;
            }
        }

        private void BtnCardClickEventHandler(object sender, EventArgs e)
        {
            Button btnCard = (Button)sender;
            int btnCardIndex = this.btnCards.IndexOf(btnCard);

            if (this.status == PlayerStatus.Play)
            {
                this.PlayCard(Convert.ToInt32(this.id), this.password, this.cards[btnCardIndex].index);
            } 
            else if (this.status == PlayerStatus.Bet)
            {
                this.BetCard(Convert.ToInt32(this.id), this.password, this.cards[btnCardIndex].index);
            }                    
        }

        public void PlayCard(int playerId, string playerPassword, int cardIndex)
        {
            Controllers.PlayCard.Handle(playerId, playerPassword, cardIndex);
        }

        public void BetCard(int playerId, string playerPassword, int cardIndex)
        {
            Controllers.BetCard.Handle(playerId, playerPassword, cardIndex);
        }

        public void SkipBet(int playerId, string playerPassword)
        {
            Controllers.BetCard.Handle(playerId, playerPassword, 0);
        }
    }
}

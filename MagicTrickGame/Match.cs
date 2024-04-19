using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicTrickGame
{
    public partial class Match : Form
    {
        private int timerWhoStartsCounter = 0;
        private int timerWhoStartsCounterLimit = 0;
        private string whoIsPlayingNowText = "";
        private string playerWhoStartsId;
        public int matchId;
        public List<Player> players = new List<Player>();
        public int roundByCardsPlayed = 1;
        public int maxRoundByCardsPlayed;
        public int round = 1;

        public Match(int matchId, string playerWhoStartsId, Player me)
        {
            InitializeComponent();
            this.resetCardsPlayed();
            this.WindowState = FormWindowState.Maximized;
            this.matchId = matchId;
            this.playerWhoStartsId = playerWhoStartsId;

            lblWhoIsPlayingNow.Text = "";
            timerWhoStarts.Interval = 100;
            timerWhoStarts.Start();

            string response = Jogo.ListarJogadores(this.matchId);
            if (response.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            response = response.Replace("\r", "");
            response = response.Substring(0, response.Length - 1);
            foreach (string playerData in response.Split('\n'))
            {
                this.players.Add(new Player(playerData));
            };

            while (this.players[0].id != me.id)
            {
                Player player = this.players[0];
                this.players.RemoveAt(0);
                this.players.Add(player);
            }

            this.handlePlayersAmount(this.players.Count);

            foreach (Player player in players)
            {
                player.fetchCards(this.matchId);
                player.distributeCards();
            }

            this.players[0].password = me.password;
            this.players[0].AddClickEventToButtons();
        }

        public void resetCardsPlayed()
        {
            btnCardP1Played.Text = "";
            btnCardP1Played.BackgroundImage = null;

            btnCardP2Played.Text = "";
            btnCardP2Played.BackgroundImage = null;

            btnCardP3Played.Text = "";
            btnCardP3Played.BackgroundImage = null;

            btnCardP4Played.Text = "";
            btnCardP4Played.BackgroundImage = null;
        }

        private void timerWhoStarts_Tick(object sender, EventArgs e)
        {
            this.handleWhoIsPlayingNowLabel();
        }

        private void handleWhoIsPlayingNowLabel()
        {
            if (this.whoIsPlayingNowText == "")
            {
                Player playerWhoStart = this.players.Find(player => player.id == this.playerWhoStartsId);
                this.whoIsPlayingNowText = $"Jogador {playerWhoStart.id} {playerWhoStart.name} Começa!";
                this.timerWhoStartsCounterLimit = this.whoIsPlayingNowText.Length * 2;
            }

            if (this.timerWhoStartsCounter >= this.timerWhoStartsCounterLimit)
            {
                timerWhoStarts.Stop();
                lblWhoIsPlayingNow.Text = "";
                this.whoIsPlayingNowText = "";
                lblWhoIsPlayingNow.Visible = false;
                this.timerWhoStartsCounter = 0;
            } else
            {
                if (this.timerWhoStartsCounter < this.whoIsPlayingNowText.Length)
                {
                    this.lblWhoIsPlayingNow.Text += this.whoIsPlayingNowText[this.timerWhoStartsCounter];
                }
                this.timerWhoStartsCounter++;
            }
        }

        private void handlePlayersAmount(int playerAmount)
        {
            switch (playerAmount)
            {
                case 2:
                    pnlPlayer1.Visible = true;
                    pnlPlayer2.Visible = false;
                    pnlPlayer3.Visible = true;
                    pnlPlayer4.Visible = false;

                    this.players[0].playerPosition = PlayerPosition.BOTTOM;
                    lblP1Id.Text = this.players[0].id;
                    lblP1Name.Text = this.players[0].name;
                    lblP1Bet.Text = "0/?";
                    lblP1Score.Text = this.players[0].score.ToString();
                    foreach (Control control in pnlPlayer1.Controls)
                    {
                        if (control is Button)
                        {
                            this.players[0].btnCards.Add((Button)control);
                        }
                    }

                    this.players[1].playerPosition = PlayerPosition.TOP;
                    lblP3Id.Text = this.players[1].id;
                    lblP3Name.Text = this.players[1].name;
                    lblP3Bet.Text = "0/?";
                    lblP3Score.Text = this.players[1].score.ToString();
                    foreach (Control control in pnlPlayer3.Controls)
                    {
                        if (control is Button)
                        {
                            this.players[1].btnCards.Add((Button)control);
                        }
                    }

                    this.maxRoundByCardsPlayed = 11;
                    break;
                case 4:
                    pnlPlayer1.Visible = true;
                    pnlPlayer2.Visible = true;
                    pnlPlayer3.Visible = true;
                    pnlPlayer4.Visible = true;

                    /*Player 1*/
                    this.players[0].playerPosition = PlayerPosition.BOTTOM;
                    lblP1Id.Text = this.players[0].id;
                    lblP1Name.Text = this.players[0].name;
                    lblP1Bet.Text = "0/?";
                    lblP1Score.Text = this.players[0].score.ToString();
                    foreach (Control control in pnlPlayer1.Controls)
                    {
                        if (control is Button)
                        {
                            this.players[0].btnCards.Add((Button)control);
                        }
                    }

                    /*Player 2*/
                    this.players[1].playerPosition = PlayerPosition.LEFT;
                    lblP2Id.Text = this.players[1].id;
                    lblP2Name.Text = this.players[1].name;
                    lblP2Bet.Text = "0/?";
                    lblP2Score.Text = this.players[1].score.ToString();
                    foreach (Control control in pnlPlayer2.Controls)
                    {
                        if (control is Button)
                        {
                            this.players[1].btnCards.Add((Button)control);
                        }
                    }

                    /*Player 3*/
                    this.players[2].playerPosition = PlayerPosition.TOP;
                    lblP3Id.Text = this.players[2].id;
                    lblP3Name.Text = this.players[2].name;
                    lblP3Bet.Text = "0/?";
                    lblP3Score.Text = this.players[2].score.ToString();
                    foreach (Control control in pnlPlayer3.Controls)
                    {
                        if (control is Button)
                        {
                            this.players[2].btnCards.Add((Button)control);
                        }
                    }

                    /*Player 4*/
                    this.players[3].playerPosition = PlayerPosition.RIGHT;
                    lblP4Id.Text = this.players[3].id;
                    lblP4Name.Text = this.players[3].name;
                    lblP4Bet.Text = "0/?";
                    lblP4Score.Text = this.players[3].score.ToString();
                    foreach (Control control in pnlPlayer4.Controls)
                    {
                        if (control is Button)
                        {
                            this.players[3].btnCards.Add((Button)control);
                        }
                    }

                    this.maxRoundByCardsPlayed = 13;
                    break;
                default:
                    MessageBox.Show($"Ocorreu um erro:\n Quantidade de jogadores inválida.", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            } 
        }

        private void Match_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnSkipBet_Click(object sender, EventArgs e)
        {
            this.players[0].SkipBet();
        }

        private void btnCheckWhoPlays_Click(object sender, EventArgs e)
        {
            this.updatePlayersCard();

            string response = Jogo.VerificarVez2(this.matchId);
            if (response.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            response = response.Replace("\r", "");
            response = response.Substring(0, response.Length - 1);
            foreach (string line in response.Split('\n'))
            {
                string[] data = line.Split(',');

                if (data[0].Contains("J"))
                {
                    this.showRoundStatus(data[3], data[1]);
                } else if (data[0].Contains("A:"))
                {
                    this.updatePlayerBet(data[0].Substring(2), Convert.ToChar(data[1]), Convert.ToInt32(data[2]), Convert.ToInt32(data[3]), Convert.ToInt32(data[4]));   
                } 
            };
        }

        private void updatePlayerBet(string playerId, char cardSuitLetter, int cardValue, int round, int index)
        {
            Player player = this.players.Find(p => p.id == playerId);
            player.bet = player.bet == null ? new Bet(playerId, cardSuitLetter, cardValue, round, index) : player.bet;
            player.cards[index-1].value = cardValue;
            player.btnCards[index-1].Text = cardValue.ToString();

            switch (player.playerPosition)
            {
                case PlayerPosition.BOTTOM:
                    this.lblP1Bet.Text = this.lblP1Bet.Text.Split('/')[0] + $"/{player.bet.CardValue}";
                    break;
                case PlayerPosition.LEFT:
                    this.lblP2Bet.Text = this.lblP1Bet.Text.Split('/')[0] + $"/{player.bet.CardValue}";
                    break;
                case PlayerPosition.TOP:
                    this.lblP3Bet.Text = this.lblP1Bet.Text.Split('/')[0] + $"/{player.bet.CardValue}";
                    break;
                case PlayerPosition.RIGHT:
                    this.lblP4Bet.Text = this.lblP1Bet.Text.Split('/')[0] + $"/{player.bet.CardValue}";
                    break;
            }
        }

        private void showRoundStatus(string statusLetter, string playerId)
        {
            pnlPlayer4.BackColor = Color.Transparent;
            pnlPlayer3.BackColor = Color.Transparent;
            pnlPlayer2.BackColor = Color.Transparent;
            pnlPlayer1.BackColor = Color.Transparent;

            foreach (Player p in this.players)
            {
                p.status = PlayerStatus.Wait;
            }

            Player player = this.players.Find(p => p.id == playerId);
            player.status = statusLetter == "C" ? PlayerStatus.Play : PlayerStatus.Bet;

            switch (player.playerPosition)
            {
                case PlayerPosition.BOTTOM:
                    pnlPlayer1.BackColor = statusLetter == "C" ? Color.DarkSlateBlue : Color.Sienna;
                    break;
                case PlayerPosition.LEFT:
                    pnlPlayer2.BackColor = statusLetter == "C" ? Color.DarkSlateBlue : Color.Sienna;
                    break;
                case PlayerPosition.TOP:
                    pnlPlayer3.BackColor = statusLetter == "C" ? Color.DarkSlateBlue : Color.Sienna;
                    break;
                case PlayerPosition.RIGHT:
                    pnlPlayer4.BackColor = statusLetter == "C" ? Color.DarkSlateBlue : Color.Sienna;
                    break;
            }
        }

        private void updatePlayersCard()
        {
            string response = Jogo.ExibirJogadas2(this.matchId, this.round);
            if (response == "") return;
            if (response.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.resetCardsPlayed();
            response = response.Replace("\r", "");
            response = response.Substring(0, response.Length - 1);

            int currentRound = 1;
            while (currentRound * this.players.Count < response.Split('\n').Length)
            {
                currentRound++;
            }
            this.roundByCardsPlayed = currentRound;

            foreach (string line in response.Split('\n'))
            {
                string[] data = line.Split(',');
                int cardIndex = Convert.ToInt32(data[4]) - 1;

                Player player = this.players.Find(p => p.id == data[1]);
                player.cards[cardIndex].value = Convert.ToInt32(data[3]);
                player.btnCards[cardIndex].Text = data[3];

                switch (player.playerPosition)
                {
                    case PlayerPosition.BOTTOM:
                        if (data[0] == this.roundByCardsPlayed.ToString())
                        {
                            this.btnCardP1Played.Text = data[3];
                            this.btnCardP1Played.BackgroundImage = player.cards[cardIndex].img;
                        }
                        break;
                    case PlayerPosition.LEFT:
                        if (data[0] == this.roundByCardsPlayed.ToString())
                        {
                            this.btnCardP2Played.Text = data[3];
                            this.btnCardP2Played.BackgroundImage = player.cards[cardIndex].img;
                        }
                        break;
                    case PlayerPosition.TOP:
                        if (data[0] == this.roundByCardsPlayed.ToString())
                        {
                            this.btnCardP3Played.Text = data[3];
                            this.btnCardP3Played.BackgroundImage = player.cards[cardIndex].img;
                        }
                        break;
                    case PlayerPosition.RIGHT:
                        if (data[0] == this.roundByCardsPlayed.ToString())
                        {
                            this.btnCardP4Played.Text = data[3];
                            this.btnCardP4Played.BackgroundImage = player.cards[cardIndex].img;
                        }
                        break;
                }
            };

            if (currentRound == this.maxRoundByCardsPlayed && currentRound * this.players.Count % response.Split('\n').Length == 0 && this.round < this.players.Count)
            {
                this.round++;
                this.roundByCardsPlayed = 1;
                foreach (Player player in this.players)
                {
                    player.bet = null;
                    player.fetchCards(this.matchId);
                    player.distributeCards();
                }
                this.lblP1Bet.Text = "0/?";
                this.lblP2Bet.Text = "0/?";
                this.lblP3Bet.Text = "0/?";
                this.lblP4Bet.Text = "0/?";
            }
        }
    }
}

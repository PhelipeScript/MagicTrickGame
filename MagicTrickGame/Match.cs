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
                    lblP1Bet.Text = null;
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
                    lblP3Bet.Text = null;
                    lblP3Score.Text = this.players[1].score.ToString();
                    foreach (Control control in pnlPlayer3.Controls)
                    {
                        if (control is Button)
                        {
                            this.players[1].btnCards.Add((Button)control);
                        }
                    }

                    this.maxRoundByCardsPlayed = 12;
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
                    lblP1Bet.Text = null;
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
                    lblP2Bet.Text = null;
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
                    lblP3Bet.Text = null;
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
                    lblP4Bet.Text = null;
                    lblP4Score.Text = this.players[3].score.ToString();
                    foreach (Control control in pnlPlayer4.Controls)
                    {
                        if (control is Button)
                        {
                            this.players[3].btnCards.Add((Button)control);
                        }
                    }

                    this.maxRoundByCardsPlayed = 14;
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
            this.updatePlayerCard();
            string response = Jogo.VerificarVez(this.matchId);

            if (response.Length >= 4 && response.Substring(0, 4) == "ERRO") 
            {
                MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            response = response.Replace("\r", "");
            response = response.Substring(0, response.Length - 1);
            string[] data = response.Split('\n');

            for (int i = 0; i < data.Length; i++)
            {
                string[] dataLine = data[i].Split(',');
                if (dataLine[0] == "J")
                {   
                    if (this.players.Count == 2)
                    {
                        if (dataLine[1] == this.players[0].id)
                        {
                            pnlPlayer3.BackColor = Color.Transparent;
                            pnlPlayer1.BackColor = Color.DarkSlateBlue;
                        }
                        else if (dataLine[1] == this.players[1].id)
                        {
                            pnlPlayer3.BackColor = Color.DarkSlateBlue;
                            pnlPlayer1.BackColor = Color.Transparent;
                        }
                    } else 
                    {
                        if (dataLine[1] == this.players[0].id)
                        {
                            pnlPlayer4.BackColor = Color.Transparent;
                            pnlPlayer3.BackColor = Color.Transparent;
                            pnlPlayer2.BackColor = Color.Transparent;
                            pnlPlayer1.BackColor = Color.DarkSlateBlue;
                        } else if (dataLine[1] == this.players[1].id)
                        {
                            pnlPlayer4.BackColor = Color.Transparent;
                            pnlPlayer3.BackColor = Color.Transparent;
                            pnlPlayer2.BackColor = Color.DarkSlateBlue;
                            pnlPlayer1.BackColor = Color.Transparent;
                        } else if (dataLine[1] == this.players[2].id)
                        {
                            pnlPlayer4.BackColor = Color.Transparent;
                            pnlPlayer3.BackColor = Color.DarkSlateBlue;
                            pnlPlayer2.BackColor = Color.Transparent;
                            pnlPlayer1.BackColor = Color.Transparent;
                        } else if (dataLine[1] == this.players[3].id)
                        {
                            pnlPlayer4.BackColor = Color.DarkSlateBlue;
                            pnlPlayer3.BackColor = Color.Transparent;
                            pnlPlayer2.BackColor = Color.Transparent;
                            pnlPlayer1.BackColor = Color.Transparent;
                        }

                    }
                    
                } 
            } 
        }

        public void updatePlayerCard()
        {
            string[] history = this.fetchHistoryByRound(this.round);
            if (history == null) return;

            if (this.allPlayersPlayedThisRound() && this.roundByCardsPlayed == this.maxRoundByCardsPlayed)
            {
                this.round++;
                foreach (var player in this.players)
                {
                    player.fetchCards(this.matchId);
                    player.distributeCards();
                }
            }

            for (int i = 0; i < this.players.Count; i++)
            {
                List<Card> playerCardsLeft = this.players[i].checkCardsLeft(this.matchId);
                if (playerCardsLeft == null) return;

                int maxIndex = this.players.Count == 2 ? 12 : 14;
                int cardsLeftIndex = 0;
                int playerCardsIndex = 0;
                do {
                    if (this.players[i].cards[playerCardsIndex].index == playerCardsLeft[cardsLeftIndex].index)
                    {
                        cardsLeftIndex++;
                    } else
                    {
                        if (this.players[i].btnCards[playerCardsIndex].Text == "")
                        {
                            string[] historyData = history[history.Length - 1].Split(',');
                            this.players[i].cards[playerCardsIndex].value = Convert.ToInt32(historyData[3]);
                            this.players[i].btnCards[playerCardsIndex].Text = historyData[3];

                            if (this.players.Count == 2)
                            {
                                if (i == 0)
                                {
                                    btnCardP1Played.Text = this.players[i].btnCards[playerCardsIndex].Text;
                                    btnCardP1Played.BackgroundImage = this.players[i].cards[playerCardsIndex].img;
                                }
                                else if (i == 1)
                                {
                                    btnCardP3Played.Text = this.players[i].btnCards[playerCardsIndex].Text;
                                    btnCardP3Played.BackgroundImage = this.players[i].cards[playerCardsIndex].img;
                                }
                            } else
                            {
                                if (i == 0)
                                {
                                    btnCardP1Played.Text = this.players[i].btnCards[playerCardsIndex].Text;
                                    btnCardP1Played.BackgroundImage = this.players[i].cards[playerCardsIndex].img;
                                }
                                else if (i == 1)
                                {
                                    btnCardP2Played.Text = this.players[i].btnCards[playerCardsIndex].Text;
                                    btnCardP2Played.BackgroundImage = this.players[i].cards[playerCardsIndex].img;
                                }
                                else if (i == 2)
                                {
                                    btnCardP3Played.Text = this.players[i].btnCards[playerCardsIndex].Text;
                                    btnCardP3Played.BackgroundImage = this.players[i].cards[playerCardsIndex].img;
                                }
                                else if (i == 3)
                                {
                                    btnCardP4Played.Text = this.players[i].btnCards[playerCardsIndex].Text;
                                    btnCardP4Played.BackgroundImage = this.players[i].cards[playerCardsIndex].img;
                                }
                            }
                        }
                    }
                    playerCardsIndex++;
                } while (playerCardsIndex < maxIndex);
            }
        }

        public bool allPlayersPlayedThisRound()
        {
            string[] history = this.fetchHistoryByRound(this.round);
            if (history == null) return false;

            int playerCounter = 0;
            for (int i = 0; i < history.Length; i++)
            {
                string[] dataLine = history[i].Split(',');

                if (dataLine[0] == this.roundByCardsPlayed.ToString())
                {
                    playerCounter++;
                }
            }

            if (playerCounter == 0)
            {
                this.resetCardsPlayed();
            }

            if (this.players.Count == playerCounter)
            {
                int lastRoundInHistory = Convert.ToInt32(history[history.Length - 1].Split(',')[0]);
                if (this.roundByCardsPlayed <= lastRoundInHistory)
                {
                    this.roundByCardsPlayed++;
                }
                return true;
            }
            return false;
        }

        public string[] fetchHistoryByRound(int round)
        {
            string response = Jogo.ExibirJogadas(this.matchId, round);
            if (response == "") return null;

            if (response.Length >= 4 && response.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            response = response.Replace("\r", "");
            response = response.Substring(0, response.Length - 1);
            string[] history = response.Split('\n');

            return history;
        }
    }
}

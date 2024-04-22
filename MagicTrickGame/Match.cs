using MagicTrickGame.Controllers;
using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        public List<Historic> historics = new List<Historic>();
        string turnData = null;
        string historicData = null;
        string playersCardsData = null;

        public Match(int matchId, string playerWhoStartsId, Player me)
        {
            InitializeComponent();
            this.resetCardsPlayed();
            this.WindowState = FormWindowState.Maximized;
            this.matchId = matchId;
            this.playerWhoStartsId = playerWhoStartsId;

            lblWhoIsPlayingNow.Text = "";
            tmrWhoStarts.Interval = 50;
            tmrWhoStarts.Start();
            tmrCheckDatabase.Enabled = true;

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

            string playersCardsData = FetchCards.Handle(this.matchId);
            foreach (Player player in players)
            {
                player.fetchCards(playersCardsData);
                player.distributeCards();
            }

            this.players[0].password = me.password;
            this.players[0].AddClickEventToButtons();

            tmrAutonomous.Enabled = true;
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

        private void tmrWhoStarts_Tick(object sender, EventArgs e)
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
                tmrWhoStarts.Stop();
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

        private void tmrCheckDatabase_Tick(object sender, EventArgs e)
        {
            tmrCheckDatabase.Enabled = false;
            string turnData = CheckTurn.Handle(this.matchId);
            if (turnData == null) return;
            else this.turnData = turnData;

            string[] firstLineTurnData = turnData.Split('\n')[0].Split(',');

            string playersCardsData = FetchCards.Handle(this.matchId);
            if (playersCardsData == null) return;
            else if (firstLineTurnData[0].Equals("J") && firstLineTurnData[2].Equals("1") && firstLineTurnData[3].Equals("C"))
                this.playersCardsData = playersCardsData;

            string historicData = FetchHistoric.Handle(this.matchId, this.round);
            this.historicData = historicData;

            tmrCheckDatabase.Enabled = true;
        }

        private void tmrAutonomous_Tick(object sender, EventArgs e)
        {
            tmrAutonomous.Enabled = false;

            this.updatePlayersCard(this.historicData, this.playersCardsData);
            this.showRoundStatus(this.turnData);
            this.updatePlayersScoreByHistory(this.historicData);
            this.updatePlayersScorePerTurn(this.turnData);
            this.updatePlayersBet(this.turnData);
            this.showPlayersScore();
            Strategy.Handle(this.players[0], this.turnData, this.historics);

            tmrAutonomous.Enabled = true;
        }

        private void updatePlayersBet(string betData) 
        {
            if (betData == null || betData.Contains("A:") == false) return;

            foreach (string line in betData.Split('\n'))
            {
                string[] lineData = line.Split(',');

                if (lineData[0].Contains("A:"))
                {
                    string playerId = lineData[0].Substring(2);
                    char cardSuitLetter = Convert.ToChar(lineData[1]);
                    int cardValue = Convert.ToInt32(lineData[2]);
                    int round = Convert.ToInt32(lineData[3]);
                    int cardIndex = Convert.ToInt32(lineData[4]);

                    Player player = this.players.Find(p => p.id == playerId);
                    player.bet = player.bet == null ? new Bet(player.id, cardSuitLetter, cardValue, round, cardIndex) : player.bet;
                    player.cards[cardIndex-1].value = cardValue;
                    player.btnCards[cardIndex-1].Text = cardValue.ToString();
                }
            };
        }
        
        private void showRoundStatus(string statusData)
        {
            pnlPlayer4.BackColor = Color.Transparent;
            pnlPlayer3.BackColor = Color.Transparent;
            pnlPlayer2.BackColor = Color.Transparent;
            pnlPlayer1.BackColor = Color.Transparent;
            foreach (Player p in this.players)
            {
                p.status = PlayerStatus.Wait;
            }

            if (statusData.Contains("J") == false) return;
            string firstLine = statusData.Split('\n')[0];
            string[] firstLineData = firstLine.Split(',');
            string playerId = firstLineData[1];
            string statusLetter = firstLineData[3];

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

        private void showPlayersScore()
        {
            foreach (Player player in this.players)
            {
                string playerBet = player.bet == null ? "?" : player.bet.CardValue.ToString();
                switch (player.playerPosition)
                {
                    case PlayerPosition.BOTTOM:
                        this.lblP1Bet.Text = player.score.ToString() + $"/{playerBet}";
                        break;
                    case PlayerPosition.LEFT:
                        this.lblP2Bet.Text = player.score.ToString() + $"/{playerBet}";
                        break;
                    case PlayerPosition.TOP:
                        this.lblP3Bet.Text = player.score.ToString() + $"/{playerBet}";
                        break;
                    case PlayerPosition.RIGHT:
                        this.lblP4Bet.Text = player.score.ToString() + $"/{playerBet}";
                        break;
                }
            }
        }

        private void updatePlayersScoreByHistory(string historicData)
        {
            if (historicData == null) return;

            foreach (Player player in this.players)
            {
                player.score = 0;
            }

            string[] historic = historicData.Split('\n');
            for (int i = this.players.Count; i < historic.Length; i += this.players.Count)
            {
                string playerId = historic[i].Split(',')[1];
                Player player = this.players.Find(p => p.id == playerId);
                player.score++;
            }
        }

        private void updatePlayersScorePerTurn(string turnData)
        {
            if (turnData == null || turnData.Contains("C:")) return;

            string firstLine = turnData.Split('\n')[0];
            string[] firstLineData = firstLine.Split(',');

            if (!firstLineData[2].Equals("1") && firstLineData[3].Equals("C"))
            {
                Player player = this.players.Find(p => p.id == firstLineData[1]);
                player.score++;
            }
        }

        private void updatePlayersCard(string historicData, string playersCardsData)
        {
            if (historicData == null) return;

            this.resetCardsPlayed();
            int currentRound = 1;
            while (currentRound * this.players.Count < historicData.Split('\n').Length)
            {
                currentRound++;
            }
            this.roundByCardsPlayed = currentRound;

            this.historics.Clear();
            foreach (string line in historicData.Split('\n'))
            {
                string[] data = line.Split(',');
                int cardIndex = Convert.ToInt32(data[4]) - 1;
                this.historics.Add(new Historic(Convert.ToInt32(data[0]), data[2], Convert.ToInt32(data[3]), data[4]));

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

            

            if (currentRound == this.maxRoundByCardsPlayed && currentRound * this.players.Count % historicData.Split('\n').Length == 0 && this.round < this.players.Count)
            {
                this.round++;
                this.roundByCardsPlayed = 1;
                foreach (Player player in this.players)
                {
                    player.score = 0;
                    player.bet = null;
                    player.fetchCards(playersCardsData);
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

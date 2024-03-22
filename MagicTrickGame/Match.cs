using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public Match(int matchId, string playerWhoStartsId, Player me)
        {
            InitializeComponent();
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
                    break;
                default:
                    MessageBox.Show($"Ocorreu um erro:\n Quantidade de jogadores inválida.", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            btnCardP1Played.Text = null;
            btnCardP1Played.Visible = false;
            btnCardP1Played.BackgroundImage = null;

            btnCardP2Played.Text = null;
            btnCardP2Played.Visible = false;
            btnCardP2Played.BackgroundImage = null;

            btnCardP3Played.Text = null;
            btnCardP3Played.Visible = false;
            btnCardP3Played.BackgroundImage = null;

            btnCardP4Played.Text = null;
            btnCardP4Played.Visible = false;
            btnCardP4Played.BackgroundImage = null; 

        }

        private void Match_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}

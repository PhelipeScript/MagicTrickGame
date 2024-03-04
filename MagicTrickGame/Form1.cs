using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicTrickServer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MagicTrickGame
{
    public partial class MagicTrick : Form
    {
        public bool isNewGameMatchNameOk = false;
        public bool isNewGamePasswordOk = false;
        public bool isJoinGamePasswordOk = false;
        public bool isJoinGameUsernameOk = false;
        public bool isMatchSelected = false;
        public string createdMatchId = "";
        public string[] matches;
        public int matchId;
        public string matchName;
        public string[] players;
        private string userId;
        private string userPassword;

        public MagicTrick()
        {
            InitializeComponent();
            lblVersion.Text = $"Versão: {Jogo.Versao}";
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlNewGame.Visible = true;
        }

        private void lblGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtNewGameMatchName.Text = "";
            txtNewGamePassword.Text = "";
            pnlNewGame.Visible = false;
            pnlMenu.Visible = true;
        }

        private void btnNewGameCreate_Handle()
        {
            if (this.isNewGamePasswordOk && this.isNewGameMatchNameOk)
            {
                btnNewGameCreate.Enabled = true;
            } else
            {
                btnNewGameCreate.Enabled = false;
            }
        }

        private void txtNewGameMatchName_TextChanged(object sender, EventArgs e)
        {
            if (txtNewGameMatchName.Text == "")
            {
                lblNewGameMatchNameError.Text = "Digite o nome da partida.";
                this.isNewGameMatchNameOk = false;
            }
            else
            {
                lblNewGameMatchNameError.Text = "";
                this.isNewGameMatchNameOk = true;
            }

            this.btnNewGameCreate_Handle();
        }

        private void txtNewGamePassword_TextChanged(object sender, EventArgs e)
        {
            if (txtNewGamePassword.Text == "")
            {
                lblNewGamePasswordError.Text = "Digite a senha da partida.";
                this.isNewGamePasswordOk = false;
            }
            else if (txtNewGamePassword.Text.Length > 10)
            {
                lblNewGamePasswordError.Text = "A senha deve ter no máximo 10 caracteres.";
                this.isNewGamePasswordOk = false;
            }
            else
            {
                lblNewGamePasswordError.Text = "";
                this.isNewGamePasswordOk = true;
            }

            this.btnNewGameCreate_Handle();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair o jogo?", "Confirmação de Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnJoinGame_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlJoinGame.Visible = true;
            cboStatus.SelectedIndex = 0;
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlJoinGame.Visible = false;
            pnlMenu.Visible = true;
            lstMatches.Items.Clear();
            pnlMatchInfo.Visible = false;
            this.isMatchSelected = false;
            txtJoinGamePassword.Text = "";
            txtJoinGameUsername.Text = "";
            lblSelectMatchError.Text = "Selecione uma partida.";
        }

        private void btnFetchMatches_Click(object sender, EventArgs e)
        {
            string status = cboStatus.Text.Substring(0, 1);
            string response = Jogo.ListarPartidas(status);
            if (response.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            response = response.Replace("\r", "");
            response = response.Substring(0, response.Length - 1);

            this.matches = response.Split('\n');

            lstMatches.Items.Clear();
            int defaultSelectedIndex = 0;
            for (int i = 0; i < this.matches.Length; i++)
            {
                string[] matchData = this.matches[i].Split(',');
                string matchName = matchData[1];
                lstMatches.Items.Add(matchName);
                if (matchData[0] == this.createdMatchId)
                {
                    defaultSelectedIndex = i;
                }
            }

            lstMatches.SelectedIndex = defaultSelectedIndex;
            this.isMatchSelected = true;
            lblSelectMatchError.Text = "";
            this.btnJoinMatch_Handle();
        }

        private void lstMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] selectedMatchData = this.matches[lstMatches.SelectedIndex].Split(',');
            this.matchId = Convert.ToInt32(selectedMatchData[0]);
            this.matchName = selectedMatchData[1];
            string matchDate = selectedMatchData[2];
            string matchStatus = selectedMatchData[3];

            switch (matchStatus)
            {
                case "A":
                    matchStatus = "Aberta";
                    break;
                case "J":
                    matchStatus = "Jogando";
                    break;
                case "F":
                    matchStatus = "Finalizada";
                    break;
            }

            lblMatchId.Text = this.matchId.ToString();
            lblMatchName.Text = this.matchName;
            lblMatchStatus.Text = matchStatus;
            lblMatchDate.Text = matchDate;
            pnlMatchInfo.Visible = true;
        }

        private void btnNewGameCreate_Click(object sender, EventArgs e)
        {
            string matchName = txtNewGameMatchName.Text;
            string matchPassword = txtNewGamePassword.Text;

            string response = Jogo.CriarPartida(matchName, matchPassword, "Atenas");
            if (response.Length > 4 && response.Substring(0, 4) == "ERRO")
            {
                lblNewGameMatchNameError.Text = "Esse nome já existe. Tente escolher outro.";
                MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.createdMatchId = response;
            pnlNewGame.Visible = false;
            pnlJoinGame.Visible = true;
            cboStatus.SelectedIndex = 0;
        }

        private void btnJoinMatch_Click(object sender, EventArgs e)
        {
            string matchPassword = txtJoinGamePassword.Text;
            string username = txtJoinGameUsername.Text;
            
            string response = Jogo.EntrarPartida(this.matchId, username, matchPassword);
            if (response.Substring(0, 4) == "ERRO")
            {
                if (response.Contains("Senha"))
                {
                    lblJoinGamePasswordError.Text = response.Substring(5);
                } 
                else if (response.Contains("jogador com este nome"))
                {
                    lblJoinGameUsernameError.Text = response.Substring(5);
                } else
                {
                    MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            response = response.Replace("\r", "");
            response = response.Substring(0, response.Length - 1);

            this.userId = response.Split(',')[0];
            this.userPassword = response.Split(',')[1];
            this.listPlayers();
        }

        private void listPlayers()
        {
            pnlJoinGame.Visible = false;
            pnlPlayers.Visible = true;
            lblSelectedMatchName.Text = this.matchName;

            string response = Jogo.ListarJogadores(this.matchId);
            if (response.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            response = response.Replace("\r", "");
            response = response.Substring(0, response.Length - 1);
            this.players = response.Split('\n');

            for (int i = 0; i < this.players.Length; i++)
            {
                lstPlayers.Items.Add(this.players[i]);
            }
        }

        private void btnJoinMatch_Handle()
        {
            if (this.isJoinGamePasswordOk && this.isJoinGameUsernameOk && this.isMatchSelected)
            {
                btnJoinMatch.Enabled = true;
            }
            else
            {
                btnJoinMatch.Enabled = false;
            }
        }

        private void txtJoinGamePassword_TextChanged(object sender, EventArgs e)
        {
            if (txtJoinGamePassword.Text == "")
            {
                lblJoinGamePasswordError.Text = "Digite a senha para entrar na partida.";
                this.isJoinGamePasswordOk = false;
            }
            else if (txtJoinGamePassword.Text.Length > 10)
            {
                lblJoinGamePasswordError.Text = "A senha deve ter no máximo 10 caracteres.";
                this.isJoinGamePasswordOk = false;
            }
            else
            {
                lblJoinGamePasswordError.Text = "";
                this.isJoinGamePasswordOk = true;
            }

            this.btnJoinMatch_Handle();
        }

        private void txtJoinGameUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtJoinGameUsername.Text == "")
            {
                lblJoinGameUsernameError.Text = "Digite o seu nome de jogador para entrar na partida.";
                this.isJoinGameUsernameOk = false;
            }
            else
            {
                lblJoinGameUsernameError.Text = "";
                this.isJoinGameUsernameOk = true;
            }

            this.btnJoinMatch_Handle();
        }
    }
}

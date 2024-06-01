using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MagicTrickGame.Controllers;
using MagicTrickServer;

namespace MagicTrickGame
{
    public partial class MenuScreen : Form
    {
        bool isNewGameMatchNameOk = false;
        bool isNewGamePasswordOk = false;
        bool isJoinGamePasswordOk = false;
        bool isJoinGameUsernameOk = false;
        Player me = new Player();
        Match selectedMatch = null;

        public MenuScreen()
        {
            InitializeComponent();
            lblVersion.Text = $"Versão: {Jogo.Versao}";
        }

        private void ResetNewGameInputs()
        {
            txtNewGameMatchName.Text = "";
            txtNewGamePassword.Text = "";
        }

        private void ResetJoinGameInputs()
        {
            cboStatus.SelectedIndex = 0;
            txtJoinGamePassword.Text = "";
            txtJoinGameUsername.Text = "";
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlNewGame.Visible = true;
        }

        private void lblGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ResetNewGameInputs();
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

        private void btnNewGameCreate_Click(object sender, EventArgs e)
        {
            string createdMatchId = CreateNewMatch.Handle(txtNewGameMatchName.Text, txtNewGamePassword.Text);
                
            if (createdMatchId == null) { return; }

            pnlNewGame.Visible = false;
            pnlJoinGame.Visible = true;
            cboStatus.SelectedIndex = 0;
            this.ResetNewGameInputs();
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
            this.ResetJoinGameInputs();
            lblSelectMatchError.Text = "Selecione uma partida.";
        }

        private void btnUpdateMatches_Click(object sender, EventArgs e)
        {
            string status = cboStatus.Text.Substring(0, 1);

            dgvMatches.DataSource = Match.All(status);
            dgvMatches.Columns[0].Visible = false;
            dgvMatches.Columns[1].HeaderText = "Nome da Partida";
            dgvMatches.Columns[2].HeaderText = "Data de Criação";

            lblSelectMatchError.Text = "";
            this.btnJoinMatch_Handle();
        }

        private string[] JoinMatch(int matchId, string username, string matchPassword)
        {
            try
            {
                string response = Jogo.EntrarPartida(matchId, username, matchPassword);
                if (response.Substring(0, 4) == "ERRO")
                {
                    if (response.Contains("Senha"))
                    {
                        lblJoinGamePasswordError.Text = response;
                    }
                    else if (response.Contains("jogador com este nome"))
                    {
                        lblJoinGameUsernameError.Text = response;
                    }
                    else
                    {
                        MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return null;
                }
                response = response.Replace("\r", "");
                response = response.Substring(0, response.Length - 1);

                return response.Split(',');
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro:\n {e}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnJoinMatch_Click(object sender, EventArgs e)
        {
            string[] playerCreatedData = this.JoinMatch(this.selectedMatch.Id, txtJoinGameUsername.Text, txtJoinGamePassword.Text);

            if (playerCreatedData == null) { return; }

            me.id = playerCreatedData[0];
            me.password = playerCreatedData[1];

            this.listPlayers();
            pnlJoinGame.Visible = false;
            pnlPlayers.Visible = true;
            lblSelectedMatchName.Text = this.selectedMatch.Name;

            tmrStartMatch.Enabled = true;   
        }

        private void listPlayers()
        {
            string playersResponse = FetchPlayers.Handle(this.selectedMatch.Id);

            if (playersResponse == null) { return; }

            List<Player> players = new List<Player>();
            
            for (int i = 0; i < playersResponse.Split('\n').Length; i++)
            {
                string playerData = playersResponse.Split('\n')[i];
                players.Add(new Player(playerData));
            }

            dgvMatchPlayers.DataSource = players;
            dgvMatchPlayers.Columns[0].HeaderText = "Nome do Jogador";
            dgvMatchPlayers.Columns[1].HeaderText = "Pontuação";
        }

        private void btnJoinMatch_Handle()
        {
            if (this.isJoinGamePasswordOk && this.isJoinGameUsernameOk)
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

        private void btnBackToMatchList_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar?", "Confirmação de Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                pnlJoinGame.Visible = true;
                pnlPlayers.Visible = false;
                this.ResetJoinGameInputs();
            }
        }

        private string CheckWhoStartedMatch()
        {
            string response = Jogo.VerificarVez(this.selectedMatch.Id);

            if (response.Length >= 4 && response.Substring(0, 4) == "ERRO")
            {
                if (response.Contains("Partida não está em andamento"))
                {
                    return null;
                }
                MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            response = response.Replace("\r", "");
            response = response.Substring(0, response.Length - 1);
            return response.Split('\n')[0].Split(',')[1];
        }

        private string StartMatch(int playerId, string playerPassword) 
        {
            string response = Jogo.IniciarPartida(playerId, playerPassword);

            if (response.Length >= 4 && response.Substring(0, 4) == "ERRO")
            {
                if (response.Substring(5) == "Partida não está aberta")
                {
                    return this.CheckWhoStartedMatch();
                }

                MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return response; // playerId that starts the match
        }

        private void JoinMatch(string playerWhoStartsId)
        {
            Form match = new MatchScreen(this.selectedMatch.Id, playerWhoStartsId, me);

            match.Show();
            this.Hide();

            match.FormClosed += this.Match_FormClosed;
            this.ResetJoinGameInputs();
            this.ResetNewGameInputs();
        }

        private void btnStartMatch_Click(object sender, EventArgs e)
        {
            string playerWhoStartsId = this.StartMatch(Int32.Parse(me.id), me.password);
            if (playerWhoStartsId == null) { return; }

            this.JoinMatch(playerWhoStartsId);
            tmrStartMatch.Enabled = false;
        }

        private void tmrStartMatch_Tick(object sender, EventArgs e)
        {
            tmrStartMatch.Enabled = false;
            this.listPlayers();
            string playerWhoStartsId = this.CheckWhoStartedMatch();
            if (playerWhoStartsId == null)
            {
                tmrStartMatch.Enabled = true;
            } else
            {
                this.JoinMatch(playerWhoStartsId);
            }
        }

        private void Match_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            pnlPlayers.Visible = false;
            pnlMenu.Visible = true;
        }

        private void dgvMatches_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dgvMatches.SelectedRows;
            if (selectedRow.Count == 0) return;

            this.selectedMatch = (Match)selectedRow[0].DataBoundItem;

            string playersResponse = FetchPlayers.Handle(this.selectedMatch.Id);
            if (playersResponse == null) return;

            List<Player> players = new List<Player>();

            if (playersResponse != "")
            {
                for (int i = 0; i < playersResponse.Split('\n').Length; i++)
                {
                    string playerData = playersResponse.Split('\n')[i];
                    players.Add(new Player(playerData));
                }
            }

            dgvSelectedMatchPlayers.DataSource = players;
            dgvSelectedMatchPlayers.Columns[0].HeaderText = "Nome do Jogador";
            dgvSelectedMatchPlayers.Columns[1].HeaderText = "Pontuação";
        }
    }
}

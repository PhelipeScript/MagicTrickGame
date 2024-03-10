namespace MagicTrickGame
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnJoinGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlNewGame = new System.Windows.Forms.Panel();
            this.lblNewGamePasswordError = new System.Windows.Forms.Label();
            this.lblNewGameMatchNameError = new System.Windows.Forms.Label();
            this.btnNewGameCreate = new System.Windows.Forms.Button();
            this.txtNewGamePassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewGameMatchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGoBack = new System.Windows.Forms.LinkLabel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlJoinGame = new System.Windows.Forms.Panel();
            this.lblSelectMatchError = new System.Windows.Forms.Label();
            this.pnlMatchInfo = new System.Windows.Forms.Panel();
            this.lblMatchStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblMatchId = new System.Windows.Forms.Label();
            this.lblMatchDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblMatchName = new System.Windows.Forms.Label();
            this.btnJoinMatch = new System.Windows.Forms.Button();
            this.lblJoinGameUsernameError = new System.Windows.Forms.Label();
            this.txtJoinGameUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblJoinGamePasswordError = new System.Windows.Forms.Label();
            this.txtJoinGamePassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFetchMatches = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstMatches = new System.Windows.Forms.ListBox();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.pnlPlayers = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.lblSelectedMatchName = new System.Windows.Forms.Label();
            this.btnStartMatch = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.pnlNewGame.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlJoinGame.SuspendLayout();
            this.pnlMatchInfo.SuspendLayout();
            this.pnlPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewGame.Location = new System.Drawing.Point(3, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(222, 70);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "Criar Partida";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnJoinGame
            // 
            this.btnJoinGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnJoinGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJoinGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinGame.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinGame.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnJoinGame.Location = new System.Drawing.Point(3, 111);
            this.btnJoinGame.Name = "btnJoinGame";
            this.btnJoinGame.Size = new System.Drawing.Size(222, 70);
            this.btnJoinGame.TabIndex = 1;
            this.btnJoinGame.Text = "Entrar Partida";
            this.btnJoinGame.UseVisualStyleBackColor = false;
            this.btnJoinGame.Click += new System.EventHandler(this.btnJoinGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(3, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(222, 70);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlNewGame
            // 
            this.pnlNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(158)))), ((int)(((byte)(199)))));
            this.pnlNewGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewGame.Controls.Add(this.lblNewGamePasswordError);
            this.pnlNewGame.Controls.Add(this.lblNewGameMatchNameError);
            this.pnlNewGame.Controls.Add(this.btnNewGameCreate);
            this.pnlNewGame.Controls.Add(this.txtNewGamePassword);
            this.pnlNewGame.Controls.Add(this.label3);
            this.pnlNewGame.Controls.Add(this.txtNewGameMatchName);
            this.pnlNewGame.Controls.Add(this.label2);
            this.pnlNewGame.Controls.Add(this.label1);
            this.pnlNewGame.Controls.Add(this.lblGoBack);
            this.pnlNewGame.Location = new System.Drawing.Point(342, 235);
            this.pnlNewGame.Name = "pnlNewGame";
            this.pnlNewGame.Size = new System.Drawing.Size(346, 364);
            this.pnlNewGame.TabIndex = 3;
            this.pnlNewGame.Visible = false;
            // 
            // lblNewGamePasswordError
            // 
            this.lblNewGamePasswordError.AutoSize = true;
            this.lblNewGamePasswordError.BackColor = System.Drawing.Color.Transparent;
            this.lblNewGamePasswordError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNewGamePasswordError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewGamePasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblNewGamePasswordError.Location = new System.Drawing.Point(31, 234);
            this.lblNewGamePasswordError.Name = "lblNewGamePasswordError";
            this.lblNewGamePasswordError.Size = new System.Drawing.Size(144, 14);
            this.lblNewGamePasswordError.TabIndex = 13;
            this.lblNewGamePasswordError.Text = "Digite a senha da partida.";
            // 
            // lblNewGameMatchNameError
            // 
            this.lblNewGameMatchNameError.AutoSize = true;
            this.lblNewGameMatchNameError.BackColor = System.Drawing.Color.Transparent;
            this.lblNewGameMatchNameError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNewGameMatchNameError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewGameMatchNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNewGameMatchNameError.Location = new System.Drawing.Point(31, 142);
            this.lblNewGameMatchNameError.Name = "lblNewGameMatchNameError";
            this.lblNewGameMatchNameError.Size = new System.Drawing.Size(143, 14);
            this.lblNewGameMatchNameError.TabIndex = 12;
            this.lblNewGameMatchNameError.Text = "Digite o nome da partida.";
            // 
            // btnNewGameCreate
            // 
            this.btnNewGameCreate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNewGameCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGameCreate.Enabled = false;
            this.btnNewGameCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGameCreate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGameCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewGameCreate.Location = new System.Drawing.Point(100, 288);
            this.btnNewGameCreate.Name = "btnNewGameCreate";
            this.btnNewGameCreate.Size = new System.Drawing.Size(133, 49);
            this.btnNewGameCreate.TabIndex = 11;
            this.btnNewGameCreate.Text = "CRIAR";
            this.btnNewGameCreate.UseVisualStyleBackColor = false;
            this.btnNewGameCreate.Click += new System.EventHandler(this.btnNewGameCreate_Click);
            // 
            // txtNewGamePassword
            // 
            this.txtNewGamePassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewGamePassword.Location = new System.Drawing.Point(25, 202);
            this.txtNewGamePassword.Name = "txtNewGamePassword";
            this.txtNewGamePassword.Size = new System.Drawing.Size(286, 26);
            this.txtNewGamePassword.TabIndex = 10;
            this.txtNewGamePassword.TextChanged += new System.EventHandler(this.txtNewGamePassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Senha da partida:";
            // 
            // txtNewGameMatchName
            // 
            this.txtNewGameMatchName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewGameMatchName.Location = new System.Drawing.Point(25, 113);
            this.txtNewGameMatchName.Name = "txtNewGameMatchName";
            this.txtNewGameMatchName.Size = new System.Drawing.Size(286, 26);
            this.txtNewGameMatchName.TabIndex = 8;
            this.txtNewGameMatchName.TextChanged += new System.EventHandler(this.txtNewGameMatchName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome da partida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Criar uma partida";
            // 
            // lblGoBack
            // 
            this.lblGoBack.ActiveLinkColor = System.Drawing.Color.MediumSlateBlue;
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.BackColor = System.Drawing.Color.Transparent;
            this.lblGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGoBack.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoBack.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblGoBack.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblGoBack.LinkColor = System.Drawing.Color.MediumSlateBlue;
            this.lblGoBack.Location = new System.Drawing.Point(3, 9);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(44, 16);
            this.lblGoBack.TabIndex = 5;
            this.lblGoBack.TabStop = true;
            this.lblGoBack.Text = "Voltar";
            this.lblGoBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGoBack.VisitedLinkColor = System.Drawing.Color.MediumSlateBlue;
            this.lblGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGoBack_LinkClicked);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.btnNewGame);
            this.pnlMenu.Controls.Add(this.btnJoinGame);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Location = new System.Drawing.Point(396, 279);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(228, 289);
            this.pnlMenu.TabIndex = 14;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblVersion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVersion.Location = new System.Drawing.Point(3, 589);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(67, 16);
            this.lblVersion.TabIndex = 15;
            this.lblVersion.Text = "Versão: X";
            // 
            // pnlJoinGame
            // 
            this.pnlJoinGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(158)))), ((int)(((byte)(199)))));
            this.pnlJoinGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJoinGame.Controls.Add(this.lblSelectMatchError);
            this.pnlJoinGame.Controls.Add(this.pnlMatchInfo);
            this.pnlJoinGame.Controls.Add(this.btnJoinMatch);
            this.pnlJoinGame.Controls.Add(this.lblJoinGameUsernameError);
            this.pnlJoinGame.Controls.Add(this.txtJoinGameUsername);
            this.pnlJoinGame.Controls.Add(this.label10);
            this.pnlJoinGame.Controls.Add(this.lblJoinGamePasswordError);
            this.pnlJoinGame.Controls.Add(this.txtJoinGamePassword);
            this.pnlJoinGame.Controls.Add(this.label8);
            this.pnlJoinGame.Controls.Add(this.btnFetchMatches);
            this.pnlJoinGame.Controls.Add(this.cboStatus);
            this.pnlJoinGame.Controls.Add(this.label5);
            this.pnlJoinGame.Controls.Add(this.lstMatches);
            this.pnlJoinGame.Controls.Add(this.lblBack);
            this.pnlJoinGame.Location = new System.Drawing.Point(184, 235);
            this.pnlJoinGame.Name = "pnlJoinGame";
            this.pnlJoinGame.Size = new System.Drawing.Size(680, 364);
            this.pnlJoinGame.TabIndex = 14;
            this.pnlJoinGame.Visible = false;
            // 
            // lblSelectMatchError
            // 
            this.lblSelectMatchError.AutoSize = true;
            this.lblSelectMatchError.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectMatchError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelectMatchError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMatchError.ForeColor = System.Drawing.Color.Red;
            this.lblSelectMatchError.Location = new System.Drawing.Point(428, 343);
            this.lblSelectMatchError.Name = "lblSelectMatchError";
            this.lblSelectMatchError.Size = new System.Drawing.Size(132, 14);
            this.lblSelectMatchError.TabIndex = 23;
            this.lblSelectMatchError.Text = "Selecione uma partida.";
            // 
            // pnlMatchInfo
            // 
            this.pnlMatchInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlMatchInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMatchInfo.Controls.Add(this.lblMatchStatus);
            this.pnlMatchInfo.Controls.Add(this.label4);
            this.pnlMatchInfo.Controls.Add(this.label6);
            this.pnlMatchInfo.Controls.Add(this.label16);
            this.pnlMatchInfo.Controls.Add(this.lblMatchId);
            this.pnlMatchInfo.Controls.Add(this.lblMatchDate);
            this.pnlMatchInfo.Controls.Add(this.label12);
            this.pnlMatchInfo.Controls.Add(this.label14);
            this.pnlMatchInfo.Controls.Add(this.lblMatchName);
            this.pnlMatchInfo.Location = new System.Drawing.Point(346, 3);
            this.pnlMatchInfo.Name = "pnlMatchInfo";
            this.pnlMatchInfo.Size = new System.Drawing.Size(298, 122);
            this.pnlMatchInfo.TabIndex = 16;
            this.pnlMatchInfo.Visible = false;
            // 
            // lblMatchStatus
            // 
            this.lblMatchStatus.AutoSize = true;
            this.lblMatchStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchStatus.Location = new System.Drawing.Point(63, 77);
            this.lblMatchStatus.Name = "lblMatchStatus";
            this.lblMatchStatus.Size = new System.Drawing.Size(19, 19);
            this.lblMatchStatus.TabIndex = 30;
            this.lblMatchStatus.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "Informações da Partida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "id:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 19);
            this.label16.TabIndex = 29;
            this.label16.Text = "status:";
            // 
            // lblMatchId
            // 
            this.lblMatchId.AutoSize = true;
            this.lblMatchId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchId.Location = new System.Drawing.Point(33, 40);
            this.lblMatchId.Name = "lblMatchId";
            this.lblMatchId.Size = new System.Drawing.Size(19, 19);
            this.lblMatchId.TabIndex = 24;
            this.lblMatchId.Text = "?";
            // 
            // lblMatchDate
            // 
            this.lblMatchDate.AutoSize = true;
            this.lblMatchDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchDate.Location = new System.Drawing.Point(134, 96);
            this.lblMatchDate.Name = "lblMatchDate";
            this.lblMatchDate.Size = new System.Drawing.Size(19, 19);
            this.lblMatchDate.TabIndex = 28;
            this.lblMatchDate.Text = "?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "nome:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 19);
            this.label14.TabIndex = 27;
            this.label14.Text = "data de criação:";
            // 
            // lblMatchName
            // 
            this.lblMatchName.AutoSize = true;
            this.lblMatchName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchName.Location = new System.Drawing.Point(63, 58);
            this.lblMatchName.Name = "lblMatchName";
            this.lblMatchName.Size = new System.Drawing.Size(19, 19);
            this.lblMatchName.TabIndex = 26;
            this.lblMatchName.Text = "?";
            // 
            // btnJoinMatch
            // 
            this.btnJoinMatch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnJoinMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJoinMatch.Enabled = false;
            this.btnJoinMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinMatch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinMatch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnJoinMatch.Location = new System.Drawing.Point(413, 301);
            this.btnJoinMatch.Name = "btnJoinMatch";
            this.btnJoinMatch.Size = new System.Drawing.Size(157, 39);
            this.btnJoinMatch.TabIndex = 22;
            this.btnJoinMatch.Text = "Entrar";
            this.btnJoinMatch.UseVisualStyleBackColor = false;
            this.btnJoinMatch.Click += new System.EventHandler(this.btnJoinMatch_Click);
            // 
            // lblJoinGameUsernameError
            // 
            this.lblJoinGameUsernameError.AutoSize = true;
            this.lblJoinGameUsernameError.BackColor = System.Drawing.Color.Transparent;
            this.lblJoinGameUsernameError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblJoinGameUsernameError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinGameUsernameError.ForeColor = System.Drawing.Color.Red;
            this.lblJoinGameUsernameError.Location = new System.Drawing.Point(364, 268);
            this.lblJoinGameUsernameError.Name = "lblJoinGameUsernameError";
            this.lblJoinGameUsernameError.Size = new System.Drawing.Size(293, 14);
            this.lblJoinGameUsernameError.TabIndex = 21;
            this.lblJoinGameUsernameError.Text = "Digite o seu nome de jogador para entrar na partida.";
            // 
            // txtJoinGameUsername
            // 
            this.txtJoinGameUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJoinGameUsername.Location = new System.Drawing.Point(358, 239);
            this.txtJoinGameUsername.Name = "txtJoinGameUsername";
            this.txtJoinGameUsername.Size = new System.Drawing.Size(286, 26);
            this.txtJoinGameUsername.TabIndex = 20;
            this.txtJoinGameUsername.TextChanged += new System.EventHandler(this.txtJoinGameUsername_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(354, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Seu nome: ";
            // 
            // lblJoinGamePasswordError
            // 
            this.lblJoinGamePasswordError.AutoSize = true;
            this.lblJoinGamePasswordError.BackColor = System.Drawing.Color.Transparent;
            this.lblJoinGamePasswordError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblJoinGamePasswordError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinGamePasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblJoinGamePasswordError.Location = new System.Drawing.Point(364, 189);
            this.lblJoinGamePasswordError.Name = "lblJoinGamePasswordError";
            this.lblJoinGamePasswordError.Size = new System.Drawing.Size(208, 14);
            this.lblJoinGamePasswordError.TabIndex = 18;
            this.lblJoinGamePasswordError.Text = "Digite a senha para entrar na partida.";
            // 
            // txtJoinGamePassword
            // 
            this.txtJoinGamePassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJoinGamePassword.Location = new System.Drawing.Point(358, 160);
            this.txtJoinGamePassword.Name = "txtJoinGamePassword";
            this.txtJoinGamePassword.Size = new System.Drawing.Size(286, 26);
            this.txtJoinGamePassword.TabIndex = 17;
            this.txtJoinGamePassword.TextChanged += new System.EventHandler(this.txtJoinGamePassword_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Senha da partida:";
            // 
            // btnFetchMatches
            // 
            this.btnFetchMatches.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFetchMatches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFetchMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchMatches.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchMatches.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFetchMatches.Location = new System.Drawing.Point(9, 45);
            this.btnFetchMatches.Name = "btnFetchMatches";
            this.btnFetchMatches.Size = new System.Drawing.Size(157, 39);
            this.btnFetchMatches.TabIndex = 12;
            this.btnFetchMatches.Text = "Listar Partidas";
            this.btnFetchMatches.UseVisualStyleBackColor = false;
            this.btnFetchMatches.Click += new System.EventHandler(this.btnFetchMatches_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Todas",
            "Jogando",
            "Abertas",
            "Finalizadas"});
            this.cboStatus.Location = new System.Drawing.Point(172, 60);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(111, 24);
            this.cboStatus.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status da partida: ";
            // 
            // lstMatches
            // 
            this.lstMatches.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMatches.FormattingEnabled = true;
            this.lstMatches.ItemHeight = 16;
            this.lstMatches.Location = new System.Drawing.Point(8, 90);
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(278, 260);
            this.lstMatches.TabIndex = 8;
            this.lstMatches.SelectedIndexChanged += new System.EventHandler(this.lstMatches_SelectedIndexChanged);
            // 
            // lblBack
            // 
            this.lblBack.ActiveLinkColor = System.Drawing.Color.MediumSlateBlue;
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblBack.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblBack.LinkColor = System.Drawing.Color.MediumSlateBlue;
            this.lblBack.Location = new System.Drawing.Point(3, 9);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(44, 16);
            this.lblBack.TabIndex = 6;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "Voltar";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.VisitedLinkColor = System.Drawing.Color.MediumSlateBlue;
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(158)))), ((int)(((byte)(199)))));
            this.pnlPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayers.Controls.Add(this.label7);
            this.pnlPlayers.Controls.Add(this.lstPlayers);
            this.pnlPlayers.Controls.Add(this.lblSelectedMatchName);
            this.pnlPlayers.Controls.Add(this.btnStartMatch);
            this.pnlPlayers.Controls.Add(this.label15);
            this.pnlPlayers.Location = new System.Drawing.Point(342, 212);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(346, 364);
            this.pnlPlayers.TabIndex = 14;
            this.pnlPlayers.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Jogadores da partida:";
            // 
            // lstPlayers
            // 
            this.lstPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPlayers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 18;
            this.lstPlayers.Location = new System.Drawing.Point(17, 83);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(305, 198);
            this.lstPlayers.TabIndex = 16;
            // 
            // lblSelectedMatchName
            // 
            this.lblSelectedMatchName.AutoEllipsis = true;
            this.lblSelectedMatchName.AutoSize = true;
            this.lblSelectedMatchName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedMatchName.Location = new System.Drawing.Point(89, 16);
            this.lblSelectedMatchName.MaximumSize = new System.Drawing.Size(246, 27);
            this.lblSelectedMatchName.Name = "lblSelectedMatchName";
            this.lblSelectedMatchName.Size = new System.Drawing.Size(246, 27);
            this.lblSelectedMatchName.TabIndex = 15;
            this.lblSelectedMatchName.Text = "AtenasTeste0aaaaaaaaaaaa";
            // 
            // btnStartMatch
            // 
            this.btnStartMatch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnStartMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartMatch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMatch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStartMatch.Location = new System.Drawing.Point(94, 298);
            this.btnStartMatch.Name = "btnStartMatch";
            this.btnStartMatch.Size = new System.Drawing.Size(160, 49);
            this.btnStartMatch.TabIndex = 11;
            this.btnStartMatch.Text = "Iniciar Partida";
            this.btnStartMatch.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 27);
            this.label15.TabIndex = 6;
            this.label15.Text = "Partida:";
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGroupName.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGroupName.Location = new System.Drawing.Point(-3, -6);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(160, 61);
            this.lblGroupName.TabIndex = 16;
            this.lblGroupName.Text = "Atenas";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::MagicTrickGame.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 611);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlNewGame);
            this.Controls.Add(this.pnlJoinGame);
            this.Controls.Add(this.pnlPlayers);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 650);
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "Menu";
            this.Text = "MagicTrick";
            this.pnlNewGame.ResumeLayout(false);
            this.pnlNewGame.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlJoinGame.ResumeLayout(false);
            this.pnlJoinGame.PerformLayout();
            this.pnlMatchInfo.ResumeLayout(false);
            this.pnlMatchInfo.PerformLayout();
            this.pnlPlayers.ResumeLayout(false);
            this.pnlPlayers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnJoinGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlNewGame;
        private System.Windows.Forms.LinkLabel lblGoBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewGameMatchName;
        private System.Windows.Forms.TextBox txtNewGamePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewGameCreate;
        private System.Windows.Forms.Label lblNewGameMatchNameError;
        private System.Windows.Forms.Label lblNewGamePasswordError;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel pnlJoinGame;
        private System.Windows.Forms.LinkLabel lblBack;
        private System.Windows.Forms.ListBox lstMatches;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFetchMatches;
        private System.Windows.Forms.Button btnJoinMatch;
        private System.Windows.Forms.Label lblJoinGameUsernameError;
        private System.Windows.Forms.TextBox txtJoinGameUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblJoinGamePasswordError;
        private System.Windows.Forms.TextBox txtJoinGamePassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMatchName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMatchId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMatchStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblMatchDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlMatchInfo;
        private System.Windows.Forms.Label lblSelectMatchError;
        private System.Windows.Forms.Panel pnlPlayers;
        private System.Windows.Forms.Label lblSelectedMatchName;
        private System.Windows.Forms.Button btnStartMatch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Label lblGroupName;
    }
}


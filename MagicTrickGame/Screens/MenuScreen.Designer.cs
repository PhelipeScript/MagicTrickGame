﻿namespace MagicTrickGame
{
    partial class MenuScreen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
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
            this.dgvSelectedMatchPlayers = new System.Windows.Forms.DataGridView();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.lblSelectMatchError = new System.Windows.Forms.Label();
            this.btnJoinMatch = new System.Windows.Forms.Button();
            this.lblJoinGameUsernameError = new System.Windows.Forms.Label();
            this.txtJoinGameUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblJoinGamePasswordError = new System.Windows.Forms.Label();
            this.txtJoinGamePassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdateMatches = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.pnlPlayers = new System.Windows.Forms.Panel();
            this.btnBackToMatchList = new System.Windows.Forms.Button();
            this.dgvMatchPlayers = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSelectedMatchName = new System.Windows.Forms.Label();
            this.btnStartMatch = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.tmrStartMatch = new System.Windows.Forms.Timer(this.components);
            this.pnlNewGame.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlJoinGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedMatchPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.pnlPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchPlayers)).BeginInit();
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
            this.pnlJoinGame.Controls.Add(this.dgvSelectedMatchPlayers);
            this.pnlJoinGame.Controls.Add(this.dgvMatches);
            this.pnlJoinGame.Controls.Add(this.lblSelectMatchError);
            this.pnlJoinGame.Controls.Add(this.btnJoinMatch);
            this.pnlJoinGame.Controls.Add(this.lblJoinGameUsernameError);
            this.pnlJoinGame.Controls.Add(this.txtJoinGameUsername);
            this.pnlJoinGame.Controls.Add(this.label10);
            this.pnlJoinGame.Controls.Add(this.lblJoinGamePasswordError);
            this.pnlJoinGame.Controls.Add(this.txtJoinGamePassword);
            this.pnlJoinGame.Controls.Add(this.label8);
            this.pnlJoinGame.Controls.Add(this.btnUpdateMatches);
            this.pnlJoinGame.Controls.Add(this.cboStatus);
            this.pnlJoinGame.Controls.Add(this.label5);
            this.pnlJoinGame.Controls.Add(this.lblBack);
            this.pnlJoinGame.Location = new System.Drawing.Point(158, 216);
            this.pnlJoinGame.Name = "pnlJoinGame";
            this.pnlJoinGame.Size = new System.Drawing.Size(745, 383);
            this.pnlJoinGame.TabIndex = 14;
            this.pnlJoinGame.Visible = false;
            // 
            // dgvSelectedMatchPlayers
            // 
            this.dgvSelectedMatchPlayers.AllowUserToAddRows = false;
            this.dgvSelectedMatchPlayers.AllowUserToDeleteRows = false;
            this.dgvSelectedMatchPlayers.AllowUserToResizeColumns = false;
            this.dgvSelectedMatchPlayers.AllowUserToResizeRows = false;
            this.dgvSelectedMatchPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedMatchPlayers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(158)))), ((int)(((byte)(199)))));
            this.dgvSelectedMatchPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSelectedMatchPlayers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectedMatchPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelectedMatchPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedMatchPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectedMatchPlayers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSelectedMatchPlayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSelectedMatchPlayers.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSelectedMatchPlayers.Location = new System.Drawing.Point(440, 4);
            this.dgvSelectedMatchPlayers.MultiSelect = false;
            this.dgvSelectedMatchPlayers.Name = "dgvSelectedMatchPlayers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectedMatchPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSelectedMatchPlayers.RowHeadersVisible = false;
            this.dgvSelectedMatchPlayers.RowTemplate.Height = 30;
            this.dgvSelectedMatchPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedMatchPlayers.Size = new System.Drawing.Size(286, 154);
            this.dgvSelectedMatchPlayers.TabIndex = 24;
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.AllowUserToResizeColumns = false;
            this.dgvMatches.AllowUserToResizeRows = false;
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMatches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMatches.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatches.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMatches.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMatches.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMatches.Location = new System.Drawing.Point(9, 89);
            this.dgvMatches.MultiSelect = false;
            this.dgvMatches.Name = "dgvMatches";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatches.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.RowTemplate.Height = 30;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(408, 289);
            this.dgvMatches.TabIndex = 14;
            this.dgvMatches.SelectionChanged += new System.EventHandler(this.dgvMatches_SelectionChanged);
            // 
            // lblSelectMatchError
            // 
            this.lblSelectMatchError.AutoSize = true;
            this.lblSelectMatchError.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectMatchError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelectMatchError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMatchError.ForeColor = System.Drawing.Color.Red;
            this.lblSelectMatchError.Location = new System.Drawing.Point(510, 364);
            this.lblSelectMatchError.Name = "lblSelectMatchError";
            this.lblSelectMatchError.Size = new System.Drawing.Size(132, 14);
            this.lblSelectMatchError.TabIndex = 23;
            this.lblSelectMatchError.Text = "Selecione uma partida.";
            // 
            // btnJoinMatch
            // 
            this.btnJoinMatch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnJoinMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJoinMatch.Enabled = false;
            this.btnJoinMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinMatch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinMatch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnJoinMatch.Location = new System.Drawing.Point(495, 322);
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
            this.lblJoinGameUsernameError.Location = new System.Drawing.Point(446, 289);
            this.lblJoinGameUsernameError.Name = "lblJoinGameUsernameError";
            this.lblJoinGameUsernameError.Size = new System.Drawing.Size(293, 14);
            this.lblJoinGameUsernameError.TabIndex = 21;
            this.lblJoinGameUsernameError.Text = "Digite o seu nome de jogador para entrar na partida.";
            // 
            // txtJoinGameUsername
            // 
            this.txtJoinGameUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJoinGameUsername.Location = new System.Drawing.Point(440, 260);
            this.txtJoinGameUsername.Name = "txtJoinGameUsername";
            this.txtJoinGameUsername.Size = new System.Drawing.Size(286, 26);
            this.txtJoinGameUsername.TabIndex = 20;
            this.txtJoinGameUsername.TextChanged += new System.EventHandler(this.txtJoinGameUsername_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(436, 238);
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
            this.lblJoinGamePasswordError.Location = new System.Drawing.Point(446, 218);
            this.lblJoinGamePasswordError.Name = "lblJoinGamePasswordError";
            this.lblJoinGamePasswordError.Size = new System.Drawing.Size(208, 14);
            this.lblJoinGamePasswordError.TabIndex = 18;
            this.lblJoinGamePasswordError.Text = "Digite a senha para entrar na partida.";
            // 
            // txtJoinGamePassword
            // 
            this.txtJoinGamePassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJoinGamePassword.Location = new System.Drawing.Point(440, 189);
            this.txtJoinGamePassword.Name = "txtJoinGamePassword";
            this.txtJoinGamePassword.Size = new System.Drawing.Size(286, 26);
            this.txtJoinGamePassword.TabIndex = 17;
            this.txtJoinGamePassword.TextChanged += new System.EventHandler(this.txtJoinGamePassword_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Senha da partida:";
            // 
            // btnUpdateMatches
            // 
            this.btnUpdateMatches.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnUpdateMatches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMatches.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMatches.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateMatches.Location = new System.Drawing.Point(9, 45);
            this.btnUpdateMatches.Name = "btnUpdateMatches";
            this.btnUpdateMatches.Size = new System.Drawing.Size(186, 39);
            this.btnUpdateMatches.TabIndex = 12;
            this.btnUpdateMatches.Text = "Atualizar Partidas";
            this.btnUpdateMatches.UseVisualStyleBackColor = false;
            this.btnUpdateMatches.Click += new System.EventHandler(this.btnUpdateMatches_Click);
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
            "Finalizadas",
            "Empates"});
            this.cboStatus.Location = new System.Drawing.Point(204, 61);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(111, 24);
            this.cboStatus.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status da partida: ";
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
            this.pnlPlayers.Controls.Add(this.btnBackToMatchList);
            this.pnlPlayers.Controls.Add(this.dgvMatchPlayers);
            this.pnlPlayers.Controls.Add(this.label7);
            this.pnlPlayers.Controls.Add(this.lblSelectedMatchName);
            this.pnlPlayers.Controls.Add(this.btnStartMatch);
            this.pnlPlayers.Controls.Add(this.label15);
            this.pnlPlayers.Location = new System.Drawing.Point(342, 212);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(346, 364);
            this.pnlPlayers.TabIndex = 14;
            this.pnlPlayers.Visible = false;
            // 
            // btnBackToMatchList
            // 
            this.btnBackToMatchList.BackColor = System.Drawing.Color.Silver;
            this.btnBackToMatchList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToMatchList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnBackToMatchList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMatchList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMatchList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackToMatchList.Location = new System.Drawing.Point(17, 296);
            this.btnBackToMatchList.Name = "btnBackToMatchList";
            this.btnBackToMatchList.Size = new System.Drawing.Size(117, 49);
            this.btnBackToMatchList.TabIndex = 18;
            this.btnBackToMatchList.Text = "Cancelar";
            this.btnBackToMatchList.UseVisualStyleBackColor = false;
            this.btnBackToMatchList.Click += new System.EventHandler(this.btnBackToMatchList_Click);
            // 
            // dgvMatchPlayers
            // 
            this.dgvMatchPlayers.AllowUserToAddRows = false;
            this.dgvMatchPlayers.AllowUserToDeleteRows = false;
            this.dgvMatchPlayers.AllowUserToResizeColumns = false;
            this.dgvMatchPlayers.AllowUserToResizeRows = false;
            this.dgvMatchPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatchPlayers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(158)))), ((int)(((byte)(199)))));
            this.dgvMatchPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMatchPlayers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatchPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMatchPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatchPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatchPlayers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMatchPlayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMatchPlayers.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMatchPlayers.Location = new System.Drawing.Point(17, 83);
            this.dgvMatchPlayers.MultiSelect = false;
            this.dgvMatchPlayers.Name = "dgvMatchPlayers";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatchPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMatchPlayers.RowHeadersVisible = false;
            this.dgvMatchPlayers.RowTemplate.Height = 30;
            this.dgvMatchPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatchPlayers.Size = new System.Drawing.Size(305, 203);
            this.dgvMatchPlayers.TabIndex = 25;
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
            this.btnStartMatch.Location = new System.Drawing.Point(162, 296);
            this.btnStartMatch.Name = "btnStartMatch";
            this.btnStartMatch.Size = new System.Drawing.Size(160, 49);
            this.btnStartMatch.TabIndex = 11;
            this.btnStartMatch.Text = "Iniciar Partida";
            this.btnStartMatch.UseVisualStyleBackColor = false;
            this.btnStartMatch.Click += new System.EventHandler(this.btnStartMatch_Click);
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
            // tmrStartMatch
            // 
            this.tmrStartMatch.Interval = 1500;
            this.tmrStartMatch.Tick += new System.EventHandler(this.tmrStartMatch_Tick);
            // 
            // MenuScreen
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
            this.Controls.Add(this.pnlPlayers);
            this.Controls.Add(this.pnlJoinGame);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 650);
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "MenuScreen";
            this.Text = "MagicTrick";
            this.pnlNewGame.ResumeLayout(false);
            this.pnlNewGame.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlJoinGame.ResumeLayout(false);
            this.pnlJoinGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedMatchPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.pnlPlayers.ResumeLayout(false);
            this.pnlPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchPlayers)).EndInit();
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
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateMatches;
        private System.Windows.Forms.Button btnJoinMatch;
        private System.Windows.Forms.Label lblJoinGameUsernameError;
        private System.Windows.Forms.TextBox txtJoinGameUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblJoinGamePasswordError;
        private System.Windows.Forms.TextBox txtJoinGamePassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSelectMatchError;
        private System.Windows.Forms.Panel pnlPlayers;
        private System.Windows.Forms.Label lblSelectedMatchName;
        private System.Windows.Forms.Button btnStartMatch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Button btnBackToMatchList;
        private System.Windows.Forms.Timer tmrStartMatch;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.DataGridView dgvSelectedMatchPlayers;
        private System.Windows.Forms.DataGridView dgvMatchPlayers;
    }
}


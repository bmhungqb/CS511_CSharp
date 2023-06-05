namespace GameMini
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnl_Home = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_setting = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_exit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Ranking = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_playGame = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_dictionary = new Guna.UI2.WinForms.Guna2GradientButton();
            this.media = new AxWMPLib.AxWindowsMediaPlayer();
            this.speaker_bg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.scoreBoard = new GameMini.UserControls.ScoreBoard();
            this.gamePage = new GameMini.UserControls.game();
            this.dictionary = new GameMini.UserControls.Dictionary();
            this.pnl_Home.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speaker_bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Home
            // 
            this.pnl_Home.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Home.Controls.Add(this.guna2CustomGradientPanel1);
            this.pnl_Home.Controls.Add(this.media);
            this.pnl_Home.Controls.Add(this.speaker_bg);
            this.pnl_Home.Controls.Add(this.guna2PictureBox1);
            this.pnl_Home.Controls.Add(this.scoreBoard);
            this.pnl_Home.Controls.Add(this.gamePage);
            this.pnl_Home.Controls.Add(this.dictionary);
            this.pnl_Home.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnl_Home.Location = new System.Drawing.Point(0, 0);
            this.pnl_Home.Name = "pnl_Home";
            this.pnl_Home.Size = new System.Drawing.Size(1100, 600);
            this.pnl_Home.TabIndex = 2;
            this.pnl_Home.UseTransparentBackground = true;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_setting);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_exit);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_Ranking);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_playGame);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_dictionary);
            this.guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(81)))), ((int)(((byte)(121)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(176)))), ((int)(((byte)(218)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(352, 131);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(373, 373);
            this.guna2CustomGradientPanel1.TabIndex = 13;
            // 
            // btn_setting
            // 
            this.btn_setting.BorderRadius = 25;
            this.btn_setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_setting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_setting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_setting.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_setting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_setting.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.ForeColor = System.Drawing.Color.White;
            this.btn_setting.Location = new System.Drawing.Point(65, 238);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(250, 50);
            this.btn_setting.TabIndex = 10;
            this.btn_setting.Text = "Setting";
            this.btn_setting.Click += new System.EventHandler(this.btn_gameBoard);
            // 
            // btn_exit
            // 
            this.btn_exit.BorderRadius = 25;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(65, 306);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(250, 50);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_gameBoard);
            // 
            // btn_Ranking
            // 
            this.btn_Ranking.BorderRadius = 25;
            this.btn_Ranking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ranking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ranking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ranking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Ranking.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Ranking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Ranking.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ranking.ForeColor = System.Drawing.Color.White;
            this.btn_Ranking.Location = new System.Drawing.Point(65, 100);
            this.btn_Ranking.Name = "btn_Ranking";
            this.btn_Ranking.Size = new System.Drawing.Size(250, 50);
            this.btn_Ranking.TabIndex = 8;
            this.btn_Ranking.Text = "Score board";
            this.btn_Ranking.Click += new System.EventHandler(this.btn_gameBoard);
            // 
            // btn_playGame
            // 
            this.btn_playGame.BorderRadius = 25;
            this.btn_playGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_playGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_playGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_playGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_playGame.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_playGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_playGame.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playGame.ForeColor = System.Drawing.Color.White;
            this.btn_playGame.Location = new System.Drawing.Point(65, 30);
            this.btn_playGame.Name = "btn_playGame";
            this.btn_playGame.Size = new System.Drawing.Size(250, 50);
            this.btn_playGame.TabIndex = 3;
            this.btn_playGame.Text = "Play Game";
            this.btn_playGame.Click += new System.EventHandler(this.btn_gameBoard);
            // 
            // btn_dictionary
            // 
            this.btn_dictionary.BorderRadius = 25;
            this.btn_dictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dictionary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dictionary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dictionary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dictionary.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dictionary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dictionary.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dictionary.ForeColor = System.Drawing.Color.White;
            this.btn_dictionary.Location = new System.Drawing.Point(65, 168);
            this.btn_dictionary.Name = "btn_dictionary";
            this.btn_dictionary.Size = new System.Drawing.Size(250, 50);
            this.btn_dictionary.TabIndex = 4;
            this.btn_dictionary.Text = "Dictionary";
            this.btn_dictionary.Click += new System.EventHandler(this.btn_gameBoard);
            // 
            // media
            // 
            this.media.Enabled = true;
            this.media.Location = new System.Drawing.Point(26, 111);
            this.media.Name = "media";
            this.media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media.OcxState")));
            this.media.Size = new System.Drawing.Size(46, 73);
            this.media.TabIndex = 1;
            this.media.Visible = false;
            // 
            // speaker_bg
            // 
            this.speaker_bg.BackColor = System.Drawing.Color.Transparent;
            this.speaker_bg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speaker_bg.FillColor = System.Drawing.Color.Transparent;
            this.speaker_bg.Image = ((System.Drawing.Image)(resources.GetObject("speaker_bg.Image")));
            this.speaker_bg.ImageRotate = 0F;
            this.speaker_bg.Location = new System.Drawing.Point(26, 29);
            this.speaker_bg.Name = "speaker_bg";
            this.speaker_bg.Size = new System.Drawing.Size(78, 64);
            this.speaker_bg.TabIndex = 12;
            this.speaker_bg.TabStop = false;
            this.speaker_bg.UseTransparentBackground = true;
            this.speaker_bg.Click += new System.EventHandler(this.speaker_bg_Click_1);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1100, 600);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // scoreBoard
            // 
            this.scoreBoard.BackColor = System.Drawing.Color.Transparent;
            this.scoreBoard.Location = new System.Drawing.Point(0, 0);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(1100, 600);
            this.scoreBoard.TabIndex = 15;
            this.scoreBoard.Visible = false;
            // 
            // gamePage
            // 
            this.gamePage.BackColor = System.Drawing.Color.Black;
            this.gamePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamePage.BackgroundImage")));
            this.gamePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePage.Location = new System.Drawing.Point(0, 0);
            this.gamePage.Name = "gamePage";
            this.gamePage.Size = new System.Drawing.Size(1100, 600);
            this.gamePage.TabIndex = 3;
            this.gamePage.Visible = false;
            // 
            // dictionary
            // 
            this.dictionary.Location = new System.Drawing.Point(0, 0);
            this.dictionary.Name = "dictionary";
            this.dictionary.Size = new System.Drawing.Size(1100, 600);
            this.dictionary.TabIndex = 16;
            this.dictionary.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.pnl_Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_Home.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speaker_bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public AxWMPLib.AxWindowsMediaPlayer media;
        private Guna.UI2.WinForms.Guna2Panel pnl_Home;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Ranking;
        private Guna.UI2.WinForms.Guna2GradientButton btn_playGame;
        private Guna.UI2.WinForms.Guna2GradientButton btn_dictionary;
        private Guna.UI2.WinForms.Guna2PictureBox speaker_bg;
        private Guna.UI2.WinForms.Guna2GradientButton btn_exit;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private UserControls.game gamePage;
        private UserControls.ScoreBoard scoreBoard;
        private UserControls.Dictionary dictionary;
        private Guna.UI2.WinForms.Guna2GradientButton btn_setting;
    }
}


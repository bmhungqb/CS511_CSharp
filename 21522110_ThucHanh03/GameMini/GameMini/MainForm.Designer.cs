﻿namespace GameMini
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.media = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnl_Home = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_playGame = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.speaker_bg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.game1 = new GameMini.UserControls.game();
            ((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
            this.pnl_Home.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speaker_bg)).BeginInit();
            this.SuspendLayout();
            // 
            // media
            // 
            this.media.Enabled = true;
            this.media.Location = new System.Drawing.Point(31, 106);
            this.media.Name = "media";
            this.media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media.OcxState")));
            this.media.Size = new System.Drawing.Size(46, 73);
            this.media.TabIndex = 1;
            this.media.Visible = false;
            // 
            // pnl_Home
            // 
            this.pnl_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Home.BackgroundImage")));
            this.pnl_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Home.Controls.Add(this.guna2CustomGradientPanel1);
            this.pnl_Home.Controls.Add(this.speaker_bg);
            this.pnl_Home.Controls.Add(this.media);
            this.pnl_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Home.Location = new System.Drawing.Point(0, 0);
            this.pnl_Home.Name = "pnl_Home";
            this.pnl_Home.Size = new System.Drawing.Size(1100, 600);
            this.pnl_Home.TabIndex = 2;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2GradientButton4);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2TextBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_playGame);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2GradientButton3);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2GradientButton2);
            this.guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Violet;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.SystemColors.Window;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Yellow;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Empty;
            this.guna2CustomGradientPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(362, 106);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(415, 433);
            this.guna2CustomGradientPanel1.TabIndex = 13;
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BorderRadius = 25;
            this.guna2GradientButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.Location = new System.Drawing.Point(62, 212);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Size = new System.Drawing.Size(300, 50);
            this.guna2GradientButton4.TabIndex = 8;
            this.guna2GradientButton4.Text = "Score board";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(90, 83);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(250, 35);
            this.guna2TextBox1.TabIndex = 7;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Sienna;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(150, 45);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(129, 31);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Your name";
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
            this.btn_playGame.Location = new System.Drawing.Point(62, 145);
            this.btn_playGame.Name = "btn_playGame";
            this.btn_playGame.Size = new System.Drawing.Size(300, 50);
            this.btn_playGame.TabIndex = 3;
            this.btn_playGame.Text = "Play Game";
            this.btn_playGame.Click += new System.EventHandler(this.btn_playGame_Click_1);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderRadius = 25;
            this.guna2GradientButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.Location = new System.Drawing.Point(62, 345);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(300, 50);
            this.guna2GradientButton3.TabIndex = 5;
            this.guna2GradientButton3.Text = "Settings";
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 25;
            this.guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(62, 279);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(300, 50);
            this.guna2GradientButton2.TabIndex = 4;
            this.guna2GradientButton2.Text = "New words with FlashCard";
            // 
            // speaker_bg
            // 
            this.speaker_bg.BackColor = System.Drawing.Color.Transparent;
            this.speaker_bg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speaker_bg.FillColor = System.Drawing.Color.Transparent;
            this.speaker_bg.Image = ((System.Drawing.Image)(resources.GetObject("speaker_bg.Image")));
            this.speaker_bg.ImageRotate = 0F;
            this.speaker_bg.Location = new System.Drawing.Point(31, 41);
            this.speaker_bg.Name = "speaker_bg";
            this.speaker_bg.Size = new System.Drawing.Size(78, 64);
            this.speaker_bg.TabIndex = 12;
            this.speaker_bg.TabStop = false;
            this.speaker_bg.UseTransparentBackground = true;
            this.speaker_bg.Click += new System.EventHandler(this.speaker_bg_Click_1);
            // 
            // game1
            // 
            this.game1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.game1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game1.Location = new System.Drawing.Point(0, 0);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(1100, 600);
            this.game1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.pnl_Home);
            this.Controls.Add(this.game1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
            this.pnl_Home.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speaker_bg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public AxWMPLib.AxWindowsMediaPlayer media;
        private Guna.UI2.WinForms.Guna2Panel pnl_Home;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_playGame;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2PictureBox speaker_bg;
        private UserControls.game game1;
    }
}


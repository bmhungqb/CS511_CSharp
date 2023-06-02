namespace GameMini.UserControls
{
    partial class ScoreBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreBoard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_easy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_medium = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_hard = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.back_scoreboard = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dataGridScore = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.back_scoreboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScore)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_easy
            // 
            this.btn_easy.BackColor = System.Drawing.Color.Transparent;
            this.btn_easy.BorderRadius = 25;
            this.btn_easy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_easy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_easy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_easy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_easy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_easy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_easy.ForeColor = System.Drawing.Color.White;
            this.btn_easy.Location = new System.Drawing.Point(789, 259);
            this.btn_easy.Name = "btn_easy";
            this.btn_easy.Size = new System.Drawing.Size(206, 48);
            this.btn_easy.TabIndex = 2;
            this.btn_easy.Text = "Easy";
            this.btn_easy.UseTransparentBackground = true;
            this.btn_easy.Click += new System.EventHandler(this.btn_chooseLevel);
            // 
            // btn_medium
            // 
            this.btn_medium.BackColor = System.Drawing.Color.Transparent;
            this.btn_medium.BorderRadius = 25;
            this.btn_medium.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_medium.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_medium.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_medium.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_medium.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_medium.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_medium.ForeColor = System.Drawing.Color.White;
            this.btn_medium.Location = new System.Drawing.Point(789, 313);
            this.btn_medium.Name = "btn_medium";
            this.btn_medium.Size = new System.Drawing.Size(206, 48);
            this.btn_medium.TabIndex = 3;
            this.btn_medium.Text = "Medium";
            this.btn_medium.UseTransparentBackground = true;
            this.btn_medium.Click += new System.EventHandler(this.btn_chooseLevel);
            // 
            // btn_hard
            // 
            this.btn_hard.BackColor = System.Drawing.Color.Transparent;
            this.btn_hard.BorderRadius = 25;
            this.btn_hard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_hard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_hard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_hard.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_hard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_hard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_hard.ForeColor = System.Drawing.Color.White;
            this.btn_hard.Location = new System.Drawing.Point(789, 367);
            this.btn_hard.Name = "btn_hard";
            this.btn_hard.Size = new System.Drawing.Size(206, 48);
            this.btn_hard.TabIndex = 4;
            this.btn_hard.Text = "Hard";
            this.btn_hard.UseTransparentBackground = true;
            this.btn_hard.Click += new System.EventHandler(this.btn_chooseLevel);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Blue;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(470, 42);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(191, 41);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Score board";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Blue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(861, 216);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(57, 26);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = "Levels";
            // 
            // back_scoreboard
            // 
            this.back_scoreboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_scoreboard.Image = ((System.Drawing.Image)(resources.GetObject("back_scoreboard.Image")));
            this.back_scoreboard.ImageRotate = 0F;
            this.back_scoreboard.Location = new System.Drawing.Point(2, 2);
            this.back_scoreboard.Name = "back_scoreboard";
            this.back_scoreboard.Size = new System.Drawing.Size(87, 62);
            this.back_scoreboard.TabIndex = 8;
            this.back_scoreboard.TabStop = false;
            this.back_scoreboard.UseTransparentBackground = true;
            this.back_scoreboard.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1100, 600);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // dataGridScore
            // 
            this.dataGridScore.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridScore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridScore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridScore.ColumnHeadersHeight = 4;
            this.dataGridScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridScore.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridScore.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridScore.Location = new System.Drawing.Point(57, 184);
            this.dataGridScore.Name = "dataGridScore";
            this.dataGridScore.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridScore.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridScore.RowHeadersVisible = false;
            this.dataGridScore.Size = new System.Drawing.Size(454, 316);
            this.dataGridScore.TabIndex = 10;
            this.dataGridScore.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridScore.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridScore.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridScore.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridScore.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridScore.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridScore.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridScore.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridScore.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridScore.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridScore.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridScore.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridScore.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridScore.ThemeStyle.ReadOnly = false;
            this.dataGridScore.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridScore.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridScore.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridScore.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridScore.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridScore.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridScore.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dataGridScore);
            this.Controls.Add(this.back_scoreboard);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btn_hard);
            this.Controls.Add(this.btn_medium);
            this.Controls.Add(this.btn_easy);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "ScoreBoard";
            this.Size = new System.Drawing.Size(1100, 600);
            ((System.ComponentModel.ISupportInitialize)(this.back_scoreboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton btn_easy;
        private Guna.UI2.WinForms.Guna2GradientButton btn_medium;
        private Guna.UI2.WinForms.Guna2GradientButton btn_hard;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox back_scoreboard;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridScore;
    }
}

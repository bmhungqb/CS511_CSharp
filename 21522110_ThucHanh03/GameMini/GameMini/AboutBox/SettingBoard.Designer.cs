namespace GameMini.AboutBox
{
    partial class SettingBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_volume = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.trackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(74, 97);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(81, 27);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Volume";
            // 
            // lb_volume
            // 
            this.lb_volume.BackColor = System.Drawing.Color.Transparent;
            this.lb_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_volume.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_volume.Location = new System.Drawing.Point(74, 185);
            this.lb_volume.Name = "lb_volume";
            this.lb_volume.Size = new System.Drawing.Size(69, 22);
            this.lb_volume.TabIndex = 3;
            this.lb_volume.Text = "Value: 0";
            // 
            // trackBar
            // 
            this.trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar.FillColor = System.Drawing.Color.LightGray;
            this.trackBar.Location = new System.Drawing.Point(110, 140);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(300, 23);
            this.trackBar.TabIndex = 0;
            this.trackBar.ThumbColor = System.Drawing.Color.Blue;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // SettingBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(521, 291);
            this.Controls.Add(this.lb_volume);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.trackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingBoard";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_volume;
        private Guna.UI2.WinForms.Guna2TrackBar trackBar;
    }
}

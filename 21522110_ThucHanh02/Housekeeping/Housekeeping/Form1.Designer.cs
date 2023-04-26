namespace Housekeeping
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_function = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_Account = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Message = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Activity = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Service = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Home = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.message1 = new Housekeeping.Message();
            this.pnl_function.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_function
            // 
            this.pnl_function.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_function.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnl_function.BorderThickness = 2;
            this.pnl_function.Controls.Add(this.btn_Account);
            this.pnl_function.Controls.Add(this.btn_Message);
            this.pnl_function.Controls.Add(this.btn_Activity);
            this.pnl_function.Controls.Add(this.btn_Service);
            this.pnl_function.Controls.Add(this.btn_Home);
            this.pnl_function.CustomBorderColor = System.Drawing.Color.Black;
            this.pnl_function.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.pnl_function.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_function.Location = new System.Drawing.Point(0, 600);
            this.pnl_function.Name = "pnl_function";
            this.pnl_function.Size = new System.Drawing.Size(450, 70);
            this.pnl_function.TabIndex = 0;
            // 
            // btn_Account
            // 
            this.btn_Account.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Account.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Account.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Account.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Account.FillColor = System.Drawing.Color.Transparent;
            this.btn_Account.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_Account.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.ForeColor = System.Drawing.Color.Silver;
            this.btn_Account.Image = ((System.Drawing.Image)(resources.GetObject("btn_Account.Image")));
            this.btn_Account.ImageOffset = new System.Drawing.Point(0, 10);
            this.btn_Account.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Account.Location = new System.Drawing.Point(360, 0);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(90, 70);
            this.btn_Account.TabIndex = 4;
            this.btn_Account.Text = "Account";
            this.btn_Account.TextOffset = new System.Drawing.Point(0, 2);
            this.btn_Account.Tile = true;
            // 
            // btn_Message
            // 
            this.btn_Message.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Message.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Message.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Message.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Message.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Message.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Message.FillColor = System.Drawing.Color.Transparent;
            this.btn_Message.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_Message.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Message.ForeColor = System.Drawing.Color.Silver;
            this.btn_Message.Image = ((System.Drawing.Image)(resources.GetObject("btn_Message.Image")));
            this.btn_Message.ImageOffset = new System.Drawing.Point(0, 15);
            this.btn_Message.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_Message.Location = new System.Drawing.Point(270, 0);
            this.btn_Message.Name = "btn_Message";
            this.btn_Message.Size = new System.Drawing.Size(90, 70);
            this.btn_Message.TabIndex = 3;
            this.btn_Message.Text = "Message";
            this.btn_Message.TextOffset = new System.Drawing.Point(0, -4);
            this.btn_Message.Tile = true;
            // 
            // btn_Activity
            // 
            this.btn_Activity.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Activity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Activity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Activity.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Activity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Activity.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Activity.FillColor = System.Drawing.Color.Transparent;
            this.btn_Activity.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_Activity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Activity.ForeColor = System.Drawing.Color.Silver;
            this.btn_Activity.Image = ((System.Drawing.Image)(resources.GetObject("btn_Activity.Image")));
            this.btn_Activity.ImageOffset = new System.Drawing.Point(0, 8);
            this.btn_Activity.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Activity.Location = new System.Drawing.Point(180, 0);
            this.btn_Activity.Name = "btn_Activity";
            this.btn_Activity.Size = new System.Drawing.Size(90, 70);
            this.btn_Activity.TabIndex = 2;
            this.btn_Activity.Text = "Activity";
            this.btn_Activity.TextOffset = new System.Drawing.Point(0, 2);
            this.btn_Activity.Tile = true;
            // 
            // btn_Service
            // 
            this.btn_Service.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Service.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Service.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Service.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Service.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Service.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Service.FillColor = System.Drawing.Color.Transparent;
            this.btn_Service.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_Service.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Service.ForeColor = System.Drawing.Color.Silver;
            this.btn_Service.Image = ((System.Drawing.Image)(resources.GetObject("btn_Service.Image")));
            this.btn_Service.ImageOffset = new System.Drawing.Point(0, 10);
            this.btn_Service.ImageSize = new System.Drawing.Size(37, 37);
            this.btn_Service.Location = new System.Drawing.Point(90, 0);
            this.btn_Service.Name = "btn_Service";
            this.btn_Service.Size = new System.Drawing.Size(90, 70);
            this.btn_Service.TabIndex = 1;
            this.btn_Service.Text = "Service";
            this.btn_Service.Tile = true;
            // 
            // btn_Home
            // 
            this.btn_Home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Home.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Home.FillColor = System.Drawing.Color.Transparent;
            this.btn_Home.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.Silver;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageOffset = new System.Drawing.Point(0, 10);
            this.btn_Home.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Home.Location = new System.Drawing.Point(0, 0);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(90, 70);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Home";
            this.btn_Home.Tile = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.message1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(450, 600);
            this.guna2Panel1.TabIndex = 1;
            // 
            // message1
            // 
            this.message1.Location = new System.Drawing.Point(0, 0);
            this.message1.Name = "message1";
            this.message1.Size = new System.Drawing.Size(450, 600);
            this.message1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 670);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnl_function);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_function.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnl_function;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Account;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Message;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Activity;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Service;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Home;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Message message1;
    }
}


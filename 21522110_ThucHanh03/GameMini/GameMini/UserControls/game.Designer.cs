namespace GameMini.UserControls
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.btn_back = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_rule = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_start = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ck_vehicles = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.ck_jobs = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.ck_animals = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.ck_hard = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.ck_medium = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.ck_easy = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_continue = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FillColor = System.Drawing.Color.Transparent;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageRotate = 0F;
            this.btn_back.Location = new System.Drawing.Point(7, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(73, 68);
            this.btn_back.TabIndex = 0;
            this.btn_back.TabStop = false;
            this.btn_back.UseTransparentBackground = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_rule
            // 
            this.btn_rule.BackColor = System.Drawing.Color.Transparent;
            this.btn_rule.BorderColor = System.Drawing.Color.Transparent;
            this.btn_rule.BorderRadius = 30;
            this.btn_rule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rule.CustomBorderThickness = new System.Windows.Forms.Padding(25);
            this.btn_rule.CustomizableEdges.BottomLeft = false;
            this.btn_rule.CustomizableEdges.TopLeft = false;
            this.btn_rule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_rule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_rule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_rule.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_rule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_rule.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.btn_rule.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(15)))), ((int)(((byte)(214)))));
            this.btn_rule.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_rule.ForeColor = System.Drawing.Color.White;
            this.btn_rule.Location = new System.Drawing.Point(0, 210);
            this.btn_rule.Name = "btn_rule";
            this.btn_rule.Size = new System.Drawing.Size(250, 60);
            this.btn_rule.TabIndex = 1;
            this.btn_rule.Text = "Rule";
            this.btn_rule.UseTransparentBackground = true;
            this.btn_rule.Click += new System.EventHandler(this.button_Game_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(91, 12);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(108, 48);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Topics";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BorderRadius = 30;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.CustomizableEdges.BottomLeft = false;
            this.btn_start.CustomizableEdges.TopLeft = false;
            this.btn_start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_start.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_start.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.btn_start.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(165)))), ((int)(((byte)(69)))));
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(0, 379);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(250, 60);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Start";
            this.btn_start.UseTransparentBackground = true;
            this.btn_start.Click += new System.EventHandler(this.button_Game_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(590, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(104, 48);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Levels";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox3);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.ck_vehicles);
            this.guna2Panel1.Controls.Add(this.ck_jobs);
            this.guna2Panel1.Controls.Add(this.ck_animals);
            this.guna2Panel1.Controls.Add(this.ck_hard);
            this.guna2Panel1.Controls.Add(this.ck_medium);
            this.guna2Panel1.Controls.Add(this.ck_easy);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel1.Location = new System.Drawing.Point(278, 100);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(794, 496);
            this.guna2Panel1.TabIndex = 6;
            this.guna2Panel1.UseTransparentBackground = true;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Orange;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(167, 468);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(71, 22);
            this.guna2HtmlLabel8.TabIndex = 22;
            this.guna2HtmlLabel8.Text = "Vehicles";
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(139, 368);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(120, 120);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox3.TabIndex = 21;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Orange;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(178, 340);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(41, 22);
            this.guna2HtmlLabel7.TabIndex = 20;
            this.guna2HtmlLabel7.Text = "Jobs";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(139, 219);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(120, 120);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 19;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Orange;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(169, 179);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(66, 22);
            this.guna2HtmlLabel6.TabIndex = 18;
            this.guna2HtmlLabel6.Text = "Animals";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(151, 61);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(120, 120);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 7;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Orange;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(623, 193);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(48, 26);
            this.guna2HtmlLabel5.TabIndex = 17;
            this.guna2HtmlLabel5.Text = "Hard";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Orange;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(623, 143);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(78, 26);
            this.guna2HtmlLabel4.TabIndex = 16;
            this.guna2HtmlLabel4.Text = "Medium";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Orange;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(623, 93);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(48, 26);
            this.guna2HtmlLabel3.TabIndex = 15;
            this.guna2HtmlLabel3.Text = "Easy";
            // 
            // ck_vehicles
            // 
            this.ck_vehicles.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ck_vehicles.CheckedState.BorderRadius = 2;
            this.ck_vehicles.CheckedState.BorderThickness = 0;
            this.ck_vehicles.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ck_vehicles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ck_vehicles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ck_vehicles.Location = new System.Drawing.Point(89, 423);
            this.ck_vehicles.Name = "ck_vehicles";
            this.ck_vehicles.Size = new System.Drawing.Size(25, 25);
            this.ck_vehicles.TabIndex = 14;
            this.ck_vehicles.Text = "guna2CustomCheckBox4";
            this.ck_vehicles.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ck_vehicles.UncheckedState.BorderRadius = 2;
            this.ck_vehicles.UncheckedState.BorderThickness = 0;
            this.ck_vehicles.UncheckedState.FillColor = System.Drawing.Color.Aqua;
            this.ck_vehicles.Click += new System.EventHandler(this.btn_radio_click);
            // 
            // ck_jobs
            // 
            this.ck_jobs.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ck_jobs.CheckedState.BorderRadius = 2;
            this.ck_jobs.CheckedState.BorderThickness = 0;
            this.ck_jobs.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ck_jobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ck_jobs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ck_jobs.Location = new System.Drawing.Point(89, 270);
            this.ck_jobs.Name = "ck_jobs";
            this.ck_jobs.Size = new System.Drawing.Size(25, 25);
            this.ck_jobs.TabIndex = 13;
            this.ck_jobs.Text = "guna2CustomCheckBox5";
            this.ck_jobs.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ck_jobs.UncheckedState.BorderRadius = 2;
            this.ck_jobs.UncheckedState.BorderThickness = 0;
            this.ck_jobs.UncheckedState.FillColor = System.Drawing.Color.Aqua;
            this.ck_jobs.Click += new System.EventHandler(this.btn_radio_click);
            // 
            // ck_animals
            // 
            this.ck_animals.Checked = true;
            this.ck_animals.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ck_animals.CheckedState.BorderRadius = 2;
            this.ck_animals.CheckedState.BorderThickness = 0;
            this.ck_animals.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ck_animals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ck_animals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ck_animals.Location = new System.Drawing.Point(89, 126);
            this.ck_animals.Name = "ck_animals";
            this.ck_animals.Size = new System.Drawing.Size(25, 25);
            this.ck_animals.TabIndex = 12;
            this.ck_animals.Text = "guna2CustomCheckBox6";
            this.ck_animals.UncheckedState.BorderColor = System.Drawing.Color.DarkCyan;
            this.ck_animals.UncheckedState.BorderRadius = 2;
            this.ck_animals.UncheckedState.BorderThickness = 0;
            this.ck_animals.UncheckedState.FillColor = System.Drawing.Color.Cyan;
            this.ck_animals.Click += new System.EventHandler(this.btn_radio_click);
            // 
            // ck_hard
            // 
            this.ck_hard.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ck_hard.CheckedState.BorderRadius = 2;
            this.ck_hard.CheckedState.BorderThickness = 0;
            this.ck_hard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ck_hard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ck_hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_hard.Location = new System.Drawing.Point(590, 195);
            this.ck_hard.Name = "ck_hard";
            this.ck_hard.Size = new System.Drawing.Size(25, 25);
            this.ck_hard.TabIndex = 11;
            this.ck_hard.Text = "guna2CustomCheckBox3";
            this.ck_hard.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ck_hard.UncheckedState.BorderRadius = 2;
            this.ck_hard.UncheckedState.BorderThickness = 0;
            this.ck_hard.UncheckedState.FillColor = System.Drawing.Color.Aqua;
            this.ck_hard.Click += new System.EventHandler(this.btn_radio_click);
            // 
            // ck_medium
            // 
            this.ck_medium.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ck_medium.CheckedState.BorderRadius = 2;
            this.ck_medium.CheckedState.BorderThickness = 0;
            this.ck_medium.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ck_medium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ck_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_medium.Location = new System.Drawing.Point(590, 145);
            this.ck_medium.Name = "ck_medium";
            this.ck_medium.Size = new System.Drawing.Size(25, 25);
            this.ck_medium.TabIndex = 10;
            this.ck_medium.Text = "guna2CustomCheckBox2";
            this.ck_medium.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ck_medium.UncheckedState.BorderRadius = 2;
            this.ck_medium.UncheckedState.BorderThickness = 0;
            this.ck_medium.UncheckedState.FillColor = System.Drawing.Color.Aqua;
            this.ck_medium.Click += new System.EventHandler(this.btn_radio_click);
            // 
            // ck_easy
            // 
            this.ck_easy.Checked = true;
            this.ck_easy.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ck_easy.CheckedState.BorderRadius = 2;
            this.ck_easy.CheckedState.BorderThickness = 0;
            this.ck_easy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ck_easy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ck_easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_easy.Location = new System.Drawing.Point(590, 94);
            this.ck_easy.Name = "ck_easy";
            this.ck_easy.Size = new System.Drawing.Size(25, 25);
            this.ck_easy.TabIndex = 9;
            this.ck_easy.Text = "guna2CustomCheckBox1";
            this.ck_easy.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ck_easy.UncheckedState.BorderRadius = 2;
            this.ck_easy.UncheckedState.BorderThickness = 0;
            this.ck_easy.UncheckedState.FillColor = System.Drawing.Color.Aqua;
            this.ck_easy.Click += new System.EventHandler(this.btn_radio_click);
            // 
            // guna2CirclePictureBox4
            // 
            this.guna2CirclePictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox4.Image")));
            this.guna2CirclePictureBox4.ImageRotate = 0F;
            this.guna2CirclePictureBox4.Location = new System.Drawing.Point(5, 466);
            this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox4.Size = new System.Drawing.Size(128, 128);
            this.guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox4.TabIndex = 7;
            this.guna2CirclePictureBox4.TabStop = false;
            this.guna2CirclePictureBox4.UseTransparentBackground = true;
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.Transparent;
            this.btn_continue.BorderRadius = 30;
            this.btn_continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_continue.CustomizableEdges.BottomLeft = false;
            this.btn_continue.CustomizableEdges.TopLeft = false;
            this.btn_continue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_continue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_continue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_continue.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_continue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_continue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.btn_continue.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(228)))), ((int)(((byte)(14)))));
            this.btn_continue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.ForeColor = System.Drawing.Color.White;
            this.btn_continue.Location = new System.Drawing.Point(0, 293);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(250, 60);
            this.btn_continue.TabIndex = 8;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseTransparentBackground = true;
            this.btn_continue.Click += new System.EventHandler(this.button_Game_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2CirclePictureBox4);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_rule);
            this.Controls.Add(this.btn_back);
            this.Name = "game";
            this.Size = new System.Drawing.Size(1100, 600);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox btn_back;
        private Guna.UI2.WinForms.Guna2GradientButton btn_rule;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_start;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ck_vehicles;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ck_jobs;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ck_animals;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ck_hard;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ck_medium;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ck_easy;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
        private Guna.UI2.WinForms.Guna2GradientButton btn_continue;
    }
}

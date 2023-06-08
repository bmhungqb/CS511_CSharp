namespace GameMini.UserControls
{
    partial class Dictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dictionary));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Back = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cb_topic = new System.Windows.Forms.ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridDictionary = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_addNewWord = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.English = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vietnamese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDictionary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.ImageRotate = 0F;
            this.btn_Back.Location = new System.Drawing.Point(1, 1);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(70, 70);
            this.btn_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Back.TabIndex = 0;
            this.btn_Back.TabStop = false;
            this.btn_Back.UseTransparentBackground = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // cb_topic
            // 
            this.cb_topic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_topic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_topic.FormattingEnabled = true;
            this.cb_topic.Location = new System.Drawing.Point(44, 125);
            this.cb_topic.Name = "cb_topic";
            this.cb_topic.Size = new System.Drawing.Size(141, 32);
            this.cb_topic.Sorted = true;
            this.cb_topic.TabIndex = 1;
            this.cb_topic.SelectedValueChanged += new System.EventHandler(this.cb_topic_SelectedValueChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(79, 93);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(66, 26);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Topics";
            // 
            // dataGridDictionary
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridDictionary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDictionary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDictionary.ColumnHeadersHeight = 15;
            this.dataGridDictionary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridDictionary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.English,
            this.Vietnamese,
            this.Column3,
            this.edit,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDictionary.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDictionary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridDictionary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridDictionary.Location = new System.Drawing.Point(224, 93);
            this.dataGridDictionary.Name = "dataGridDictionary";
            this.dataGridDictionary.RowHeadersVisible = false;
            this.dataGridDictionary.RowHeadersWidth = 51;
            this.dataGridDictionary.Size = new System.Drawing.Size(799, 429);
            this.dataGridDictionary.TabIndex = 3;
            this.dataGridDictionary.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridDictionary.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridDictionary.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridDictionary.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridDictionary.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridDictionary.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridDictionary.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridDictionary.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridDictionary.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridDictionary.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridDictionary.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridDictionary.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridDictionary.ThemeStyle.HeaderStyle.Height = 15;
            this.dataGridDictionary.ThemeStyle.ReadOnly = false;
            this.dataGridDictionary.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridDictionary.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridDictionary.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridDictionary.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridDictionary.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridDictionary.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridDictionary.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridDictionary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDictionary_CellClick);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 469);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(128, 128);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // btn_addNewWord
            // 
            this.btn_addNewWord.BackColor = System.Drawing.Color.Transparent;
            this.btn_addNewWord.BorderRadius = 20;
            this.btn_addNewWord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addNewWord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addNewWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addNewWord.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addNewWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addNewWord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(200)))), ((int)(((byte)(213)))));
            this.btn_addNewWord.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(223)))));
            this.btn_addNewWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addNewWord.ForeColor = System.Drawing.Color.White;
            this.btn_addNewWord.Location = new System.Drawing.Point(904, 542);
            this.btn_addNewWord.Name = "btn_addNewWord";
            this.btn_addNewWord.Size = new System.Drawing.Size(180, 45);
            this.btn_addNewWord.TabIndex = 5;
            this.btn_addNewWord.Text = "Add new word";
            this.btn_addNewWord.UseTransparentBackground = true;
            this.btn_addNewWord.Click += new System.EventHandler(this.btn_addNewWord_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(450, 14);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(226, 57);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Dictionary";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 152.2842F;
            this.Column1.HeaderText = "Image";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // English
            // 
            this.English.FillWeight = 89.54311F;
            this.English.HeaderText = "English";
            this.English.MinimumWidth = 6;
            this.English.Name = "English";
            // 
            // Vietnamese
            // 
            this.Vietnamese.FillWeight = 89.54311F;
            this.Vietnamese.HeaderText = "Vietnamese";
            this.Vietnamese.Name = "Vietnamese";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 89.54311F;
            this.Column3.HeaderText = "Speaker";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // edit
            // 
            this.edit.FillWeight = 89.54311F;
            this.edit.HeaderText = "Edit";
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 89.54311F;
            this.Column4.HeaderText = "Delete";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btn_addNewWord);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.dataGridDictionary);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cb_topic);
            this.Controls.Add(this.btn_Back);
            this.Name = "Dictionary";
            this.Size = new System.Drawing.Size(1100, 600);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDictionary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox btn_Back;
        private System.Windows.Forms.ComboBox cb_topic;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridDictionary;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_addNewWord;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn English;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vietnamese;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
    }
}

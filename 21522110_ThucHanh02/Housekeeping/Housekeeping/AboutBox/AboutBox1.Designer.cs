namespace Housekeeping
{
    partial class AboutBox1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Confirm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.check_CurrentAddress = new Guna.UI2.WinForms.Guna2CheckBox();
            this.check_NewAddress = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txt_CurrentAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_NewAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.check_cash = new Guna.UI2.WinForms.Guna2CheckBox();
            this.check_banking = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.date_do = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_removeItem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(171, 11);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(115, 26);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Order Detail";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(170, 405);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(111, 45);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Confirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Confirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Confirm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Confirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Confirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Confirm.ForeColor = System.Drawing.Color.White;
            this.btn_Confirm.Location = new System.Drawing.Point(302, 405);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(125, 45);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AllowUserToResizeColumns = false;
            this.dataTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTable.Location = new System.Drawing.Point(38, 40);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersVisible = false;
            this.dataTable.Size = new System.Drawing.Size(373, 149);
            this.dataTable.TabIndex = 5;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTable.ThemeStyle.HeaderStyle.Height = 23;
            this.dataTable.ThemeStyle.ReadOnly = true;
            this.dataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTable.ThemeStyle.RowsStyle.Height = 22;
            this.dataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(11, 275);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(41, 15);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Address";
            // 
            // check_CurrentAddress
            // 
            this.check_CurrentAddress.AutoSize = true;
            this.check_CurrentAddress.Checked = true;
            this.check_CurrentAddress.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_CurrentAddress.CheckedState.BorderRadius = 0;
            this.check_CurrentAddress.CheckedState.BorderThickness = 0;
            this.check_CurrentAddress.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_CurrentAddress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_CurrentAddress.Location = new System.Drawing.Point(11, 296);
            this.check_CurrentAddress.Name = "check_CurrentAddress";
            this.check_CurrentAddress.Size = new System.Drawing.Size(101, 17);
            this.check_CurrentAddress.TabIndex = 7;
            this.check_CurrentAddress.Text = "Current Address";
            this.check_CurrentAddress.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_CurrentAddress.UncheckedState.BorderRadius = 0;
            this.check_CurrentAddress.UncheckedState.BorderThickness = 0;
            this.check_CurrentAddress.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_CurrentAddress.Click += new System.EventHandler(this.btn_Check_Address);
            // 
            // check_NewAddress
            // 
            this.check_NewAddress.AutoSize = true;
            this.check_NewAddress.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_NewAddress.CheckedState.BorderRadius = 0;
            this.check_NewAddress.CheckedState.BorderThickness = 0;
            this.check_NewAddress.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_NewAddress.Location = new System.Drawing.Point(11, 329);
            this.check_NewAddress.Name = "check_NewAddress";
            this.check_NewAddress.Size = new System.Drawing.Size(88, 17);
            this.check_NewAddress.TabIndex = 8;
            this.check_NewAddress.Text = "New address";
            this.check_NewAddress.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_NewAddress.UncheckedState.BorderRadius = 0;
            this.check_NewAddress.UncheckedState.BorderThickness = 0;
            this.check_NewAddress.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_NewAddress.Click += new System.EventHandler(this.btn_Check_Address);
            // 
            // txt_CurrentAddress
            // 
            this.txt_CurrentAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CurrentAddress.DefaultText = "";
            this.txt_CurrentAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CurrentAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CurrentAddress.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txt_CurrentAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CurrentAddress.Enabled = false;
            this.txt_CurrentAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CurrentAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CurrentAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CurrentAddress.Location = new System.Drawing.Point(111, 289);
            this.txt_CurrentAddress.Name = "txt_CurrentAddress";
            this.txt_CurrentAddress.PasswordChar = '\0';
            this.txt_CurrentAddress.PlaceholderText = "";
            this.txt_CurrentAddress.ReadOnly = true;
            this.txt_CurrentAddress.SelectedText = "";
            this.txt_CurrentAddress.Size = new System.Drawing.Size(298, 30);
            this.txt_CurrentAddress.TabIndex = 9;
            // 
            // txt_NewAddress
            // 
            this.txt_NewAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NewAddress.DefaultText = "";
            this.txt_NewAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NewAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NewAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NewAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NewAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NewAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_NewAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NewAddress.Location = new System.Drawing.Point(111, 322);
            this.txt_NewAddress.Name = "txt_NewAddress";
            this.txt_NewAddress.PasswordChar = '\0';
            this.txt_NewAddress.PlaceholderText = "";
            this.txt_NewAddress.SelectedText = "";
            this.txt_NewAddress.Size = new System.Drawing.Size(298, 30);
            this.txt_NewAddress.TabIndex = 10;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(11, 369);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(86, 15);
            this.guna2HtmlLabel3.TabIndex = 11;
            this.guna2HtmlLabel3.Text = "Mode of Payment";
            // 
            // check_cash
            // 
            this.check_cash.AutoSize = true;
            this.check_cash.Checked = true;
            this.check_cash.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_cash.CheckedState.BorderRadius = 0;
            this.check_cash.CheckedState.BorderThickness = 0;
            this.check_cash.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_cash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_cash.Location = new System.Drawing.Point(125, 369);
            this.check_cash.Name = "check_cash";
            this.check_cash.Size = new System.Drawing.Size(50, 17);
            this.check_cash.TabIndex = 12;
            this.check_cash.Text = "Cash";
            this.check_cash.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_cash.UncheckedState.BorderRadius = 0;
            this.check_cash.UncheckedState.BorderThickness = 0;
            this.check_cash.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_cash.Click += new System.EventHandler(this.btn_Check_Payment);
            // 
            // check_banking
            // 
            this.check_banking.AutoSize = true;
            this.check_banking.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_banking.CheckedState.BorderRadius = 0;
            this.check_banking.CheckedState.BorderThickness = 0;
            this.check_banking.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_banking.Location = new System.Drawing.Point(216, 369);
            this.check_banking.Name = "check_banking";
            this.check_banking.Size = new System.Drawing.Size(95, 17);
            this.check_banking.TabIndex = 13;
            this.check_banking.Text = "Smart Banking";
            this.check_banking.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_banking.UncheckedState.BorderRadius = 0;
            this.check_banking.UncheckedState.BorderThickness = 0;
            this.check_banking.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_banking.Click += new System.EventHandler(this.btn_Check_Payment);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(12, 211);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(26, 15);
            this.guna2HtmlLabel4.TabIndex = 14;
            this.guna2HtmlLabel4.Text = "Date";
            // 
            // date_do
            // 
            this.date_do.Animated = true;
            this.date_do.Checked = true;
            this.date_do.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.date_do.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_do.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_do.Location = new System.Drawing.Point(58, 207);
            this.date_do.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_do.MinDate = new System.DateTime(2023, 5, 9, 19, 16, 23, 0);
            this.date_do.Name = "date_do";
            this.date_do.Size = new System.Drawing.Size(126, 24);
            this.date_do.TabIndex = 15;
            this.date_do.Value = new System.DateTime(2023, 5, 9, 19, 16, 23, 0);
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_removeItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_removeItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_removeItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_removeItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_removeItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeItem.ForeColor = System.Drawing.Color.White;
            this.btn_removeItem.Location = new System.Drawing.Point(333, 193);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(78, 31);
            this.btn_removeItem.TabIndex = 16;
            this.btn_removeItem.Text = "Remove";
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Animated = true;
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.guna2DateTimePicker1.IndicateFocus = true;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(58, 244);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShowUpDown = true;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(126, 25);
            this.guna2DateTimePicker1.TabIndex = 17;
            this.guna2DateTimePicker1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2DateTimePicker1.Value = new System.DateTime(2023, 5, 9, 19, 24, 0, 0);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(12, 250);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(26, 15);
            this.guna2HtmlLabel5.TabIndex = 18;
            this.guna2HtmlLabel5.Text = "Time";
            // 
            // AboutBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 461);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.btn_removeItem);
            this.Controls.Add(this.date_do);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.check_banking);
            this.Controls.Add(this.check_cash);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txt_NewAddress);
            this.Controls.Add(this.txt_CurrentAddress);
            this.Controls.Add(this.check_NewAddress);
            this.Controls.Add(this.check_CurrentAddress);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox1";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Cancel;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Confirm;
        private Guna.UI2.WinForms.Guna2DataGridView dataTable;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CheckBox check_CurrentAddress;
        private Guna.UI2.WinForms.Guna2CheckBox check_NewAddress;
        private Guna.UI2.WinForms.Guna2TextBox txt_CurrentAddress;
        private Guna.UI2.WinForms.Guna2TextBox txt_NewAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2CheckBox check_cash;
        private Guna.UI2.WinForms.Guna2CheckBox check_banking;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_do;
        private Guna.UI2.WinForms.Guna2Button btn_removeItem;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}

namespace Housekeeping
{
    partial class Activity
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btn_Order = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Active = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnl_Active = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dataGridActive = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Order = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBoxID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel1.SuspendLayout();
            this.pnl_Active.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActive)).BeginInit();
            this.pnl_Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btn_Order);
            this.guna2GradientPanel1.Controls.Add(this.btn_Active);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(450, 50);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // btn_Order
            // 
            this.btn_Order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Order.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Order.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Order.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Order.ForeColor = System.Drawing.Color.White;
            this.btn_Order.Location = new System.Drawing.Point(225, 0);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(225, 50);
            this.btn_Order.TabIndex = 1;
            this.btn_Order.Text = "Orders";
            this.btn_Order.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Active
            // 
            this.btn_Active.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Active.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Active.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Active.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Active.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Active.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Active.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Active.ForeColor = System.Drawing.Color.White;
            this.btn_Active.Location = new System.Drawing.Point(0, 0);
            this.btn_Active.Name = "btn_Active";
            this.btn_Active.Size = new System.Drawing.Size(225, 50);
            this.btn_Active.TabIndex = 0;
            this.btn_Active.Text = "Active";
            this.btn_Active.Click += new System.EventHandler(this.btn_Click);
            // 
            // pnl_Active
            // 
            this.pnl_Active.Controls.Add(this.guna2HtmlLabel1);
            this.pnl_Active.Controls.Add(this.dataGridActive);
            this.pnl_Active.Location = new System.Drawing.Point(0, 50);
            this.pnl_Active.Name = "pnl_Active";
            this.pnl_Active.Size = new System.Drawing.Size(450, 550);
            this.pnl_Active.TabIndex = 2;
            // 
            // dataGridActive
            // 
            this.dataGridActive.AllowUserToAddRows = false;
            this.dataGridActive.AllowUserToDeleteRows = false;
            this.dataGridActive.AllowUserToResizeColumns = false;
            this.dataGridActive.AllowUserToResizeRows = false;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.White;
            this.dataGridActive.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle43;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridActive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.dataGridActive.ColumnHeadersHeight = 20;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridActive.DefaultCellStyle = dataGridViewCellStyle45;
            this.dataGridActive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridActive.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridActive.Location = new System.Drawing.Point(0, 46);
            this.dataGridActive.Name = "dataGridActive";
            this.dataGridActive.ReadOnly = true;
            this.dataGridActive.RowHeadersVisible = false;
            this.dataGridActive.Size = new System.Drawing.Size(450, 504);
            this.dataGridActive.TabIndex = 0;
            this.dataGridActive.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridActive.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridActive.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridActive.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridActive.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridActive.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridActive.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridActive.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridActive.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridActive.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridActive.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridActive.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridActive.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridActive.ThemeStyle.ReadOnly = true;
            this.dataGridActive.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridActive.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridActive.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridActive.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridActive.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridActive.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridActive.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnl_Order
            // 
            this.pnl_Order.Controls.Add(this.guna2HtmlLabel3);
            this.pnl_Order.Controls.Add(this.comboBoxID);
            this.pnl_Order.Controls.Add(this.guna2HtmlLabel2);
            this.pnl_Order.Controls.Add(this.dataGridOrder);
            this.pnl_Order.Location = new System.Drawing.Point(0, 50);
            this.pnl_Order.Name = "pnl_Order";
            this.pnl_Order.Size = new System.Drawing.Size(450, 550);
            this.pnl_Order.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(115, 13);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(213, 27);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "List of work in progress";
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AllowUserToAddRows = false;
            this.dataGridOrder.AllowUserToDeleteRows = false;
            this.dataGridOrder.AllowUserToResizeColumns = false;
            this.dataGridOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.White;
            this.dataGridOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle46;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.dataGridOrder.ColumnHeadersHeight = 20;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridOrder.DefaultCellStyle = dataGridViewCellStyle48;
            this.dataGridOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridOrder.Location = new System.Drawing.Point(0, 85);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.ReadOnly = true;
            this.dataGridOrder.RowHeadersVisible = false;
            this.dataGridOrder.Size = new System.Drawing.Size(450, 465);
            this.dataGridOrder.TabIndex = 1;
            this.dataGridOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridOrder.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridOrder.ThemeStyle.ReadOnly = true;
            this.dataGridOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridOrder.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(163, 13);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(122, 27);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "List of Orders";
            // 
            // comboBoxID
            // 
            this.comboBoxID.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxID.DropDownHeight = 100;
            this.comboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID.DropDownWidth = 170;
            this.comboBoxID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxID.IntegralHeight = false;
            this.comboBoxID.ItemHeight = 30;
            this.comboBoxID.Location = new System.Drawing.Point(96, 43);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(170, 36);
            this.comboBoxID.TabIndex = 3;
            this.comboBoxID.SelectedValueChanged += new System.EventHandler(this.comboBoxID_SelectedValueChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(3, 52);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(87, 15);
            this.guna2HtmlLabel3.TabIndex = 4;
            this.guna2HtmlLabel3.Text = "Select OrderID";
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Order);
            this.Controls.Add(this.pnl_Active);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "Activity";
            this.Size = new System.Drawing.Size(450, 600);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.pnl_Active.ResumeLayout(false);
            this.pnl_Active.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActive)).EndInit();
            this.pnl_Order.ResumeLayout(false);
            this.pnl_Order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Order;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Active;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnl_Active;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnl_Order;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridActive;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxID;
    }
}

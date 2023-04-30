using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace Housekeeping.FormChild
{
    partial class LoginSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSignup));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnl_Signup = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.SU_noti = new System.Windows.Forms.Label();
            this.SU_Gmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SU_Phonenumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.SU_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SU_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.SU_Sex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SU_Address = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SU_Birthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SU_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.SU_btnSignup = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btn_FormSignup = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_FormLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnl_Login = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LI_ForgetPassword = new System.Windows.Forms.LinkLabel();
            this.LI_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.LI_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.LI_btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LI_SaveAccount = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2GradientPanel1.SuspendLayout();
            this.pnl_Signup.SuspendLayout();
            this.guna2ContainerControl1.SuspendLayout();
            this.pnl_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.pnl_Signup);
            this.guna2GradientPanel1.Controls.Add(this.guna2ContainerControl1);
            this.guna2GradientPanel1.Controls.Add(this.pnl_Login);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(41)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(450, 670);
            this.guna2GradientPanel1.TabIndex = 1;
            this.guna2GradientPanel1.UseTransparentBackground = true;
            // 
            // pnl_Signup
            // 
            this.pnl_Signup.Controls.Add(this.SU_noti);
            this.pnl_Signup.Controls.Add(this.SU_Gmail);
            this.pnl_Signup.Controls.Add(this.guna2HtmlLabel9);
            this.pnl_Signup.Controls.Add(this.SU_Phonenumber);
            this.pnl_Signup.Controls.Add(this.SU_Password);
            this.pnl_Signup.Controls.Add(this.guna2HtmlLabel8);
            this.pnl_Signup.Controls.Add(this.guna2HtmlLabel10);
            this.pnl_Signup.Controls.Add(this.SU_Username);
            this.pnl_Signup.Controls.Add(this.SU_Sex);
            this.pnl_Signup.Controls.Add(this.guna2HtmlLabel7);
            this.pnl_Signup.Controls.Add(this.guna2HtmlLabel6);
            this.pnl_Signup.Controls.Add(this.SU_Address);
            this.pnl_Signup.Controls.Add(this.guna2HtmlLabel5);
            this.pnl_Signup.Controls.Add(this.SU_Birthday);
            this.pnl_Signup.Controls.Add(this.guna2HtmlLabel4);
            this.pnl_Signup.Controls.Add(this.guna2HtmlLabel3);
            this.pnl_Signup.Controls.Add(this.SU_Name);
            this.pnl_Signup.Controls.Add(this.SU_btnSignup);
            this.pnl_Signup.Location = new System.Drawing.Point(24, 71);
            this.pnl_Signup.Name = "pnl_Signup";
            this.pnl_Signup.Size = new System.Drawing.Size(403, 533);
            this.pnl_Signup.TabIndex = 10;
            this.pnl_Signup.Visible = false;
            // 
            // SU_noti
            // 
            this.SU_noti.AutoSize = true;
            this.SU_noti.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SU_noti.ForeColor = System.Drawing.Color.Red;
            this.SU_noti.Location = new System.Drawing.Point(119, 377);
            this.SU_noti.Name = "SU_noti";
            this.SU_noti.Size = new System.Drawing.Size(0, 17);
            this.SU_noti.TabIndex = 23;
            this.SU_noti.Visible = false;
            // 
            // SU_Gmail
            // 
            this.SU_Gmail.BorderRadius = 10;
            this.SU_Gmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SU_Gmail.DefaultText = "";
            this.SU_Gmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SU_Gmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SU_Gmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SU_Gmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SU_Gmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SU_Gmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SU_Gmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SU_Gmail.IconLeftSize = new System.Drawing.Size(32, 32);
            this.SU_Gmail.Location = new System.Drawing.Point(155, 326);
            this.SU_Gmail.Name = "SU_Gmail";
            this.SU_Gmail.PasswordChar = '\0';
            this.SU_Gmail.PlaceholderText = "account@gmail.com";
            this.SU_Gmail.SelectedText = "";
            this.SU_Gmail.Size = new System.Drawing.Size(213, 35);
            this.SU_Gmail.TabIndex = 21;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(155, 299);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(34, 17);
            this.guna2HtmlLabel9.TabIndex = 20;
            this.guna2HtmlLabel9.Text = "Gmail";
            // 
            // SU_Phonenumber
            // 
            this.SU_Phonenumber.BorderRadius = 10;
            this.SU_Phonenumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SU_Phonenumber.DefaultText = "";
            this.SU_Phonenumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SU_Phonenumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SU_Phonenumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SU_Phonenumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SU_Phonenumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SU_Phonenumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SU_Phonenumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SU_Phonenumber.IconLeftSize = new System.Drawing.Size(32, 32);
            this.SU_Phonenumber.Location = new System.Drawing.Point(26, 326);
            this.SU_Phonenumber.Name = "SU_Phonenumber";
            this.SU_Phonenumber.PasswordChar = '\0';
            this.SU_Phonenumber.PlaceholderText = "Nhập số điện thoại";
            this.SU_Phonenumber.SelectedText = "";
            this.SU_Phonenumber.Size = new System.Drawing.Size(117, 35);
            this.SU_Phonenumber.TabIndex = 19;
            // 
            // SU_Password
            // 
            this.SU_Password.BorderRadius = 10;
            this.SU_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SU_Password.DefaultText = "";
            this.SU_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SU_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SU_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SU_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SU_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SU_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SU_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SU_Password.IconLeftSize = new System.Drawing.Size(32, 32);
            this.SU_Password.Location = new System.Drawing.Point(228, 47);
            this.SU_Password.Name = "SU_Password";
            this.SU_Password.PasswordChar = '●';
            this.SU_Password.PlaceholderText = "Nhập mật khẩu";
            this.SU_Password.SelectedText = "";
            this.SU_Password.Size = new System.Drawing.Size(141, 35);
            this.SU_Password.TabIndex = 18;
            this.SU_Password.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(228, 27);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(53, 17);
            this.guna2HtmlLabel8.TabIndex = 17;
            this.guna2HtmlLabel8.Text = "Mật khẩu";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(26, 27);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(83, 17);
            this.guna2HtmlLabel10.TabIndex = 14;
            this.guna2HtmlLabel10.Text = "Tên đăng nhập";
            // 
            // SU_Username
            // 
            this.SU_Username.BorderRadius = 10;
            this.SU_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SU_Username.DefaultText = "";
            this.SU_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SU_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SU_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SU_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SU_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SU_Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SU_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SU_Username.IconLeftSize = new System.Drawing.Size(32, 32);
            this.SU_Username.Location = new System.Drawing.Point(26, 47);
            this.SU_Username.Name = "SU_Username";
            this.SU_Username.PasswordChar = '\0';
            this.SU_Username.PlaceholderText = "Tên đăng nhập";
            this.SU_Username.SelectedText = "";
            this.SU_Username.Size = new System.Drawing.Size(189, 35);
            this.SU_Username.TabIndex = 13;
            // 
            // SU_Sex
            // 
            this.SU_Sex.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.SU_Sex.BackColor = System.Drawing.Color.Transparent;
            this.SU_Sex.BorderRadius = 10;
            this.SU_Sex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SU_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SU_Sex.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SU_Sex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SU_Sex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SU_Sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SU_Sex.ItemHeight = 35;
            this.SU_Sex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.SU_Sex.Location = new System.Drawing.Point(267, 180);
            this.SU_Sex.Name = "SU_Sex";
            this.SU_Sex.Size = new System.Drawing.Size(84, 41);
            this.SU_Sex.StartIndex = 0;
            this.SU_Sex.TabIndex = 8;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(266, 162);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(48, 17);
            this.guna2HtmlLabel7.TabIndex = 12;
            this.guna2HtmlLabel7.Text = "Giới tính";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(26, 299);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(73, 17);
            this.guna2HtmlLabel6.TabIndex = 11;
            this.guna2HtmlLabel6.Text = "Số điện thoại";
            // 
            // SU_Address
            // 
            this.SU_Address.BorderRadius = 10;
            this.SU_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SU_Address.DefaultText = "";
            this.SU_Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SU_Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SU_Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SU_Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SU_Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SU_Address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SU_Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SU_Address.IconLeftSize = new System.Drawing.Size(32, 32);
            this.SU_Address.Location = new System.Drawing.Point(26, 254);
            this.SU_Address.Name = "SU_Address";
            this.SU_Address.PasswordChar = '\0';
            this.SU_Address.PlaceholderText = "Nhập địa chỉ";
            this.SU_Address.SelectedText = "";
            this.SU_Address.Size = new System.Drawing.Size(343, 35);
            this.SU_Address.TabIndex = 10;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(26, 234);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(40, 17);
            this.guna2HtmlLabel5.TabIndex = 9;
            this.guna2HtmlLabel5.Text = "Địa chỉ";
            // 
            // SU_Birthday
            // 
            this.SU_Birthday.BorderRadius = 10;
            this.SU_Birthday.Checked = true;
            this.SU_Birthday.FillColor = System.Drawing.Color.White;
            this.SU_Birthday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SU_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.SU_Birthday.Location = new System.Drawing.Point(26, 186);
            this.SU_Birthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.SU_Birthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.SU_Birthday.Name = "SU_Birthday";
            this.SU_Birthday.Size = new System.Drawing.Size(226, 35);
            this.SU_Birthday.TabIndex = 8;
            this.SU_Birthday.Value = new System.DateTime(2003, 9, 17, 10, 14, 0, 0);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(26, 164);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(56, 17);
            this.guna2HtmlLabel4.TabIndex = 7;
            this.guna2HtmlLabel4.Text = "Ngày sinh";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(26, 95);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(54, 17);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Họ và tên";
            // 
            // SU_Name
            // 
            this.SU_Name.BorderRadius = 10;
            this.SU_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SU_Name.DefaultText = "";
            this.SU_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SU_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SU_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SU_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SU_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SU_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SU_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SU_Name.IconLeftSize = new System.Drawing.Size(32, 32);
            this.SU_Name.Location = new System.Drawing.Point(26, 115);
            this.SU_Name.Name = "SU_Name";
            this.SU_Name.PasswordChar = '\0';
            this.SU_Name.PlaceholderText = "Nhập họ tên";
            this.SU_Name.SelectedText = "";
            this.SU_Name.Size = new System.Drawing.Size(343, 35);
            this.SU_Name.TabIndex = 0;
            // 
            // SU_btnSignup
            // 
            this.SU_btnSignup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(155)))));
            this.SU_btnSignup.BorderRadius = 5;
            this.SU_btnSignup.BorderThickness = 1;
            this.SU_btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SU_btnSignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SU_btnSignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SU_btnSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SU_btnSignup.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SU_btnSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SU_btnSignup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(155)))));
            this.SU_btnSignup.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.SU_btnSignup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SU_btnSignup.ForeColor = System.Drawing.Color.White;
            this.SU_btnSignup.Location = new System.Drawing.Point(119, 420);
            this.SU_btnSignup.Name = "SU_btnSignup";
            this.SU_btnSignup.Size = new System.Drawing.Size(154, 39);
            this.SU_btnSignup.TabIndex = 4;
            this.SU_btnSignup.Text = "Đăng ký";
            this.SU_btnSignup.Click += new System.EventHandler(this.SU_btnSignup_Click);
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ContainerControl1.Controls.Add(this.btn_FormSignup);
            this.guna2ContainerControl1.Controls.Add(this.btn_FormLogin);
            this.guna2ContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ContainerControl1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(450, 62);
            this.guna2ContainerControl1.TabIndex = 7;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            this.guna2ContainerControl1.UseTransparentBackground = true;
            // 
            // btn_FormSignup
            // 
            this.btn_FormSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_FormSignup.BorderColor = System.Drawing.Color.Transparent;
            this.btn_FormSignup.BorderThickness = 1;
            this.btn_FormSignup.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_FormSignup.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(83)))), ((int)(((byte)(51)))));
            this.btn_FormSignup.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(77)))));
            this.btn_FormSignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_FormSignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_FormSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_FormSignup.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_FormSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_FormSignup.FillColor = System.Drawing.Color.Transparent;
            this.btn_FormSignup.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_FormSignup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_FormSignup.ForeColor = System.Drawing.Color.White;
            this.btn_FormSignup.Location = new System.Drawing.Point(219, 23);
            this.btn_FormSignup.Name = "btn_FormSignup";
            this.btn_FormSignup.Size = new System.Drawing.Size(204, 39);
            this.btn_FormSignup.TabIndex = 1;
            this.btn_FormSignup.Text = "Đăng ký";
            this.btn_FormSignup.Click += new System.EventHandler(this.btn_FormSignup_Click);
            // 
            // btn_FormLogin
            // 
            this.btn_FormLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_FormLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btn_FormLogin.BorderThickness = 1;
            this.btn_FormLogin.Checked = true;
            this.btn_FormLogin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_FormLogin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(83)))), ((int)(((byte)(51)))));
            this.btn_FormLogin.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(77)))));
            this.btn_FormLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FormLogin.CustomizableEdges.BottomLeft = false;
            this.btn_FormLogin.CustomizableEdges.BottomRight = false;
            this.btn_FormLogin.CustomizableEdges.TopLeft = false;
            this.btn_FormLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_FormLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_FormLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_FormLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_FormLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_FormLogin.FillColor = System.Drawing.Color.Transparent;
            this.btn_FormLogin.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_FormLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_FormLogin.ForeColor = System.Drawing.Color.White;
            this.btn_FormLogin.Location = new System.Drawing.Point(20, 23);
            this.btn_FormLogin.Name = "btn_FormLogin";
            this.btn_FormLogin.Size = new System.Drawing.Size(193, 39);
            this.btn_FormLogin.TabIndex = 0;
            this.btn_FormLogin.Text = "Đăng nhập";
            this.btn_FormLogin.Click += new System.EventHandler(this.btn_FormLogin_Click);
            // 
            // pnl_Login
            // 
            this.pnl_Login.Controls.Add(this.guna2PictureBox2);
            this.pnl_Login.Controls.Add(this.guna2CirclePictureBox2);
            this.pnl_Login.Controls.Add(this.guna2CirclePictureBox1);
            this.pnl_Login.Controls.Add(this.guna2HtmlLabel2);
            this.pnl_Login.Controls.Add(this.LI_ForgetPassword);
            this.pnl_Login.Controls.Add(this.LI_Username);
            this.pnl_Login.Controls.Add(this.LI_Password);
            this.pnl_Login.Controls.Add(this.LI_btnLogin);
            this.pnl_Login.Controls.Add(this.guna2HtmlLabel1);
            this.pnl_Login.Controls.Add(this.LI_SaveAccount);
            this.pnl_Login.Location = new System.Drawing.Point(34, 68);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(386, 446);
            this.pnl_Login.TabIndex = 6;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(254, 334);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(50, 50);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 9;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(161, 335);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(48, 48);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 8;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(60, 322);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(75, 75);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 7;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(26, 298);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(328, 22);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "--------------- Hoặc tiếp tục bằng ----------------";
            // 
            // LI_ForgetPassword
            // 
            this.LI_ForgetPassword.AutoSize = true;
            this.LI_ForgetPassword.LinkColor = System.Drawing.Color.LightGray;
            this.LI_ForgetPassword.Location = new System.Drawing.Point(251, 150);
            this.LI_ForgetPassword.Name = "LI_ForgetPassword";
            this.LI_ForgetPassword.Size = new System.Drawing.Size(86, 13);
            this.LI_ForgetPassword.TabIndex = 5;
            this.LI_ForgetPassword.TabStop = true;
            this.LI_ForgetPassword.Text = "Quên mật khẩu?";
            // 
            // LI_Username
            // 
            this.LI_Username.BorderRadius = 10;
            this.LI_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LI_Username.DefaultText = "";
            this.LI_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LI_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LI_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LI_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LI_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LI_Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LI_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LI_Username.IconLeftSize = new System.Drawing.Size(32, 32);
            this.LI_Username.Location = new System.Drawing.Point(48, 37);
            this.LI_Username.Name = "LI_Username";
            this.LI_Username.PasswordChar = '\0';
            this.LI_Username.PlaceholderText = "Tên tài khoản";
            this.LI_Username.SelectedText = "";
            this.LI_Username.Size = new System.Drawing.Size(284, 44);
            this.LI_Username.TabIndex = 0;
            // 
            // LI_Password
            // 
            this.LI_Password.BorderRadius = 10;
            this.LI_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LI_Password.DefaultText = "";
            this.LI_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LI_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LI_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LI_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LI_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LI_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LI_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LI_Password.IconLeftSize = new System.Drawing.Size(32, 32);
            this.LI_Password.IconRightSize = new System.Drawing.Size(25, 25);
            this.LI_Password.Location = new System.Drawing.Point(48, 103);
            this.LI_Password.Name = "LI_Password";
            this.LI_Password.PasswordChar = '●';
            this.LI_Password.PlaceholderText = "Mật khẩu";
            this.LI_Password.SelectedText = "";
            this.LI_Password.Size = new System.Drawing.Size(284, 44);
            this.LI_Password.TabIndex = 1;
            this.LI_Password.UseSystemPasswordChar = true;
            // 
            // LI_btnLogin
            // 
            this.LI_btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(155)))));
            this.LI_btnLogin.BorderRadius = 5;
            this.LI_btnLogin.BorderThickness = 1;
            this.LI_btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LI_btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LI_btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LI_btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LI_btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LI_btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(155)))));
            this.LI_btnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.LI_btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LI_btnLogin.ForeColor = System.Drawing.Color.White;
            this.LI_btnLogin.Location = new System.Drawing.Point(119, 219);
            this.LI_btnLogin.Name = "LI_btnLogin";
            this.LI_btnLogin.Size = new System.Drawing.Size(154, 39);
            this.LI_btnLogin.TabIndex = 4;
            this.LI_btnLogin.Text = "Đăng nhập";
            this.LI_btnLogin.Click += new System.EventHandler(this.LI_btnLogin_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(83, 164);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(70, 15);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Nhớ tài khoản";
            // 
            // LI_SaveAccount
            // 
            this.LI_SaveAccount.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LI_SaveAccount.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LI_SaveAccount.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.LI_SaveAccount.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LI_SaveAccount.Location = new System.Drawing.Point(48, 164);
            this.LI_SaveAccount.Name = "LI_SaveAccount";
            this.LI_SaveAccount.Size = new System.Drawing.Size(30, 17);
            this.LI_SaveAccount.TabIndex = 2;
            this.LI_SaveAccount.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LI_SaveAccount.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LI_SaveAccount.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.LI_SaveAccount.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // LoginSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 670);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoginSignup";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.pnl_Signup.ResumeLayout(false);
            this.pnl_Signup.PerformLayout();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_FormSignup;
        private Guna.UI2.WinForms.Guna2GradientButton btn_FormLogin;
        private Guna.UI2.WinForms.Guna2GradientPanel pnl_Login;
        private Guna.UI2.WinForms.Guna2GradientPanel pnl_Signup;
        private Guna.UI2.WinForms.Guna2TextBox SU_Gmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2TextBox SU_Phonenumber;
        private Guna.UI2.WinForms.Guna2TextBox SU_Password;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2TextBox SU_Username;
        private Guna.UI2.WinForms.Guna2ComboBox SU_Sex;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox SU_Address;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2DateTimePicker SU_Birthday;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox SU_Name;
        private Guna.UI2.WinForms.Guna2GradientButton SU_btnSignup;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private LinkLabel LI_ForgetPassword;
        private Guna.UI2.WinForms.Guna2TextBox LI_Username;
        private Guna.UI2.WinForms.Guna2TextBox LI_Password;
        private Guna.UI2.WinForms.Guna2GradientButton LI_btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch LI_SaveAccount;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label SU_noti;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}
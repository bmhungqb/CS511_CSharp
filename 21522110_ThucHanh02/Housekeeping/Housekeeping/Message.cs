using Guna.UI2.WinForms;
using Housekeeping.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Windows.Forms;

namespace Housekeeping
{
    public partial class Message : UserControl
    {
        public Message()
        {
            InitializeComponent();
        }
        #region Declare constant variable
        int Pos_x = 132;
        int Pos_y = 120;
        int Pos_x_Ad = 4;
        #endregion
        #region handle Send Message
        private void ResponseMessage(string content)
        {
            Guna2TextBox textBox = new Guna2TextBox();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            textBox.BackColor = System.Drawing.Color.Transparent;
            textBox.BorderColor = System.Drawing.Color.Blue;
            textBox.BorderRadius = 20;
            textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            if(content == "Thanks" || content == "thank")
            {
                textBox.DefaultText = "You're Welcome <3";
            }
            else
            {
                textBox.DefaultText = "Hello, it's oke !!!";
            }
            textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            textBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(114)))), ((int)(((byte)(180)))));
            textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            textBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox.ForeColor = System.Drawing.Color.White;
            textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            textBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("AdminMessage.IconLeft")));
            textBox.IconLeftOffset = new System.Drawing.Point(-4, 0);
            textBox.IconLeftSize = new System.Drawing.Size(40, 40);
            textBox.IconRightSize = new System.Drawing.Size(0, 0);
            textBox.Location = new System.Drawing.Point(4, 20);
            textBox.PasswordChar = '\0';
            textBox.PlaceholderText = "";
            textBox.ReadOnly = true;
            textBox.SelectedText = "";
            textBox.Size = new System.Drawing.Size(210, 40);
            textBox.TabIndex = 0;
            textBox.Location = new System.Drawing.Point(Pos_x_Ad, Pos_y);
            Pos_y = textBox.Location.Y + textBox.Height + 10;
            pnl_containerMessage.Controls.Add(textBox);
            pnl_containerMessage.Show();
        }
        private void MS_btnSend_Click(object sender, EventArgs e)
        {
            if (MS_InputText.Text == "")
            {
                MS_noti_error.Visible = true;
                MS_noti_error.Text = "Please type your comment..";
            }
            else
            {
                MS_noti_error.Text = "";
                MS_noti_error.Visible = false;
                Guna2TextBox textBox = new Guna2TextBox();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
                textBox.BackColor = System.Drawing.Color.Transparent;
                textBox.BorderColor = System.Drawing.Color.Blue;
                textBox.BorderRadius = 20;
                textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
                textBox.Text = MS_InputText.Text;
                textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                textBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
                textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
                textBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textBox.ForeColor = System.Drawing.Color.White;
                textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
                textBox.IconLeftSize = new System.Drawing.Size(40, 40);
                textBox.IconRight = ((System.Drawing.Image)(resources.GetObject("UserMessage.IconRight")));
                textBox.IconRightOffset = new System.Drawing.Point(-4, 0);
                textBox.IconRightSize = new System.Drawing.Size(40, 40);
                textBox.ReadOnly = true;
                textBox.Multiline = true;
                int len = MS_InputText.Text.Length;
                int len_box = (len / 35) * 300;
                if (len_box > 400)
                {
                    int x = ((len / 35)*300) / 400;
                    textBox.Size = new System.Drawing.Size(400,40 * x);
                    textBox.Location = new System.Drawing.Point(29, Pos_y);
                }
                else
                {
                    textBox.Size = new System.Drawing.Size(300, 40);
                    textBox.Location = new System.Drawing.Point(Pos_x, Pos_y);
                }
                Pos_y = textBox.Location.Y + textBox.Height + 10;
                pnl_containerMessage.Controls.Add(textBox);
                pnl_containerMessage.Show();
                ResponseMessage(MS_InputText.Text);
            }
        }
        #endregion
    }
}

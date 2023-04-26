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
        int Pos_x = 195;
        int Pos_y = 100;
        #endregion
        #region handle Send Message
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
                textBox.Text = MS_InputText.Text;
                textBox.BackColor = System.Drawing.Color.Transparent;
                textBox.BorderColor = System.Drawing.Color.Blue;
                textBox.BorderRadius = 20;
                textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
                //textBox.DefaultText = "Can i checkout by Smartbanking ?";
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
                textBox.Location = new System.Drawing.Point(Pos_x, Pos_y);
                textBox.PasswordChar = '\0';
                textBox.PlaceholderText = "";
                textBox.SelectedText = "";
                textBox.Size = new System.Drawing.Size(253, 40);
                textBox.TabIndex = 1;
                pnl_containerMessage.Controls.Add(textBox);
                pnl_containerMessage.Show();
                Pos_y += 30;
            }
            //return "";
        }
        #endregion
    }
}

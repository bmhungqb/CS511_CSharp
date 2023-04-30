using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housekeeping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HomePage.Visible = true;
            ServicePage.Visible = false;
            MessagePage.Visible = false;
            AccountPage.Visible = false;
            ActivityPage.Visible = false;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Guna2GradientButton button = sender as Guna2GradientButton;
            if (button.Name == "btn_Home")
            {
                HomePage.Visible = true;
                ServicePage.Visible = false;
                MessagePage.Visible = false;
                AccountPage.Visible = false;
                ActivityPage.Visible = false;
            }
            else if (button.Name == "btn_Service")
            {
                HomePage.Visible = false;
                ServicePage.Visible = true;
                MessagePage.Visible = false;
                AccountPage.Visible = false;
                ActivityPage.Visible = false;
            }
            else if (button.Name == "btn_Activity")
            {
                HomePage.Visible = false;
                ServicePage.Visible = false;
                MessagePage.Visible = false;
                AccountPage.Visible = false;
                ActivityPage.Visible = true;

            }
            else if (button.Name == "btn_Message")
            {
                HomePage.Visible = false;
                ServicePage.Visible = false;
                MessagePage.Visible = true;
                AccountPage.Visible = false;
                ActivityPage.Visible = false;

            }
            else if (button.Name == "btn_Account")
            {
                HomePage.Visible = false;
                ServicePage.Visible = false;
                MessagePage.Visible = false;
                AccountPage.Visible = true;
                ActivityPage.Visible = false;

            }
        }
    }
}

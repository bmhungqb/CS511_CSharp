using Guna.UI2.WinForms;
using Housekeeping.FormChild;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Housekeeping
{
    public partial class Form1 : Form
    {
        public string UserInfor = "";
        public Form1(string userInfor)
        {
            InitializeComponent();
            HomePage.Visible = true;
            ServicePage.Visible = false;
            MessagePage.Visible = false;
            AccountPage.Visible = false;
            ActivityPage.Visible = false;
            btn_Home.Checked = true;
            btn_Account.Checked = false;
            btn_Activity.Checked = false;
            btn_Message.Checked = false;
            btn_Service.Checked = false;
            updateInfor(userInfor);
            UserInfor = userInfor;
        }
        public string getDataUser()
        {
            return UserInfor;
        }
        public void updateInfor(string userInfor)
        {
            UserInfor = userInfor;
            HomePage.updateHome(userInfor);
            AccountPage.UpdateAcount(userInfor);
            ServicePage.GetCurrentAddress(userInfor);
            ActivityPage.GetInforUserFromParent(userInfor);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Guna2GradientButton button = sender as Guna2GradientButton;
            if (button.Name == "btn_Home")
            {
                //updateInfor(id);
                HomePage.Visible = true;
                ServicePage.Visible = false;
                MessagePage.Visible = false;
                AccountPage.Visible = false;
                ActivityPage.Visible = false;
                btn_Home.Checked = true;
                btn_Account.Checked = false;
                btn_Activity.Checked = false;
                btn_Message.Checked = false;
                btn_Service.Checked = false;
            }
            else if (button.Name == "btn_Service")
            {
                HomePage.Visible = false;
                ServicePage.Visible = true;
                MessagePage.Visible = false;
                AccountPage.Visible = false;
                ActivityPage.Visible = false;
                btn_Home.Checked = false;
                btn_Account.Checked = false;
                btn_Activity.Checked = false;
                btn_Message.Checked = false;
                btn_Service.Checked = true;
            }
            else if (button.Name == "btn_Activity")
            {
                HomePage.Visible = false;
                ServicePage.Visible = false;
                MessagePage.Visible = false;
                AccountPage.Visible = false;
                ActivityPage.Visible = true;
                btn_Home.Checked = false;
                btn_Account.Checked = false;
                btn_Activity.Checked = true;
                btn_Message.Checked = false;
                btn_Service.Checked = false;
                ActivityPage.updateActivity();

            }
            else if (button.Name == "btn_Message")
            {
                HomePage.Visible = false;
                ServicePage.Visible = false;
                MessagePage.Visible = true;
                AccountPage.Visible = false;
                ActivityPage.Visible = false;

                btn_Home.Checked = false;
                btn_Account.Checked = false;
                btn_Activity.Checked = false;
                btn_Message.Checked = true;
                btn_Service.Checked = false;

            }
            else if (button.Name == "btn_Account")
            {
                HomePage.Visible = false;
                ServicePage.Visible = false;
                MessagePage.Visible = false;
                AccountPage.Visible = true;
                ActivityPage.Visible = false;

                btn_Home.Checked = false;
                btn_Account.Checked = true;
                btn_Activity.Checked = false;
                btn_Message.Checked = false;
                btn_Service.Checked = false;
                AccountPage.Load_history();
                AccountPage.Load_Statistics_Service();
            }
        }
        public void HandleLogout()
        {
            LoginSignup loginSignup = new LoginSignup();
            loginSignup.Show();
            this.Hide();
        }

        private void ActivityPage_Load(object sender, EventArgs e)
        {

        }
    }
}

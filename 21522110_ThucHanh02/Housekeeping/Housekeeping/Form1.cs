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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            btn_Home.Checked = true;
            btn_Account.Checked = false;
            btn_Activity.Checked = false;
            btn_Message.Checked = false;
            btn_Service.Checked = false;
            LoginSignup login = new LoginSignup();
            login.ShowDialog();
            updateInfor(login.idUser);
            id = login.idUser;  
        }
        private const string filePath = @"C:\Users\bmhun\Documents\TaiLieuHocTapDaiHoc\Year2\HK_II\UIT\C-Sharp\ThucHanh\21522110_ThucHanh02\Housekeeping\dataUser\DataUserInfor.txt";
        private string id = "";
        public void updateInfor(string id)
        {
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string inforUser;
                Dictionary<string, string> User = new Dictionary<string, string>();
                while ((inforUser = reader.ReadLine()) != null)
                {
                    string[] infor = inforUser.Split('_');
                    if (infor[0] == id)
                    {
                        User.Add("Username", infor[3]);
                        User.Add("Address", infor[6]);
                        User.Add("Phone", infor[7]);
                        User.Add("Email", infor[8]);
                        User.Add("Sex", infor[5]);
                        //User.Add("Username", infor[3]);
                        HomePage.updateHome(User["Username"], User["Address"]);
                        AccountPage.UpdateAcount(User["Username"], User["Phone"], User["Email"], User["Sex"], User["Address"], id);
                        ServicePage.GetCurrentAddress(User["Address"]);
                        break;
                    }
                }
            }
            
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Guna2GradientButton button = sender as Guna2GradientButton;
            if (button.Name == "btn_Home")
            {
                updateInfor(id);
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
            }
        }
    }
}

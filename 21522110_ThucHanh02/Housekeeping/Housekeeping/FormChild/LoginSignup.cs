using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Housekeeping.FormChild
{
    public partial class LoginSignup : Form
    {
        public LoginSignup()
        {
            InitializeComponent();
        }

        private void btn_FormLogin_Click(object sender, EventArgs e)
        {
            pnl_Signup.Visible = false;
            pnl_Login.Visible = true;
        }

        private void btn_FormSignup_Click(object sender, EventArgs e)
        {
            pnl_Signup.Visible = true;
            pnl_Login.Visible = false;
        }

        private string getInfor(Dictionary<string,string> InforUser)
        {
            if(SU_Username.Text == "")
            {
                return "0Please enter Username..";
            }
            else
            {
                InforUser.Add("Username", SU_Username.Text);
            }
            if(SU_Password.Text =="")
            {
                return "0Please enter password..";
            }
            else
            {
                InforUser.Add("Password", SU_Password.Text);
            }
            if(SU_Name.Text == "")
            {
                return "0Please enter your name..";
            }
            else
            {
                InforUser.Add("Name", SU_Name.Text);
            }
            if(SU_Birthday.Text == "")
            {
                return "0Please choose your birthday..";
            }
            else
            {
                InforUser.Add("Birthday", SU_Birthday.Text);
            }
            if(SU_Sex.Text == "")
            {
                return "0Please choose your sex..";
            }
            else
            {
                InforUser.Add("Sex", SU_Sex.Text);
            }
            if(SU_Address.Text =="")
            {
                return "0Please enter your address..";
            }
            else
            {
                InforUser.Add("Address", SU_Address.Text);
            }
            if(SU_Phonenumber.Text =="")
            {
                return "0Please enter your phonenumber..";
            }
            else
            {
                InforUser.Add("Phonenumber", SU_Phonenumber.Text);
            }
            if(SU_Gmail.Text =="")
            {
                return "0Please enter your gmail..";
            }
            else
            {
                InforUser.Add("Gmail", SU_Gmail.Text);
            }
            return "1Congratulations, your account has been successfully created.";
        }
        private void saveDataToFile(Dictionary<string,string>InforUser)
        {
            string infor = Get
        }
        private void SU_btnSignup_Click(object sender, EventArgs e)
        {
            Dictionary<string,string> InforUser = new Dictionary<string,string>();
            string res = getInfor(InforUser);
            if (res[0] == '1')
            {
                saveDataToFile(InforUser);
            }
        }
    }
}

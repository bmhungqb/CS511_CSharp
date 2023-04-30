using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Housekeeping.FormChild
{
    public partial class LoginSignup : Form
    {
        public LoginSignup()
        {
            InitializeComponent();
        }
        #region Constants
        private const string filePath = @"C:\Users\bmhun\Documents\TaiLieuHocTapDaiHoc\Year2\HK_II\UIT\C-Sharp\ThucHanh\21522110_ThucHanh02\Housekeeping\dataUser\DataUserInfor.txt";
        #endregion
        #region Handle button
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
        #endregion
        #region Handle Sign up
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
            string inforUser = "";
            foreach(KeyValuePair<string,string> infor in InforUser)
            {
                inforUser += infor.Value;
                inforUser += "_";
            }
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath,true))
                {
                    writer.WriteLine(inforUser);
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving information: {ex.Message}");
            }
        }
        private void SU_btnSignup_Click(object sender, EventArgs e)
        {
            Dictionary<string,string> InforUser = new Dictionary<string,string>();
            string res = getInfor(InforUser);
            if (res.Substring(0,1) == "1")
            {
                saveDataToFile(InforUser);
                MessageBox.Show(res);
                this.Close();
            }
            else
            {
                SU_noti.Visible = true;
                SU_noti.Text = res.Substring(1, res.Length);
            }
        }
        #endregion
        #region Handle Login
        private string checkInforLogin(string Username,string Password)
        {
            if(Username == "")
            {
                return "0Please enter Username";
            }
            else if(Password =="")
            {
                return "0Please enter Password";
            }
            try
            {
                using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    string inforUser;
                    while((inforUser = reader.ReadLine()) != null)
                    {
                        string[] infor = inforUser.Split('_');
                        if(Username == infor[0] && Password == infor[1]) 
                        {
                            return "1Login Success";
                        }
                        if(Username == infor[0] && Password != infor[1])
                        {
                            return "0Wrong Password";
                        }

                    }
                    return "0Account doesn't exists";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving information: {ex.Message}");
            }


            return "1Login success";
        }
        private void LI_btnLogin_Click(object sender, EventArgs e)
        {
            string res = checkInforLogin(LI_Username.Text, LI_Password.Text);
            if (res.Substring(0,1) == "1")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(res);
            }
        }
        #endregion
    }
}
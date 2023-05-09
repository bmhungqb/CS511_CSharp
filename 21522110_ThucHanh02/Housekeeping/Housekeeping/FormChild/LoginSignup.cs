using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Housekeeping.FormChild
{
    public partial class LoginSignup : Form
    {
        public LoginSignup()
        {
            InitializeComponent();
            HandleRemember(1);
        }
        #region Constants
        private const string filePath = @"C:\Users\bmhun\Documents\TaiLieuHocTapDaiHoc\Year2\HK_II\UIT\C-Sharp\ThucHanh\21522110_ThucHanh02\Housekeeping\dataUser\DataUserInfor.txt";
        private const string filePathDataRemember = @"C:\Users\bmhun\Documents\TaiLieuHocTapDaiHoc\Year2\HK_II\UIT\C-Sharp\ThucHanh\21522110_ThucHanh02\Housekeeping\dataUser\DataRemember.txt";
        public string idUser;
        #endregion
        #region Handle button
        public void HandleRemember(int i)
        {
            string inforUser = File.ReadAllText(filePathDataRemember);
            if(inforUser != "" && i == 1)
            {
                string[] infor = inforUser.Split('_');
                LI_Username.Text = infor[0];
                LI_Password.Text = infor[1];
            }
            if(i == 0)
            {
                if (LI_SaveAccount.Checked)
                {
                    string lineReplace = LI_Username.Text.ToString() + "_" + LI_Password.Text.ToString();
                    File.WriteAllText(filePathDataRemember, lineReplace);
                }
                else
                {
                    File.WriteAllText(filePathDataRemember, String.Empty);
                }
            }
        }
        private void btn_FormLogin_Click(object sender, EventArgs e)
        {
            pnl_Signup.Visible = false;
            pnl_Login.Visible = true;
            btn_FormLogin.Checked = true;
            btn_FormSignup.Checked = false;
            HandleRemember(1);
        }

        private void btn_FormSignup_Click(object sender, EventArgs e)
        {
            pnl_Signup.Visible = true;
            pnl_Login.Visible = false;
            btn_FormLogin.Checked = false;
            btn_FormSignup.Checked = true;
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
                InforUser.Add("Birthday", SU_Birthday.Value.ToString("yyyy-MM-dd hh:mm tt"));
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
            return "1";
        }
        private string saveDataToFile(Dictionary<string,string>InforUser)
        {
            string path = Constants.dataUser +'/'+InforUser["Username"];
            if(Directory.Exists(path))
            {
                return "null";
            }
            Directory.CreateDirectory(path);
            path = path + "/UserInfor.txt";
            StreamWriter sw = File.CreateText(path);
            Random rdn= new Random();
            int random = rdn.Next();
            idUser = random.ToString();
            sw.WriteLine(idUser);
            foreach(KeyValuePair<string,string> infor in InforUser)
            {
                sw.WriteLine(infor.Value);
            }
            sw.Close();
            return "1";
        }
        private string SaveInforUser(string username)
        {
            string user = "";
            using (StreamReader reader = new StreamReader(Constants.dataUser+"/"+username+"/UserInfor.txt", Encoding.UTF8))
            {
                string inforUser;
                while ((inforUser = reader.ReadLine()) != null)
                {   
                    user += inforUser;
                    user += "_";
                }
            }
            return user;
        }
        private void SU_btnSignup_Click(object sender, EventArgs e)
        {
            Dictionary<string,string> InforUser = new Dictionary<string,string>();
            string res = getInfor(InforUser);
            if (res == "1")
            {
                string result = saveDataToFile(InforUser);
                if(result != "null")
                {
                    string user = SaveInforUser(InforUser["Username"]);
                    Form1 Home = new Form1(user);
                    this.Hide();
                    Home.Show();    
                }
                else
                {
                    MessageBox.Show("Username is exists", "Exists Account",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                SU_noti.Visible = true;
                SU_noti.Text = res;
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
            string path = Constants.dataUser + "/" + Username;
            if (Directory.Exists(path))
            {
                string User = "";
                using (StreamReader reader = new StreamReader(path+"/UserInfor.txt", Encoding.UTF8))
                {
                    string inforUser;
                    while ((inforUser = reader.ReadLine()) != null)
                    {
                        User += inforUser;
                        User += "_";
                        
                    }
                    string RealPass = User.Split('_')[2];
                    if (Password == RealPass)
                    {
                        return "1Login Success";
                    }
                    else
                    {
                        return "0Wrong Password";
                    }
                }
            }
            else
            {
                return "0Account doesn't exists";
            }
        }
        private void LI_btnLogin_Click(object sender, EventArgs e)
        {
            string res = checkInforLogin(LI_Username.Text, LI_Password.Text);
            if (res.Substring(0,1) == "1")
            {
                HandleRemember(0);
                string user = SaveInforUser(LI_Username.Text);
                Form1 Home = new Form1(user);
                this.Hide();
                Home.Show();
            }
            else
            {
                MessageBox.Show(res);
            }
        }
        #endregion

    }
}
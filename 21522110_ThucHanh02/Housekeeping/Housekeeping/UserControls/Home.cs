using Housekeeping.FormChild;
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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        public void updateHome(string userInfor)
        {
            string[] user = userInfor.Split('_');
            tb_Greeting.Text = "Welcome " + user[3];
            tb_Address.Text = user[6];
        }
        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                ((Form1)this.TopLevelControl).HandleLogout();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoginSignup login = new LoginSignup();
            login.ShowDialog();
            //((Form)this.TopLevelControl).Close();
        }
    }
}

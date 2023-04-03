using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.FormChild
{
    public partial class FormLoginSignup : Form
    {
        public FormLoginSignup()
        {
            InitializeComponent();
        }

        private void btn_FormSignup_Click(object sender, EventArgs e)
        {
            pnl_Login.Visible = false;
            pnl_Signup.Visible = true;
            btn_FormLogin.Checked = false;
            btn_FormSignup.Checked = true;
        }

        private void btn_FormLogin_Click(object sender, EventArgs e)
        {
            pnl_Login.Visible = true;
            pnl_Signup.Visible = false;
            btn_FormLogin.Checked = true;
            btn_FormSignup.Checked = false;
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}

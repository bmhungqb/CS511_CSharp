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

        public void updateHome(string name,string address)
        {
            tb_Greeting.Text = "Welcome " + name;
            tb_Address.Text = address;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                ((Form)this.TopLevelControl).Close();
            }
        }
    }
}

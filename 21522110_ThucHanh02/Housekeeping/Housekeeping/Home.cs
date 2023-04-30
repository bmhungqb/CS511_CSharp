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
            tb_Greeting.Text = "Welcom " + name;
            tb_Address.Text = address;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

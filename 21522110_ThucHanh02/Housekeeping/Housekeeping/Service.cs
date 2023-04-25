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
    public partial class Service : UserControl
    {
        public Service()
        {
            InitializeComponent();
        }
        #region DataService
        public Dictionary<string, string> dataService = new Dictionary<string, string>()
        {
            {"c1","150,000" },
            {"c2","200,000" },
            {"c3","300,000" },
            {"c4","200,000" },
            {"c5","200,000" },
            {"c6","300,000" },
            {"c7","300,000" },
            {"c8","200,000" },

            {"l1","200,000" },
            {"l2","100,000" },
            {"l3","300,000" },
            {"l4","200,000" },
            {"l5","100,000" },

            {"cl1","150,000" },
            {"cl2","200,000" },
            {"cl3","500,000" },
            {"cl4","300,000" },
            {"cl5","300,000" },
        };
        #endregion
        #region Handle Click Service
        private void updateTotalPrice(string money,bool isCheck)
        {
            string total = SV_TotalPrice.Text;
            string[] str = total.Split(' ');
            int currentMoney = Convert.ToInt32(str[2]);
            int newMoney = Convert.ToInt32(money);
            if(isCheck == true)
            {
                SV_TotalPrice.Text = "Order total: " + (currentMoney + newMoney).ToString() + " nvđ";
            }
            else
            {
                SV_TotalPrice.Text = "Order total: " + (currentMoney - newMoney).ToString() + " nvđ";
            }
        }
        private void checkTick(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            string money = dataService[check.Name];
            if (check.Checked)
            {
                check.Checked = false;
            }
            else
            {
                check.Checked = true;
            }
            updateTotalPrice(money, check.Checked);
        }
        #endregion
        #region Handle choose service-Cooking-Cleaning-Laundry
        private void btn_Service_Click(object sender, EventArgs e)
        {
            Button btnService = sender as Button;
            if(btnService.Name == "btn_Cooking")
            {
                pnl_Cooking.Visible = true;
                pnl_Laundry.Visible = false;
                pnl_Cleaning.Visible = false;
            }
            else if(btnService.Name == "btn_Cleaning")
            {
                pnl_Cooking.Visible = false;
                pnl_Laundry.Visible = false;
                pnl_Cleaning.Visible = true;
            }
            else
            {
                pnl_Cooking.Visible = false;
                pnl_Laundry.Visible = true;
                pnl_Cleaning.Visible = false;
            }
        }
        #endregion

    }
}

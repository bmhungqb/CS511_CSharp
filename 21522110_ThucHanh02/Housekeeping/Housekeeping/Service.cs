using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Windows.Documents;
using System.Windows.Controls.Primitives;

namespace Housekeeping
{
    public partial class Service : UserControl
    {
        public Service()
        {
            InitializeComponent();
            pnl_Cooking.Visible = true;
            pnl_Laundry.Visible = false;
            pnl_Cleaning.Visible = false;
            btn_Cooking.Checked = true;
            btn_Laundry.Checked = false;
            btn_Cleaning.Checked = false;
        }
        #region dataPrice
        public Dictionary<string, string> dataPrice = new Dictionary<string, string>()
        {
            {"c1","150000" },
            {"c2","200000" },
            {"c3","300000" },
            {"c4","200000" },
            {"c5","200000" },
            {"c6","300000" },
            {"c7","300000" },
            {"c8","200000" },

            {"l1","200000" },
            {"l2","100000" },
            {"l3","300000" },
            {"l4","200000" },
            {"l5","100000" },

            {"cl1","150000" },
            {"cl2","200000" },
            {"cl3","500000" },
            {"cl4","300000" },
            {"cl5","300000" },
        };
        public Dictionary<string, string> dataPropertyService = new Dictionary<string, string>()
        {
            {"c1","2 Dishes" },
            {"c2","3 Dishes" },
            {"c3","4 Dishes" },
            {"c4","3 Dishes" },
            {"c5","3 Dishes" },
            {"c6","4 Dishes" },
            {"c7","4 Dishes" },
            {"c8","3 Dishes" },

            {"l1","Laundrying & Ironing" },
            {"l2","Laundrying" },
            {"l3","Laundrying & Ironing & Folding" },
            {"l4","Laundrying & Ironing" },
            {"l5","Laundrying" },

            {"cl1","Living room" },
            {"cl2","Living room" },
            {"cl3","Living & Chicken room" },
            {"cl4","Living room" },
            {"cl5","Chicken room" },
        };
        List<string> elChecked = new List<string>();
        #endregion
        #region Handle Click Service
        private void updateTotalPrice(string money,bool isCheck)
        {
            string total = SV_TotalPrice.Text;
            string[] str = total.Split(' ');
            int currentMoney = Convert.ToInt32(str[2]);
            int newMoney = Convert.ToInt32(money);
            if (isCheck == true)
            {
                SV_TotalPrice.Text = "Order total: " + (currentMoney + newMoney).ToString() + " vnđ";
            }
            else
            {
                SV_TotalPrice.Text = "Order total: " + (currentMoney - newMoney).ToString() + " vnđ";
            }
        }
        private void checkTick(object sender, EventArgs e)
        {
            Guna2CustomCheckBox check = sender as Guna2CustomCheckBox;
            check.Checked = !check.Checked;
            string money = dataPrice[check.Name];
            if (check.Checked)
            {
                check.Checked = false;
                elChecked.Remove(check.Name);
            }
            else
            {
                check.Checked = true;
                elChecked.Add(check.Name);
            }
            updateTotalPrice(money, check.Checked);
        }
        #endregion
        #region Handle choose service-Cooking-Cleaning-Laundry
        private void btn_Service_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btnService = sender as Guna2GradientButton;
            if(btnService.Name == "btn_Cooking")
            {
                pnl_Cooking.Visible = true;
                pnl_Laundry.Visible = false;
                pnl_Cleaning.Visible = false;
                btn_Cooking.Checked = true;
                btn_Laundry.Checked = false;
                btn_Cleaning.Checked = false;
            }
            else if(btnService.Name == "btn_Cleaning")
            {
                pnl_Cooking.Visible = false;
                pnl_Laundry.Visible = false;
                pnl_Cleaning.Visible = true;
                btn_Cooking.Checked = false;
                btn_Laundry.Checked = false;
                btn_Cleaning.Checked = true;
            }
            else
            {
                pnl_Cooking.Visible = false;
                pnl_Laundry.Visible = true;
                pnl_Cleaning.Visible = false;
                btn_Cooking.Checked = false;
                btn_Laundry.Checked = true;
                btn_Cleaning.Checked = false;
            }
        }
        #endregion

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            if(elChecked.Count == 0)
            {
                MessageBox.Show("Please Order Any Our Services", "Empty Order",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                AboutBox1 Aboutbox= new AboutBox1();
                Aboutbox.VisualizeData(elChecked, dataPrice, dataPropertyService);
                DialogResult dialogResult = Aboutbox.ShowDialog();
                if(dialogResult == DialogResult.OK)
                {
                    ClearChecked();
                }
            }
        }
        public void ClearChecked()
        {
            elChecked.Clear();
            foreach (Control pnl in SV_Container.Controls)
            {
                foreach (Control container in pnl.Controls)
                {
                    foreach (Control c in container.Controls)
                    {
                        if (c is Guna2CustomCheckBox cb)
                        {
;                            cb.Checked = false;
                        }
                    }
                }
            }
        }
    }
}
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
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnCountUp_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(txtSL1.Text);
            count++;
            float priceTotalItem = float.Parse(txtCartPriceItem1.Text);
            float sum = priceTotalItem * count;
            txtCartTotalItem1.Text = sum.ToString();
            txtSL1.Text = count.ToString();
        }

        private void btnCountDown_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(txtSL1.Text);
            if (count == 0)
            {
                MessageBox.Show("Bạn có muốn xóa sản phẩm đang chọn?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            count--;
            float priceTotalItem = float.Parse(txtCartPriceItem1.Text);
            float sum = priceTotalItem * count;
            txtCartTotalItem1.Text = sum.ToString();
            txtSL1.Text = count.ToString();
        }

        private void btnitem1plus_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(txtSL1.Text);
            count++;
            float priceTotalItem = float.Parse(txtCartPriceItem1.Text);
            float sum = priceTotalItem * count;
            txtCartTotalItem1.Text = sum.ToString();
            txtSL1.Text = count.ToString();
        }

        private void btnitemminus_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(txtSL1.Text);
            count--;
            if(count==-1)
            {
                count = 0;
            }
            float priceTotalItem = float.Parse(txtCartPriceItem1.Text);
            float sum = priceTotalItem * count;
            txtCartTotalItem1.Text = sum.ToString();
            txtSL1.Text = count.ToString();
        }
    }
}

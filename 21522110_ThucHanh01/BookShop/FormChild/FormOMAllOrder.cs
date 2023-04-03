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
    public partial class FormOMAllOrder : Form
    {
        public FormOMAllOrder()
        {
            InitializeComponent();
        }

        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlShowDetailOrder.Controls.Add(childForm);
            pnlShowDetailOrder.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            pnlSHowOrder.Visible = true;
            openChildForm(new FormChild.FormOMTransport());
        }

        private void btnBackDetaail_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = true;
            pnlSHowOrder.Visible = false;
        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            pnlSHowOrder.Visible = true;
            openChildForm(new FormChild.FormOMDone());
        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            pnlSHowOrder.Visible = true;
            openChildForm(new FormChild.FormOMPaid());
        }

        private void guna2HtmlLabel15_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            pnlSHowOrder.Visible = true;
            openChildForm(new FormChild.FormOMCancel());
        }
    }
}

using BookShop.Components;
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

    public partial class FormChildHome : Form
    {
        public FormChildHome()
        {
            InitializeComponent();
        }

        //public void openChildControl(UserControl childControl)
        //{
        //    childControl.Dock = DockStyle.Fill;
        //    pnlSubDetailItem.Controls.Add(childControl);
        //    pnlSubDetailItem.Tag = childControl;
        //    childControl.BringToFront();
        //    childControl.Show();
        //}
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
            pnlSubDetailItem.Controls.Add(childForm);
            pnlSubDetailItem.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void HomeItem1_Click(object sender, EventArgs e)
        {
            layoutFormHome.Visible = false;
            pnlDetailItem.Visible = true;
            openChildForm(new FormChild.FormDetailItem1());
        }

        private void btnBackDetail_Click(object sender, EventArgs e)
        {
            layoutFormHome.Visible = true;
            pnlDetailItem.Visible = false;
            activeForm.Close();
        }

        private void HomeItem8_Click(object sender, EventArgs e)
        {
            layoutFormHome.Visible = false;
            pnlDetailItem.Visible = true;
            openChildForm(new FormChild.FormDetailItem6());
        }

        private void HomeItem2_Click(object sender, EventArgs e)
        {
            layoutFormHome.Visible = false;
            pnlDetailItem.Visible = true;
            openChildForm(new FormChild.FormDetailItem5());
        }

        private void HomeItem4_Click(object sender, EventArgs e)
        {
            layoutFormHome.Visible = false;
            pnlDetailItem.Visible = true;
            openChildForm(new FormChild.FormDetailItem3());
        }

        private void guna2Panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeItem5_Click(object sender, EventArgs e)
        {
            layoutFormHome.Visible = false;
            pnlDetailItem.Visible = true;
            openChildForm(new FormChild.FormDetailItem7());
        }

        private void guna2Panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeItem6_Click(object sender, EventArgs e)
        {
            layoutFormHome.Visible = false;
            pnlDetailItem.Visible = true;
            openChildForm(new FormChild.FormDetailItem8());
        }

        private void HomeItem7_Click(object sender, EventArgs e)
        {
            layoutFormHome.Visible = false;
            pnlDetailItem.Visible = true;
            openChildForm(new FormChild.FormDetailItem9());
        }

        private void HomeItem3_Click(object sender, EventArgs e)
        {
            layoutFormHome.Visible = false;
            pnlDetailItem.Visible = true;
            openChildForm(new FormChild.FormDetailItem9());
        }
    }
}

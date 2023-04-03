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
    public partial class FormOrderManagement : Form
    {
        public FormOrderManagement()
        {
            InitializeComponent();
            openChildForm(new FormChild.FormOMAllOrder());
        }
        public Form activeForm = null;
        public Form activeForm2 = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            if (activeForm2 != null)
            {
                activeForm2.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlShowOM.Controls.Add(childForm);
            pnlShowOM.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void openChildForm1(Form childForm1,Form childForm2)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            if (activeForm2 != null)
            {
                activeForm2.Close();
            }
            activeForm = childForm1;
            activeForm2 = childForm2;
            childForm1.TopLevel = false;
            childForm1.FormBorderStyle = FormBorderStyle.None;
            childForm1.Dock = DockStyle.Top;
            childForm1.AutoScroll = false;
            childForm1.AutoSize = true;
            childForm2.AutoScroll = false;
            childForm2.AutoSize = true;
            childForm2.TopLevel = false;
            childForm2.FormBorderStyle = FormBorderStyle.None;
            childForm2.Dock = DockStyle.Top;
            pnlShowOM.Controls.Add(childForm1);
            pnlShowOM.Tag = childForm1;
            childForm1.BringToFront();
            childForm1.Show();
            pnlShowOM.Controls.Add(childForm2);
            pnlShowOM.Tag = childForm2;
            childForm2.BringToFront();
            childForm2.Show();
        }
        private void btnOMProcessing_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormOMProcessing());
        }

        private void btnOMDone_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormOMDone());
        }

        private void btnOMCancel_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormOMCancel());
        }

        private void btnOMPaid_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormOMPaid());
        }

        private void btnOMTransport_Click(object sender, EventArgs e)
        {
            openChildForm1(new FormChild.FormOMTransport(),new FormChild.FormOMDone());
        }

        private void btnOMAll_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormOMAllOrder());
        }
    }
}

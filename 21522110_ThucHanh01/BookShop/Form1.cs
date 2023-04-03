using BookShop.Components;
using BookShop.FormChild;

namespace BookShop
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openChildForm(new FormChild.FormChildHome());
            //openChildControl(new Components.UCItemDetail());
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
            pnlMainShow.Controls.Add(childForm);
            pnlMainShow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void openChildControl(UserControl childControl)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            childControl.Dock = DockStyle.Fill;
            pnlMainShow.Controls.Add(childControl);
            pnlMainShow.Tag = childControl;
            childControl.BringToFront();
            childControl.Show();
        }

        private void btnControlBook_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormBookPage());
            pnlSubAccount.Visible = false;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormVPP());
            pnlSubAccount.Visible = false;
        }

        private void btnControlSouvenir_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormSouvenir());
            pnlSubAccount.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormChildHome());
            pnlSubAccount.Visible = false;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormChild.FormAccount());
            //openChildForm(new FormChild.FormOrderManagement());
        }

        private void btn_Account_Infor_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormAccount());
        }

        private void btn_Account_HisOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormOrderManagement());
        }

        private void btn_LoginSignup_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormLoginSignup());
        }

        private void btnHeaderCart_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormCart());
        }

        private void btnHeaderNoti_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn đến với Bookshop <3", "Thông báo");
        }

        private void pnlMainShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBookShop_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormChildHome());
        }

        private void showSubmenu(Panel subMenu)
        {
            subMenu.Visible = !subMenu.Visible;
        }
        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            showSubmenu(pnlSubAccount);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormSetting());
            pnlSubAccount.Visible = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChild.FormHelp());
            pnlSubAccount.Visible = false;
        }
    }
}
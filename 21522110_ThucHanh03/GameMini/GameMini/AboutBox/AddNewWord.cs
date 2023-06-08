using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.IO;

namespace GameMini.AboutBox
{
    partial class AddNewWord : Form
    {
        public AddNewWord(string topic,string tx_english1 = null,string tx_vietnamese1 = null,Image img1 = null)
        {
            InitializeComponent();
            tp = topic;
            if(tx_english1 != null && tx_vietnamese1 != null)
            {
                isEdit = true;
                image.Image = img1;
                text.Text = tx_english1;
                tb_vn.Text = tx_vietnamese1;
                currentEn = tx_english1;
                currentVi = tx_vietnamese1;
            }
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
        #region define path
        const string folder_dic = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/Dataset/Dictionary";
        string tp;
        Dictionary<string,string> dataToEdit = new Dictionary<string,string>();
        bool isEdit = false;
        string delePath;
        string currentEn;
        string currentVi;
        #endregion
        private void btn_click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = sender as Guna2GradientButton;  
            if(btn.Name == "btn_cancel")
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else if(btn.Name == "btn_add")
            {
            if(text.Text == "")
            {
                this.Close();
            }
            if (currentEn == text.Text && currentVi == tb_vn.Text)
            {
                this.Close();
            }
            else
            {

                savePath = folder_dic + "/" + tp + "/" + text.Text+"_"+tb_vn.Text + ".png";
                image.Image.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);
                this.DialogResult = DialogResult.OK;
            }
            }
            this.Close();
        }
        string savePath;
        private void btn_Click_ChangeImage(object sender, EventArgs e)
        {
            if(!isEdit)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    image.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
}

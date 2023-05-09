using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Housekeeping
{
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
            pnl_account.Visible = true;
            pnl_History.Visible = false;
            pnl_Statistics.Visible = false;
            A_btnAccount.Checked = true;
            A_btnHistory.Checked = false;
            A_btnStatistics.Checked = false;
        }
        #region declare constant variable 
        private const string filePath = @"C:\Users\bmhun\Documents\TaiLieuHocTapDaiHoc\Year2\HK_II\UIT\C-Sharp\ThucHanh\21522110_ThucHanh02\Housekeeping\dataUser\DataCart.txt";
        private const string filePathData = @"C:\Users\bmhun\Documents\TaiLieuHocTapDaiHoc\Year2\HK_II\UIT\C-Sharp\ThucHanh\21522110_ThucHanh02\Housekeeping\dataUser\DataUserInfor.txt";
        private string UserId = "";
        Dictionary<string, int> dataC = new Dictionary<string, int>()
        {
            {"Cleaning", 0},
            {"Laundry", 0},
            {"Cooking", 0},
            {"Done", 0},
            {"Cancel", 0},
            {"Doing", 0},
        };
        #endregion
        string USER = "";
        public void UpdateAcount(string userInfor)
        {
            USER= userInfor;
            string[] user = userInfor.Split('_');
            tb_Name.Text = user[3];
            tb_Phone.Text = user[7];
            tb_Gmail.Text = user[8];
            tb_Sex.SelectedValue = user[5];
            tb_Address.Text = user[6];
            DateTime dateTime = DateTime.Parse(user[4].ToString());
            tb_Birthday.Value = dateTime.ToUniversalTime();
            UserId = user[0];
            string pathImg = Constants.dataUser + "/" + user[1] + "/avatar.png";
            if(File.Exists(pathImg))
            {
                avatar.Image = Image.FromFile(pathImg);
            }
        }
        // Format store data
        //OrderId_Id_NameService_DetailService_Price_DayOrder_Status_Adress_ModePayment
        DataTable table = new DataTable();
        private void Load_history()
        {
            table.Columns.Clear();
            table.Rows.Clear();
            table.Columns.Add("Order ID", typeof(string));
            table.Columns.Add("Service", typeof(string));
            table.Columns.Add("Detail Service", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Implementation Date", typeof(string));
            table.Columns.Add("Status", typeof(string));
            AC_dataHistoryView.DataSource = table;

            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string inforUser;
                while ((inforUser = reader.ReadLine()) != null)
                {
                    string[] infor = inforUser.Split('_');
                    string[] row = new string[6];
                    if (infor[6] != "Doing")
                    {
                        row[0] = infor[0].Substring(0, 5);
                        row[1] = infor[2];
                        row[2] = infor[3];
                        row[3] = infor[4];
                        row[4] = infor[5];
                        row[5] = infor[6];
                        table.Rows.Add(row);
                    }

                }
            }
            AC_dataHistoryView.ColumnHeadersHeight = 50;
            AC_dataHistoryView.Columns[0].Width = 40;
            AC_dataHistoryView.Columns[1].Width = 50;
            AC_dataHistoryView.Columns[2].Width = 150;
            AC_dataHistoryView.Columns[3].Width = 50;
            AC_dataHistoryView.Columns[4].Width = 100;
        }
        // Format store data
        //OrderId_Id_NameService_DetailService_Price_DayOrder_Status_Adress_ModePayment
        DataTable dataChart = new DataTable();
        private void Load_Statistics_Service()
        {
            AC_ChartViewService.DataSource = dataChart;
            AC_ChartViewStatus.DataSource = dataChart;
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string inforUser;
                while ((inforUser = reader.ReadLine()) != null)
                {
                    string[] infor = inforUser.Split('_');
                    dataC[infor[2]]++;
                    dataC[infor[6]]++;
                }
            }
            AC_ChartViewService.Series.Clear();
            AC_ChartViewService.Titles.Clear();
            AC_ChartViewService.Series.Add("Quantity");
            AC_ChartViewService.Series["Quantity"].Points.AddXY("Cleaning", dataC["Cleaning"]);
            AC_ChartViewService.Series["Quantity"].Points.AddXY("Cooking", dataC["Cooking"]);
            AC_ChartViewService.Series["Quantity"].Points.AddXY("Laundry", dataC["Laundry"]);
            AC_ChartViewService.Titles.Add("Number of job you ordered");

            AC_ChartViewStatus.Series.Clear(); 
            AC_ChartViewStatus.Titles.Clear();  
            AC_ChartViewStatus.Series.Add("Status");
            AC_ChartViewStatus.Series["Status"].Points.AddXY("Done", dataC["Done"]);
            AC_ChartViewStatus.Series["Status"].Points.AddXY("Doing", dataC["Doing"]);
            AC_ChartViewStatus.Series["Status"].Points.AddXY("Cancel", dataC["Cancel"]);
            AC_ChartViewStatus.Titles.Add("Status of your job");


        }

        private void btn_Click(object sender, EventArgs e)
        {
            Guna2GradientButton button = sender as Guna2GradientButton;
            if(button.Name == "A_btnAccount")
            {
                pnl_account.Visible = true;
                pnl_History.Visible = false;
                pnl_Statistics.Visible  = false;
                A_btnAccount.Checked = true;
                A_btnHistory.Checked = false;
                A_btnStatistics.Checked = false; 
            }
            else if(button.Name == "A_btnHistory")
            {
                pnl_account.Visible = false;
                pnl_History.Visible = true;
                pnl_Statistics.Visible = false;
                A_btnAccount.Checked = false;
                A_btnHistory.Checked = true;
                A_btnStatistics.Checked = false;
                Load_history();
            }
            else if(button.Name == "A_btnStatistics")
            {
                pnl_account.Visible = false;
                pnl_History.Visible = false;
                pnl_Statistics.Visible = true;
                A_btnAccount.Checked = false;
                A_btnHistory.Checked = false;
                A_btnStatistics.Checked = true;
                Load_Statistics_Service();
            }

        }
        string savePath = "";
        private void btn_Click_ChangeImage(object sender,EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            avatar.Image.Dispose();
            savePath = Constants.dataUser + "/" + USER.Split('_')[1] + "/avatar.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatar.Image = Image.FromFile(openFileDialog.FileName);
                avatar.Image.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);
            }
            else
            {
                avatar.Image = Image.FromFile(savePath);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string[] infor = USER.Split('_');
            if (tb_OldPass.Text != "")
            {
                if(tb_NewPass.Text == "")
                {
                    MessageBox.Show("Please type new password!!");
                    return;
                }
                else if(tb_OldPass.Text != infor[2])
                {
                    MessageBox.Show(infor[2]);
                    MessageBox.Show("Wrong old password !");
                    return;
                }
                else
                {
                    infor[2] = tb_NewPass.Text;
                }
            }
            string pathFile = Constants.dataUser + "/" + USER.Split('_')[1] + "/UserInfor.txt";
            if(File.Exists(pathFile))
            {
                File.Delete(pathFile);
            }
            StreamWriter sw = File.CreateText(pathFile);
            sw.WriteLine(infor[0]);
            sw.WriteLine(infor[1]);
            sw.WriteLine(infor[2]);
            sw.WriteLine(tb_Name.Text);
            sw.WriteLine(tb_Birthday.Value.ToString("yyyy-MM-dd hh:mm tt"));
            sw.WriteLine(tb_Sex.Text);
            sw.WriteLine(tb_Address.Text);
            sw.WriteLine(tb_Phone.Text);
            sw.WriteLine(tb_Gmail.Text);
            sw.Close();
            tb_OldPass.Text = "";
            tb_NewPass.Text = "";
        }
    }
}

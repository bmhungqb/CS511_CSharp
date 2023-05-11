using Guna.UI2.WinForms;
using System;
using System.CodeDom;
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
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
        public void Load_history()
        {
            table.Clear();
            table.Columns.Clear();
            table.Columns.Add("Order ID", typeof(string));
            table.Columns.Add("Service", typeof(string));
            table.Columns.Add("Detail Service", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Implementation Date", typeof(string));
            table.Columns.Add("Implementation Time", typeof(string));
            table.Columns.Add("Status", typeof(string));
            AC_dataHistoryView.DataSource = table;
            string filePath = Constants.dataUser + "/" + USER.Split('_')[1] + "/DataCart.txt";
            if (!File.Exists(filePath)) return;
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string inforUser;
                while ((inforUser = reader.ReadLine()) != null)
                {
                    string[] infor = inforUser.Split('_');
                    string[] row = new string[7];
                    if (infor[6] != "Doing")
                    {
                        row[0] = infor[0];
                        row[1] = infor[2];
                        row[2] = infor[3];
                        row[3] = infor[4];
                        row[4] = infor[5];
                        row[5] = infor[6];
                        row[6] = infor[8];
                        try
                        {
                            table.Rows.Add(row);
                        }
                        catch { }
                    }

                }
            }
            AC_dataHistoryView.ColumnHeadersHeight = 50;
            AC_dataHistoryView.Columns[0].Width = 30;
            AC_dataHistoryView.Columns[1].Width = 60;
            AC_dataHistoryView.Columns[2].Width = 70;
            AC_dataHistoryView.Columns[3].Width = 50;
            AC_dataHistoryView.Columns[4].Width = 80;
        }
        // Format store data
        public void Load_Statistics_Service()
        {
            AC_ChartViewService.Series.Clear();
            AC_ChartViewService.Titles.Clear();
            string filePath = Constants.dataUser + "/" + USER.Split('_')[1] + "/DataCart.txt";
            if (!File.Exists(filePath)) return;
            string setting = cb_settings.SelectedItem.ToString() ;
            if (setting == "Status")
            {
                Series Series_Status = new Series("Status");
                using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    string inforUser;
                    int Done = 0;
                    int Cancel = 0;
                    int Doing = 0;
                    while ((inforUser = reader.ReadLine()) != null)
                    {
                        string[] infor = inforUser.Split('_');
                        if (infor[8] == "Doing")
                        {
                            Doing++;
                        }
                        else if (infor[8] == "Done")
                        {
                            Done++;
                        }
                        else
                        {
                            Cancel++;
                        }

                    }
                    Series_Status.ChartType = SeriesChartType.Pie;
                    Series_Status.IsValueShownAsLabel = true;
                    float done = ((float)Done*100 / (Done + Doing + Cancel));
                    float doing = ((float)Doing*100 / (Doing + Cancel + Done));
                    float cancel = 100 - done - doing;
                    Series_Status.Points.AddXY("Done", done.ToString("0.00"));
                    Series_Status.Points.AddXY("Doing", doing.ToString("0.00"));
                    Series_Status.Points.AddXY("Cancel", cancel.ToString("0.00"));
                }
                AC_ChartViewService.Titles.Add("Statictis by Status");
                AC_ChartViewService.Series.Add(Series_Status);
                AC_ChartViewService.Show();
            }
            if (setting == "Services")
            {
                int max = 0;
                Series Series_Services = new Series("Services");
                if (!File.Exists(filePath)) return;
                using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    string inforUser;
                    int Cooking = 0;
                    int Laundrying = 0;
                    int Cleaning = 0;
                    while ((inforUser = reader.ReadLine()) != null)
                    {
                        string[] infor = inforUser.Split('_');
                        if (infor[2] == "Cooking")
                        {
                            Cooking++;
                        }
                        else if (infor[2] == "Cleaning")
                        {
                            Cleaning++;
                        }
                        else
                        {
                            Laundrying++;
                        }

                    }
                    int[] y = { Cooking, Cleaning, Laundrying };
                    max = y.Max();
                    Series_Services.ChartType = SeriesChartType.Column;
                    Series_Services.Palette = ChartColorPalette.EarthTones;
                    Series_Services.IsValueShownAsLabel = true;
                    Series_Services.Points.AddXY("Cooking", Cooking);
                    Series_Services.Points.AddXY("Cleaning", Cleaning);
                    Series_Services.Points.AddXY("Laundrying", Laundrying);
                }
                AC_ChartViewService.Series.Add(Series_Services);
                AC_ChartViewService.ChartAreas[0].AxisY.Maximum = max * 1.1;
                AC_ChartViewService.Titles.Add("Statictis by Services");
                AC_ChartViewService.Show();
            }
            if (setting == "Price")
            {
                Series Series_Price = new Series("Price");
                int max = 0;
                using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    string inforUser;
                    int Cooking = 0;
                    int Laundrying = 0;
                    int Cleaning = 0;
                    while ((inforUser = reader.ReadLine()) != null)
                    {
                        string[] infor = inforUser.Split('_');
                        if(infor[8] == "Doing")
                        {
                            if (infor[2] == "Cooking")
                            {
                                Cooking += int.Parse(infor[4]);
                            }
                            else if (infor[2] == "Cleaning")
                            {
                                Cleaning += int.Parse(infor[4]);
                            }
                            else
                            {
                                Laundrying += int.Parse(infor[4]);
                            }
                        }
                        int[] y = { Cooking, Cleaning, Laundrying };
                        max = y.Max();
                    }
                    Series_Price.ChartType = SeriesChartType.Column;
                    Series_Price.Palette = ChartColorPalette.EarthTones;
                    Series_Price.IsValueShownAsLabel = true;
                    Series_Price.Points.AddXY("Cooking", Cooking);
                    Series_Price.Points.AddXY("Cleaning", Cleaning);
                    Series_Price.Points.AddXY("Laundrying", Laundrying);
                }
                AC_ChartViewService.Series.Add(Series_Price);
                AC_ChartViewService.Titles.Add("Statictis by Services");
                AC_ChartViewService.ChartAreas[0].AxisY.Maximum = max * 1.1;
                AC_ChartViewService.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                AC_ChartViewService.Show();
            }
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
            savePath = Constants.dataUser + "/" + USER.Split('_')[1] + "/avatar.png";
            avatar.Image.Dispose();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatar.Image = Image.FromFile(openFileDialog.FileName);
                avatar.Image.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);
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
            string userinfor = infor[0] + "_" + infor[1] + "_" + infor[2] + "_" + tb_Name.Text + "_" + tb_Birthday.Value.ToString("yyyy-MM-dd hh:mm tt") +
                "_" + tb_Sex.Text + "_" + tb_Address.Text + "_" + tb_Phone.Text + "_" + tb_Gmail.Text+"_";
            tb_OldPass.Text = "";
            tb_NewPass.Text = "";
            var mainForm = Application.OpenForms.OfType<Form1>().Single();
            mainForm.updateInfor(userinfor);
        }
        private void guna2ComboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            Load_Statistics_Service();
        }

        private void cb_settings_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Housekeeping
{
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
            Load_history();
            Load_Statistics_Service();
            pnl_account.Visible = true;
            pnl_History.Visible = false;
            pnl_Statistics.Visible = false;
        }
        #region declare constant variable 
        private const string filePath = @"C:\Users\bmhun\Documents\TaiLieuHocTapDaiHoc\Year2\HK_II\UIT\C-Sharp\ThucHanh\21522110_ThucHanh02\Housekeeping\dataUser\DataCartHistory.txt";
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
        DataTable table = new DataTable();
        private void Load_history()
        {
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Service", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Date of order", typeof(string));
            table.Columns.Add("Status", typeof(string));
            AC_dataHistoryView.DataSource = table;

            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string inforUser;
                while ((inforUser = reader.ReadLine()) != null)
                {
                    string[] infor = inforUser.Split('_');
                    string[] row = new string[infor.Length-1];
                    for (int i = 0; i < infor.Length-1; i++)
                    {
                        row[i] = infor[i].Trim();
                    }
                    table.Rows.Add(row);
                }
            }
        }

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
                    dataC[infor[1]]++;
                    dataC[infor[4]]++;
                }
            }
            AC_ChartViewService.Series.Add("Quantity");
            AC_ChartViewService.Series["Quantity"].Points.AddXY("Cleaning", dataC["Cleaning"]);
            AC_ChartViewService.Series["Quantity"].Points.AddXY("Cooking", dataC["Cooking"]);
            AC_ChartViewService.Series["Quantity"].Points.AddXY("Laundry", dataC["Laundry"]);
            AC_ChartViewService.Titles.Add("Number of job you ordered");

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
            }
            else if(button.Name == "A_btnHistory")
            {
                pnl_account.Visible = false;
                pnl_History.Visible = true;
                pnl_Statistics.Visible = false;
            }
            else if(button.Name == "A_btnStatistics")
            {
                pnl_account.Visible = false;
                pnl_History.Visible = false;
                pnl_Statistics.Visible = true;
            }

        }
    }
}

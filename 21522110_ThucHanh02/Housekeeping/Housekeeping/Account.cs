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
        }
        #region declare constant variable 
        private const string filePath = @"C:\Users\bmhun\Documents\TaiLieuHocTapDaiHoc\Year2\HK_II\UIT\C-Sharp\ThucHanh\21522110_ThucHanh02\Housekeeping\dataUser\DataCartHistory.txt";
        #endregion
        DataTable table = new DataTable();
        private void Load_history(object sender, EventArgs e)
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
                    string[] row = new string[infor.Length];
                    for(int i = 0; i< infor.Length; i++)
                    {
                        row[i] = infor[i].Trim();
                    }
                    table.Rows.Add(row);
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Guna2GradientButton button = new Guna2GradientButton();
            if(button.Name == "A_btnAccount")
            {
                pnl_account.Visible = true;
                AC_dataHistoryView.Visible = false;
                pnl_Statistics.Visible  = false;
            }
            else if(button.Name == "A_btnHistory")
            {
                pnl_account.Visible = false;
                AC_dataHistoryView.Visible = true;
                pnl_Statistics.Visible = false;
            }
            else if(button.Name == "A_btnStatistics")
            {
                pnl_account.Visible = false;
                AC_dataHistoryView.Visible = false;
                pnl_Statistics.Visible = true;
            }

        }
    }
}

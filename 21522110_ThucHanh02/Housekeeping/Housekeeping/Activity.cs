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

namespace Housekeeping
{
    public partial class Activity : UserControl
    {
        public Activity()
        {
            InitializeComponent();
            LoadSelectOrderId();
            visualizeDataActive();
            pnl_Active.Visible = true;
            pnl_Order.Visible = false;
            btn_Active.Checked = true;
            btn_Order.Checked = false;
        }
        #region Define pathfile txt store data
        private const string filePath = @"C:\Users\bmhun\Documents\TaiLieuHocTapDaiHoc\Year2\HK_II\UIT\C-Sharp\ThucHanh\21522110_ThucHanh02\Housekeeping\dataUser\DataCart.txt";
        #endregion
        // Format store data
        //OrderId_Id_NameService_DetailService_Price_DayOrder_Status_Adress_ModePayment
        DataTable table = new DataTable();
        public void visualizeDataActive()
        {
            table.Columns.Clear();
            table.Rows.Clear();
            table.Columns.Add("Order ID", typeof(string));
            table.Columns.Add("Service", typeof(string));
            table.Columns.Add("Detail Service",typeof(string));
            //table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Date of order", typeof(string));
            table.Columns.Add("Status", typeof(string));
            dataGridActive.DataSource = table;

            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string inforUser;
                while ((inforUser = reader.ReadLine()) != null)
                {
                    string[] infor = inforUser.Split('_');
                    string[] row = new string[5];
                    if (infor[6] == "Doing")
                    {
                        row[0] = infor[0].Substring(0,5);
                        row[1] = infor[2];
                        row[2] = infor[3];
                        //row[3] = infor[4];
                        row[3] = infor[5];
                        row[4] = infor[6];
                        table.Rows.Add(row);
                    }

                }
            }
            dataGridActive.ColumnHeadersHeight = 50;
            dataGridActive.Columns[0].Width = 60;
            dataGridActive.Columns[1].Width = 80;
            dataGridActive.Columns[2].Width = 150;
            dataGridActive.Columns[3].Width = 80;
        }
        public void LoadSelectOrderId()
        {
            List<string> listID = new List<string>();
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string inforUser;
                string lastId = "";
                while ((inforUser = reader.ReadLine()) != null)
                {
                    string[] infor = inforUser.Split('_');
                    if(listID.Count == 0)
                    {
                        listID.Add(infor[0]);
                        lastId = infor[0];
                    }
                    else if (lastId != infor[0])
                    {
                        listID.Add(infor[0]);
                        lastId = infor[0];
                    }

                }
            }
            comboBoxID.Items.Clear();
            for(int i =0;i< listID.Count;i++)
            {
                comboBoxID.Items.Add(listID[i]);
            }
        }
        DataTable tableOrder = new DataTable();
        public void visualizeOrders(string id)
        {
            tableOrder.Columns.Clear();
            tableOrder.Rows.Clear();    
            tableOrder.Columns.Add("ID", typeof(string));
            tableOrder.Columns.Add("Service", typeof(string));
            tableOrder.Columns.Add("Detail Service", typeof(string));
            tableOrder.Columns.Add("Price", typeof(string));
            tableOrder.Columns.Add("Date of order", typeof(string));
            tableOrder.Columns.Add("Status", typeof(string));
            dataGridOrder.DataSource = tableOrder;

            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string inforOrder;
                while ((inforOrder = reader.ReadLine()) != null)
                {
                    string[] infor = inforOrder.Split('_');
                    string[] row = new string[6];
                    if (id == infor[0])
                    {
                        row[0] = infor[1];
                        row[1] = infor[2];
                        row[2] = infor[3];
                        row[3] = infor[4];
                        row[4] = infor[5];
                        row[5] = infor[6];
                        tableOrder.Rows.Add(row);
                    }
                }
            }
            dataGridOrder.ColumnHeadersHeight = 50;
            dataGridOrder.Columns[0].Width = 30;
            dataGridOrder.Columns[1].Width = 80;
            dataGridOrder.Columns[2].Width = 150;
            dataGridOrder.Columns[3].Width = 50;
            dataGridOrder.Columns[4].Width = 80;
            //dataGridOrder.Columns[3].Width = 20;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = sender as Guna2GradientButton;
            if(btn.Name == "btn_Active")
            {
                visualizeDataActive();
                pnl_Active.Visible = true;
                pnl_Order.Visible = false;
                btn_Active.Checked = true;
                btn_Order.Checked = false;
            }
            else
            {
                LoadSelectOrderId();
                pnl_Active.Visible = false;
                pnl_Order.Visible = true;
                btn_Active.Checked = false;
                btn_Order.Checked = true;
            }
        }

        private void comboBoxID_SelectedValueChanged(object sender, EventArgs e)
        {
            Guna2ComboBox cb = sender as Guna2ComboBox;
            visualizeOrders(cb.SelectedItem.ToString());
        }
    }
}

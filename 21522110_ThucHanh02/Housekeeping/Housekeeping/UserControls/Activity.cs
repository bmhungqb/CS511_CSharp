using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Housekeeping
{
    public partial class Activity : UserControl
    {
        public Activity()
        {
            InitializeComponent();
            pnl_Active.Visible = true;
            pnl_Order.Visible = false;
            btn_Active.Checked = true;
            btn_Order.Checked = false;
        }
        string userInfor = "";
        public void GetInforUserFromParent(string user)
        {
            userInfor = user;
            updateActivity();
        }
        public void updateActivity()
        {
            LoadSelectOrderId();
            visualizeDataActive();
        }
        // Format store data
        //OrderId_Id_NameService_DetailService_Price_DayOrder_Status_Adress_ModePayment
        DataTable table = new DataTable();
        public void visualizeDataActive()
        {
            table.Clear();
            table.Columns.Clear();
            table.Columns.Add("Order ID", typeof(string));
            table.Columns.Add("Service", typeof(string));
            table.Columns.Add("Detail Service",typeof(string));
            //table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Implementation date", typeof(string));
            table.Columns.Add("Implementation time", typeof(string));
            dataGridActive.DataSource = table;
            string filePath = Constants.dataUser + "/" + userInfor.Split('_')[1]+"/DataCart.txt";
            if (!File.Exists(filePath)) return;
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string inforCart;
                while ((inforCart = reader.ReadLine()) != null)
                {
                    string[] infor = inforCart.Split('_');
                    string[] row = new string[5];
                    if (infor[8] == "Doing")
                    {
                        row[0] = infor[0]+"_"+infor[1];
                        row[1] = infor[2];
                        row[2] = infor[3];
                        row[3] = infor[5];
                        row[4] = infor[6];
                        table.Rows.Add(row);
                    }

                }
                reader.Close();
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
            string filePath = Constants.dataUser + "/" + userInfor.Split('_')[1] + "/DataCart.txt";
            if (!File.Exists(filePath)) return;
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
                reader.Close();
            }
            comboBoxID.Items.Clear();
            for(int i =0;i< listID.Count;i++)
            {
                comboBoxID.Items.Add(listID[i]);
            }
            if(listID.Count >0)
            {
                visualizeOrders(listID[0]);
                comboBoxID.SelectedItem = listID[0];
            }
        }
        DataTable tableOrder = new DataTable();
        public void visualizeOrders(string id)
        {
            tableOrder.Clear();    
            tableOrder.Columns.Clear();
            tableOrder.Columns.Add("ID", typeof(string));
            tableOrder.Columns.Add("Service", typeof(string));
            tableOrder.Columns.Add("Detail Service", typeof(string));
            tableOrder.Columns.Add("Price", typeof(string));
            tableOrder.Columns.Add("Implementation Date", typeof(string));
            tableOrder.Columns.Add("Implementation Time", typeof(string));
            tableOrder.Columns.Add("Status", typeof(string));
            dataGridOrder.DataSource = tableOrder;
            string filePath = Constants.dataUser + "/" + userInfor.Split('_')[1] + "/DataCart.txt";
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string inforOrder;
                while ((inforOrder = reader.ReadLine()) != null)
                {
                    string[] infor = inforOrder.Split('_');
                    string[] row = new string[7];
                    if (id == infor[0])
                    {
                        row[0] = infor[1];
                        row[1] = infor[2];
                        row[2] = infor[3];
                        row[3] = infor[4];
                        row[4] = infor[5];
                        row[5] = infor[6];
                        row[6] = infor[8];
                        tableOrder.Rows.Add(row);
                    }
                }
                reader.Close();
            }
            dataGridOrder.ColumnHeadersHeight = 50;
            dataGridOrder.Columns[0].Width = 30;
            dataGridOrder.Columns[1].Width = 80;
            dataGridOrder.Columns[2].Width = 50;
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult res =  MessageBox.Show("Are you sure ?", "Remove services", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(res == DialogResult.OK)
            {
                if (dataGridActive.SelectedRows.Count == 0) return;
                string filePathData = Constants.dataUser + "/" + userInfor.Split('_')[1] + "/DataCart.txt";
                if (!File.Exists(filePathData)) return;
                string[] lines = File.ReadAllLines(filePathData);
                foreach (DataGridViewRow row in dataGridActive.SelectedRows)
                {
                    int lineNumber = Array.FindIndex(lines, line => line.Contains(row.Cells[0].Value.ToString()));
                    if(lineNumber >= 0)
                    {
                        lines[lineNumber] = lines[lineNumber].Replace("Doing", "Cancel");
                        dataGridActive.Rows.RemoveAt(row.Index);
                        File.WriteAllLines(filePathData, lines);
                    }
                            
                }
            }
        }
    }
}

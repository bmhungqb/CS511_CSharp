using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Housekeeping
{
     public partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
        }
        #region Define Path file
        private const string filePathData = @"C:\Users\bmhun\Documents\TaiLieuHocTapDaiHoc\Year2\HK_II\UIT\C-Sharp\ThucHanh\21522110_ThucHanh02\Housekeeping\dataUser\DataCart.txt";
        #endregion
        #region
        #endregion
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        //When click button Confirm => Save data into file DataCart.txt with format below:
        // OrderId_Id_NameService_DetailService_Price_DayOrder_Status_Adress_ModePayment
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if(check_NewAddress.Checked && txt_NewAddress.Text=="")
            {
                MessageBox.Show("Please Fill Your Address", "Empty Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Random rdn = new Random();
                DateTime dateTime = DateTime.UtcNow.Date;
                using (StreamWriter writer = new StreamWriter(filePathData, true))
                {
                    string address;
                    string modePayment;
                    string OrderId = "#"+rdn.Next().ToString();
                    if(check_NewAddress.Checked)
                    {
                        address = txt_NewAddress.Text;
                    }
                    else
                    {
                        address = txt_CurrentAddress.Text;
                    }
                    if(check_cash.Checked)
                    {
                        modePayment = "Cash";
                    }
                    else
                    {
                        modePayment = "Smart Banking";
                    }
                    foreach (DataRow service in datatableCart.Rows)
                    {
                        string inforOrder;
                        inforOrder =  OrderId+ "_"
                            + service["ID"].ToString() + "_" + service["Service"].ToString() + "_"
                            + service["Service Detail"].ToString() + "_" + service["Price"].ToString() + "_"
                            + date_do.Value.ToString("dd/MM/yyyy") + "_" + "Doing" +"_"+ address + "_" +modePayment;
                        writer.WriteLine(inforOrder);
                    }
                    writer.Close();
                    //After confirm the order => Clear box checked of service
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        DataTable datatableCart = new DataTable();
        public void VisualizeData(List<string> elChecked, Dictionary<string, string> dataPrice, Dictionary<string, string> dataPropertyService,string address)
        {
            datatableCart.Clear();
            datatableCart.Columns.Clear();
            datatableCart.Columns.Add("ID", typeof(string));
            datatableCart.Columns.Add("Service", typeof(string));
            datatableCart.Columns.Add("Service Detail", typeof(string));
            datatableCart.Columns.Add("Price", typeof(string));
            txt_CurrentAddress.Text = address;
            dataTable.DataSource = datatableCart;
           for(int i=0;i<elChecked.Count;i++)
            {
                string[] row = new string[4];
                row[0] = i.ToString();
                string c = elChecked[i].Substring(0,1);
                if (c == "c")
                {
                    if (elChecked[i].Substring(0,2) == "cl")
                    {
                        row[1] = "Cleaning";
                    }
                    else
                    {
                        row[1] = "Cooking";
                    }
                }
                else if(c=="l")
                {
                    row[1] = "Laundry";
                }
                row[2] = dataPropertyService[elChecked[i]];
                row[3] = dataPrice[elChecked[i]];   
                datatableCart.Rows.Add(row);
            }
        }
        private void btn_Check_Address(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = sender as Guna2CheckBox;
            if (checkBox.Name == "check_NewAddress")
            {
                check_CurrentAddress.Checked = false;
                check_NewAddress.Checked = true;
            }
            else
            {
                check_CurrentAddress.Checked = true;
                check_NewAddress.Checked = false;
            }
        }
        private void btn_Check_Payment(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox1 = sender as Guna2CheckBox;
            if (checkBox1.Name == "check_cash")
            {
                check_banking.Checked = false;
                check_cash.Checked = true;
            }
            else
            {
                check_banking.Checked = true;
                check_cash.Checked = false;
            }
        }

        private void btn_removeItem_Click(object sender, EventArgs e)
        {
            if (dataTable.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataTable.SelectedRows)
                {
                    dataTable.Rows.RemoveAt(row.Index);
                }
            }

        }
    }
}
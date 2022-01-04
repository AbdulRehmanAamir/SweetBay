using Sweet_Bay_Point_Of_Sale.Screens.SalesOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sweet_Bay_Point_Of_Sale.General;

namespace Sweet_Bay_Point_Of_Sale.Screens
{
    public partial class NewSalesOrderForm : MetroFramework.Forms.MetroForm
    {
        public NewSalesOrderForm()
        {
            InitializeComponent();
        }


        private void NewSalesOrderForm_Load(object sender, EventArgs e)
        {
            LoadSalesRecord();
            DateTime today = DateTime.Today;
            textBoxdate.Text = today.ToString();


        }
        public decimal quantity;
        public decimal discount;
        public decimal itemTotal = 0.00M;

        private void LoadSalesRecord()
        {

            dataGridViewSalesOrderForm.DataSource = GetData();

        }
        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select * FROM SalesRecords", con))
                {
                    SqlDataReader sdr = cmd.ExecuteReader();


                    dt.Load(sdr);
                    con.Close();
                }
                return dt;
            }
        }


        private void EXIT_Click(object sender, EventArgs e)
        {
            DashboardForm goToDashboard = new DashboardForm();
            this.Hide();
            goToDashboard.Show();

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {      
            NewOrders sale = new NewOrders();
            sale.invoic_Date = Int32.Parse(textBoxdate.Text);
            sale.customer_ID = Int32.Parse(textBoxcustomerID.Text);
            sale.product_Name = textBoxproductname.Text;
            sale.price = decimal.Parse(textBoxPrice.Text);
            sale.quantity = decimal.Parse(textBoxquantity.Text);
            sale.discount = decimal.Parse(textBoxdiscount.Text);          
            sale.itemTotal = decimal.Parse(textBoxPrice.Text) * sale.quantity;

            decimal discountPrice = (sale.itemTotal / 100) * sale.discount;
            sale.itemTotal = sale.itemTotal - discountPrice;
            sale.saveItemsToDb();
           

            textBoxcustomerID.Clear();
            textBoxdate.Clear();
            textBoxPrice.Clear();
            textBoxproductname.Clear();
            textBoxquantity.Clear();
            textBoxdiscount.Clear();
            this.LoadSalesRecord();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            BillReceipt bill = new BillReceipt();
            this.Hide();
            bill.Show();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            NewOrders orders = new NewOrders();
            orders.deletedata();
            this.LoadSalesRecord();
        }

        class NewOrders
        {
            public int invoic_Date;
            public int customer_ID;
            public string product_Name;
            public decimal price;
            public decimal quantity;
            public decimal discount;
            public decimal itemTotal = 0.00M;

            private bool IsValid()
            {
                if (invoic_Date == 0 || customer_ID == 0 || product_Name == "" || price == 0 || quantity == 0 || discount == 0 || itemTotal == 0)
                {
                    MessageBox.Show("All Fields Are Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
                return true;
            }

            public void saveItemsToDb()
            {              
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SalesRecords values('" + invoic_Date + "','" + customer_ID + "','" + product_Name + "','" + price + "','" + quantity + "','" + discount + "','" + itemTotal + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been saved in Data Base", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                }

            }
            public void deletedata()
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Delete FROM SalesRecords", con))
                    {
                        SqlDataReader sdr = cmd.ExecuteReader();
                        MessageBox.Show("Data has been Deleted From Data Base", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }
                }
            }
        }
        
    }
}

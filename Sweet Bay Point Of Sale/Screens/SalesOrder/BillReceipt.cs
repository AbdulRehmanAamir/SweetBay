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
namespace Sweet_Bay_Point_Of_Sale.Screens.SalesOrder
{
    public partial class BillReceipt : MetroFramework.Forms.MetroForm
    {
        public BillReceipt()
        {
            InitializeComponent();
        }

        private void BillReceipt_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM SalesRecords", con))
                {

                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                    billgrid.DataSource = dt;
                    cmd.Dispose();
                    con.Close();

                }
            }
            GetTotalBill();
        }

        private void GetTotalBill()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT SUM (itemTotal) FROM SalesRecords", con))
                {

                    textBox2.Text = cmd.ExecuteScalar().ToString();

                    cmd.Dispose();
                    con.Close();
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void billbtn_Click(object sender, EventArgs e)
        {
            totalvalue t1 = new totalvalue();

            t1.paidam = Int32.Parse(textBoxpaidamount.Text);
            decimal totals = Decimal.Parse(textBox2.Text);
            t1.total = totals;
            textBoxReturnamount.Text = t1.GetReturnAmnt().ToString();
        }
        private void EXIT_Click(object sender, EventArgs e)
        {
            loginform goToLogin = new loginform();
            this.Hide();
            goToLogin.Show();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            NewSalesOrderForm gotosales = new NewSalesOrderForm();
            this.Hide();
            gotosales.Show();
        }

        class totalvalue
        {
            public decimal returnAm;
            public decimal paidam;
            public decimal total;

            public decimal GetReturnAmnt()
            {
                if (paidam > total)
                {
                    returnAm = paidam - total;
                    return returnAm;
                }
                else
                {
                    MessageBox.Show("Invalid Value", "ValidationError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }

            }
        }

        private void textBoxtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void billgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxpaidamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

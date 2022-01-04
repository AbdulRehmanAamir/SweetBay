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

namespace Sweet_Bay_Point_Of_Sale.Screens.CustomerF
{
    public partial class NewCustomerForm : MetroFramework.Forms.MetroForm
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }
        private void NewCustomerForm_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void LoadAllData()
        {
            dataGridViewcustomer.DataSource = GetData();
            dataGridViewcustomer.Columns[0].Visible = false;
            dataGridViewcustomer.Columns[1].Width = 230;
            dataGridViewcustomer.Columns[2].Width = 220;
            dataGridViewcustomer.Columns[3].Width = 230;
        }
        private DataTable GetData()
        {
            DataTable dtdata = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select* FROM Customers", con))
                {

                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtdata.Load(sdr);
                    con.Close();

                }


            }
            return dtdata;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DashboardForm goToDashboard = new DashboardForm();
            this.Close();
            goToDashboard.Show();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            customer c1 = new customer();
            c1.customerName = textBoxcustomerName.Text;
            c1.customerMobile = Int64.Parse(textBoxCustomerMobile.Text);
            c1.customerAdress = textBoxadress.Text;
            c1.NewDataEntries();
            this.LoadAllData();
            textBoxcustomerName.Clear();
            textBoxCustomerMobile.Clear();
            textBoxadress.Clear();
            textBoxcustomersearch.Clear();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            customer c2 = new customer();
            c2.deleteCustomer = textBoxcustomersearch.Text;
            c2.DeleteData();
            this.LoadAllData();
        }
        private void textBoxcustomersearch_TextChanged(object sender, EventArgs e)
        {
            customer c3 = new customer();
            c3.searchCustomer = textBoxcustomersearch.Text;
            dataGridViewcustomer.DataSource = c3.findcustomer();
        }


        class customer
        {
            public string customerName;
            public Int64 customerMobile;
            public string customerAdress;
            public string searchCustomer;
            public string deleteCustomer;

            private bool IsValid()
            {
                if (customerName == "" || customerMobile == 0 || customerAdress == "")
                {
                    MessageBox.Show("All Field Are Required", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;

                }
                return true;
            }

            public void NewDataEntries()
            {

                if (IsValid())
                {


                    using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Customers values('" + customerName + "','" + customerMobile + "','" + customerAdress + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been saved in Data Base", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();

                    }
                }

            }

            public DataTable DeleteData()
            {

                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Delete FROM Customers WHERE Name Like + '%' + @Name + '%'", con))
                    {
                        cmd.Parameters.AddWithValue("@Name", deleteCustomer);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        MessageBox.Show("Data has been Deleted From Data Base", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }

                }
                return dt;
            }
            public DataTable findcustomer()
            {
                DataTable dtdata = new DataTable();
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Select* FROM Customers WHERE Name Like + '%'+ @Name + '%'", con))
                    {
                        cmd.Parameters.AddWithValue("@Name", searchCustomer);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dtdata.Load(sdr);
                        con.Close();

                    }

                }
                return dtdata;


            }

        }


    }
}


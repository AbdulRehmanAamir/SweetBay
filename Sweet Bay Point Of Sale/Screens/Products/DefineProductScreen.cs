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
namespace Sweet_Bay_Point_Of_Sale.Screens.Products
{
    public partial class DefineProductScreen : MetroFramework.Forms.MetroForm
    {
        public DefineProductScreen()
        {
            InitializeComponent();

        }
        private void DefineProductScreen_Load(object sender, EventArgs e)
        {
            LoadAllProductsData();
        }

        private void LoadAllProductsData()
        {
            textBoxproductsearch.Focus();
            dataGridViewrecord.DataSource = GetData();
            dataGridViewrecord.Columns[0].Visible = false;
            dataGridViewrecord.Columns[1].Width = 230;
            dataGridViewrecord.Columns[2].Width = 220;
            dataGridViewrecord.Columns[3].Width = 230;
        }
        private DataTable GetData()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select * FROM Products", con))
                {
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                }
                return dt;
            }

        }
        private void cancelbtn_Click(object sender, EventArgs e)
        {
           DashboardForm goToDashboard = new DashboardForm();
            this.Hide();
            goToDashboard.Show();
        }

       

        private void Save_Click(object sender, EventArgs e)
        {
            Product p1 = new Product();
            p1.productName = textBoxproductname.Text;
            p1.purchasePrice = Int32.Parse(textBoxprice.Text);
            p1.salePrice = Int32.Parse(textBoxsaleprice.Text);
            p1.uploadToDB();
            textBoxproductname.Clear();
            textBoxprice.Clear();
            textBoxsaleprice.Clear();
            textBoxproductsearch.Clear(); 
            this.LoadAllProductsData();
        }
        private void buttondeleteitem_Click(object sender, EventArgs e)
        {
            Product p1 = new Product();
            p1.itemToDelete = textBoxproductsearch.Text;
            p1.DeleteEntries();
            this.LoadAllProductsData();
        }

        private void textBoxproductsearch_TextChanged(object sender, EventArgs e)
        {
           
            Product ob = new Product();
            ob.itemToSearch = textBoxproductsearch.Text;
            dataGridViewrecord.DataSource = ob.searchproducts();
           

            }          
        }
       
    }

class Product
{
    public string productName;
    public int purchasePrice;
    public int salePrice;
    public string itemToDelete;
    public string itemToSearch;

    private bool IsValid()
    {
        if (productName == string.Empty || purchasePrice == 0 || salePrice == 0)
        {
            MessageBox.Show("All Fields Are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }


    public void uploadToDB()
    {
        if (IsValid())
        {
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Products values('" + productName + "','" + purchasePrice + "','" + salePrice + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product has been saved in Data Base", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

            }
        }
    }

    public void DeleteEntries()
    {
        DataTable dt = new DataTable();
        using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand("Delete FROM Products WHERE Name Like + '%' + @Name+'%'", con))
            {
                cmd.Parameters.AddWithValue("@Name", itemToDelete);
                SqlDataReader sdr = cmd.ExecuteReader();
                MessageBox.Show("Product has been Deleted From Data Base", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

            }

        }
    }
    public DataTable searchproducts()
    {

        DataTable dttable = new DataTable();
        using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand("Select * FROM Products WHERE Name Like +'%' + @Name +'%'", con))
            {
                cmd.Parameters.AddWithValue("@Name", itemToSearch);
                SqlDataReader sdr = cmd.ExecuteReader();
                dttable.Load(sdr);
                con.Close();

            }
            return dttable;

        }


    }
}


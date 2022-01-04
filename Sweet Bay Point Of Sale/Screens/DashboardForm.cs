using Sweet_Bay_Point_Of_Sale.Screens.CustomerF;
using Sweet_Bay_Point_Of_Sale.Screens.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sweet_Bay_Point_Of_Sale.Screens
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void productbutton_Click(object sender, EventArgs e)
        {
            DefineProductScreen obj = new DefineProductScreen();
            DashboardClass dash = new DashboardClass();
            dash.DashboardCall(sender, e, obj);
            this.Hide();
        }

        private void Closse_Click(object sender, EventArgs e)
        {
            loginform obj = new loginform();
            DashboardClass dash = new DashboardClass();
            dash.DashboardCall(sender, e, obj);
            this.Hide();
        }

        private void Customermanage_Click(object sender, EventArgs e)
        {
            NewCustomerForm obj = new NewCustomerForm();
            DashboardClass dash = new DashboardClass();
            dash.DashboardCall(sender, e, obj);
            this.Hide();
        }


        private void sales_Click(object sender, EventArgs e)
        {
            NewSalesOrderForm obj = new NewSalesOrderForm();
            DashboardClass dash = new DashboardClass();
            dash.DashboardCall(sender, e, obj);
            this.Hide();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }

    class DashboardClass
    {
        public void DashboardCall(object sender, EventArgs e, DefineProductScreen formName)
        {
            DashboardForm d1 = new DashboardForm();
            formName.Show();
        }

        public void DashboardCall(object sender, EventArgs e, loginform formName)
        {
            DashboardForm d1 = new DashboardForm();
            formName.Show();
        }

        public void DashboardCall(object sender, EventArgs e, NewCustomerForm formName)
        {
            DashboardForm d1 = new DashboardForm();
            formName.Show();
        }
   
        public void DashboardCall(object sender, EventArgs e, NewSalesOrderForm formName)
        {
            DashboardForm d1 = new DashboardForm();
            formName.Show();
        }
    }
}

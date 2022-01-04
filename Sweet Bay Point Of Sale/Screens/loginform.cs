using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Sweet_Bay_Point_Of_Sale.Screens;
using Sweet_Bay_Point_Of_Sale.General;
using MetroFramework.Forms;

namespace Sweet_Bay_Point_Of_Sale
{   
    //Student Name: AbdulRehmanAmir (10613),Waheb Ali(10612)
    //Project: POINT OF SALE
    public partial class loginform : MetroFramework.Forms.MetroForm
    {
        public loginform()
        {
            InitializeComponent();
        }

   
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.username = textBox1.Text;
            L.password = textBox2.Text;
            bool response = L.LoginFunction();

            if (response)
            {
                DashboardForm goToDash = new DashboardForm();
                this.Hide();
                goToDash.Show();
            }

        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


     
    }

    class Login
    {
        public string username;
        public string password;

        public bool LoginFunction()
        {
            if (IsValid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Login_VerifyLoginDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username.Trim());
                        cmd.Parameters.AddWithValue("@Password", password.Trim());
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Username or password is incorrect", "loginFailed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
                    return false;
        }

        private bool IsValid()
        {
            if (username.Trim() == string.Empty)
            {
                MessageBox.Show("Username is required", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (password.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


    }

}


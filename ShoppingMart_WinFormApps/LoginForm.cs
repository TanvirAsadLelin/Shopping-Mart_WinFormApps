using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ShoppingMart_WinFormApps
{
    public partial class LoginForm : Form
    {
        public static string username = "";
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string querySelect = "select * from Login_Tbl where Login_Username = @userName and Login_Password = @password ";
            SqlCommand cmd = new SqlCommand(querySelect, con);

            cmd.Parameters.AddWithValue("@userName", textBoxUsername.Text);
            cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);

            con.Open();
            SqlDataReader dr  =  cmd.ExecuteReader();
            if(dr.HasRows == true)
            {
             
                MessageBox.Show("Login Successful","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                username = textBoxUsername.Text;
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
            }

            else
            {
                MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            
            bool check  =  checkBoxShowPass.Checked;

            switch (check)
            {
                case true:
                    textBoxPassword.UseSystemPasswordChar = false;
                    break;
                default:
                    textBoxPassword.UseSystemPasswordChar = true;
                    break;

            }
            
            
        }
    }
}

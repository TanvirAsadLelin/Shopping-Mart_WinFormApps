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
    public partial class AddItemForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void btnInsertItem_Click(object sender, EventArgs e)
        {
            SqlConnection con =  new SqlConnection(cs);
            string queryInsert = "insert into Items_Tbl values (@name,@price,@discount)";
            SqlCommand cmd  =  new SqlCommand(queryInsert, con);
            cmd.Parameters.AddWithValue("@name", textBoxAddName.Text);
            cmd.Parameters.AddWithValue("@price", textBoxAddPrice.Text);
            cmd.Parameters.AddWithValue("@discount", textBoxAddDiscount.Text);

            con.Open();
            int value =  cmd.ExecuteNonQuery();
            if (value > 0)
            {
                MessageBox.Show("Inserted successfuly", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxAddName.Clear();
                textBoxAddPrice.Clear();
                textBoxAddDiscount.Clear();
                textBoxAddName.Focus();
            }

            else
            {
                MessageBox.Show("Insertion failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }
}

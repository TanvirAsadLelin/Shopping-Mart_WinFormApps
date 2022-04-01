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
    public partial class EditItemForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public EditItemForm()
        {
            InitializeComponent();
            BindGridview();
        }

        void BindGridview()
        {    
            SqlConnection con =  new SqlConnection(cs);
            string querySelect = "select * from Items_Tbl";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelect,con);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dataGridViewForEdit.DataSource = dataTable;

        }

        private void dataGridViewForEdit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxId.Text = dataGridViewForEdit.SelectedRows[0].Cells[0].Value.ToString();
            textBoxEditName.Text = dataGridViewForEdit.SelectedRows[0].Cells[1].Value.ToString();
            textBoxEditPrice.Text = dataGridViewForEdit.SelectedRows[0].Cells[2].Value.ToString();
            textBoxEditDiscount.Text = dataGridViewForEdit.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string queryInsert = "update Items_Tbl set Item_Name=@name,Item_Price=@price,Item_Discount=@discount where Item_Id=@id";
            SqlCommand cmd = new SqlCommand(queryInsert, con);
            cmd.Parameters.AddWithValue("@id", textBoxId.Text);
            cmd.Parameters.AddWithValue("@name", textBoxEditName.Text);
            cmd.Parameters.AddWithValue("@price", textBoxEditPrice.Text);
            cmd.Parameters.AddWithValue("@discount", textBoxEditDiscount.Text);

            con.Open();
            int value = cmd.ExecuteNonQuery();
            if (value > 0)
            {
                MessageBox.Show("Updated successfuly", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridview();
                textBoxId.Clear();
                textBoxEditName.Clear();
                textBoxEditPrice.Clear();
                textBoxEditDiscount.Clear();
                textBoxEditName.Focus();
            }

            else
            {
                MessageBox.Show("Updation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string queryInsert = "delete from Items_Tbl where Item_Id=@id";
            SqlCommand cmd = new SqlCommand(queryInsert, con);
            cmd.Parameters.AddWithValue("@id", textBoxId.Text);

            con.Open();
            int value = cmd.ExecuteNonQuery();
            if (value > 0)
            {
                MessageBox.Show("Updated successfuly", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridview();
                textBoxId.Clear();
                textBoxEditName.Clear();
                textBoxEditPrice.Clear();
                textBoxEditDiscount.Clear();
                textBoxEditName.Focus();
            }

            else
            {
                MessageBox.Show("Updation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }
}

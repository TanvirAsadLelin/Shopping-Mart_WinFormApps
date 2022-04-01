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
    public partial class ViewDataForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public ViewDataForm()
        {
            InitializeComponent();
            BindGridview();
        }

        void BindGridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string querySelect = "select * from Items_Tbl";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelect, con);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dataGridViewForViewData.DataSource = dataTable;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditItemForm editItemForm = new EditItemForm();
            editItemForm.ShowDialog();  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EditItemForm editItemForm = new EditItemForm();
            editItemForm.ShowDialog();
        }

        private void ViewDataForm_Activated(object sender, EventArgs e)
        {
            BindGridview();
        }
    }
}

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
    public partial class DetailsSearchForm : Form
    {   
        string cs  = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public DetailsSearchForm()
        {
            InitializeComponent();
            BindGridviewBothData();
        }

        void BindGridviewBothData()
        {
            SqlConnection con =  new SqlConnection(cs);
            string queryStoreProcedure = "getBothTablesData_Sp";
            SqlCommand cmd = new SqlCommand(queryStoreProcedure, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewBothTableDataShow.DataSource = table;
            dataGridViewBothTableDataShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
    }
}

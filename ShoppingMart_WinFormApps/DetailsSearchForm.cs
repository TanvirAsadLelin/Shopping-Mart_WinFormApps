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
        }

        void BindGridviewBothData()
        {

        }
    }
}

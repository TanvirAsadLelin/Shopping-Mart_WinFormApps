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
    public partial class Form1 : Form
    {

        int tax = 0;

        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            GetItem();
        }

        void GetItem()
        {
            SqlConnection con = new SqlConnection(cs);
            string querySelect = "select * from Items_Tbl";
            SqlCommand cmd = new SqlCommand(querySelect, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string itemName = dr.GetString(1);
                comboBoxSelectItem.Items.Add(itemName);
            }

            con.Close();
        }

        void GetPrice()
        {
            int price = 0;
            SqlConnection con = new SqlConnection(cs);
            string queryGetPrice = "select Item_Price from Items_Tbl where Item_Name = @itemName";
            SqlDataAdapter sda = new SqlDataAdapter(queryGetPrice, con);
            sda.SelectCommand.Parameters.AddWithValue("@itemName", comboBoxSelectItem.SelectedItem.ToString());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            if(dataTable.Rows.Count > 0)
            {
               price = Convert.ToInt32(dataTable.Rows[0]["Item_Price"]);
            }

            textBoxUnitPrice.Text = price.ToString();

        }

        void GetDiscount()
        {
            int discount = 0;
            SqlConnection con = new SqlConnection(cs);
            string queryGetPrice = "select Item_Discount from Items_Tbl where Item_Name = @itemName";
            SqlDataAdapter sda = new SqlDataAdapter(queryGetPrice, con);
            sda.SelectCommand.Parameters.AddWithValue("@itemName", comboBoxSelectItem.SelectedItem.ToString());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                discount = Convert.ToInt32(dataTable.Rows[0]["Item_Discount"]);
            }

            textBoxDiscountPerItem.Text = discount.ToString();

        }

        private void comboBoxSelectItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPrice();
            GetDiscount();
            textBoxQuantity.Enabled = true;
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBoxUnitPrice.Text);
            int discount = Convert.ToInt32(textBoxDiscountPerItem.Text);
            int quantity = Convert.ToInt32(textBoxQuantity.Text);

            int subTotal = price * quantity;
            subTotal = subTotal - discount * quantity;

            textBoxSubTotal.Text = subTotal.ToString();

        }

        private void textBoxSubTotal_TextChanged(object sender, EventArgs e)
        {
            int subTotal = Convert.ToInt32(textBoxSubTotal.Text);

            if (subTotal >= 2000)
            {
                tax = (int)(subTotal * 0.05);

                textBoxTax.Text = tax.ToString();
            }
            else if (subTotal >= 5000)
            {
                tax = (int)(subTotal * 0.10);

                textBoxTax.Text = tax.ToString();
            }
            else if (subTotal >= 10000)
            {
                tax = (int)(subTotal * 0.20);

                textBoxTax.Text = tax.ToString();
            }
            else
            {
                tax = (int)(subTotal * 0.03);

                textBoxTax.Text = tax.ToString();
            }



        }

        private void textBoxTax_TextChanged(object sender, EventArgs e)
        {
            int subTotal = Convert.ToInt32(textBoxSubTotal.Text);
            int tax = Convert.ToInt32(textBoxTax.Text);

            int totalCost = subTotal + tax;

            textBoxTotalCost.Text = totalCost.ToString();
        }
    }
}

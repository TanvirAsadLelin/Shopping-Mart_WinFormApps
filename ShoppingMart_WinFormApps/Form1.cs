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

        int finalCost = 0;
        int srNo = 0;
        int tax = 0;

        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            GetInvoiceID();
            textBoxUser.Text = LoginForm.username;
            GetItem();
            GridViewColumnAdd();
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
            if (comboBoxSelectItem.SelectedItem == null)
            {

            }
            else
            {

                int price = 0;
                SqlConnection con = new SqlConnection(cs);
                string queryGetPrice = "select Item_Price from Items_Tbl where Item_Name = @itemName";
                SqlDataAdapter sda = new SqlDataAdapter(queryGetPrice, con);
                sda.SelectCommand.Parameters.AddWithValue("@itemName", comboBoxSelectItem.SelectedItem.ToString());
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    price = Convert.ToInt32(dataTable.Rows[0]["Item_Price"]);
                }

                textBoxUnitPrice.Text = price.ToString();
            }

        }

        void GetDiscount()
        {
            if (comboBoxSelectItem.SelectedItem == null)
            {

            }
            else
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

        }

        private void comboBoxSelectItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPrice();
            GetDiscount();
            textBoxQuantity.Enabled = true;
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxQuantity.Text) == true)
            {

            }
            else
            {

                int price = Convert.ToInt32(textBoxUnitPrice.Text);
                int discount = Convert.ToInt32(textBoxDiscountPerItem.Text);
                int quantity = Convert.ToInt32(textBoxQuantity.Text);

                int subTotal = price * quantity;
                subTotal = subTotal - discount * quantity;

                textBoxSubTotal.Text = subTotal.ToString();
            }

        }

        private void textBoxSubTotal_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSubTotal.Text) == true)
            {

            }
            else
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

        }

        private void textBoxTax_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTax.Text) == true)
            {

            }
            else
            {
                int subTotal = Convert.ToInt32(textBoxSubTotal.Text);
                int tax = Convert.ToInt32(textBoxTax.Text);

                int totalCost = subTotal + tax;

                textBoxTotalCost.Text = totalCost.ToString();
            }
        }

        void GridViewColumnAdd()
        {
            dataGridViewItemAdd.ColumnCount = 8;
            dataGridViewItemAdd.Columns[0].Name = "SR NO.";
            dataGridViewItemAdd.Columns[1].Name = "Item Name";
            dataGridViewItemAdd.Columns[2].Name = "Unit Price";
            dataGridViewItemAdd.Columns[3].Name = "Discount";
            dataGridViewItemAdd.Columns[4].Name = "Quantity";
            dataGridViewItemAdd.Columns[5].Name = "Sub Total";
            dataGridViewItemAdd.Columns[6].Name = "Tax";
            dataGridViewItemAdd.Columns[7].Name = "Total Cost";
        }

        void AddDataToGridview(string sr_no , string itemName, string unitPrice, string discount,string quantity, string subTotal, string tax, string totalCost)
        {
            string[] row = {sr_no,itemName,unitPrice,discount,quantity,subTotal,tax, totalCost };

            dataGridViewItemAdd.Rows.Add(row);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDataToGridview((++srNo).ToString(), comboBoxSelectItem.SelectedItem.ToString(), textBoxUnitPrice.Text.ToString(), textBoxDiscountPerItem.Text, textBoxQuantity.Text, textBoxSubTotal.Text, textBoxTax.Text, textBoxTotalCost.Text);
            ResetControl();

            CalculateFinalCost();
        }

        void ResetControl()
        {
            comboBoxSelectItem.SelectedItem = null;
            textBoxUnitPrice.Clear();
            textBoxDiscountPerItem.Clear();
            textBoxQuantity.Clear();
            textBoxSubTotal.Clear();
            textBoxTax.Clear();
            textBoxTotalCost.Clear();

            textBoxFinalCost.Clear();
            textBoxAmountPaid.Clear();
            textBoxChange.Clear();
            textBoxQuantity.Enabled = false;
        }


        void CalculateFinalCost()
        {
            finalCost = 0;
            for (int i = 0; i < dataGridViewItemAdd.Rows.Count; i++)
            {
                finalCost = finalCost + Convert.ToInt32(dataGridViewItemAdd.Rows[i].Cells[7].Value);
                textBoxFinalCost.Text = finalCost.ToString();
            }
        }

        private void textBoxAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAmountPaid.Text) == true)
            {

            }
            else
            {
                int amountPaid = Convert.ToInt32(textBoxAmountPaid.Text);
                int fCost = Convert.ToInt32(textBoxFinalCost.Text);

                int changeAmount = amountPaid - fCost;  

                textBoxChange.Text = changeAmount.ToString();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridViewItemAdd.Rows.Clear();
            srNo = 0;
        }

        void GetInvoiceID()
        {
            SqlConnection con = new SqlConnection(cs);
            string queryGetInvoice = "select Invoice_Id from OrderMaster_Tbl";
            SqlDataAdapter sda = new SqlDataAdapter(queryGetInvoice, con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            if(dataTable.Rows.Count < 1)
            {
                textBoxInvoiceNo.Text = "1";
            }
            else
            {
                string queryGetInvoice2 = "select max(Invoice_Id) from OrderMaster_Tbl";
                SqlCommand cmd =  new SqlCommand(queryGetInvoice2, con);
                con.Open();
                int value = Convert.ToInt32(cmd.ExecuteScalar());

                value = value + 1;
                textBoxInvoiceNo.Text = value.ToString();
                con.Close();
            }
        }
    }
}

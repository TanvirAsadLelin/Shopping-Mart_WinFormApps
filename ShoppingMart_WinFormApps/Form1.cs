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
            comboBoxSelectItem.Items.Clear();
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

            comboBoxSelectItem.Sorted = true;
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

            if(comboBoxSelectItem.SelectedItem != null)
            {
                AddDataToGridview((++srNo).ToString(), comboBoxSelectItem.SelectedItem.ToString(), textBoxUnitPrice.Text.ToString(), textBoxDiscountPerItem.Text, textBoxQuantity.Text, textBoxSubTotal.Text, textBoxTax.Text, textBoxTotalCost.Text);
                ResetControl();

                CalculateFinalCost();
            }

            else
            {
                MessageBox.Show ("Plaase select your item!","Select",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            
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
               
            }
            textBoxFinalCost.Text = finalCost.ToString();

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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string queryInsert = "insert into OrderMaster_Tbl values(@invoiceId,@userName,@dateTime,@finalCost)";

            SqlCommand cmd = new SqlCommand(queryInsert, con);

            cmd.Parameters.AddWithValue("@invoiceId", textBoxInvoiceNo.Text);
            cmd.Parameters.AddWithValue("@userName", textBoxUser.Text);
            cmd.Parameters.AddWithValue("@dateTime", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@finalCost", textBoxFinalCost.Text);

            con.Open();

            int value =cmd.ExecuteNonQuery();
            if(value > 0)
            {
                MessageBox.Show("Insert Successfuly","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                GetInvoiceID();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Insertion failed", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
            InsertIntoOrderDeatils();

        }

        int GetLastInvoiceId()
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "select max(Invoice_Id) from OrderMaster_Tbl";

            SqlCommand cmd  = new SqlCommand(query, con);

            con.Open();
            int maxInvoiceId = Convert.ToInt32( cmd.ExecuteScalar());
            
            con.Close();

            return maxInvoiceId;

            
        }

        void InsertIntoOrderDeatils()
        {
            int value = 0;
            SqlConnection con = new SqlConnection(cs);

            try
            {


                for (int i = 0; i < dataGridViewItemAdd.Rows.Count; i++)
                {
                    string queryInsert = "insert into OrderDetails_Tbl values (@invoiceId, @name, @price, @discount, @quantity, @subTotal, @tax, @totalCost)";

                    SqlCommand cmd = new SqlCommand(queryInsert, con);

                    cmd.Parameters.AddWithValue("@invoiceId", GetLastInvoiceId());
                    cmd.Parameters.AddWithValue("@name", dataGridViewItemAdd.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@price", dataGridViewItemAdd.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@discount", dataGridViewItemAdd.Rows[i].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@quantity", dataGridViewItemAdd.Rows[i].Cells[4].Value);
                    cmd.Parameters.AddWithValue("@subTotal", dataGridViewItemAdd.Rows[i].Cells[5].Value);
                    cmd.Parameters.AddWithValue("@tax", dataGridViewItemAdd.Rows[i].Cells[6].Value);
                    cmd.Parameters.AddWithValue("@totalCost", dataGridViewItemAdd.Rows[i].Cells[7].Value);

                    con.Open();
                    value = value + cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch
            {

            }
            if(value > 0)
            {
                MessageBox.Show("Successfuly Inserted");
            }
            else
            {
                MessageBox.Show("Insertion Failed");
            }
            
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch  = e.KeyChar;
            if(char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(char.IsDigit(ch) == true)
            {
                e.Handled=false;
            }

            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled |= true;
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialogInvoice.Document = printDocumentInvoice;
            printPreviewDialogInvoice.ShowDialog();
        }

        private void printDocumentInvoice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {   

            Bitmap bitmap = Properties.Resources.Lillian_removebg_preview;
            Image image = bitmap;
            e.Graphics.DrawImage(image, 30, 5,800,225);
            e.Graphics.DrawString("Invoice Id: " + textBoxInvoiceNo.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 300));
            e.Graphics.DrawString("Username: " + textBoxUser.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 330));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 360));
            e.Graphics.DrawString("Time: " + DateTime.Now.ToLongTimeString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 390));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 420));
            e.Graphics.DrawString("Item", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 450));
            e.Graphics.DrawString("Price", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(230, 450));
            e.Graphics.DrawString("Quantity", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(430, 450));
            e.Graphics.DrawString("Discount", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(630, 450));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 480));

           
            // Item name add in printview control
            int gap = 510;

            if (dataGridViewItemAdd.Rows.Count > 0 )
            {
                for (int i = 0; i < dataGridViewItemAdd.Rows.Count; i++)
                {   
                    //if (dataGridViewItemAdd.Rows[i].Cells[1].Value.ToString() == null)
                    //{
                        try
                        {
                            e.Graphics.DrawString(dataGridViewItemAdd.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, gap));
                            gap = gap + 30;
                        }
                        catch
                        {

                        }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Hello null");
                    //}


                    //MessageBox.Show(dataGridViewItemAdd.Rows[i].Cells[1].Value.ToString());

                }
              
            }

            // Item price add in printview control
            int gap1 = 510;

            if (dataGridViewItemAdd.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewItemAdd.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridViewItemAdd.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(243, gap1));
                        gap1 = gap1 + 30;
                    }
                    catch
                    {

                    }

                    //MessageBox.Show(dataGridViewItemAdd.Rows[i].Cells[1].Value.ToString());

                }

            }
            // Item Discount  add in printview control
            int gap2 = 510;

            if (dataGridViewItemAdd.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewItemAdd.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridViewItemAdd.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(460, gap2));
                        gap2 = gap2 + 30;
                    }
                    catch
                    {

                    }

                    //MessageBox.Show(dataGridViewItemAdd.Rows[i].Cells[1].Value.ToString());

                }

            }
            // Item Quantity add in printview control
            int gap3 = 510;

            if (dataGridViewItemAdd.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewItemAdd.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridViewItemAdd.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(660, gap3));
                        gap3 = gap3 + 30;
                    }
                    catch
                    {

                    }

                    //MessageBox.Show(dataGridViewItemAdd.Rows[i].Cells[1].Value.ToString());

                }

            }

            int  subTotalPrint = 0;
            for (int i = 0; i < dataGridViewItemAdd.Rows.Count; i++)
            {
                subTotalPrint = subTotalPrint + Convert.ToInt32(dataGridViewItemAdd.Rows[i].Cells[5].Value);

            }

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 800));

            
            
            e.Graphics.DrawString("Sub Total: " + subTotalPrint.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 830));

            int taxPrint = 0;
            for (int i = 0; i < dataGridViewItemAdd.Rows.Count; i++)
            {
                taxPrint = taxPrint + Convert.ToInt32(dataGridViewItemAdd.Rows[i].Cells[6].Value);

            }

            e.Graphics.DrawString("Tax: " + taxPrint.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 860));
            e.Graphics.DrawString("Final cost: " + textBoxFinalCost.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 890));


            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 920));

            e.Graphics.DrawString("Amount paid: " + textBoxAmountPaid.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30,950));
            e.Graphics.DrawString("Change: " + textBoxChange.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 980));

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocumentInvoice.Print();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            GetItem();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditItemForm editItemForm = new EditItemForm();
            editItemForm.ShowDialog();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDataForm viewDataForm = new ViewDataForm();
            viewDataForm.ShowDialog();
        }

        private void detailsSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsSearchForm detailsSearchForm = new DetailsSearchForm();
            detailsSearchForm.ShowDialog();
        }
    }
}

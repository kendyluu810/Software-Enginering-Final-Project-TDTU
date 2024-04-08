using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CafeShopManagement
{
    public partial class CashierOrderForm : Form
    {
        static string conn = ConfigurationManager.ConnectionStrings["connectData"].ConnectionString;
        SqlConnection cn = new SqlConnection(conn);
        private int idGen = 0;
        public static int getCustID;
        private float totalPrice;

        public CashierOrderForm()
        {
            InitializeComponent();
            displayAvailableProds();
            displayAllOrders();
            displayTotalPrice();

        }

        private void displayTotalPrice()
        {
            GenerateID();

            if (cn.State == ConnectionState.Closed)
            {
                try
                {
                    cn.Open();

                    string selectData = "SELECT SUM(prod_price) FROM orders WHERE customer_id = @custId";

                    using (SqlCommand cmd = new SqlCommand(selectData, cn))
                    {
                        cmd.Parameters.AddWithValue("@custId", idGen);

                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);

                            CashierOrderForm_orderPrice.Text = totalPrice.ToString("0");
                        }
                        else
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cn.Close();
                }
            }

        }

        public void clearFields()
        {
            CashierOrderForm_Type.SelectedIndex = -1;
            CashierOrderForm_productID.Items.Clear();
            CashierOrderForm_ProductName.Text = "";
            CashierOrderForm_Price.Text = "";
            CashierOrderForm_Quantity.Value = 0;
        }


        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAvailableProds();
            displayAllOrders();

            displayTotalPrice();
        }

        private void displayAllOrders()
        {

            CashierOrdersData allOrders = new CashierOrdersData();

            List<CashierOrdersData> listData = allOrders.ordersListData();

            CashierOrderForm_orderTable.DataSource = listData;

        }

        public void displayAvailableProds()
        {

            CashierOrderFormProdData allProds = new CashierOrderFormProdData();

            List<CashierOrderFormProdData> listData = allProds.availableProductsData();

            CashierOrderForm_menuTable.DataSource = listData;

        }

        private void CashierOrderForm_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            CashierOrderForm_productID.SelectedIndex = -1;
            CashierOrderForm_productID.Items.Clear();
            CashierOrderForm_ProductName.Text = "";
            CashierOrderForm_Price.Text = "";



            string selectedValue = CashierOrderForm_Type.SelectedItem as string;

            if (selectedValue != null)
            {

                try
                {
                    using (SqlConnection cn = new SqlConnection(conn))
                    {
                        cn.Open();
                        string selectData = $"SELECT * FROM products WHERE prod_type = '{selectedValue}' AND prod_status = @status AND date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, cn))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["prod_id"].ToString();

                                    CashierOrderForm_productID.Items.Add(value);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void CashierOrderForm_productID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = CashierOrderForm_productID.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(conn))
                    {
                        cn.Open();
                        string selectData = $"SELECT * FROM products WHERE prod_id = '{selectedValue}' AND prod_status = @status AND date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, cn))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["prod_name"].ToString();
                                    string prodPrice = reader["prod_price"].ToString();

                                    CashierOrderForm_ProductName.Text = prodName;
                                    CashierOrderForm_Price.Text = prodPrice;

                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        public void GenerateID()
        {
            using (SqlConnection cn = new SqlConnection(conn))
            {
                cn.Open();
                string selectID = "SELECT MAX(customer_id) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectID, cn))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);

                        if (temp == 0)
                        {
                            idGen = 1;
                        }
                        else
                        {
                            idGen = temp + 1;
                        }
                    }
                    else
                    {
                        idGen = 1;
                    }
                    getCustID = idGen;
                }
            }

        }

        private void CashierOrderForm_Addbtn_Click(object sender, EventArgs e)
        {
            GenerateID();

            if (CashierOrderForm_productID.SelectedIndex == -1 || CashierOrderForm_productID.SelectedIndex == -1
                || CashierOrderForm_ProductName.Text == "" || CashierOrderForm_Quantity.Value == 0
                || CashierOrderForm_productID.Text == "")
            {
                MessageBox.Show("Please select the product first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cn.State == ConnectionState.Closed)
                {
                    try
                    {
                        cn.Open();
                        float getPrice = 0;
                        string selectOrder = "SELECT * FROM products WHERE prod_id = @prodID";

                        using (SqlCommand getOrder = new SqlCommand(selectOrder, cn))
                        {
                            getOrder.Parameters.AddWithValue("@prodID", CashierOrderForm_productID.Text.Trim());

                            using (SqlDataReader reader = getOrder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object rawValue = reader["prod_price"];
                                    if (rawValue != DBNull.Value)
                                    {
                                        getPrice = Convert.ToSingle(rawValue);
                                    }
                                }
                            }
                        }

                        string insertOrder = "INSERT INTO orders (customer_id, prod_id, prod_name, prod_type, qty, prod_price, order_date) " +
                            "VALUES(@customerID, @prodID, @prodName, @prodType, @qty, @prodPrice, @orderDate)";

                        DateTime today = DateTime.Today;

                        using (SqlCommand cmd = new SqlCommand(insertOrder, cn))
                        {
                            cmd.Parameters.AddWithValue("@customerID", idGen);
                            cmd.Parameters.AddWithValue("@prodID", CashierOrderForm_productID.Text.Trim());
                            cmd.Parameters.AddWithValue("@prodName", CashierOrderForm_ProductName.Text);
                            cmd.Parameters.AddWithValue("@prodType", CashierOrderForm_Type.Text.Trim());

                            float totalPrice = (getPrice * (int)CashierOrderForm_Quantity.Value);

                            cmd.Parameters.AddWithValue("@qty", CashierOrderForm_Quantity.Value);
                            cmd.Parameters.AddWithValue("@prodPrice", totalPrice);
                            cmd.Parameters.AddWithValue("@orderDate", today);

                            cmd.ExecuteNonQuery();


                            displayAllOrders();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
            displayTotalPrice();
        }


        private void CashierOrderForm_Clearbtn_Click(object sender, EventArgs e)
        {
            displayAllOrders();
            displayTotalPrice();

            clearFields();
        }

        private void CashierOrderForm_Total_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(CashierOrderForm_Total.Text);

                    float getChange = (getAmount - totalPrice);

                    if (getChange <= -1)
                    {
                        CashierOrderForm_Total.Text = "";
                        CashierOrderForm_change.Text = "";
                    }
                    else
                    {
                        CashierOrderForm_change.Text = getChange.ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CashierOrderForm_Total.Text = "";
                    CashierOrderForm_change.Text = "";
                }
            }

        }

        private void CashierOrderForm_Paybtn_Click(object sender, EventArgs e)
        {
            if (CashierOrderForm_Total.Text == "" || CashierOrderForm_orderTable.Rows.Count < 0)
            {
                MessageBox.Show("Something went wrong.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure for paying?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        try
                        {
                            cn.Open();

                            GenerateID();


                            string insertData = "INSERT INTO customers (customer_id, total_price, amount, change, date) " +
                                "VALUES(@custID, @totalprice, @amount, @change, @date)";

                            DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, cn))
                            {
                                cmd.Parameters.AddWithValue("@custID", idGen);
                                cmd.Parameters.AddWithValue("@totalprice", totalPrice);
                                cmd.Parameters.AddWithValue("@amount", CashierOrderForm_Total.Text);
                                cmd.Parameters.AddWithValue("@change", CashierOrderForm_change.Text);
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Paid successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            cn.Close();
                        }
                    }
                }
            }
            displayTotalPrice();

        }
        private int rowIndex = 0;

        private void CashierOrderForm_Receiptbtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            displayTotalPrice();

            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;
            int tableMargin = 20;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "Aubert de coffee";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left
                + (CashierOrderForm_orderTable.Columns.Count / 2) * colWidth, y, alignCenter);

            count++;
            y += tableMargin;

            string[] header = { "CID", "ProdID", "ProdName", "ProdType", "Qty", "Price" };

            for (int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            while (rowIndex < CashierOrderForm_orderTable.Rows.Count)
            {
                DataGridViewRow row = CashierOrderForm_orderTable.Rows[rowIndex];

                for (int i = 0; i < CashierOrderForm_orderTable.Columns.Count; i++)
                {
                    object cellValue = row.Cells[i].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            int labelMargin = (int)Math.Min(rSpace, 200);

            DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------", labelFont).Width;

            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString("Total Price: \tVND " + totalPrice + "\nAmount: \tVND "
                + CashierOrderForm_Total.Text + "\n\t\t------------\nChange: \tVND " + CashierOrderForm_change.Text, labelFont, Brushes.Black, labelX, y);

            labelMargin = (int)Math.Min(rSpace, -40);

            string labelText = today.ToString();
            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------", labelFont).Width, y);

        }

        private int getOrderID = 0;

        private void CashierOrderForm_Removebtn_Click(object sender, EventArgs e)
        {
            if (getOrderID == 0)
            {
                MessageBox.Show("Select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove the Order ID: " + getOrderID + "?", "Confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        try
                        {
                            cn.Open();

                            string deleteData = "DELETE FROM orders WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", getOrderID);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Removed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            cn.Close();
                        }
                    }
                }
            }

            displayAllOrders();
            displayTotalPrice();

        }

        private void CashierOrderForm_orderTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = CashierOrderForm_orderTable.Rows[e.RowIndex];
            getOrderID = (int)row.Cells[0].Value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopManagement
{
    public partial class AdminProduct : UserControl
    {
        static string conn = ConfigurationManager.ConnectionStrings["connectData"].ConnectionString;
        SqlConnection cn = new SqlConnection(conn);

        public AdminProduct()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {
            AdminAddProductsData prodData = new AdminAddProductsData();
            List<AdminAddProductsData> listData = prodData.productsListData();

            dataGridView1.DataSource = listData;
        }

        public bool emptyFields()
        {
            if (tbPID.Text == "" || tbPName.Text == "" || cbType.SelectedIndex == -1 || tbStock.Text == "" || tbPrice.Text == "" || cbStatus.SelectedIndex == -1) return true;
            return false;
        }
        private void AdminAddProduct_Addbtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cn.State == ConnectionState.Closed)
                {
                    try
                    {
                        cn.Open();

                        // CHECKING IF THE PRODUCT ID IS EXISTING ALREADY
                        string selectProdID = "SELECT * FROM products WHERE prod_id = @prodID";

                        using (SqlCommand selectPID = new SqlCommand(selectProdID, cn))
                        {
                            selectPID.Parameters.AddWithValue("@prodID", tbPID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(selectPID);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Product ID: " + tbPID.Text.Trim() + " is taken already", "Error Message"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO products (prod_id, prod_name, prod_type, " +
                                    "prod_stock, prod_price, prod_status, prod_image, date_insert) VALUES(@prodID, @prodName" +
                                    ", @prodType, @prodStock, @prodPrice, @prodStatus, @prodImage, @dateInsert)";

                                DateTime today = DateTime.Today;

                                string path = Path.Combine(@"E:\SE HK2 2023-2024\Software-Enginering-Final-Project-TDTU\CafeShopManagement\Product_Directory\"
                                    + tbPID.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(AdminAddProduct_ImageView.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, cn))
                                {
                                    cmd.Parameters.AddWithValue("@prodID", tbPID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodName", tbPName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodType", cbType.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStock", tbStock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodPrice", tbPrice.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStatus", cbStatus.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodImage", path);
                                    cmd.Parameters.AddWithValue("@dateInsert", today);

                                    cmd.ExecuteNonQuery();
                                    clearFields();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    displayData();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex, "Error Message"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }

            }

        }

        public void clearFields()
        {
            tbPID.Text = "";
            tbPName.Text = "";
            cbType.SelectedIndex = -1;
            tbStock.Text = "";
            tbPrice.Text = "";
            cbStatus.SelectedIndex = -1;
            AdminAddProduct_ImageView.Image = null;
        }

        private void AdminAddProduct_Uploadbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";


                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    AdminAddProduct_ImageView.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbPID.Text = row.Cells[1].Value.ToString();
                tbPName.Text = row.Cells[2].Value.ToString();
                cbType.Text = row.Cells[3].Value.ToString();
                tbStock.Text = row.Cells[4].Value.ToString();
                tbPrice.Text = row.Cells[5].Value.ToString();
                cbStatus.Text = row.Cells[6].Value.ToString();

                string imagePath = row.Cells[7].Value.ToString();

                try
                {
                    if (imagePath != null)
                    {
                        AdminAddProduct_ImageView.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        AdminAddProduct_ImageView.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Image" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AdminAddProduct_Updatebtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update Product ID: " + tbPID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (cn.State != ConnectionState.Open)
                    {
                        try
                        {
                            cn.Open();

                            string updateData = "UPDATE products SET prod_name = @prodName" +
                                ", prod_type = @prodType, prod_stock = @prodStock, prod_price = @prodPrice, prod_status = @prodStatus" +
                                ", date_update = @dateUpdate WHERE prod_id = @prodID";

                            DateTime today = DateTime.Today;

                            using (SqlCommand updateD = new SqlCommand(updateData, cn))
                            {
                                updateD.Parameters.AddWithValue("@prodName", tbPName.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodType", cbType.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodStock", tbStock.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodPrice", tbPrice.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodStatus", cbStatus.Text.Trim());
                                updateD.Parameters.AddWithValue("@dateUpdate", today);
                                updateD.Parameters.AddWithValue("@prodID", tbPID.Text.Trim());

                                updateD.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayData();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed Connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            cn.Close();
                        }
                    }
                }
            }
        }

        private void AdminAddProduct_Clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void AdminAddProduct_Deletebtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to delete Product ID: " + tbPID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (cn.State != ConnectionState.Open)
                    {
                        try
                        {
                            cn.Open();

                            string updateData = "UPDATE products SET date_delete = @dateDelete WHERE prod_id = @prodID";

                            DateTime today = DateTime.Today;

                            using (SqlCommand updateD = new SqlCommand(updateData, cn))
                            {
                                updateD.Parameters.AddWithValue("@dateDelete", today);
                                updateD.Parameters.AddWithValue("@prodID", tbPID.Text.Trim());

                                updateD.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Removed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayData();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed Connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            cn.Close();
                        }
                    }
                }
            }
        }

        private void AdminAddProduct_Export_Click(object sender, EventArgs e)
        {
            ExportToCSV();
        }

        private void ExportToCSV()
        {
            try
            {
                // Create a StringBuilder to hold the CSV data
                var csvData = new List<string>();

                // Add header row
                var headerRow = new List<string>();
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    headerRow.Add(column.HeaderText);
                }
                csvData.Add(string.Join(",", headerRow));

                // Add data rows
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var dataRow = new List<string>();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataRow.Add(cell.Value.ToString());
                    }
                    csvData.Add(string.Join(",", dataRow));
                }

                // Write CSV data to file
                string filePath = "product_data.csv"; // Change the file path as needed
                File.WriteAllLines(filePath, csvData);

                MessageBox.Show("Data exported to CSV successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to export data to CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

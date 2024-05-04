using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class productManagement : Form
    {
        public productManagement()
        {
            InitializeComponent();

        }
        private int dk = 0;

        private void ProdIMG_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image FIles(*.jpg; *.png|*.jpg;*.png)";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    ProdIMG.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        internal void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            showGRD();
            gbProd.Enabled = false;
            cbLoading();
        }
        //GRD
        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //show button when clicking to grd
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            btnClear.Enabled = false;
            gbProd.Enabled = false;
            btnAdd.Enabled = true;

            //grid view
            tbProdID.Text = grd.CurrentRow.Cells[0].Value.ToString();
            tbProdName.Text = grd.CurrentRow.Cells[1].Value.ToString();
            cbType.Text = grd.CurrentRow.Cells[2].Value.ToString();
            nStock.Text = grd.CurrentRow.Cells[3].Value.ToString();
            nPrice.Text = grd.CurrentRow.Cells[4].Value.ToString();
            cbStatus.Text = grd.CurrentRow.Cells[5].Value.ToString();
            ProdIMG.Enabled = false;
            //--img
            string imagePath = grd.CurrentRow.Cells[6].Value.ToString();
            if (imagePath != "")
            {
                ProdIMG.Image = System.Drawing.Image.FromFile(imagePath);
            }
            else
            {
                ProdIMG.Image = null;
            }

        }

        private void showGRD()
        {
            BUS_product b = new BUS_product("", "", "", 0, "0", "", "");
            grd.DataSource = b.selectQuery();
        }


        //Button processing

        private void clearFields()
        {
            tbProdID.Text = "";
            tbProdName.Text = "";
            cbStatus.Text = "";
            cbType.Text = "";
            nStock.Value = 0;
            nPrice.Text = "0";

        }

        private void enable(GroupBox gb, bool v)
        {
            gb.Enabled = v;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearFields();
            btnAdd.Enabled = false;
            BUS_product b = new BUS_product("", "", "", 0, "0", "", "");
            tbProdID.Text = b.auto_generateProdID();
            tbProdID.Enabled = false;
            btnSave.Enabled = true;
            enable(gbProd, true);
            btnClear.Enabled = true;
            ProdIMG.Enabled = true;
            dk = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BUS_product b = new BUS_product("", "", "", 0, "0", "", "");

            string prodname = tbProdName.Text;

            string type = cbType.Text;
            int stock = (int)nStock.Value;
            string price = nPrice.Text.Replace(',', '.');
            string status = cbStatus.Text;

            string prodID = b.auto_generateProdID();
            string img = "";
            if (ProdIMG.ImageLocation != null)
            {

                img = b.getImagePath(ProdIMG.ImageLocation, ProdIMG.Name);

            }


            if (isEmpty())
            {
                MessageBox.Show("product information fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dk == 1)
                { //add product 
                    BUS_product addProd = new BUS_product(prodID, prodname, type, stock, price, status, img);
                    addProd.addQuery();
                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (dk == 2)
                {

                    //update product 
                    BUS_product updateProd = new BUS_product(tbProdID.Text, prodname, type, stock, price, status, img);
                    updateProd.updateQuery();
                    MessageBox.Show("Update Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            refreshGRD();

            dk = 0;

        }

        private void refreshGRD()
        {
            showGRD();
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
        }

        private bool isEmpty()
        {
            if (
            tbProdName.Text == "" ||
            nPrice.Text == "" ||
            cbType.Text == "" ||
            cbType.Text == ""
                ) { return true; }
            return false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dk = 2;

            enable(gbProd, true);
            ProdIMG.Enabled = false;
            btnSave.Enabled = true;
            tbProdID.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete username: " + tbProdName.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BUS_product b = new BUS_product(tbProdID.Text, "", "", 0, "0", "", "");
                b.deleteQuery();
                MessageBox.Show("Delete Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshGRD();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void cbLoading()
        {
            //Type
            cbType.Items.Add("Coffee");
            cbType.Items.Add("Tea");
            cbType.Items.Add("Cold Brew");

            //status 
            cbStatus.Items.Add("Available");
            cbStatus.Items.Add("Out of stock");


        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";


                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    ProdIMG.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // export data to csv file

        private void ExportToCSV()
        {
            try
            {
                if (grd != null && grd.Rows.Count > 0 && grd.Columns.Count > 0)
                {
                    // Create a StringBuilder to hold the CSV data
                    var csvData = new List<string>();

                    // Add header row
                    var headerRow = new List<string>();
                    foreach (DataGridViewColumn column in grd.Columns)
                    {
                        headerRow.Add(column.HeaderText);
                    }
                    csvData.Add(string.Join(",", headerRow));

                    // Add data rows
                    foreach (DataGridViewRow row in grd.Rows)
                    {
                        var dataRow = new List<string>();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            dataRow.Add(cell.Value?.ToString() ?? ""); // Handle null values
                        }
                        csvData.Add(string.Join(",", dataRow));
                    }

                    // Write CSV data to file
                    string filePath = "product_data.csv"; // Change the file path as needed
                    File.WriteAllLines(filePath, csvData);

                    MessageBox.Show("Data exported to CSV successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No data available to export.", "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to export data to CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToCSV();
        }
    }
}

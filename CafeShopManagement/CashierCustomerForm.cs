using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopManagement
{
    public partial class CashierCustomerForm : Form
    {
        public CashierCustomerForm()
        {
            InitializeComponent();
            displayCustomerData();
        }

        public void displayCustomerData()
        {
            CustomerData customerData = new CustomerData();
            List<CustomerData> listData = customerData.allCustomersData();
            CashierCustomerForm_menuTable.DataSource = listData;
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCustomerData();
        }

        private void CashierCustomersForm_Exportbtn_Click(object sender, EventArgs e)
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
                foreach (DataGridViewColumn column in CashierCustomerForm_menuTable.Columns)
                {
                    headerRow.Add(column.HeaderText);
                }
                csvData.Add(string.Join(",", headerRow));

                // Add data rows
                foreach (DataGridViewRow row in CashierCustomerForm_menuTable.Rows)
                {
                    var dataRow = new List<string>();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataRow.Add(cell.Value.ToString());
                    }
                    csvData.Add(string.Join(",", dataRow));
                }

                // Write CSV data to file
                string filePath = "customer_data.csv"; // Change the file path as needed
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

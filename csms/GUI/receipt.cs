using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GUI
{
    public partial class receipt : Form
    {
        private BUS_receipt bus_Receipt;
        private DAL_staff dal_staff;
        private DAL_receipt dal_receipt;
        private string receiptid = "";
        public receipt()
        {
            InitializeComponent();
            bus_Receipt = new BUS_receipt("","","","","","",0);
            dal_receipt = new DAL_receipt("", "", "", "", "", "", 0);
            dal_staff= new DAL_staff("", "", "", "", "", "", "");
            cbLoading();
        }

        internal void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            showGRD();
            cbLoading();
        }

        private void cbLoading()
        {
            // Load staff IDs into staff_cb
            DataTable staffData = dal_staff.GetStaffIds();
            foreach (DataRow row in staffData.Rows)
            {
                staff_cb.Items.Add(row["staffid"].ToString());
            }

            // Clear date_cb before loading new items
            date_cb.Items.Clear();

            // Load distinct dates into date_cb
            DataTable dateData = dal_receipt.GetDistinctDates();
            foreach (DataRow row in dateData.Rows)
            {
                date_cb.Items.Add(((DateTime)row["receiptDate"]).ToString("yyyy-MM-dd"));
            }
        }


        private void showGRD()
        {
            BUS_receipt r = new BUS_receipt("", "", "", "", "", "", 0);
            grdReceipt.DataSource = r.selectQuery();
        }

        private void grdReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            receiptid = grdReceipt.CurrentRow.Cells[0].Value.ToString();
            showGRD_order();
        }


        private void showGRD_order()
        {
            BUS_order o = new BUS_order(receiptid, "", "", 0, "");
            grdOrder.DataSource = o.selectQuery();
        }

        private void staff_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchReceipts();
        }

        private void date_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchReceipts();
        }

        private void SearchReceipts()
        {
            if (staff_cb.SelectedItem != null && date_cb.SelectedItem != null)
            {
                // Retrieve the selected staff ID and date
                string staffId = staff_cb.SelectedItem.ToString();
                DateTime date = DateTime.ParseExact(date_cb.SelectedItem.ToString(), "yyyy-MM-dd", null);

                // Call the method to search for receipts based on staff ID and date
                DataTable searchRes = bus_Receipt.SearchReceiptsByStaffAndDate(staffId, date);
                grdReceipt.DataSource = searchRes;
            }
        }
    }
}

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

namespace GUI
{
    public partial class dashboard : Form
    {

        private BUS_receipt busReceipt;
        private BUS_STAFF busStaff;
        private BUS_membership busmembership;

        public dashboard()
        {
            InitializeComponent();
            busReceipt = new BUS_receipt("","","","","","",0);
            busStaff = new BUS_STAFF("","","","","","","");
            busmembership = new BUS_membership("", "", "", "", 0, "");
            displayTodayIncome();
            displayTotalIncome();
            displayTotalCashier();
            displayTotalCustomers();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayTotalIncome();
            displayTodayIncome();
            displayTotalCashier();
            displayTotalCustomers();
        }

        private void displayTotalCashier()
        {

            try
            {
                int totalStaff = busStaff.getTotalStaff();
                // Update the appropriate control to display total staff
                totalStaff_tb.Text = totalStaff.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to display total staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayTotalIncome()
        {
            try
            {
                decimal totalIcome = busReceipt.GetTotalIncome();
                totalIncome_tb.Text = totalIcome.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to display total income: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayTotalCustomers()
        {
            try
            {
                int totalMemberships = busmembership.getTotalMembership();
                // Update the appropriate control to display total memberships
                totalCustomer_tb.Text = totalMemberships.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to display total memberships: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayTodayIncome()
        {
            try
            {
                decimal todayIncome = busReceipt.GetTodayIncome();
                todayIncome_tb.Text = todayIncome.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to display today's income: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

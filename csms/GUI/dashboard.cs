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
        public dashboard()
        {
            InitializeComponent();
            //displayTotalCashier();
            //displayTotalCustomers();
           // displayTotalIncome();
           // displayTodayIncome();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            //displayTotalCashier();
            //displayTotalCustomers();
            //displayTotalIncome();
            //displayTodayIncome();
        }

        private void displayTotalCashier()
        {

            throw new NotImplementedException();
        }

        private void displayTotalIncome()
        {
            throw new NotImplementedException();
        }

        private void displayTotalCustomers()
        {
            throw new NotImplementedException();
        }

        private void displayTodayIncome()
        {
            throw new NotImplementedException();
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

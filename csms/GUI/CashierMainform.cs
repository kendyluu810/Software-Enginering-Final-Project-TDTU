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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class CashierMainform : Form
    {
        private string username;

        public CashierMainform(string username)
        {
            this.username = username;
            InitializeComponent();
            this.username = username;
            takeOrder dashboardForm = new takeOrder(username);
            ShowFormInPanel(dashboardForm);
            displayUser();
        }



        private void displayUser()
        {
            label_username.Text = username;
        }



        private void ShowFormInPanel(Form formToShow)
        {
            mainboard.Controls.Clear();
            formToShow.TopLevel = false;
            formToShow.Dock = DockStyle.Fill;
            mainboard.Controls.Add(formToShow);
            formToShow.Show();
        }

        private void mainboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();

                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label_username_Click(object sender, EventArgs e)
        {

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            receipt m = new receipt();
            ShowFormInPanel(m);

            receipt mem = m as receipt;

            if (mem != null)
            {
                mem.refreshData();
            }
        }

        private void btnMem_Click(object sender, EventArgs e)
        {

            membership m = new membership();
            ShowFormInPanel(m);

            membership mem = m as membership;

            if (mem != null)
            {
                mem.refreshData();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            takeOrder dashboardForm = new takeOrder(username);
            ShowFormInPanel(dashboardForm);

            takeOrder mem = dashboardForm as takeOrder;

            if (mem != null)
            {
                mem.refreshData();
            }

        }
    }
}

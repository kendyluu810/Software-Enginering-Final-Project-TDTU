using GUI;
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
    public partial class MainForm : Form
    {
        private string username;
        public MainForm(string username)
        {
            InitializeComponent();
            this.username = username;
            dashboard dashboardForm = new dashboard();
            ShowFormInPanel(dashboardForm);
            displayUser();
        }

        private void displayUser()
        {
            label_username.Text = username;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();

                this.Hide();
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            staffManagement staffManagement = new staffManagement();
            ShowFormInPanel(staffManagement);

            staffManagement aaUser = staffManagement as staffManagement;

            if (aaUser != null)
            {
                aaUser.refreshData();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            ShowFormInPanel(dashboard);

            dashboard db = dashboard as dashboard;

            if (db != null)
            {
                db.refreshData();
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            productManagement productManagement = new productManagement();
            ShowFormInPanel(productManagement);

            productManagement p = productManagement as productManagement;

            if (p != null)
            {
                p.refreshData();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            membership m = new membership();
            ShowFormInPanel(m);

            membership mem = m as membership;

            if (mem != null)
            {
                mem.refreshData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coupon m = new coupon();
            ShowFormInPanel(m);

            coupon mem = m as coupon;

            if (mem != null)
            {
                mem.refreshData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            receipt m = new receipt();
            ShowFormInPanel(m);

            receipt mem = m as receipt;

            if (mem != null)
            {
                mem.refreshData();
            }
        }
    }
}

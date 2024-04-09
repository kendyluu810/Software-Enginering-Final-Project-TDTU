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
    public partial class MainForm : Form
    {
        static string conn = ConfigurationManager.ConnectionStrings["connectData"].ConnectionString;
        SqlConnection cn = new SqlConnection(conn);
        private DashboardForm dashboardForm;
        public MainForm()
        {
            InitializeComponent();
            dashboardForm = new DashboardForm();
            ShowFormInPanel(dashboardForm);
            displayUser();

        }

        public void displayUser()
        {
            if(cn.State == ConnectionState.Closed)
            {
                try
                {
                    cn.Open();
                    string selectData = "SELECT username FROM users WHERE username = @username AND role = @role";
                    using (SqlCommand cm = new SqlCommand(selectData, cn))
                    {
                        cm.Parameters.AddWithValue("@username",AdminMainForm_User.Text.Trim());
                        cm.Parameters.AddWithValue("@role","Admin");

                        SqlDataReader rd = cm.ExecuteReader();

                        if (rd.Read())
                        {
                            string username = rd["username"].ToString();
                            AdminMainForm_User.Text= username;
                        }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation Messgae", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Hide();
            }
        }

        private void ShowFormInPanel(Form formToShow)
        {
            panel2.Controls.Clear();
            formToShow.TopLevel = false;
            formToShow.Dock = DockStyle.Fill;
            panel2.Controls.Add(formToShow);
            formToShow.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(dashboardForm);
            DashboardForm adForm = dashboardForm as DashboardForm;

            if(adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            AdminAddUser adminAddUser = new AdminAddUser();
            ShowFormInPanel(adminAddUser);

            AdminAddUser aaUser = adminAddUser as AdminAddUser;

            if(aaUser != null)
            {
                aaUser.refreshData();
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            AdminAddProducts adminAddProducts = new AdminAddProducts();
            ShowFormInPanel(adminAddProducts);

            AdminAddProducts aaProduct = adminAddProducts as AdminAddProducts;

            if(aaProduct != null)
            {
                aaProduct.refreshData();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CashierCustomerForm customerForm = new CashierCustomerForm();
            ShowFormInPanel(customerForm);

            CashierCustomerForm cf = customerForm as CashierCustomerForm;

            if(cf != null)
            {
                cf.refreshData();
            }
        }
    }
}

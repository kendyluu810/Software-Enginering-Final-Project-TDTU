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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CafeShopManagement
{
    public partial class CashierMainForm : Form
    {
        static string conn = ConfigurationManager.ConnectionStrings["connectData"].ConnectionString;
        SqlConnection cn = new SqlConnection(conn);


        private DashboardForm dashboardForm;
        private string loggedInUsername;

        public CashierMainForm(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
            displayUser();
            dashboardForm = new DashboardForm();
            ShowFormInPanel(dashboardForm);
        }


        public void displayUser()
        {
            if (cn.State == ConnectionState.Closed)
            {
                try
                {
                    cn.Open();
                    string selectData = "SELECT username FROM users WHERE username = @username AND role = @role AND status = @status";

                    using (SqlCommand cm = new SqlCommand(selectData, cn))
                    {
                        cm.Parameters.AddWithValue("@username", loggedInUsername);
                        cm.Parameters.AddWithValue("@role", "Cashier");
                        cm.Parameters.AddWithValue("@status", "Active");

                        using (SqlDataReader rd = cm.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                string retrievedUsername = rd["username"].ToString();
                                CashierMainForm_User.Text = retrievedUsername;
                            }
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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            CashierOrderForm orderForm = new CashierOrderForm();
            ShowFormInPanel(orderForm);

            CashierOrderForm cof = orderForm as CashierOrderForm;

            if (cof != null)
            {
                cof.refreshData();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(dashboardForm);
            DashboardForm adForm = dashboardForm as DashboardForm;

            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AdminAddProducts adminAddProducts = new AdminAddProducts();
            ShowFormInPanel(adminAddProducts);

            AdminAddProducts aaProduct = adminAddProducts as AdminAddProducts;

            if (aaProduct != null)
            {
                aaProduct.refreshData();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CashierCustomerForm customerForm = new CashierCustomerForm();
            ShowFormInPanel(customerForm);
            CashierCustomerForm cf = customerForm as CashierCustomerForm;

            if (cf != null)
            {
                cf.refreshData();
            }
        }
    }
}

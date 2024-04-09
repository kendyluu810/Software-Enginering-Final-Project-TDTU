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
    public partial class DashboardForm : Form
    {
        static string conn = ConfigurationManager.ConnectionStrings["connectData"].ConnectionString;
        SqlConnection cn = new SqlConnection(conn);
        public DashboardForm()
        {
            InitializeComponent();
            displayTotalCashier();
            displayTotalCustomers();
            displayTotalIncome();
            displayTodayIncome();
        }

        public void refreshData()
        { 
            if (InvokeRequired)
            {
              Invoke((MethodInvoker)refreshData);
                return;
            }
            displayTotalCashier();
            displayTotalCustomers();
            displayTotalIncome();
            displayTodayIncome();
        }

        public void displayTotalCashier()
        {
            if(cn.State == ConnectionState.Closed)
            {
                try
                {
                    cn.Open();
                    string selectData = "SELECT COUNT(id) FROM users WHERE role = @role AND status = @status";
                    using (SqlCommand cm = new SqlCommand(selectData, cn))
                    {
                        cm.Parameters.AddWithValue("@role", "Cashier");
                        cm.Parameters.AddWithValue("@status", "Active");

                        SqlDataReader rd = cm.ExecuteReader();

                        if(rd.Read())
                        {
                            int count = Convert.ToInt32(rd[0]);
                            dashboard_TC.Text = count.ToString();
                        }

                        rd.Close();
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

        public void displayTotalCustomers()
        {
            if (cn.State == ConnectionState.Closed)
            {
                try
                {
                    cn.Open();
                    string selectData = "SELECT COUNT(id) FROM customers";

                    using (SqlCommand cm = new SqlCommand(selectData, cn))
                    {
                        SqlDataReader rd = cm.ExecuteReader();

                        if (rd.Read())
                        {
                            int count = Convert.ToInt32(rd[0]);
                            dashboard_TCust.Text = count.ToString();
                        }

                        rd.Close();
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

        public void displayTotalIncome()
        {
            if (cn.State == ConnectionState.Closed)
            {
                try
                {
                    cn.Open();
                    string selectData = "SELECT SUM(total_price) FROM customers";

                    using (SqlCommand cm = new SqlCommand(selectData, cn))
                    {
                        SqlDataReader rd = cm.ExecuteReader();

                        if (rd.Read())
                        {
                            int count = Convert.ToInt32(rd[0]);
                            dashboard_Ttin.Text = count.ToString();
                        }

                        rd.Close();
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
        
        public void displayTodayIncome()
        {
            if (cn.State == ConnectionState.Closed)
            {
                try
                {
                    cn.Open();
                    string selectData = "SELECT SUM(total_price) FROM customers WHERE date = @date";

                    using (SqlCommand cm = new SqlCommand(selectData, cn))
                    {
                        DateTime today = DateTime.Today;
                        string getToday = today.ToString("yyyy-MM-dd");

                        cm.Parameters.AddWithValue("@date", getToday);
                        object result = cm.ExecuteScalar(); // Use ExecuteScalar to get a single value

                        if (result != DBNull.Value) // Check if the result is not DBNull
                        {
                            decimal income = Convert.ToDecimal(result); // Convert to decimal
                            dashboard_Tin.Text = income.ToString(); // Display the income
                        }
                        else
                        {
                            dashboard_Tin.Text = "0"; // If no income, display 0
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
    }
}

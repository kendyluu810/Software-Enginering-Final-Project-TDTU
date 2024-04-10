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
    public partial class LoginForm : Form
    {
        static string conn = ConfigurationManager.ConnectionStrings["connectData"].ConnectionString;
        SqlConnection cn = new SqlConnection(conn);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            RegisterForm registerform = new RegisterForm();
            registerform.Show();

            this.Hide();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            tbPass.PasswordChar = ckbShowPass.Checked ? '\0' : '*';
        }

        public bool emptyFields()
        {
            if (tbUser.Text == "" || tbPass.Text == "") return true;
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cn.State == ConnectionState.Closed)
                {
                    try
                    {
                        cn.Open();
                        string selectAccount = "SELECT COUNT (*) FROM users WHERE username = @username AND password = @pass AND status = @status";

                        using (SqlCommand cm = new SqlCommand(selectAccount, cn))
                        {
                            cm.Parameters.AddWithValue("@username", tbUser.Text.Trim());
                            cm.Parameters.AddWithValue("@pass", tbPass.Text.Trim());
                            cm.Parameters.AddWithValue("@status", "Active");

                            int rowCount = (int) cm.ExecuteScalar();

                            if(rowCount > 0)
                            {
                                string selectRole = "SELECT role FROM users WHERE username = @username AND password = @pass";

                                using (SqlCommand getRole = new SqlCommand(selectRole, cn))
                                {
                                    getRole.Parameters.AddWithValue("@username", tbUser.Text.Trim());
                                    getRole.Parameters.AddWithValue("@pass", tbPass.Text.Trim());

                                    string userRole = getRole.ExecuteScalar() as string;

                                    MessageBox.Show("Login Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (userRole == "Admin")
                                    {
                                        MainForm mainForm = new MainForm();
                                        mainForm.Show();

                                        this.Hide();

                                    }
                                    else if (userRole == "Cashier")
                                    {
                                        CashierMainForm cashierMainForm = new CashierMainForm(tbUser.Text.Trim());
                                        cashierMainForm.Show();

                                        this.Hide();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username or Password / there's no Admin approval", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed: "+ex,"Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }
    }
}

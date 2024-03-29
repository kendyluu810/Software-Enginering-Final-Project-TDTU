using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        SqlConnection cn = new SqlConnection(@"Data Source=SAMMELUU;Initial Catalog=CSMS;Persist Security Info=True;User ID=sa;Password=Lkendy0911");
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
                        string selectAccount = "SELECT * FROM users WHERE username = @username AND password = @pass AND status = @status";

                        using (SqlCommand cm = new SqlCommand(selectAccount, cn))
                        {
                            cm.Parameters.AddWithValue("@username", tbUser.Text.Trim());
                            cm.Parameters.AddWithValue("@pass", tbPass.Text.Trim());
                            cm.Parameters.AddWithValue("@status", "Active");

                            SqlDataAdapter data = new SqlDataAdapter(cm);
                            DataTable dt = new DataTable();
                            data.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainForm mainform = new MainForm();
                                mainform.Show();

                                this.Hide();
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

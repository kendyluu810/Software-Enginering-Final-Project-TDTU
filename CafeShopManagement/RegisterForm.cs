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
    public partial class RegisterForm : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=KENDYL;Initial Catalog=CSMS;Persist Security Info=True;User ID=sa;Password=Lkendy0911");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();

            this.Hide();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            tbPass.PasswordChar = ckbShowPass.Checked ? '\0' : '*';
            tbCP.PasswordChar = ckbShowPass.Checked ? '\0' : '*';
        }

        public bool emptyFields()
        {
            if (tbUsername.Text == "" || tbCP.Text == "" || tbCP.Text == "") return true;
            return false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
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

                        string selectUsername = "SELECT * FROM users WHERE username = @username";

                        using (SqlCommand checkUsername = new SqlCommand(selectUsername, cn))
                        {
                            checkUsername.Parameters.AddWithValue("@username", tbUsername.Text.Trim());

                            SqlDataAdapter data = new SqlDataAdapter(checkUsername);
                            DataTable dt = new DataTable();
                            data.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                string usern = tbUsername.Text.Substring(0, 1).ToUpper() + tbUsername.Text.Substring(1);
                                MessageBox.Show(usern + "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (tbPass.Text != tbCP.Text)
                            {
                                MessageBox.Show("Password doesn't match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (tbPass.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid Password, at least 8 character", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username,password,profile_image,role,status,date_reg)" +
                                    " VALUES(@username,@pass,@image,@role,@status,@date)";
                                DateTime today = DateTime.Today;
                                using (SqlCommand cm = new SqlCommand(insertData, cn))
                                {
                                    cm.Parameters.AddWithValue("@username", tbUsername.Text.Trim());
                                    cm.Parameters.AddWithValue("@pass", tbPass.Text.Trim());
                                    cm.Parameters.AddWithValue("@image", "");
                                    cm.Parameters.AddWithValue("@role", "Cashier");
                                    cm.Parameters.AddWithValue("@status", "Approval");
                                    cm.Parameters.AddWithValue("@date", today);

                                    cm.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { cn.Close(); }
                }
            }
        }
    }
}

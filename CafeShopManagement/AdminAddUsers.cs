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
using System.IO;

namespace CafeShopManagement
{
    public partial class AdminAddUsers : UserControl
    {
        static string conn = ConfigurationManager.ConnectionStrings["connectData"].ConnectionString;
        SqlConnection cn = new SqlConnection(conn);

        public AdminAddUsers()
        {
            InitializeComponent();
            displayAddUserData();
        }

        public void displayAddUserData()
        {
            AdminAddUsersData usersData = new AdminAddUsersData();
            List<AdminAddUsersData> listData = usersData.usersListData();

            dataGridView1.DataSource = listData;
        }

        public bool emptyFields()
        {
            if (tbUsername.Text == "" || tbPass.Text == ""
                || cbRole.Text == "" || cbStatus.Text == ""
                || AdminAddUsers_ImageView.Image == null) return true;
            return false;
        }

        private void AdminAddUsers_Addbtn_Click(object sender, EventArgs e)
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
                        // Check username if existing already
                        string selectUsers = "SELECT * FROM users WHERE username = @username";
                        using (SqlCommand checkUsername = new SqlCommand(selectUsers, cn))
                        {
                            checkUsername.Parameters.AddWithValue("@username", tbUsername.Text.Trim());

                            SqlDataAdapter data = new SqlDataAdapter(checkUsername);
                            DataTable dt = new DataTable();
                            data.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                string username = tbUsername.Text.Substring(0, 1).ToUpper() + tbUsername.Text.Substring(1);
                                MessageBox.Show(username + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username,password,role,status,profile_image,date_reg)" + "VALUES(@username,@pass,@role,@status,@image,@date)";
                                DateTime today = DateTime.Today;

                                string path = Path.Combine(@"E:\SE HK2 2023-2024\Software-Enginering-Final-Project-TDTU\CafeShopManagement\User_Directory\"
                                        + tbUsername.Text.Trim() + ".png");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(AdminAddUsers_ImageView.ImageLocation, path, true);

                                using (SqlCommand cm = new SqlCommand(insertData, cn))
                                {
                                    cm.Parameters.AddWithValue("@username", tbUsername.Text.ToString().Trim());
                                    cm.Parameters.AddWithValue("@pass", tbPass.Text.ToString().Trim());
                                    cm.Parameters.AddWithValue("@image", path);
                                    cm.Parameters.AddWithValue("@role", cbRole.Text.Trim());
                                    cm.Parameters.AddWithValue("@status", cbStatus.Text.Trim());
                                    cm.Parameters.AddWithValue("@date", today);

                                    cm.ExecuteNonQuery();

                                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    displayAddUserData();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }

        private void AdminAddUsers_Uploadbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image FIles(*.jpg; *.png|*.jpg;*.png)";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    AdminAddUsers_ImageView.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private int id = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id = (int)row.Cells[0].Value;
            tbUsername.Text = row.Cells[1].Value.ToString();
            tbPass.Text = row.Cells[2].Value.ToString();
            cbRole.Text = row.Cells[3].Value.ToString();
            cbStatus.Text = row.Cells[4].Value.ToString();

            string imagePath = row.Cells[5].Value.ToString();

            if (imagePath != null)
            {
                AdminAddUsers_ImageView.Image = Image.FromFile(imagePath);
            }
            else
            {
                AdminAddUsers_ImageView.Image = null;
            }
        }

        private void AdminAddUsers_Editbtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are ypu sure you want to update username: " + tbUsername.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    if (cn.State != ConnectionState.Open)
                    {
                        try
                        {
                            cn.Open();
                            string updateData = "UPDATE users SET username = @username, password = @pass, role = @role, status = @status WHERE id = @id";
                            using (SqlCommand cm = new SqlCommand(updateData, cn))
                            {
                                cm.Parameters.AddWithValue("@username", tbUsername.Text.Trim());
                                cm.Parameters.AddWithValue("@pass", tbPass.Text.Trim());
                                cm.Parameters.AddWithValue("@role", cbRole.Text.Trim());
                                cm.Parameters.AddWithValue("@status", cbStatus.Text.Trim());
                                cm.Parameters.AddWithValue("@id", id);

                                cm.ExecuteNonQuery();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayAddUserData();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            cn.Close();
                        }
                    }
                }
            }
        }

        public void clearFields()
        {
            tbUsername.Text = "";
            tbPass.Text = "";
            cbRole.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            AdminAddUsers_ImageView.Image = null;
        }

        private void AdminAddUsers_Clearbtn_Click(object sender, EventArgs e)
        {

        }
    }
}

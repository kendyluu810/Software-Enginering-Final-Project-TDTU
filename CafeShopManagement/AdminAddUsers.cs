﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CafeShopManagement
{
    public partial class AdminAddUsers : UserControl
    {
        static string conn = ConfigurationManager.ConnectionStrings["connectData"].ConnectionString;
        SqlConnection cn = new SqlConnection(conn);
        private int id = 0;
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
            if (tbUsername.Text == "" || tbPass.Text == "" || cbRole.Text == "" || cbStatus.Text == "" || AdminAddUser_ImageView.Image == null) return true;
            return false;
        }

        private void AdminAddUser_Addbtn_Click(object sender, EventArgs e)
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
                                MessageBox.Show(username + "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                File.Copy(AdminAddUser_ImageView.ImageLocation, path, true);

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
                                    clearFields();

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

        private void AdminAddUser_Uploadbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image FIles(*.jpg; *.png|*.jpg;*.png)";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    AdminAddUser_ImageView.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminAddUser_Updatebtn_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id = (int)row.Cells[0].Value;
            tbUsername.Text = row.Cells[1].Value.ToString();
            tbPass.Text = row.Cells[2].Value.ToString();
            cbRole.Text = row.Cells[3].Value.ToString();
            cbStatus.Text = row.Cells[4].Value.ToString();

            string imagePath = row.Cells[5].Value.ToString();

            try
            {
                if (imagePath != null)
                {
                    AdminAddUser_ImageView.Image = Image.FromFile(imagePath);
                }
                else
                {
                    AdminAddUser_ImageView.Image = null;
                }
            }
            catch
            {
                MessageBox.Show("No Image!", "Error Messgae", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void clearFields()
        {
            tbUsername.Text = "";
            tbPass.Text = "";
            cbRole.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            AdminAddUser_ImageView.Image = null;
        }

        private void AdminAddUser_Clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void AdminAddUser_Deletebtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are ypu sure you want to delete username: " + tbUsername.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (cn.State != ConnectionState.Open)
                    {
                        try
                        {
                            cn.Open();
                            string deleteData = "DELETE FROM users WHERE id = @id";
                            using (SqlCommand cm = new SqlCommand(deleteData, cn))
                            {
                                cm.Parameters.AddWithValue("@id", id);

                                cm.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void ExportToCSV()
        {
            try
            {
                // Open file dialog to choose save location
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the file path chosen by the user
                    string filePath = saveFileDialog.FileName;

                    // Write data to the CSV file
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Write header row
                        writer.WriteLine("Username,Password,Role,Status");

                        // Write data rows
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            string username = row.Cells[1].Value.ToString();
                            string password = row.Cells[2].Value.ToString();
                            string role = row.Cells[3].Value.ToString();
                            string status = row.Cells[4].Value.ToString();

                            writer.WriteLine($"{username},{password},{role},{status}");
                        }

                        MessageBox.Show("Data exported successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminAddUser_Export_Click(object sender, EventArgs e)
        {
            ExportToCSV();
        }
    }
}

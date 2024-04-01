using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace CafeShopManagement
{
    class AdminAddUsersData
    {
        static string conn = ConfigurationManager.ConnectionStrings["connectData"].ConnectionString;
        SqlConnection cn = new SqlConnection(conn);

        public int ID { set; get; }
        public string? Username { set; get; }
        public string? Password { set; get; }
        public string? Role { set; get; }
        public string? Status { set; get; }
        public string? Image { set; get; }
        public string? DateRegistered { set; get; }


        public List <AdminAddUsersData> usersListData()
        {
            List<AdminAddUsersData> listData = new List<AdminAddUsersData>();

            if(cn.State != ConnectionState.Open)
            {
                try
                {
                    cn.Open();
                    string selectData = "SELECT * FROM users";

                    using (SqlCommand cm = new SqlCommand(selectData, cn))
                    {
                        SqlDataReader rd = cm.ExecuteReader();

                        while (rd.Read())
                        {
                            AdminAddUsersData userData = new AdminAddUsersData();
                            userData.ID = (int)rd["id"];
                            userData.Username = rd["username"].ToString();
                            userData.Password = rd["password"].ToString();
                            userData.Role = rd["role"].ToString();
                            userData.Status = rd["status"].ToString();
                            userData.Image = rd["profile_image"].ToString();
                            userData.DateRegistered = rd["date_reg"].ToString();

                            listData.Add(userData);
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection Failed: "+ex);
                }
                finally { cn.Close(); }
            }
            return listData;
        }
    }
}

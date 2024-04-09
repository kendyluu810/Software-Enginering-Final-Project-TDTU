using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShopManagement
{
    class CustomerData
    {
        static string conn = ConfigurationManager.ConnectionStrings["connectData"].ConnectionString;
        SqlConnection cn = new SqlConnection(conn);

        public int CustomerID { set; get; }
        public string? TotalPrice { set; get; }
        public string? Amount { set; get; }
        public string? Change { set; get; }
        public string? Date { set; get; }

        public List<CustomerData> allCustomersData()
        {
            List<CustomerData> listData = new List<CustomerData>();

            if (cn.State == ConnectionState.Closed)
            {
                try
                {
                    cn.Open();

                    string selectData = "SELECT * FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, cn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CustomerData cData = new CustomerData();

                            cData.CustomerID = (int)reader["customer_id"];
                            cData.TotalPrice = reader["total_price"].ToString();
                            cData.Amount = reader["amount"].ToString();
                            cData.Change = reader["change"].ToString();
                            cData.Date = reader["date"].ToString();

                            listData.Add(cData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed cnion: " + ex);
                }
                finally
                {
                    cn.Close();
                }
            }

            return listData;
        }

    }
}

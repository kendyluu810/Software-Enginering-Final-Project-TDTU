using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CafeShopManagement
{
    class CashierOrderFormProdData
    {
        static string conn = ConfigurationManager.ConnectionStrings["connectData"].ConnectionString;
        SqlConnection cn = new SqlConnection(conn);

        public int ID { set; get; } // 0
        public string? ProductID { set; get; } // 1
        public string? ProductName { set; get; } // 2
        public string? Type { set; get; } // 3
        public string? Stock { set; get; } // 4
        public string? Price { set; get; } // 5
        public string? Status { set; get; } // 6

        public List<CashierOrderFormProdData> availableProductsData()
        {
            List<CashierOrderFormProdData> listData = new List<CashierOrderFormProdData>();

            if (cn.State == ConnectionState.Closed)
            {
                try
                {
                    cn.Open();

                    string selectData = "SELECT * FROM products WHERE prod_status = @status AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, cn))
                    {
                        cmd.Parameters.AddWithValue("@status", "Available");

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CashierOrderFormProdData apd = new CashierOrderFormProdData();

                            apd.ID = (int)reader["id"];
                            apd.ProductID = reader["prod_id"].ToString();
                            apd.ProductName = reader["prod_name"].ToString();
                            apd.Type = reader["prod_type"].ToString();
                            apd.Stock = reader["prod_stock"].ToString();
                            apd.Price = reader["prod_price"].ToString();
                            apd.Status = reader["prod_status"].ToString();

                            listData.Add(apd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed Connection: " + ex);
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
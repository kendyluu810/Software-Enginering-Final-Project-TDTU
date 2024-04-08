using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CafeShopManagement
{
    class CashierOrdersData
    {
        static string conn = ConfigurationManager.ConnectionStrings["connectData"].ConnectionString;
        SqlConnection cn = new SqlConnection(conn);

        public int ID { set; get; }
        public int CID { set; get; }
        public string? ProdID { set; get; }
        public string? ProdName { set; get; }
        public string? ProdType { set; get; }
        public int Qty { set; get; }
        public string? Price { set; get; }

        public List<CashierOrdersData> ordersListData()
        {
            List<CashierOrdersData> listData = new List<CashierOrdersData>();
            if (cn.State == ConnectionState.Closed)
            {
                try
                {
                    cn.Open();
                    int custID = 0;
                    string selectCustData = "SELECT MAX(customer_id) FROM orders";

                    using (SqlCommand getCustData = new SqlCommand(selectCustData, cn))
                    {
                        object result = getCustData.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);

                            if (temp == 0)
                            {
                                custID = 1;
                            }
                            else
                            {
                                custID = temp;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error ID");
                        }
                    }

                    string selectOrders = "SELECT * FROM orders WHERE customer_id = @customerID";

                    using (SqlCommand cmd = new SqlCommand(selectOrders, cn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", custID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CashierOrdersData coData = new CashierOrdersData();

                            coData.ID = (int)reader["id"];
                            coData.CID = (int)reader["customer_id"];
                            coData.ProdID = reader["prod_id"].ToString();
                            coData.ProdName = reader["prod_name"].ToString();
                            coData.ProdType = reader["prod_type"].ToString();
                            coData.Qty = (int)reader["qty"];
                            coData.Price = reader["prod_price"].ToString();

                            listData.Add(coData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed: " + ex);
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
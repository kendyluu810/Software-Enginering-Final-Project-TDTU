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
    class AdminAddProductsData
    {
        static string conn = ConfigurationManager.ConnectionStrings["connectData"].ConnectionString;
        SqlConnection cn = new SqlConnection(conn);

        public int ID { get; set; }
        public string? ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? Type { get; set;}
        public string? Stock {  get; set; }
        public string? Price { get; set; }
        public string? Status {  get; set; }
        public string? Image {  get; set; }
        public string? DateInsert { get; set; }
        public string? DateUpdate { get; set;}

        public List<AdminAddProductsData> productsListData()
        {
            List<AdminAddProductsData> listData = new List<AdminAddProductsData> ();

            if(cn.State == ConnectionState.Closed)
            {
                try
                {
                    cn.Open ();
                    string selectData = "SELECT * FROM products WHERE date_delete IS NULL";
                    using (SqlCommand cm = new SqlCommand(selectData, cn))
                    {
                        SqlDataReader rd = cm.ExecuteReader();
                        while (rd.Read())
                        {
                            AdminAddProductsData ap = new AdminAddProductsData();

                            ap.ID = (int)rd["id"];
                            ap.ProductID = rd["prod_id"].ToString();
                            ap.ProductName = rd["prod_name"].ToString();
                            ap.Type = rd["prod_type"].ToString();
                            ap.Stock= rd["prod_stock"].ToString();
                            ap.Price = rd["prod_price"].ToString();
                            ap.Status = rd["prod_status"].ToString();
                            ap.Image = rd["prod_image"].ToString ();
                            ap.DateInsert = rd["date_insert"].ToString ();
                            ap.DateUpdate = rd["date_update"].ToString();

                            listData.Add(ap);
                        }
                        rd.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed connection: " + ex);
                }
                finally
                {
                    cn.Close ();
                }
            }
            return listData;
        }

        public List<AdminAddProductsData> availableProductsData()
        {
            List<AdminAddProductsData> listData = new List<AdminAddProductsData>();

            if(cn.State== ConnectionState.Closed)
            {
                try
                {
                    cn.Open();

                    string selectData = "SELECT * FROM products WHERE status = @status";
                    using (SqlCommand cm = new SqlCommand(selectData, cn))
                    {
                        cm.Parameters.AddWithValue("@status", "Available");

                        SqlDataReader rd = cm.ExecuteReader();

                        while (rd.Read())
                        {
                            AdminAddProductsData ap = new AdminAddProductsData();

                            ap.ID = (int)rd["id"];
                            ap.ProductID = rd["prod_id"].ToString();
                            ap.ProductName = rd["prod_name"].ToString();
                            ap.Type = rd["prod_type"].ToString();
                            ap.Stock = rd["prod_stock"].ToString();
                            ap.Price = rd["prod_price"].ToString();

                            listData.Add(ap);
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine("Failed Connection: " +ex); }
                finally { cn.Close (); }
            }
        return listData;
        }

    }
}

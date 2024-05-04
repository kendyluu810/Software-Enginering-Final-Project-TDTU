using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Connection
    {

        private static SqlConnection cn;
        public static void connect()
        {
            //string s = "initial catalog = aubertcoffee; data source = LAPTOP-J1EBU71C\\SQLEXPRESS; integrated security = true";
            string s = "Data Source=KENDYL;Initial Catalog=aubertcoffee;Persist Security Info=True;User ID=sa;Password=Lkendy0911";
            cn = new SqlConnection(s);
            cn.Open();

        }

        public String GetConnection()
        {
            connect();
            return cn.ConnectionString;
        }

        public static void actionQuery(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
        }



        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }


     
        

       

    }
}

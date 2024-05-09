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
            string s = "Data Source=KENDYL;Initial Catalog=aubertshop;Persist Security Info=True;User ID=sa;Password=Lkendy0911";
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

        public static DataTable selectQuery(string sql, SqlParameter[] parameters)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}

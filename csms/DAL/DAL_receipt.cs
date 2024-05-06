using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_receipt
    {
        DTO_receipt r;

        public DAL_receipt(string receiptid, string staffid, string memid, string created_date, string payment, string totalAmount, int totalQuantity)
        {
            r = new DTO_receipt(receiptid, staffid, memid, created_date, payment, totalAmount, totalQuantity);
        }


        public void addQuery()
        {
            string query = "";
            if (r.memid == null){
                query = $"insert into receipt values ('{r.receiptid}', '{r.staffid}', null, '{r.created_date}', '{r.payment}', {r.totalAmount}, {r.totalQuantity})";

            }
            else
            {
                query = $"insert into receipt values ('{r.receiptid}', '{r.staffid}', '{r.memid}', '{r.created_date}', '{r.payment}', {r.totalAmount}, {r.totalQuantity})";

            }
            Connection.selectQuery(query);
        }

        public void updateQuery()
        {
            string s = $"UPDATE receipt SET payment_method = '{r.payment}',   total_amount = {r.totalAmount},  total_quantity = {r.totalQuantity} WHERE receipt_id = '{r.receiptid}';";
            Connection.selectQuery(s);

        }

        public void deleteQuery()
        {
            string query = "delete from receipt where receipt_id = '" + r.receiptid + "'";
            Connection.selectQuery(query);
        }

        public string getCurrentReceiptID()
        {
            string s = "select top 1 receipt_id from receipt order by receipt_id desc";
            DataTable dt = Connection.selectQuery(s);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return null;
            }
        }

        public DataTable selectQuery()
        {
            string s = "select * from receipt";
            return Connection.selectQuery(s);
        }

        public decimal GetTodayIncome()
        {
            string s = "SELECT SUM(total_amount) FROM receipt WHERE created_date >= @startDate AND created_date < @endDate";

            SqlParameter[] parameters = {
                new SqlParameter("@startDate", SqlDbType.DateTime) { Value = DateTime.Today },
                new SqlParameter("@endDate", SqlDbType.DateTime) { Value = DateTime.Today.AddDays(1) } // Next day to exclude today's midnight
            };

            DataTable dt = Connection.selectQuery(s, parameters);

            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                return Convert.ToDecimal(dt.Rows[0][0]);
            }
            else
            {
                return 0;
            }
        }
        
        public decimal GetTotalIncome()
        {
            string s = "SELECT SUM(total_amount) FROM receipt";

            DataTable dt = Connection.selectQuery(s);

            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                return Convert.ToDecimal(dt.Rows[0][0]);
            }
            else
            {
                return 0;
            }
        }

        public DataTable GetDistinctDates()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT DISTINCT CONVERT(date, created_date) AS receiptDate FROM receipt";
            dataTable = Connection.selectQuery(query);
            return dataTable;
        }

        public DataTable GetReceiptByStaffAndDate (string staffId, DateTime date)
        {
            DataTable dt = new DataTable();

            string s = "SELECT * FROM receipt WHERE staffid = @StaffId AND created_date >= @StartDate AND created_date < @EndDate";
            SqlParameter[] parameters = {
                new SqlParameter("@StaffId", SqlDbType.VarChar) { Value = staffId },
                new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = date.Date },
                new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = date.Date.AddDays(1) }
            };
            
            dt = Connection.selectQuery(s, parameters);
            return dt;
        }
    }     
}

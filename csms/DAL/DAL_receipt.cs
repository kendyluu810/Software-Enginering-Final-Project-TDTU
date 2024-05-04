using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
            string query = $"insert into receipt values ('{r.receiptid}', '{r.staffid}', '{r.memid}', '{r.created_date}', '{r.payment}', {r.totalAmount}, {r.totalQuantity})";
            Connection.selectQuery(query);
        }

        public void updateQuery()
        {
            string s = $"UPDATE receipt SET staffid = '{r.staffid}', \r\n    membership_id = '{r.memid}', \r\n    created_date = '{r.created_date}', \r\n    payment_method = '{r.payment}', \r\n    total_amount = {r.totalAmount}, \r\n    total_quantity = {r.totalQuantity}\r\nWHERE receipt_id = '{r.receiptid}';";
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



    }
}

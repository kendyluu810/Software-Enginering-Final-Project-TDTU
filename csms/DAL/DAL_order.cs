using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_order
    {

        DTO_order o;
        public DAL_order(string receiptid,string couponid, string prodID, int quantity, string price) {
            o = new DTO_order(receiptid,couponid, prodID, quantity, price);
        }

        public void addQuery()
        {
            string query = "";
            if (o.couponid == "")
            {
                query = "insert into order_dt (receipt_id,coupon_id, prod_id, product_quantity, product_newPrice) values ('" + o.receiptid + "', null,  '" + o.prodID + "', " + o.quantity + ", " + o.price + ")";

            }
            else
            {
                 query = "insert into order_dt (receipt_id,coupon_id, prod_id, product_quantity, product_newPrice) values ('" + o.receiptid + "','" + o.couponid + "',  '" + o.prodID + "', " + o.quantity + ", " + o.price + ")";

            }
            Connection.selectQuery(query); 
        }

        public void updateQuery()
        {
            string query = $"update order_dt set product_quantity = {o.quantity} " +
                  $"where receipt_id = '{o.receiptid}' and prod_id = '{o.prodID}'";
            Connection.selectQuery(query);
        }

        public void deleteQuery()
        {
            string query = $"delete from order_dt where receipt_id = '{o.receiptid}' and prod_id = '{o.prodID}'";
            Connection.selectQuery(query);
        }

        public DataTable selectQuery()
        {
            string query = $"SELECT product.prod_name as name, order_dt.product_quantity as quantity, order_dt.product_newPrice as price \r\nFROM product\r\nJOIN order_dt ON product.prod_id = order_dt.prod_id\r\nWHERE order_dt.receipt_id = '{o.receiptid}';\r\n";
            return Connection.selectQuery(query);
        }



    }
}

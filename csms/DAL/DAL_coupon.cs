using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_coupon
    {
        DTO_coupon c;

        public DAL_coupon(string couponID, string prodID, int percent )
        {
            c = new DTO_coupon(couponID, prodID, percent);
        }

        public void addQuery()
        {
            string query = "insert into coupon values ('"+ c.couponID + "', '"+ c.prodID + "', "+ c.percent + " )";
            Connection.selectQuery(query);
        }

        public void updateQuery()
        {
            string query = "update coupon set coupon_percent = "+ c.percent + " where coupon_id = '"+ c.couponID + "'";
            Connection.selectQuery(query);
        }

        public void deleteQuery()
        {
            string query = "delete from coupon where coupon_id = '" + c.couponID + "'";
            Connection.selectQuery(query);
        }
        public DataTable selectQuery()
        {
            string s = "SELECT c.coupon_id as 'Coupon ID', p.prod_name as 'Product name', c.coupon_percent as 'Discount percentage'\r\nFROM Coupon c\r\nJOIN product p ON c.prod_id = p.prod_id;";
            return Connection.selectQuery(s);
        }

        public string getCurrentProdID()
        {
            string s = "select top 1 coupon_id from coupon order by coupon_id desc";
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

        public DataTable isCouponExist(string id)
        {
            string s = "select * from coupon where prod_id = '" +id+ "'";
            return Connection.selectQuery(s);
        }

        public string getCouponID_byProdName(string prodName)
        {
            string s = "SELECT Coupon.coupon_id \r\nFROM Coupon \r\nJOIN product ON Coupon.prod_id = product.prod_id \r\nWHERE product.prod_name = '"+prodName+"';";
            DataTable dt = Connection.selectQuery(s);
            if (dt.Rows.Count == 0)
            {
                return "";
            }
            return dt.Rows[0][0].ToString();

        }

        public int getCouponPercent_byCouponID(string couponID)
        {
            string s = "select coupon_percent from coupon where prod_id = '" + couponID + "'";
            DataTable dt = Connection.selectQuery(s);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                // Handle the case when no data is returned
                // You can return a default value or throw an exception depending on your requirements
                return 0; // or throw new Exception("No data found");
            }
        }
    }
}

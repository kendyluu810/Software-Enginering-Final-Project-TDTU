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
    public class DAL_product
    {
        DTO_product p;

        public DAL_product(string prodID, string ProdName, string prodType, string prodPrice, String prodStatus, String prodImg)
        {
            p = new DTO_product(prodID, ProdName, prodType, prodPrice, prodStatus, prodImg);
        }

        public void addQuery()
        {
            string query = "insert into product values ('" + p.prodID + "', '" + p.prodName + "', '" + p.prodType + "', " + p.prodPrice + ", '" + p.prodStatus + "', '" + p.prodImg + "' )";
            Connection.selectQuery(query);
        }

        public void updateQuery()
        {
            string query = "update product set prod_name = '" + p.prodName + "', prod_type = '" + p.prodType + "', prod_price = " + p.prodPrice + ", prod_status = '" + p.prodStatus + "', prod_image = '" + p.prodImg + "' where prod_id = '" + p.prodID + "'";
            Connection.selectQuery(query);
        }

        public void deleteQuery()
        {
            string query = "delete from product where prod_id = '" + p.prodID + "'";
            Connection.selectQuery(query);
        }
        public DataTable selectQuery()
        {
            string s = "select * from product";
            return Connection.selectQuery(s);
        }

        public string getCurrentProdID()
        {
            string s = "select top 1 prod_id from product order by prod_id desc";
            return Connection.selectQuery(s).Rows[0][0].ToString();
        }

        public DataTable selectProdCoupon()
        {
            string s = "select prod_id, prod_name,prod_type,  prod_price from product";
            return Connection.selectQuery(s);

        }

        public string getProdID_by_prodName(string text)
        {
            string s = "select prod_id from product where prod_name = '" + text + "'";
            return Connection.selectQuery(s).Rows[0][0].ToString();
        }

        public DataTable GetFilteredProducts(string selectedType, string searchText)
        {
            string s = "SELECT * FROM product WHERE prod_type = '" + selectedType + "'AND prod_name LIKE '%" + searchText + "%'";
            return Connection.selectQuery(s);
        }
        
        public DataTable GetFilteredProductsByType(string selectedType)
        {
            string query = "SELECT * FROM product WHERE prod_type = @selectedType";
            SqlParameter[] parameters = {
             new SqlParameter("@selectedType", SqlDbType.NVarChar) { Value = selectedType }
    };
            return Connection.selectQuery(query, parameters);
        }

    }

}

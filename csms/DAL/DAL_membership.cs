using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL
{
    public class DAL_membership
    {
        DTO_membership m;

        public DAL_membership(string memid, string memName, string memPhonenumber, string memRank, int discount, string accu)
        {
            m = new DTO_membership(memid, memName, memPhonenumber, memRank, discount, accu);
        }

        public void addQuery()
        {
            string query = "insert into Membership values ('"+ m.memid + "', '"+ m.memName + "', '"+ m.memPhonenumber + "', '"+ m.memRank + "', "+m.discount+", "+m.accu+")";
            Connection.selectQuery(query);
        }

        public void updateQuery()
        {
            string query = "update Membership set membership_name = '"+ m.memName + "', membership_phonenumber = '"+ m.memPhonenumber + "' where membership_id = '"+ m.memid + "'";
            Connection.selectQuery(query);
        }

        public void deleteQuery()
        {
            string query = "delete from Membership where membership_id = '" + m.memid + "'";
            Connection.selectQuery(query);
        }
        public DataTable selectQuery()
        {
            string s = "select * from Membership";
            return Connection.selectQuery(s);
        }

        public string getCurrentProdID()
        {
            string s = "select top 1 membership_id from Membership order by membership_id desc";
            return Connection.selectQuery(s).Rows[0][0].ToString();
        }

        public string findMembership(string number)
        {
            string s = "select membership_id from membership where membership_phonenumber = '"+number+"'";
            DataTable dt = Connection.selectQuery(s);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt.Rows[0][0].ToString();

        }

        public string findDiscount(string memID)
        {
            string s = "select membership_discount from membership where membership_id = '" + memID + "'";
            return Connection.selectQuery(s).Rows[0][0].ToString();

        }
    }
}

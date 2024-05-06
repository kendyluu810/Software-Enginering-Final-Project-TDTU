using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_order
    {

        DAL_order p;

        public BUS_order(string receiptid,string couponid, string prodID, int quantity, string price)
        {
            p = new DAL_order(receiptid,couponid, prodID, quantity, price);
        }

        public void addQuery()
        {
            p.addQuery();
        }

        public void updateQuery()
        {
            p.updateQuery();
        }

        public void deleteQuery()
        {
            p.deleteQuery();
        }
        public void deleteQueryAll()
        {
            p.deleteQueryAll();
        }

        public DataTable selectQuery()
        {
            return p.selectQuery();
        }

    }
}

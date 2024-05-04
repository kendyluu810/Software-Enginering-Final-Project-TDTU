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
    public class BUS_coupon
    {
        DAL_coupon p;


        public BUS_coupon(string couponID, string prodID, int percent)
        {
            p = new DAL_coupon(couponID, prodID, percent);
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

        public DataTable selectQuery()
        {
            return p.selectQuery();
        }

        public string auto_generateProdID()
        {
            string currentID = p.getCurrentProdID();
            if (currentID != null)
            {
                int currentNumber = int.Parse(currentID.Substring(2)); // Extract the number part of the ID
                string nextID = "CP" + (currentNumber + 1).ToString("D4"); // Generate the next ID
                return nextID;
            }
            else
            {
                return "CP0001";
            }
        }

        public DataTable isCouponExist(string id)
        {
            return p.isCouponExist(id);
        }

        public string getCouponID_byProdName(string tbProdName)
        {
            return p.getCouponID_byProdName(tbProdName);
        }

        public int getCouponPercent_byCouponID(string couponID)
        {
            return p.getCouponPercent_byCouponID(couponID);
        }
    }
}

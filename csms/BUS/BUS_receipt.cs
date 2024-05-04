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
    public class BUS_receipt
    {
        DAL_receipt p;

        public BUS_receipt(string receiptid, string staffid,  string memid, string created_date, string payment, string totalAmount, int totalQuantity)
        {
            p = new DAL_receipt(receiptid, staffid,  memid, created_date, payment, totalAmount, totalQuantity);
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

        public string auto_generateReceiptID()
        {
            string currentID = p.getCurrentReceiptID();
            if (currentID != null)
            {
                int currentNumber = int.Parse(currentID.Substring(2)); // Extract the number part of the ID
                string nextID = "R" + (currentNumber + 1).ToString("D5"); // Generate the next ID
                return nextID;
            }
            else
            {
                return "R00001";
            }
        }
    }
}

using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BUS
{
    public class BUS_membership
    {
        DAL_membership p;

        public BUS_membership(string memid, string memName, string memPhonenumber, string memRank, int discount, string accu)
        {
            p = new DAL_membership(memid, memName, memPhonenumber, memRank, discount, accu);
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
                string nextID = "M" + (currentNumber + 1).ToString("D5"); // Generate the next ID
                return nextID;
            }
            else
            {
                return "M00001";
            }
        }

        public string findMembership(string number)
        {
            return p.findMembership(number);
        }

        public string findDiscount(string memID)
        {
            return p.findDiscount(memID);
        }
    }
}

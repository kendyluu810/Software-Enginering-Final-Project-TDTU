using DAL;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUS_account
    {
        DAL_account s;
        public BUS_account(string username, string password, string active, string staffid)
        {
            s = new DAL_account(username, password, active, staffid);
        }

        public void addQuery()
        {
            s.addQuery();
        }

        public void updateQuery()
        {
            s.updateQuery();
        }

        public void deleteQuery()
        {
            s.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return s.selectQuery();
        }

        public bool Login(string username, string password)
        {
            return s.ValidateLogin(username, password);
        }

        public string GetUserRole(string username)
        {
            return s.GetUserRole(username);
        }



    }
}

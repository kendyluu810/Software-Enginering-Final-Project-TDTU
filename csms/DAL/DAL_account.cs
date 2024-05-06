using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL
{
    public class DAL_account
    {
        DTO_account p;

        public DAL_account(string username, string password,string active,  string staffid)
        {
            p = new DTO_account(username, password, active, staffid);
        }

        public void addQuery()
        {
            string query = "insert into ACCOUNT values ('"+ p.username + "','"+ p.password + "','"+p.active+"', '"+ p.staffid + "')";
            Connection.selectQuery(query);
        }


        public void updateQuery()
        {
            string query = $"update ACCOUNT set  password = '{p.password}', status = '{p.active}' where staffid = '"+p.staffid+"'";
            Connection.selectQuery(query);
        }

        public void deleteQuery()
        {
            string query = "delete from ACCOUNT where username = '" + p.username + "'";
            Connection.selectQuery(query);
        }
        public DataTable selectQuery()
        {
            string s = "select * from ACCOUNT";
            return Connection.selectQuery(s);
        }



        public bool ValidateLogin(string username, string password)
        {
            string selectAccount = "SELECT * FROM ACCOUNT WHERE username = '"+username+"' AND password = '"+password+"'"; // Count rows
            DataTable selectedAccount =  Connection.selectQuery(selectAccount); //selectQuery return datatable
            return selectedAccount.Rows.Count > 0;
        }

        
        private string getStaffid(string username)
        {
            string selectAccount = "SELECT STAFFID FROM ACCOUNT WHERE username = '" + username + "'";
            DataTable selectedAccount = Connection.selectQuery(selectAccount); //selectQuery return datatable
            if(selectedAccount == null)
            {
                return "";
            }
            else
            {
                return selectedAccount.Rows[0][0].ToString();
            }
           
        }
        public string GetUserRole(string username)
        {
            string staffid = getStaffid(username);
            string selectRole = "SELECT * FROM Staff WHERE staffid = '" + staffid + "'";

            DataTable dt = Connection.selectQuery(selectRole);

            if (dt != null)
            {
                return dt.Rows[0][3].ToString(); 
            }
            else
            {
                return null; 
            }
        }

        public string getUserStatus(string tbUser)
        {
            string s = $"select status from account where username = '{tbUser}'";
            return Connection.selectQuery(s).Rows[0][0].ToString();
        }
    }
}

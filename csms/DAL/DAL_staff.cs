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
    public class DAL_staff
    {
        DTO_staff p;

        public DAL_staff(string staffid, string fullname, string role, string dob, string gender, string phonenumber, string profile_img)
        {
            p = new DTO_staff(staffid, fullname, role, dob, gender, phonenumber, profile_img);
        }

        public void addQuery()
        {
            string query = "insert into STAFF values ('"+ p.staffid + "', '"+ p.fullname + "',  '"+ p.dob + "', '"+ p.role + "','"+p.gender+"',  '"+ p.profile_img + "','"+p.phonenumber + "')";
            Connection.selectQuery(query);
        }


        public void updateQuery()
        {
            string query = "update STAFF set FULLNAME = '"+ p.fullname + "', ROLE = '"+ p.role + "', DOB = '"+ p.dob + "', GENDER = '"+ p.gender + "', PROFILE_IMAGE = '"+ p.profile_img + "', phonenumber = '" + p.phonenumber + "' where staffid = '"+p.staffid+"'";
            Connection.selectQuery(query);
        }

        public void deleteQuery()
        {
            string query = "delete from STAFF where Staffid = '" + p.staffid + "'";
            Connection.selectQuery(query);
        }
        public DataTable selectQuery()
        {
            string s = "select * from STAFF";
            return Connection.selectQuery(s);
        }

    

        public string getCurrentStaffID()
        {
            string s = "select top 1 staffid from staff order by staffid desc";
            return Connection.selectQuery(s).Rows[0][0].ToString();
        }

        public DataTable selectStaff()
        {
            string s = "\r\nSELECT s.staffid, s.fullname, s.dob, s.role, s.gender, s.profile_image, s.phonenumber,\r\n       a.username, a.password, a.status\r\nFROM staff s\r\nLEFT JOIN account a ON s.staffid = a.staffid;";
            return Connection.selectQuery(s);
        }

        public string getStaffname(string username)
        {
            string s = $"SELECT s.fullname\r\nFROM staff s\r\nJOIN account a ON s.staffid = a.staffid\r\nWHERE a.username = '{username}';";
            return Connection.selectQuery(s).Rows[0][0].ToString();
        }
        public string getStaffid(string username)
        {
            string s = $"select staffid from account where username = '{username}'";
            return Connection.selectQuery(s).Rows[0][0].ToString();
        }

        public int getTotalStaff()
        {
            string s = "SELECT COUNT(*) FROM staff";
            DataTable dt = Connection.selectQuery(s);

            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            else
            {
                return 0;
            }
        }

        public DataTable GetStaffIds()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT staffid FROM staff";
            dataTable = Connection.selectQuery(query);
            return dataTable;
        }

    }
}

using DAL;
using DTO;
using System.Data;
using System.Xml.Linq;

namespace BUS
{
    public class BUS_STAFF
    {
        DAL_staff s;
        public BUS_STAFF(string staffid, string fullname, string role, string dob, string gender, string phonenumber, string profile_img)
        {
            s = new DAL_staff(staffid, fullname, role, dob, gender, phonenumber, profile_img);
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

        public string auto_generateStaffID()
        {
            string currentID = s.getCurrentStaffID();
            if (currentID != null)
            {
                int currentNumber = int.Parse(currentID.Substring(2)); // Extract the number part of the ID
                string nextID = "ST" + (currentNumber + 1).ToString("D3"); // Generate the next ID
                return nextID;
            }
            else
            {
                return "ST001";
            }
        }

        public DataTable selectStaff()
        {
            return s.selectStaff();
        }



        public string getImagePath(string imageLocation, string username)
        {
            string path = Path.Combine(@"..\..\..\..\User_Directory\", username + ".png");

            
            File.Copy(imageLocation, path , true);

            return path;

        }

        public string getStaffid(string username)
        {
           return s.getStaffid(username);
        }

        public int getTotalStaff()
        {
            return s.getTotalStaff();
        }

        public DataTable GetStaffIds()
        {
            return s.GetStaffIds();
        }
    }
}

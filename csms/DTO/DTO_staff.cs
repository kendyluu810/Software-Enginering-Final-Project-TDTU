using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class DTO_staff
    {
        public string staffid { get; set; }
        public string fullname { get; set; }
        public string role { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }
        public string phonenumber { get; set; }
        public string profile_img { get; set; }

        public DTO_staff(string staffid, string fullname, string role, string dob, string gender, string phonenumber, string profile_img)
        {
            this.staffid = staffid;
            this.fullname = fullname;
            this.role = role;
            this.gender = gender;
            this.dob = dob;
            this.gender = gender;
            this.phonenumber = phonenumber;
            this.profile_img = profile_img;
        }

    }
}

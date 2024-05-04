using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DTO
{


    public class DTO_account
    {
        public string username { get; set; }
        public string password { get; set; }
        public string active { get; set; }
        public string staffid { get; set; }


        public DTO_account(string username, string password, string active,  string staffid)
        {
            this.username = username;
            this.password = password;
            this.active = active;
            this.staffid = staffid;
        }

      
    }

}

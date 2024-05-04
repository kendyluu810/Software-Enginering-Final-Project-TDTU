using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_membership
    {
    //membership_id varchar(10) primary key,
    //membership_name varchar(255), 
	//membership_phonenumber varchar(13), 
	//membership_rank varchar(10)

        public string memid { get; set; }
        public string memName { get; set; }
        public string  memPhonenumber { get; set; }
        public string memRank { get; set; }
        public int discount { get; set; }
        public string accu { get; set; }
        public DTO_membership(string memid, string memName, string memPhonenumber, string memRank, int discount, string accu)
        {
            this.memid = memid;
            this.memName = memName;
            this.memPhonenumber = memPhonenumber;
            this.memRank = memRank;
            this.discount = discount;
            this.accu = accu;
        }

    }
}

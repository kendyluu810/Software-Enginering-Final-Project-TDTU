using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_coupon
    {
        public string couponID { get; set; }
        public string prodID { get; set; }
        public int percent {  get; set; }
        public DTO_coupon(string couponID, string prodID, int percent) { 
            this.couponID = couponID;
            this.prodID = prodID;
            this.percent = percent;
        }

    }
}

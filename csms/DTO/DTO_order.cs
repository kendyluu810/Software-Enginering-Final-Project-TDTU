using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_order
    {
        public string receiptid { get; set; }
        public string couponid { get; set; }
        public string prodID { get; set;}
        public int quantity { get; set;}
        public string price { get; set;}

        public DTO_order(string receiptid, string couponid, string prodID,int quantity, string price)
        {
            this.receiptid = receiptid;
            this.couponid = couponid;
            this.prodID = prodID;
            this.quantity = quantity;
            this.price = price;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_receipt
    {
        public string receiptid { get; set; }
        public string staffid { get; set; }
        public string memid { get; set; }
        public string created_date { get; set; }
        public string payment { get; set; }
        public string totalAmount {  get; set; }
        public int totalQuantity {  get; set; }

        public DTO_receipt(string receiptid, string staffid, string memid, string created_date, string payment, string totalAmount, int totalQuantity)
        {
            this.receiptid = receiptid;
            this.staffid = staffid;
            this.memid = memid;
            this.created_date = created_date;
            this.payment = payment;
            this.totalAmount = totalAmount;
            this.totalQuantity = totalQuantity;
        }

    
    }
}

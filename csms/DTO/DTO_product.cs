using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_product
    {
        public string prodID { get; set; }
        public string prodName { get; set; }
        public string prodType { get; set; }
        public string prodPrice { get; set; }
        public string prodStatus { get; set; }
        public string prodImg { get; set; }
        public DTO_product(string prodID, string ProdName, string prodType, string prodPrice, String prodStatus, String prodImg) {
            this.prodID = prodID;
            this.prodName = ProdName;
            this.prodType = prodType;
            this.prodPrice = prodPrice;
            this.prodStatus = prodStatus;
            this.prodImg = prodImg;
        }
    }
}

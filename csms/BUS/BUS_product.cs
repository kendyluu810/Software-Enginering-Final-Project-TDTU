using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_product
    {
        DAL_product p;
        public BUS_product(string prodID, string ProdName, string prodType,  string prodPrice, String prodStatus, String prodImg)
        {
            p = new DAL_product(prodID, ProdName, prodType,  prodPrice, prodStatus, prodImg);
        }

        public void addQuery()
        {
            p.addQuery();
        }

        public void updateQuery()
        {
            p.updateQuery();
        }

        public void deleteQuery()
        {
            p.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return p.selectQuery();
        }

        public string auto_generateProdID()
        {
            string currentID = p.getCurrentProdID();
            if (currentID != null)
            {
                int currentNumber = int.Parse(currentID.Substring(2)); // Extract the number part of the ID
                string nextID = "PD" + (currentNumber + 1).ToString("D3"); // Generate the next ID
                return nextID;
            }
            else
            {
                return "PD001";
            }
        }

        public DataTable FilterProducts(string selectedType, string searchText)
        {
            return p.GetFilteredProducts(selectedType, searchText);
        }

        public DataTable FilterProductsByType(string selectedType)
        {
            return p.GetFilteredProductsByType(selectedType);
        }


        public string getImagePath(string imageLocation, string prodName)
        {
            string path = Path.Combine(@"..\..\..\..\Product_Directory\" + prodName + ".png");

            File.Copy(imageLocation, path, true);

            return path;
        }

        public DataTable selectProdCoupon()
        {
           return p.selectProdCoupon();
        }

        public string getProdID_by_prodName(string text)
        {
            return p.getProdID_by_prodName(text);
        }

    }
}

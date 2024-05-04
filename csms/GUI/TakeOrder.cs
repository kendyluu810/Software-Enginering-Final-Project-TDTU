using BUS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TakeOrder : Form
    {
        private string username;
        private string rid; //receipt id
        private float totalAmount;
        public TakeOrder(string username)
        {
            this.username = username;
            InitializeComponent();
            refreshData();
        }



        //------------------------utilities------------------------
        public void cbLoading()
        {
            //Type
            SearchCbType.Items.Add("Coffee");
            SearchCbType.Items.Add("Tea");
            SearchCbType.Items.Add("Cold Brew");
        }


        private bool isEmpty()
        {
            return false;
        }

        private void refreshGRD()
        {
            showGRD();
        }

        private void showGRD()
        {
            BUS_product b = new BUS_product("", "", "", 0, "0", "", "");
            grdProd.DataSource = b.selectQuery();

         
        }

        private void showGRD_order()
        {
            BUS_order order = new BUS_order(rid, "", "", 0, "");
            grdOrder.DataSource = order.selectQuery();
        }



        internal void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            showGRD();
            gbProd.Enabled = false;
            btnCreate_order.Enabled = true;
            cbLoading();
            btnAdd.Enabled = false;
            btnClear.Enabled = false;
            btnDel.Enabled = false;
            btnPrint.Enabled = false;
            tbDiscount.Enabled = false;
        }



        //------------------------data grid view handling------------------------

        private void grdProd_CellClick(object sender, DataGridViewCellEventArgs e) //product info
        {

            //grid view
            tbProdName.Text = grdProd.CurrentRow.Cells[1].Value.ToString();
            tbPrice.Text = grdProd.CurrentRow.Cells[4].Value.ToString();

            //--img
            string imagePath = grdProd.CurrentRow.Cells[6].Value.ToString();
            if (imagePath != "")
            {
                ProdIMG.Image = System.Drawing.Image.FromFile(imagePath);
            }
            else
            {
                ProdIMG.Image = null;
            }
        }


        private void grdOrder_CellClick(object sender, DataGridViewCellEventArgs e) //order info
        {

        }


        //------------------------button handling------------------------

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float price = float.Parse(tbPrice.Text);
            string name = tbProdName.Text;
            int quanity = Convert.ToInt32(tbQuantity.Value);

            //get prodID by prodname
            BUS_product b = new BUS_product("", "", "", 0, "0", "", "");
            string prodID = b.getProdID_by_prodName(name);
            //get coupon id by product name
            BUS_coupon coupon = new BUS_coupon("", "", 0);
            string couponID = coupon.getCouponID_byProdName(name);
            string finalPrice = "";
            if (couponID != "")
            {
                int couponPercent = coupon.getCouponPercent_byCouponID(couponID);
                float coupon_price = (couponPercent / 100) * price + price; 
                finalPrice = (coupon_price*quanity).ToString().Replace(",", ".");
            }
            else
            {

                finalPrice = (price*quanity).ToString().Replace(",", ".");
            }
            

            BUS_order newOrder = new BUS_order(rid, couponID, prodID, quanity , finalPrice );
            newOrder.addQuery();

            totalAmount += float.Parse(finalPrice);
            totalmoney.Text = "$" + totalAmount.ToString();

            showGRD_order();

        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbProdName.Text = "";
            tbPrice.Text = "";
            tbQuantity.Value = 0;
        }


        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_order_Click(object sender, EventArgs e)
        {

            string memID = ""; //customer phone number

            BUS_membership m = new BUS_membership("", "", "", "", 0, "");
            memID = m.findMembership(tbMem.Text); //finding membership customer by numberphone
            if (memID == null)
            {
                MessageBox.Show("This phone number hasn’t been registered yet!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(memID == "0")
            {
                tbDiscount.Text = "0";
            }
            else
            {
                tbDiscount.Text = m.findDiscount(memID);
            }
           

            //get staff name by username
            BUS_STAFF b = new BUS_STAFF("", "", "", "", "", "", "");
            string staffid = b.getStaffid(username);
            //get date
            DateTime currentDateTime = DateTime.Now;

            string format_Datetime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            //create a receipt
            BUS_receipt r = new BUS_receipt("", "", "", "", "", "0.0", 0);
            rid = r.auto_generateReceiptID();
           

            BUS_receipt receipt = new BUS_receipt(rid, staffid, memID, format_Datetime, "", "0.0", 0);
            receipt.addQuery();

            tbMem.Enabled = false;
            gbProd.Enabled = true;
            btnAdd.Enabled = true;
            btnClear.Enabled = true;
            btnDel.Enabled = true;
            tbProdName.Enabled = false;
            tbPrice.Enabled = false;
            btnCreate_order.Enabled = false;
            showGRD_order();
        }


        //Searching
        private void btnShowAll_Click(object sender, EventArgs e)
        {

        }
        //searching for membership customer numberphone

        
     
    }
}

using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GUI
{
    public partial class coupon : Form
    {

        private string choosenProduct_ID = "";
        private int dk = 0;
        public coupon()
        {
            InitializeComponent();
        }

        internal void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            refreshGRD();
            //    cbLoading();
        }

        private void clearField()
        {
            tbID.Text = "";
            tbName.Text = "";
            tbDiscount.Text = "";
        }

        private void refreshGRD()
        {
            showGRD();
            gb1.Enabled = false;
            btnSave.Enabled = false;
            btnDel.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;

        }

        //------data grid view
        public void showGRD()
        {
            BUS_product b = new BUS_product("", "", "", 0, "0", "", "");
            grdProd.DataSource = b.selectProdCoupon();

            BUS_coupon c = new BUS_coupon("", "", 0);
            grdCoupon.DataSource = c.selectQuery();
        }


        private void grdProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearField();
            btnAdd.Enabled = true;
            tbName.Text = grdProd.CurrentRow.Cells[1].Value.ToString();
            choosenProduct_ID = grdProd.CurrentRow.Cells[0].Value.ToString();
        }
        private void grdCoupon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnDel.Enabled = true;
            btnEdit.Enabled = true;

            tbID.Text = grdCoupon.CurrentRow.Cells[0].Value.ToString();
            tbName.Text = grdCoupon.CurrentRow.Cells[1].Value.ToString();
            tbDiscount.Text = grdCoupon.CurrentRow.Cells[2].Value.ToString();
        }

        //button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            gb1.Enabled = true;
            tbID.Enabled = false;
            tbName.Enabled = false;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            tbDiscount.Focus();
            tbDiscount.Enabled = true;
            BUS_coupon c = new BUS_coupon("", "", 0);
            tbID.Text = c.auto_generateProdID();
            dk = 1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            gb1.Enabled = true;
            tbID.Enabled = false;
            btnEdit.Enabled = false;
            tbName.Enabled = false;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;
            tbDiscount.Focus();
            tbDiscount.Enabled = true;
            dk = 2;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this coupon?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BUS_coupon c = new BUS_coupon(tbID.Text, "", 0);
                c.deleteQuery();
                MessageBox.Show("Delete Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshGRD();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            BUS_coupon c = new BUS_coupon("", "", 0);
            BUS_product b = new BUS_product("", "", "", 0, "0", "", "");

            string id = tbID.Text;
            string prodID = b.getProdID_by_prodName(tbName.Text) ;
            int discount = int.Parse(tbDiscount.Text);
            if(discount > 100)
            {
                MessageBox.Show("Discount must less than 100%", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDiscount.Text = "";
                tbDiscount.Focus();
                return;

            }

            if (c.isCouponExist(prodID).Rows.Count > 0) 
            {
                MessageBox.Show("This product has coupon already!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDiscount.Text = "";
                tbID.Text = "";
                tbName.Text = "";
                refreshData();
                return;
            }
            if (tbDiscount.Text == "")
            {
                MessageBox.Show("Discount percentage fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dk == 1)
                {
                    //add
                    BUS_coupon add = new BUS_coupon(id, prodID, discount);
                    add.addQuery();
                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (dk == 2)
                {

                    //update product 
                    BUS_coupon update = new BUS_coupon(id, prodID, discount); 
                    update.updateQuery();
                    MessageBox.Show("Update Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            refreshGRD();

            dk = 0;
        }

    
    }
}

using BUS;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class membership : Form
    {
        public membership()
        {
            InitializeComponent();
        }

        private int dk = 0;

        private void membership_Load(object sender, EventArgs e)
        {

        }


        //------------------------utilities------------------------
        public void cbLoading()
        {
            //Type
        }


        private bool isEmpty()
        {
            if (tbName.Text == "" || tbPhonenumber.Text == "")
            {
                return true;
            }
            return false;
        }

        private void refreshGRD()
        {
            showGRD();
        }



        internal void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            showGRD();
            gb1.Enabled = false;
            btnSave.Enabled = false;
            btnDel.Enabled = false;
            btnClear.Enabled = false;

            cbLoading();
        }

        private void clearFields()
        {
            tbID.Text = "";
            tbName.Text = "";
            tbPhonenumber.Text = "";
            tbRank.Text = "";
            tbDiscount.Text = "";
            tbAccu.Text = "";
        }

        //------------------------data grid view handling------------------------
        private void showGRD()
        {
            BUS_membership m = new BUS_membership("", "", "", "", 0, "0");
            grd.DataSource = m.selectQuery();
        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = grd.CurrentRow.Cells[0].Value.ToString();
            tbName.Text = grd.CurrentRow.Cells[1].Value.ToString();
            tbPhonenumber.Text = grd.CurrentRow.Cells[2].Value.ToString();
            tbRank.Text = grd.CurrentRow.Cells[3].Value.ToString();
            tbDiscount.Text = grd.CurrentRow.Cells[4].Value.ToString();
            tbAccu.Text = grd.CurrentRow.Cells[5].Value.ToString();

            gb1.Enabled = false;
            btnAdd.Enabled = true;
            btnClear.Enabled = false;
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }

        //------------------------button handling------------------------

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            BUS_membership m = new BUS_membership("", "", "", "", 0, "0");

            gb1.Enabled = true;
            tbID.Enabled = false;
            tbDiscount.Enabled = false;
            tbAccu.Enabled = false;
            tbRank.Enabled = false;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;

            //First innitializing
            clearFields();
            tbID.Text = m.auto_generateProdID();
            tbRank.Text = "Bronze";
            tbDiscount.Text = "2";
            tbAccu.Text = "0";

            tbName.Focus();
            dk = 1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gb1.Enabled = true;
            tbID.Enabled = false;
            tbDiscount.Enabled = false;
            tbAccu.Enabled = false;
            tbRank.Enabled = false;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnClear.Enabled = true;

            tbName.Focus();
            dk = 2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbPhonenumber.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Are you sure you want to delete " + tbName.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BUS_membership m = new BUS_membership(tbID.Text, "", "", "", 0, "0");
                m.deleteQuery();
                MessageBox.Show("Delete Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            refreshGRD();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BUS_membership m = new BUS_membership(tbID.Text, "", "", "", 0, "0");
            string id = tbID.Text;
            string name = tbName.Text;
            string phonenumber = tbPhonenumber.Text;
            string rank = tbRank.Text;
            string accu = tbAccu.Text;
            int discount = int.Parse(tbDiscount.Text);
            if (isEmpty())
            {
                MessageBox.Show("Membership information fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dk == 1)
                {
                    //add
                    BUS_membership addMembership = new BUS_membership(id, name, phonenumber, rank, discount, accu);
                    addMembership.addQuery();
                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (dk == 2)
                {

                    //update product 
                    BUS_membership updateMembership = new BUS_membership(id, name, phonenumber, rank, discount, accu);
                    updateMembership.updateQuery();
                    MessageBox.Show("Update Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            refreshGRD();

            dk = 0;
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (grd.Rows.Count - 1 > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "MembershipInfomation.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(grd.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            //add column
                            foreach (DataGridViewColumn column in grd.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            //add value
                            for (int i = 0; i < grd.Rows.Count - 1; ++i)
                            {
                                for (int j = 0; j < grd.Columns.Count; ++j)
                                {
                                    // string s = grd.Rows[i].Cells[j].Value.ToString();
                                    pdfTable.AddCell(grd.Rows[i].Cells[j].Value.ToString());

                                }
                            }

                            /*
                            foreach (DataGridViewRow row in grd.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }
                            */
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                            // Application.Run(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}

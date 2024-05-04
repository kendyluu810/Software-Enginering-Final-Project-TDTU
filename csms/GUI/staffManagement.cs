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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace GUI
{
    public partial class staffManagement : Form
    {
        public staffManagement()
        {
            InitializeComponent();
        }

        private int dk = 0;

        public void clearFields()
        {
            tbFullname.Text = "";
            tbPassword.Text = "";
            tbPhonenumber.Text = "";
            tbUsername.Text = "";
            cbGender.SelectedIndex = -1;
            cbRole.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            dob.Text = string.Empty;
            userIMG.Image = null;



        }

        public bool isEmpty()
        {
            if (
            tbFullname.Text == "" ||
            tbStaffID.Text == "" ||
            tbPhonenumber.Text == "" ||
            cbGender.SelectedIndex == -1 ||
            cbRole.SelectedIndex == -1 ||
            dob.Text == string.Empty
            ) { return true; }
            return false;

        }



        private void staffManagement_Load(object sender, EventArgs e)
        {

        }

        private void showGRD()
        {
            BUS_STAFF b = new BUS_STAFF("", "", "", "", "", "", "");
            grd.DataSource = b.selectStaff();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string staffid = tbStaffID.Text;
            string fullname = tbFullname.Text;
            string role = cbRole.SelectedIndex != -1 ? cbRole.SelectedItem.ToString() : "";
            string gender = cbGender.SelectedIndex != -1 ? cbGender.SelectedItem.ToString() : "";
            string DOB = dob.Value.ToString("yyyy-MM-dd");
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string phonenumber = tbPhonenumber.Text;
            string status = cbStatus.SelectedIndex != -1 ? cbStatus.SelectedItem.ToString() : "";
            BUS_STAFF b = new BUS_STAFF("", "", "", "", "", "", "");
            string img = "";
            if (userIMG.ImageLocation != null)
            {
                img = b.getImagePath(userIMG.ImageLocation, username.Trim());

            }

            if (isEmpty())
            {
                MessageBox.Show("Staff information fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dk == 1)
                {


                    //add staff to database
                    BUS_STAFF addStaff = new BUS_STAFF(staffid, fullname, role, DOB, gender, phonenumber, img);
                    addStaff.addQuery();
                    if (username != "" && (role == "Manager" || role == "Cashier"))
                    {
                        //add account to database
                        BUS_account addAcc = new BUS_account(username, password, status, staffid);


                        addAcc.addQuery();
                    }
                    else if (username != "" && (role != "Manager" && role != "Cashier"))
                    {
                        MessageBox.Show("Cannot add account for this role !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (dk == 2)
                {

                    //add update to database
                    BUS_STAFF updateStaff = new BUS_STAFF(staffid, fullname, role, DOB, gender, phonenumber, img);
                    updateStaff.updateQuery();
                    if (username != "" && (role == "Manager" || role == "Cashier"))
                    {
                        //add account to database
                        BUS_account updateAccount = new BUS_account(username, password, status, staffid);


                        updateAccount.updateQuery();
                    }
                    else if (username != "" && (role != "Manager" && role != "Cashier"))
                    {
                        MessageBox.Show("Cannot update account for this role !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }


                    MessageBox.Show("Update Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            refreshGRD();

            dk = 0;

        }

        private void gbStaffInfo_Enter(object sender, EventArgs e)
        {

        }
        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }
        internal void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            showGRD();
            cbLoading();
            enable(gbStaffInfo, false);
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void refreshGRD()
        {
            showGRD();
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
        }

        public void cbLoading()
        {
            //role
            cbRole.Items.Add("Manager"); //0
            cbRole.Items.Add("Cashier"); //1
            cbRole.Items.Add("Waiter"); //2
            cbRole.Items.Add("Securiry"); //3
            cbRole.Items.Add("Bartender"); //4


            //gender
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");

            //status 
            cbStatus.Items.Add("Active");
            cbStatus.Items.Add("Deactive");


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearFields();
            btnAdd.Enabled = false;
            BUS_STAFF b = new BUS_STAFF("", "", "", "", "", "", "");
            tbStaffID.Text = b.auto_generateStaffID();
            btnSave.Enabled = true;
            enable(gbStaffInfo, true);
            tbStaffID.Enabled = false;
            tbFullname.Focus();
            btnClear.Enabled = true;
            dk = 1;
        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enable(gbStaffInfo, false);
            btnAdd.Enabled = true;
            btnClear.Enabled = false;
            tbStaffID.Text = grd.CurrentRow.Cells[0].Value.ToString();
            tbFullname.Text = grd.CurrentRow.Cells[1].Value.ToString();
            dob.Text = grd.CurrentRow.Cells[2].Value.ToString();
            cbRole.Text = grd.CurrentRow.Cells[3].Value.ToString();
            cbGender.Text = grd.CurrentRow.Cells[4].Value.ToString();
            tbPhonenumber.Text = grd.CurrentRow.Cells[6].Value.ToString();
            tbUsername.Text = grd.CurrentRow.Cells[7].Value.ToString();
            tbPassword.Text = grd.CurrentRow.Cells[8].Value.ToString();
            cbStatus.Text = grd.CurrentRow.Cells[9].Value.ToString();
            //img
            string imagePath = grd.CurrentRow.Cells[5].Value.ToString();


            if (imagePath != "")
            {
                userIMG.Image = System.Drawing.Image.FromFile(imagePath);
            }
            else
            {
                userIMG.Image = null;
            }


            btnDel.Enabled = true;
            btnEdit.Enabled = true;

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image FIles(*.jpg; *.png|*.jpg;*.png)";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    userIMG.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            enable(gbStaffInfo, true);
            btnSave.Enabled = true;
            tbStaffID.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            dk = 2;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete username: " + tbUsername.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BUS_STAFF staff = new BUS_STAFF(tbStaffID.Text, "", "", "", "", "", "");
                BUS_account account = new BUS_account(tbUsername.Text, "", "", "");

                account.deleteQuery();
                staff.deleteQuery();
                MessageBox.Show("Delete Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            refreshGRD();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (grd.Rows.Count - 1 > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "StaffInfomation.pdf";
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

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


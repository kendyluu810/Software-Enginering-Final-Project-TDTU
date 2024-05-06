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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class SignUp : Form
    {



        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            tbPass.PasswordChar = ckbShowPass.Checked ? '\0' : '*';
            tbCP.PasswordChar = ckbShowPass.Checked ? '\0' : '*';
        }
        public bool emptyFields()
        {
            if (tbFullname.Text == "" || cbRole.SelectedIndex == -1 || cbGender.SelectedIndex == -1 || tbPhoneNumber.Text == "" || tbUsername.Text == "" || tbCP.Text == "" || tbCP.Text == "") return true;
            return false;
        }

        public bool isOver18()
        {
            if ((DateTime.Now.Year - dob.Value.Year) < 16)
            {
                return false;
            }

            return true;
        }


        public void cbLoading()
        {
            //role
            cbRole.Items.Add("Manager");
            cbRole.Items.Add("Cashier");

            //gender
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isOver18() == false)
            {
                MessageBox.Show("You must over 16 to sign up the system.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dob.Focus();
            }
            else
            {
                //declare variable
                string fullname = tbFullname.Text;
                string role = cbRole.SelectedIndex != -1 ? cbRole.SelectedItem.ToString() : "";
                string gender = cbGender.SelectedIndex != -1 ? cbGender.SelectedItem.ToString() : "";
                string DOB = dob.Value.ToString("yyyy-MM-dd");

                string active = "Deactive";
                string phone = tbPhoneNumber.Text;
                string username = tbUsername.Text;
                string password = tbCP.Text;
                BUS_STAFF s = new BUS_STAFF("", "", "", "", "", "", "");
                string staffid = s.auto_generateStaffID();

                BUS_account account = new BUS_account(username, password, active, staffid);
                BUS_STAFF staff = new BUS_STAFF(staffid, fullname, role, DOB, gender, phone, "");

                //add to database
                staff.addQuery();
                account.addQuery();

                //comeback to login
                Login login = new Login();
                login.Show();
                this.Hide();

            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            cbLoading();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using BUS;
using GUI;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      

        public bool emptyFields()
        {
            if (tbUser.Text == "" || tbPass.Text == "") return true;
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BUS_account b = new BUS_account("", "", "", "");
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
              
                
                // Call Business Logic Layer method for login
                if (b.Login(tbUser.Text.Trim(), tbPass.Text.Trim()))
                {   // Successful Login - Show relevant form based on user role

                    string accStatus = b.getUserStatus(tbUser.Text);
                    if(accStatus == "Active")
                    {
                        string userRole = b.GetUserRole(tbUser.Text.Trim());
                        ShowMainForm(userRole, tbUser.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("This account doesn't have authorization to access the program!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password / there's no Admin approval", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Helper methods to show appropriate forms based on role
        private void ShowMainForm(string userRole, string username)
        {
            if (userRole == "Manager")
            {
                MainForm mainForm = new MainForm(username);
                mainForm.Show();
                this.Hide();
            }
            else if (userRole == "Cashier")
            {
                CashierMainform cashierMainForm = new CashierMainform(username); //tbUser.Text.Trim()
                cashierMainForm.Show();
                this.Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
            this.Hide();
        }

        private void ckbShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            tbPass.PasswordChar = ckbShowPass.Checked ? '\0' : '*';
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopManagement
{
    public partial class CashierMainForm : Form
    {
        private CashierOrderForm cashierOrderForm;
        public CashierMainForm()
        {
            InitializeComponent();
            cashierOrderForm = new CashierOrderForm();
                ShowFormInPanel(cashierOrderForm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation Messgae", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Hide();
            }
        }

        private void ShowFormInPanel(Form formToShow)
        {
            panel2.Controls.Clear();
            formToShow.TopLevel = false;
            formToShow.Dock = DockStyle.Fill;
            panel2.Controls.Add(formToShow);
            formToShow.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(cashierOrderForm);
        }
    }
}

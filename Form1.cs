using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingManagement
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.Show();
        }
        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewCustomer view = new frmViewCustomer();
            view.Show();
        }
        private void openAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount account = new frmAccount();
            account.Show();
        }
        private void viewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewAccount account = new frmViewAccount();
            account.Show();
        }
        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeposit deposit = new frmDeposit();
            deposit.Show();
        }
        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWithdraw obj = new frmWithdraw();
            obj.Show();
        }
        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransfer obj = new FrmTransfer();
            obj.Show();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBalanceReport obj = new frmBalanceReport();
            obj.Show();
        }

        private void transactionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactionReport obj = new frmTransactionReport();
            obj.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Are you sure you want to Logout?",
       "Logout",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmLogin obj = new frmLogin();
                obj.Show();

                this.Hide();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer obj = new frmCustomer();
            obj.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            frmAccount obj = new frmAccount();
            obj.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmDeposit obj = new frmDeposit();
            obj.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            frmWithdraw obj = new frmWithdraw();
            obj.Show();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            FrmTransfer obj = new FrmTransfer();
            obj.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
    "Are you sure you want to Logout?",
    "Logout",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmLogin obj = new frmLogin();
                obj.Show();
                this.Hide();
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

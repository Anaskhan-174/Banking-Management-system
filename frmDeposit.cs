using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankingManagement
{
    public partial class frmDeposit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BankingManagement;Integrated Security=True;TrustServerCertificate=True");
        public frmDeposit()
        {
            InitializeComponent();

            txtCustomerName.ReadOnly = true;
            txtBalance.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT C.CustomerName, A.Balance FROM Account A INNER JOIN Customer C ON A.CustomerId = C.CustomerId WHERE A.AccountNo = @AccountNo", con);

                cmd.Parameters.AddWithValue("@AccountNo", txtAccountNo.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtCustomerName.Text = dr["CustomerName"].ToString();
                    txtBalance.Text = dr["Balance"].ToString();
                }
                else
                {
                    MessageBox.Show("Account Not Found");

                    txtCustomerName.Clear();
                    txtBalance.Clear();
                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                decimal currentBalance = Convert.ToDecimal(txtBalance.Text);
                decimal depositAmount = Convert.ToDecimal(txtDeposit.Text);

                decimal newBalance = currentBalance + depositAmount;

                // Update Balance
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Account SET Balance=@Balance WHERE AccountNo=@AccountNo", con);

                cmd.Parameters.AddWithValue("@Balance", newBalance);
                cmd.Parameters.AddWithValue("@AccountNo", txtAccountNo.Text);

                int rows = cmd.ExecuteNonQuery();

                // Save Transaction History
                SqlCommand cmd2 = new SqlCommand(
                    "INSERT INTO Transactions(AccountNo, TransactionType, Amount) VALUES(@AccountNo,@Type,@Amount)", con);

                cmd2.Parameters.AddWithValue("@AccountNo", txtAccountNo.Text);
                cmd2.Parameters.AddWithValue("@Type", "Deposit");
                cmd2.Parameters.AddWithValue("@Amount", depositAmount);

                cmd2.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Amount Deposited Successfully");

                    txtBalance.Text = newBalance.ToString();

                    txtDeposit.Clear();
                    txtDeposit.Focus();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccountNo.Clear();
            txtCustomerName.Clear();
            txtBalance.Clear();
            txtDeposit.Clear();

            txtAccountNo.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {

        }

        private void txtAccountNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

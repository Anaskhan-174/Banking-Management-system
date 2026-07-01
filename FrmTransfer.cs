using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankingManagement
{
    public partial class FrmTransfer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BankingManagement;Integrated Security=True;TrustServerCertificate=True");

        public FrmTransfer()
        {
            InitializeComponent();
        }

        // FROM ACCOUNT SEARCH
        private void btnSearchFrom_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                "SELECT Customer.CustomerName, Account.Balance FROM Account INNER JOIN Customer ON Account.CustomerId=Customer.CustomerId WHERE AccountNo=@AccountNo", con);

                cmd.Parameters.AddWithValue("@AccountNo", txtFromAccountNo.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtFromName.Text = dr["CustomerName"].ToString();
                    txtBalance.Text = dr["Balance"].ToString();
                }
                else
                {
                    MessageBox.Show("From Account Not Found");

                    txtFromName.Clear();
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

        // TO ACCOUNT SEARCH
        private void btnSearchFromTo_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                "SELECT CustomerName FROM Customer INNER JOIN Account ON Customer.CustomerId=Account.CustomerId WHERE AccountNo=@AccountNo", con);

                cmd.Parameters.AddWithValue("@AccountNo", txtToAccountNo.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtToName.Text = dr["CustomerName"].ToString();
                }
                else
                {
                    MessageBox.Show("To Account Not Found");

                    txtToName.Clear();
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
        // TRANSFER
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFromAccountNo.Text == "" || txtToAccountNo.Text == "" || txtTransferAmount.Text == "")
                {
                    MessageBox.Show("Please Fill All Details");
                    return;
                }

                if (txtFromAccountNo.Text == txtToAccountNo.Text)
                {
                    MessageBox.Show("From and To Account cannot be same");
                    return;
                }

                con.Open();

                decimal currentBalance = Convert.ToDecimal(txtBalance.Text);
                decimal transferAmount = Convert.ToDecimal(txtTransferAmount.Text);

                if (transferAmount <= 0)
                {
                    MessageBox.Show("Enter Valid Amount");
                    con.Close();
                    return;
                }

                if (transferAmount > currentBalance)
                {
                    MessageBox.Show("Insufficient Balance");
                    con.Close();
                    return;
                }

                decimal newFromBalance = currentBalance - transferAmount;

                // Update From Account
                SqlCommand cmd1 = new SqlCommand(
                "UPDATE Account SET Balance=@Balance WHERE AccountNo=@AccountNo", con);

                cmd1.Parameters.AddWithValue("@Balance", newFromBalance);
                cmd1.Parameters.AddWithValue("@AccountNo", txtFromAccountNo.Text);

                cmd1.ExecuteNonQuery();

                // Get To Account Balance
                SqlCommand cmd2 = new SqlCommand(
                "SELECT Balance FROM Account WHERE AccountNo=@AccountNo", con);

                cmd2.Parameters.AddWithValue("@AccountNo", txtToAccountNo.Text);

                decimal toBalance = Convert.ToDecimal(cmd2.ExecuteScalar());

                decimal newToBalance = toBalance + transferAmount;

                // Update To Account
                SqlCommand cmd3 = new SqlCommand(
                "UPDATE Account SET Balance=@Balance WHERE AccountNo=@AccountNo", con);

                cmd3.Parameters.AddWithValue("@Balance", newToBalance);
                cmd3.Parameters.AddWithValue("@AccountNo", txtToAccountNo.Text);

                cmd3.ExecuteNonQuery();

                // Transaction From
                SqlCommand cmd4 = new SqlCommand(
                "INSERT INTO Transactions(AccountNo,TransactionType,Amount) VALUES(@AccountNo,@Type,@Amount)", con);

                cmd4.Parameters.AddWithValue("@AccountNo", txtFromAccountNo.Text);
                cmd4.Parameters.AddWithValue("@Type", "Transfer Out");
                cmd4.Parameters.AddWithValue("@Amount", transferAmount);

                cmd4.ExecuteNonQuery();

                // Transaction To
                SqlCommand cmd5 = new SqlCommand(
                "INSERT INTO Transactions(AccountNo,TransactionType,Amount) VALUES(@AccountNo,@Type,@Amount)", con);

                cmd5.Parameters.AddWithValue("@AccountNo", txtToAccountNo.Text);
                cmd5.Parameters.AddWithValue("@Type", "Transfer In");
                cmd5.Parameters.AddWithValue("@Amount", transferAmount);

                cmd5.ExecuteNonQuery();

                MessageBox.Show("Amount Transferred Successfully");

                txtBalance.Text = newFromBalance.ToString();

                txtTransferAmount.Clear();
                txtTransferAmount.Focus();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        // CLEAR
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFromAccountNo.Clear();
            txtFromName.Clear();
            txtBalance.Clear();
            txtToAccountNo.Clear();
            txtToName.Clear();
            txtTransferAmount.Clear();

            txtFromAccountNo.Focus();
        }

        // BACK
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFromAccountNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

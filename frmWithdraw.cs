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
    public partial class frmWithdraw : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BankingManagement;Integrated Security=True;TrustServerCertificate=True");
        public frmWithdraw()
        {
            InitializeComponent();
            txtCustomerName.ReadOnly = true;
            txtBalance.ReadOnly = true;
        }

        private void frmWithdraw_Load(object sender, EventArgs e)
        {

        }

        // SEARCH
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT Customer.CustomerName, Account.Balance FROM Account INNER JOIN Customer ON Account.CustomerId = Customer.CustomerId WHERE AccountNo=@AccountNo", con);

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

        // WITHDRAW
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                decimal currentBalance = Convert.ToDecimal(txtBalance.Text);
                decimal withdrawAmount = Convert.ToDecimal(txtWithdraw.Text);

                if (withdrawAmount <= 0)
                {
                    MessageBox.Show("Enter Valid Amount");
                    con.Close();
                    return;
                }

                if (withdrawAmount > currentBalance)
                {
                    MessageBox.Show("Insufficient Balance");

                    con.Close();
                    return;
                }

                decimal newBalance = currentBalance - withdrawAmount;

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Account SET Balance=@Balance WHERE AccountNo=@AccountNo", con);

                cmd.Parameters.AddWithValue("@Balance", newBalance);
                cmd.Parameters.AddWithValue("@AccountNo", txtAccountNo.Text);

                int rows = cmd.ExecuteNonQuery();

                // Save Transaction
                SqlCommand cmd2 = new SqlCommand(
                    "INSERT INTO Transactions(AccountNo, TransactionType, Amount) VALUES(@AccountNo,@Type,@Amount)", con);

                cmd2.Parameters.AddWithValue("@AccountNo", txtAccountNo.Text);
                cmd2.Parameters.AddWithValue("@Type", "Withdraw");
                cmd2.Parameters.AddWithValue("@Amount", withdrawAmount);

                cmd2.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Amount Withdrawn Successfully");

                    txtBalance.Text = newBalance.ToString();

                    txtWithdraw.Clear();
                    txtWithdraw.Focus();
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

        // CLEAR
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccountNo.Clear();
            txtCustomerName.Clear();
            txtBalance.Clear();
            txtWithdraw.Clear();

            txtAccountNo.Focus();
        }

        // BACK
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmWithdraw_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    


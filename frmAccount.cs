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
    public partial class frmAccount : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BankingManagement;Integrated Security=True;TrustServerCertificate=True");
        public frmAccount()
        {
            InitializeComponent();
            txtAccountNo.ReadOnly = true;
            txtCustomerName.ReadOnly = true;

            GenerateAccountNo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT CustomerName FROM Customer WHERE CustomerId=@CustomerId", con);

                cmd.Parameters.AddWithValue("@CustomerId", txtCustomerId.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtCustomerName.Text = dr["CustomerName"].ToString();
                }
                else
                {
                    MessageBox.Show("Customer Not Found");
                    txtCustomerName.Clear();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Account(CustomerId, AccountType, Balance, OpenDate) VALUES(@CustomerId,@AccountType,@Balance,@OpenDate)", con);

                cmd.Parameters.AddWithValue("@CustomerId", txtCustomerId.Text);
                cmd.Parameters.AddWithValue("@AccountType", cmbAccountType.Text);
                cmd.Parameters.AddWithValue("@Balance", txtBalance.Text);
                cmd.Parameters.AddWithValue("@OpenDate", dtpOpenDate.Value);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Account Opened Successfully");

                    txtCustomerId.Clear();
                    txtCustomerName.Clear();
                  
                    cmbAccountType.SelectedIndex = -1;
                    txtBalance.Clear();
                    dtpOpenDate.Value = DateTime.Now;

                    
                }

                con.Close();
                GenerateAccountNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GenerateAccountNo()
        {
            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(AccountNo),1000)+1 FROM Account", con);

            txtAccountNo.Text = cmd.ExecuteScalar().ToString();

            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
       
            

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerId.Clear();
            txtCustomerName.Clear();
            txtBalance.Clear();

            cmbAccountType.SelectedIndex = -1;

            dtpOpenDate.Value = DateTime.Now;

            GenerateAccountNo();

            txtCustomerId.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {

        }
    }
}

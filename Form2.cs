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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerNAme_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFatherNAme_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BankingManagement;Integrated Security=True;TrustServerCertificate=True");

                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE CustomerId=@CustomerId", con);

                cmd.Parameters.AddWithValue("@CustomerId", txtCustomerId.Text);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Customer Deleted Successfully");

                    txtCustomerId.Clear();
                    txtCustomerNAme.Clear();
                    txtFatherNAme.Clear();
                    txtMobile.Clear();
                    txtEmail.Clear();
                    txtAddress.Clear();
                    txtAadhar.Clear();
                    dtpDOB.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Customer Not Found");
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
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BankingManagement;Integrated Security=True;TrustServerCertificate=True");

                con.Open();

                SqlCommand cmd = new SqlCommand(
                "INSERT INTO Customer(CustomerName, FatherName, Mobile, Email, Address, Aadhar, DOB) VALUES(@CustomerName,@FatherName,@Mobile,@Email,@Address,@Aadhar,@DOB)", con);

                cmd.Parameters.AddWithValue("@CustomerName", txtCustomerNAme.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherNAme.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Aadhar", txtAadhar.Text);
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Customer Saved Successfully");

                    txtCustomerId.Clear();
                    txtCustomerNAme.Clear();
                    txtFatherNAme.Clear();
                    txtMobile.Clear();
                    txtEmail.Clear();
                    txtAddress.Clear();
                    txtAadhar.Clear();
                    dtpDOB.Value = DateTime.Now;

                    txtCustomerNAme.Focus();
                }
                else
                {
                    MessageBox.Show("Customer Not Saved");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerId.Clear();
            txtCustomerNAme.Clear();
            txtFatherNAme.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtAadhar.Clear();

            dtpDOB.Value = DateTime.Now;

            txtCustomerId.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BankingManagement;Integrated Security=True;TrustServerCertificate=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE CustomerId=@CustomerId", con);

            cmd.Parameters.AddWithValue("@CustomerId", txtCustomerId.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtCustomerNAme.Text = dr["CustomerName"].ToString();
                txtFatherNAme.Text = dr["FatherName"].ToString();
                txtMobile.Text = dr["Mobile"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                txtAadhar.Text = dr["Aadhar"].ToString();
                dtpDOB.Value = Convert.ToDateTime(dr["DOB"]);
            }
            else
            {
                MessageBox.Show("Customer Not Found");
            }

            con.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BankingManagement;Integrated Security=True;TrustServerCertificate=True");

                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Customer SET CustomerName=@CustomerName, FatherName=@FatherName, Mobile=@Mobile, Email=@Email, Address=@Address, Aadhar=@Aadhar, DOB=@DOB WHERE CustomerId=@CustomerId", con);

                cmd.Parameters.AddWithValue("@CustomerId", txtCustomerId.Text);
                cmd.Parameters.AddWithValue("@CustomerName", txtCustomerNAme.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherNAme.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Aadhar", txtAadhar.Text);
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Customer Updated Successfully");
                else
                    MessageBox.Show("Customer Not Found");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
        
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
            this.Close();   // Ya this.Hide();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }
    }

}

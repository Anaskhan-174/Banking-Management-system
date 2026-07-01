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

namespace BankingManagement
{
    public partial class frmBalanceReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BankingManagement;Integrated Security=True;TrustServerCertificate=True");
        public frmBalanceReport()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                "SELECT Account.AccountNo, Customer.CustomerName, Account.AccountType, Account.Balance FROM Account INNER JOIN Customer ON Account.CustomerId = Customer.CustomerId",
                con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvBalance.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        } 

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBalanceReport_Load(object sender, EventArgs e)
        {
           
            btnLoad.PerformClick();
        }
    }
}

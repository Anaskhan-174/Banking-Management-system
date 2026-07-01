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
    public partial class frmTransactionReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BankingManagement;Integrated Security=True;TrustServerCertificate=True");
        public frmTransactionReport()
        {
            InitializeComponent();
        }

        private void frmTransactionReport_Load(object sender, EventArgs e)
        {
            btnLoad.PerformClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Transactions ORDER BY TransactionDate DESC",
                con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvTransaction.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
    
}

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
    public partial class frmViewAccount : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BankingManagement;Integrated Security=True;TrustServerCertificate=True");
        public frmViewAccount()
        {
            InitializeComponent();
            this.Load += frmViewAccount_Load;
        }
        private void frmViewAccount_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Account", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvAccount.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

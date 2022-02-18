using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace PrintingPress
{
    public partial class frmListCustomer : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public frmListCustomer()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/C# Projects/PrintingPress/PrintingPress.mdb";
            con.Open();

        }

        private void frmListCustomer_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from customer", con);

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}

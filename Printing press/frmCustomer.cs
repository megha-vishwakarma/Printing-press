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
    public partial class frmCustomer : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public frmCustomer()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/C# Projects/PrintingPress/PrintingPress.mdb";
            con.Open();
        }
        public void charonly(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Only Char are allowed");
                e.Handled = true;
            }
        }

        public void digitonly(KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
                {
                    e.Handled = true;
                    MessageBox.Show("Enter only digit and decimal point.", "Alert!");
                }
            }
            catch { }
        }
        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtmob.Text != "" && txtAdd.Text != "" && txtname.Text != "" && txtEmail.Text != "")
            {
                OleDbCommand cmd = new OleDbCommand("insert into customer values('" + txtname.Text + "','" + txtAdd.Text + "','" + txtmob.Text + "','" + txtEmail.Text + "')", con);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Customer Added");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter All the Fields");
            }
        }

        private void txtmob_KeyPress(object sender, KeyPressEventArgs e)
        {
            digitonly(e);
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            charonly(e);
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}

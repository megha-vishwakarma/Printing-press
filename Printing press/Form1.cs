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
    public partial class Form1 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/C# Projects/PrintingPress/PrintingPress.mdb";
            con.Open();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {



                OleDbCommand cmd = new OleDbCommand("select count(*) from Admin where uname='" + txtUserName.Text + "'and upass='" + txtPassword.Text + "'", con);
                int x = (int)cmd.ExecuteScalar();

                if (x > 0)
                {
                    frmSplash ob = new frmSplash();
                    ob.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmStaff : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public frmStaff()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/C# Projects/PrintingPress/PrintingPress.mdb";
            con.Open();

        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("select max(emp_id)+1  from Employee", con);
            lblId.Text = ((int)cmd.ExecuteScalar()).ToString();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text != "" && txtEmail.Text != "" && txtImg.Text != "" && txtmob.Text != "" && txtname.Text != "" && txtSal.Text != "")
            {
                MessageBox.Show("insert into Employee values(" + lblId.Text + ",'" + txtname.Text + "','" + txtAdd.Text + "','" + txtEmail.Text + "','" + txtmob.Text + "','" + dateTimePicker1.Value + "','" + txtSal.Text + "','" + dateTimePicker2.Value + "','" + txtImg.Text + "')");

                OleDbCommand cmd = new OleDbCommand("insert into Employee values(" + lblId.Text + ",'" + txtname.Text + "','" + txtAdd.Text + "','" + txtEmail.Text + "','" + txtmob.Text + "','" + dateTimePicker1.Value + "','" + txtSal.Text + "','" + dateTimePicker2.Value + "','" + txtImg.Text + "')", con);

                int x = (int)cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Employee Added Successfully");
                    lblId.Text = "";
                    txtAdd.Text = "";
                    txtname.Text = "";
                    txtSal.Text = "";
                    txtEmail.Text = "";
                    txtmob.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Enter All the Details");
            }
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Employee", con);

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
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
        private void cmdImage_Click(object sender, EventArgs e)
        {
            CommonDialog1Open.ShowDialog();
            txtImg.Text = CommonDialog1Open.FileName;
            Image1.Image = Image.FromFile(txtImg.Text);
        }

        private void txtmob_KeyPress(object sender, KeyPressEventArgs e)
        {
            digitonly(e);
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            charonly(e);
        }

        private void txtSal_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            digitonly(e);
        }
    }
}

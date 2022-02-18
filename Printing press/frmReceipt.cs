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
using System.Drawing.Printing;

namespace PrintingPress
{
    public partial class frmReceipt : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public frmReceipt()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/C# Projects/PrintingPress/PrintingPress.mdb";
            con.Open();
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString();

            OleDbCommand cmd = new OleDbCommand("select max(rid)+1  from Receipt", con);
            lblRno.Text = ((int)cmd.ExecuteScalar()).ToString();

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select cmob from Customer", con);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbCmob.Items.Add(dt.Rows[i]["cmob"]);
            }

          

        }

        private void cmbCmob_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Customer where cmob='" + cmbCmob.Text + "'", con);
            da.Fill(dt);
            lblName.Text = dt.Rows[0]["sname"].ToString();
        }

        private void cmbShipno_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblEdate.Text = dateTimePicker1.Value.ToString();


        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(groupBox1.ClientRectangle.Width, groupBox1.ClientRectangle.Height);
            groupBox1.DrawToBitmap(bmp, groupBox1.ClientRectangle);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text!="" && cmbCmob.Text!="" )
            {
                OleDbCommand cmd = new OleDbCommand("insert into jobdetails values(" + lblRno.Text + ",'" + lblName.Text + "','" + cmbCmob.Text + "','" + richTextBox1.Text + "','" + textBox1.Text + "','" + lblEdate.Text + "','" + lblDate.Text + "')", con);
                int y = cmd.ExecuteNonQuery();


                OleDbCommand cmd2 = new OleDbCommand("insert into receipt values(" + lblRno.Text + ",'" + lblName.Text + "','" + cmbCmob.Text + "','" + richTextBox1.Text + "','" + textBox1.Text + "')", con);
                int x = cmd2.ExecuteNonQuery();
                PrintPreviewDialog ppd = new PrintPreviewDialog();
                PrintDocument Pd = new PrintDocument();
                PrinterSettings PrinterSetting = new PrinterSettings();
                //Pd.PrinterSettings.PrinterName = "Eltron P310 Card Printer";
                Pd.PrinterSettings.Copies = 1;
                Pd.PrinterSettings.DefaultPageSettings.Landscape = true;

                Pd.PrintPage += printDocument1_PrintPage;
                ppd.Document = Pd;
                ppd.ShowDialog();

                button1.Enabled = false;
            }
        }
    }
}

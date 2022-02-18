using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingPress
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer ob = new frmCustomer();
            ob.ShowDialog();

        }

        private void listCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListCustomer ob = new frmListCustomer();
            ob.ShowDialog();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaff ob = new frmStaff();
            ob.ShowDialog();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listShipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void addGalleryImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void galleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void checkStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceipt ob = new frmReceipt();
            ob.Show();

        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void shipReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void staffReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }

        private void newServicingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void checkServicingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

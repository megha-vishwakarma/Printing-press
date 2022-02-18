
namespace PrintingPress
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkServicingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newServicingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listShipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Font = new System.Drawing.Font("Modern No. 20", 13F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.shipToolStripMenuItem,
            this.receiptToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.servicingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(652, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(148, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listCustomerToolStripMenuItem,
            this.newCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(83, 33);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // listCustomerToolStripMenuItem
            // 
            this.listCustomerToolStripMenuItem.Name = "listCustomerToolStripMenuItem";
            this.listCustomerToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.listCustomerToolStripMenuItem.Text = "List Customer";
            this.listCustomerToolStripMenuItem.Click += new System.EventHandler(this.listCustomerToolStripMenuItem_Click);
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.newCustomerToolStripMenuItem.Text = "New Customer";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.newCustomerToolStripMenuItem_Click);
            // 
            // receiptToolStripMenuItem
            // 
            this.receiptToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.receiptToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.receiptToolStripMenuItem.Name = "receiptToolStripMenuItem";
            this.receiptToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.receiptToolStripMenuItem.Size = new System.Drawing.Size(83, 33);
            this.receiptToolStripMenuItem.Text = "Receipt";
            this.receiptToolStripMenuItem.Click += new System.EventHandler(this.receiptToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.staffToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(83, 33);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffReportToolStripMenuItem,
            this.shipReportToolStripMenuItem,
            this.customerReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(83, 33);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // staffReportToolStripMenuItem
            // 
            this.staffReportToolStripMenuItem.Name = "staffReportToolStripMenuItem";
            this.staffReportToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.staffReportToolStripMenuItem.Text = "Staff Report";
            this.staffReportToolStripMenuItem.Click += new System.EventHandler(this.staffReportToolStripMenuItem_Click);
            // 
            // shipReportToolStripMenuItem
            // 
            this.shipReportToolStripMenuItem.Name = "shipReportToolStripMenuItem";
            this.shipReportToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.shipReportToolStripMenuItem.Text = "Ship Report";
            this.shipReportToolStripMenuItem.Click += new System.EventHandler(this.shipReportToolStripMenuItem_Click);
            // 
            // customerReportToolStripMenuItem
            // 
            this.customerReportToolStripMenuItem.Name = "customerReportToolStripMenuItem";
            this.customerReportToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.customerReportToolStripMenuItem.Text = "Customer Report";
            this.customerReportToolStripMenuItem.Click += new System.EventHandler(this.customerReportToolStripMenuItem_Click);
            // 
            // servicingToolStripMenuItem
            // 
            this.servicingToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.servicingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkServicingDetailsToolStripMenuItem,
            this.newServicingToolStripMenuItem});
            this.servicingToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.servicingToolStripMenuItem.Name = "servicingToolStripMenuItem";
            this.servicingToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.servicingToolStripMenuItem.Size = new System.Drawing.Size(115, 33);
            this.servicingToolStripMenuItem.Text = "Rates";
            // 
            // checkServicingDetailsToolStripMenuItem
            // 
            this.checkServicingDetailsToolStripMenuItem.Name = "checkServicingDetailsToolStripMenuItem";
            this.checkServicingDetailsToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.checkServicingDetailsToolStripMenuItem.Text = "Rate Card";
            this.checkServicingDetailsToolStripMenuItem.Click += new System.EventHandler(this.checkServicingDetailsToolStripMenuItem_Click);
            // 
            // newServicingToolStripMenuItem
            // 
            this.newServicingToolStripMenuItem.Name = "newServicingToolStripMenuItem";
            this.newServicingToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.newServicingToolStripMenuItem.Text = "Add / Update Ratecard";
            this.newServicingToolStripMenuItem.Click += new System.EventHandler(this.newServicingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(83, 33);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.addNewToolStripMenuItem.Text = "Add New Job";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // listShipsToolStripMenuItem
            // 
            this.listShipsToolStripMenuItem.Name = "listShipsToolStripMenuItem";
            this.listShipsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.listShipsToolStripMenuItem.Text = "List Jobs";
            this.listShipsToolStripMenuItem.Click += new System.EventHandler(this.listShipsToolStripMenuItem_Click);
            // 
            // shipToolStripMenuItem
            // 
            this.shipToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.shipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.listShipsToolStripMenuItem});
            this.shipToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.shipToolStripMenuItem.Name = "shipToolStripMenuItem";
            this.shipToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.shipToolStripMenuItem.Size = new System.Drawing.Size(115, 33);
            this.shipToolStripMenuItem.Text = "Printing Jobs";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrintingPress.Properties.Resources.Printing_press;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainform";
            this.Text = "mainform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkServicingDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newServicingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listShipsToolStripMenuItem;
    }
}
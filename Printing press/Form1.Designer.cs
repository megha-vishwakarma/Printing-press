
namespace PrintingPress
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdCheck = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.lblQues = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCancel.Location = new System.Drawing.Point(426, 340);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancel.Size = new System.Drawing.Size(212, 41);
            this.cmdCancel.TabIndex = 17;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            // 
            // cmdCheck
            // 
            this.cmdCheck.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCheck.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCheck.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCheck.Location = new System.Drawing.Point(48, 168);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCheck.Size = new System.Drawing.Size(209, 33);
            this.cmdCheck.TabIndex = 8;
            this.cmdCheck.Text = "Check Answer and Show Password";
            this.cmdCheck.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPassword.Location = new System.Drawing.Point(109, 140);
            this.txtPassword.MaxLength = 0;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(212, 23);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.Text = "fsdfds";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label1.Location = new System.Drawing.Point(543, 384);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(100, 21);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Forgot Password";
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.Color.Teal;
            this.cmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdOK.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdOK.Location = new System.Drawing.Point(109, 179);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOK.Size = new System.Drawing.Size(212, 41);
            this.cmdOK.TabIndex = 16;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // txtAns
            // 
            this.txtAns.AcceptsReturn = true;
            this.txtAns.BackColor = System.Drawing.SystemColors.Window;
            this.txtAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAns.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAns.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAns.Location = new System.Drawing.Point(48, 104);
            this.txtAns.MaxLength = 0;
            this.txtAns.Name = "txtAns";
            this.txtAns.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAns.Size = new System.Drawing.Size(211, 23);
            this.txtAns.TabIndex = 7;
            this.txtAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 10;
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.Color.White;
            this.Frame1.Controls.Add(this.cmdCheck);
            this.Frame1.Controls.Add(this.txtAns);
            this.Frame1.Controls.Add(this.lblQues);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(698, 36);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(313, 361);
            this.Frame1.TabIndex = 19;
            this.Frame1.TabStop = false;
            this.Frame1.Visible = false;
            // 
            // lblQues
            // 
            this.lblQues.AutoSize = true;
            this.lblQues.BackColor = System.Drawing.Color.Transparent;
            this.lblQues.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblQues.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQues.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQues.Location = new System.Drawing.Point(40, 48);
            this.lblQues.Name = "lblQues";
            this.lblQues.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQues.Size = new System.Drawing.Size(66, 16);
            this.lblQues.TabIndex = 6;
            this.lblQues.Text = "Question";
            // 
            // txtUserName
            // 
            this.txtUserName.AcceptsReturn = true;
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserName.Location = new System.Drawing.Point(109, 100);
            this.txtUserName.MaxLength = 0;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserName.Size = new System.Drawing.Size(212, 23);
            this.txtUserName.TabIndex = 14;
            this.txtUserName.Text = "Username";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Image1
            // 
            this.Image1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Image1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Image1.Image = global::PrintingPress.Properties.Resources.back;
            this.Image1.Location = new System.Drawing.Point(0, 0);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(686, 332);
            this.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image1.TabIndex = 20;
            this.Image1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 332);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.Image1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Button cmdCancel;
        public System.Windows.Forms.Button cmdCheck;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Button cmdOK;
        public System.Windows.Forms.TextBox txtAns;
        public System.Windows.Forms.Timer Timer1;
        public System.Windows.Forms.GroupBox Frame1;
        public System.Windows.Forms.Label lblQues;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.PictureBox Image1;
    }
}


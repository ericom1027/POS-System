namespace Pharmacy
{
    partial class frmVoid
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
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtInvoiceNo = new System.Windows.Forms.TextBox();
			this.lblInvoice = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtPassword.Location = new System.Drawing.Point(112, 84);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(156, 20);
			this.txtPassword.TabIndex = 30;
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyPressEnter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 18);
			this.label1.TabIndex = 32;
			this.label1.Text = "Password:";
			// 
			// txtInvoiceNo
			// 
			this.txtInvoiceNo.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtInvoiceNo.Location = new System.Drawing.Point(112, 49);
			this.txtInvoiceNo.Name = "txtInvoiceNo";
			this.txtInvoiceNo.Size = new System.Drawing.Size(156, 20);
			this.txtInvoiceNo.TabIndex = 29;
			this.txtInvoiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNo_KeyPress);
			// 
			// lblInvoice
			// 
			this.lblInvoice.AutoSize = true;
			this.lblInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInvoice.Location = new System.Drawing.Point(16, 48);
			this.lblInvoice.Name = "lblInvoice";
			this.lblInvoice.Size = new System.Drawing.Size(86, 18);
			this.lblInvoice.TabIndex = 31;
			this.lblInvoice.Text = "Invoice No.:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Maroon;
			this.label2.Location = new System.Drawing.Point(48, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 21);
			this.label2.TabIndex = 33;
			this.label2.Text = "SJMED Void Sale";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(97, 51);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(13, 16);
			this.label7.TabIndex = 36;
			this.label7.Text = "*";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(96, 86);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 16);
			this.label4.TabIndex = 37;
			this.label4.Text = "*";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::Pharmacy.Properties.Resources.close22;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.Location = new System.Drawing.Point(193, 125);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 33);
			this.btnClose.TabIndex = 35;
			this.btnClose.Text = "&Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.Image = global::Pharmacy.Properties.Resources.ok22k;
			this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.Location = new System.Drawing.Point(112, 125);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 30);
			this.btnOk.TabIndex = 34;
			this.btnOk.Text = "  &Ok";
			this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// frmVoid
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(284, 167);
			this.ControlBox = false;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtInvoiceNo);
			this.Controls.Add(this.lblInvoice);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmVoid";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SJMED Void Sale";
			this.Load += new System.EventHandler(this.frmVoid_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}
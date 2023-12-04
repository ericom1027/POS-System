namespace Pharmacy
{
    partial class frmSJMEDStock
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPromo = new System.Windows.Forms.TextBox();
			this.dpPromoExpiry = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpDateExpiry = new System.Windows.Forms.DateTimePicker();
			this.label12 = new System.Windows.Forms.Label();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProductDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dgvStock = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtPromo);
			this.groupBox1.Controls.Add(this.dpPromoExpiry);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.dtpDateExpiry);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txtUnit);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtProductDescription);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(16, 63);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(425, 143);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Products Details";
			// 
			// txtPromo
			// 
			this.txtPromo.Location = new System.Drawing.Point(319, 102);
			this.txtPromo.MaxLength = 10;
			this.txtPromo.Name = "txtPromo";
			this.txtPromo.Size = new System.Drawing.Size(89, 22);
			this.txtPromo.TabIndex = 5;
			this.txtPromo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPromo_KeyPress);
			// 
			// dpPromoExpiry
			// 
			this.dpPromoExpiry.CustomFormat = "dd/MM/yyyy";
			this.dpPromoExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dpPromoExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpPromoExpiry.Location = new System.Drawing.Point(113, 100);
			this.dpPromoExpiry.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.dpPromoExpiry.Name = "dpPromoExpiry";
			this.dpPromoExpiry.Size = new System.Drawing.Size(102, 22);
			this.dpPromoExpiry.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label7.Location = new System.Drawing.Point(16, 102);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 16);
			this.label7.TabIndex = 41;
			this.label7.Text = "Promo Expiry: ";
			// 
			// dtpDateExpiry
			// 
			this.dtpDateExpiry.CustomFormat = "dd/MM/yyyy";
			this.dtpDateExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDateExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateExpiry.Location = new System.Drawing.Point(112, 65);
			this.dtpDateExpiry.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.dtpDateExpiry.Name = "dtpDateExpiry";
			this.dtpDateExpiry.Size = new System.Drawing.Size(102, 22);
			this.dtpDateExpiry.TabIndex = 2;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Red;
			this.label12.Location = new System.Drawing.Point(304, 70);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(13, 16);
			this.label12.TabIndex = 38;
			this.label12.Text = "*";
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(319, 66);
			this.txtUnit.MaxLength = 10;
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(89, 22);
			this.txtUnit.TabIndex = 3;
			this.txtUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnit_KeyPress);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label13.Location = new System.Drawing.Point(278, 70);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(37, 16);
			this.label13.TabIndex = 36;
			this.label13.Text = "Unit: ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(96, 68);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(13, 16);
			this.label8.TabIndex = 34;
			this.label8.Text = "*";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label9.Location = new System.Drawing.Point(19, 67);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(83, 16);
			this.label9.TabIndex = 33;
			this.label9.Text = "Date Expiry: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(99, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 16);
			this.label3.TabIndex = 29;
			this.label3.Text = "*";
			// 
			// txtProductDescription
			// 
			this.txtProductDescription.Location = new System.Drawing.Point(113, 30);
			this.txtProductDescription.Name = "txtProductDescription";
			this.txtProductDescription.Size = new System.Drawing.Size(295, 22);
			this.txtProductDescription.TabIndex = 1;
			this.txtProductDescription.TextChanged += new System.EventHandler(this.txtProductDescription_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(7, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 27;
			this.label4.Text = "Product Name: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new System.Drawing.Point(239, 105);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 16);
			this.label5.TabIndex = 43;
			this.label5.Text = "Discount %: ";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnClose);
			this.groupBox3.Controls.Add(this.btnSave);
			this.groupBox3.Location = new System.Drawing.Point(447, 63);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(105, 143);
			this.groupBox3.TabIndex = 36;
			this.groupBox3.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::Pharmacy.Properties.Resources.close;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(6, 93);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(93, 41);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "&Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Image = global::Pharmacy.Properties.Resources.Save_icon;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(6, 12);
			this.btnSave.Name = "btnSave";
			this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSave.Size = new System.Drawing.Size(93, 41);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "&Update";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dgvStock
			// 
			this.dgvStock.AllowUserToAddRows = false;
			this.dgvStock.AllowUserToDeleteRows = false;
			this.dgvStock.AllowUserToResizeRows = false;
			this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStock.Location = new System.Drawing.Point(17, 21);
			this.dgvStock.Name = "dgvStock";
			this.dgvStock.ReadOnly = true;
			this.dgvStock.RowHeadersVisible = false;
			this.dgvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStock.Size = new System.Drawing.Size(502, 331);
			this.dgvStock.TabIndex = 12;
			this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvStock);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(16, 226);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(536, 365);
			this.groupBox2.TabIndex = 35;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "SJMED Product Stocks";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(11, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(243, 25);
			this.label1.TabIndex = 34;
			this.label1.Text = "SJMED Product Stock";
			// 
			// frmSJMEDStock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(574, 603);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSJMEDStock";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SJMED Pharmacy Stock";
			this.Load += new System.EventHandler(this.frmSJMEDStock_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDateExpiry;
        private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtPromo;
		private System.Windows.Forms.DateTimePicker dpPromoExpiry;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
    }
}
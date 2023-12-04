namespace Pharmacy
{
    partial class frmWholeSalePrice
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
			this.cmbPer = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtUnitPrice = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProductDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvWholeSale = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.chkVATexempted = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvWholeSale)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbPer);
			this.groupBox1.Controls.Add(this.chkVATexempted);
			this.groupBox1.Controls.Add(this.txtUnitPrice);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txtUnit);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtProductDescription);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtCode);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(17, 51);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(425, 182);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// cmbPer
			// 
			this.cmbPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPer.FormattingEnabled = true;
			this.cmbPer.Location = new System.Drawing.Point(170, 133);
			this.cmbPer.Name = "cmbPer";
			this.cmbPer.Size = new System.Drawing.Size(99, 24);
			this.cmbPer.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(159, 138);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(13, 16);
			this.label10.TabIndex = 47;
			this.label10.Text = "*";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(132, 136);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(35, 16);
			this.label11.TabIndex = 46;
			this.label11.Text = "UM: ";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Red;
			this.label14.Location = new System.Drawing.Point(310, 138);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(13, 16);
			this.label14.TabIndex = 44;
			this.label14.Text = "*";
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.Location = new System.Drawing.Point(322, 135);
			this.txtUnitPrice.Name = "txtUnitPrice";
			this.txtUnitPrice.Size = new System.Drawing.Size(80, 22);
			this.txtUnitPrice.TabIndex = 5;
			this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(275, 139);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(45, 16);
			this.label15.TabIndex = 42;
			this.label15.Text = "Price: ";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Red;
			this.label12.Location = new System.Drawing.Point(47, 135);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(13, 16);
			this.label12.TabIndex = 38;
			this.label12.Text = "*";
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(61, 132);
			this.txtUnit.MaxLength = 10;
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(62, 22);
			this.txtUnit.TabIndex = 3;
			this.txtUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnit_KeyPress);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(21, 135);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(37, 16);
			this.label13.TabIndex = 36;
			this.label13.Text = "Unit: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(104, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 16);
			this.label3.TabIndex = 29;
			this.label3.Text = "*";
			// 
			// txtProductDescription
			// 
			this.txtProductDescription.Location = new System.Drawing.Point(117, 35);
			this.txtProductDescription.Name = "txtProductDescription";
			this.txtProductDescription.Size = new System.Drawing.Size(288, 22);
			this.txtProductDescription.TabIndex = 1;
			this.txtProductDescription.TextChanged += new System.EventHandler(this.txtProductDescription_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 27;
			this.label4.Text = "Product Name: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(102, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(13, 16);
			this.label7.TabIndex = 26;
			this.label7.Text = "*";
			// 
			// txtCode
			// 
			this.txtCode.Enabled = false;
			this.txtCode.Location = new System.Drawing.Point(117, 85);
			this.txtCode.MaxLength = 10;
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(139, 22);
			this.txtCode.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(63, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Code: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Maroon;
			this.label1.Location = new System.Drawing.Point(17, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(277, 25);
			this.label1.TabIndex = 14;
			this.label1.Text = "SJMED Whole Sale Price";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvWholeSale);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(16, 242);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(525, 308);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Whole Sale Product Details";
			// 
			// dgvWholeSale
			// 
			this.dgvWholeSale.AllowUserToAddRows = false;
			this.dgvWholeSale.AllowUserToDeleteRows = false;
			this.dgvWholeSale.AllowUserToResizeRows = false;
			this.dgvWholeSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvWholeSale.Location = new System.Drawing.Point(14, 22);
			this.dgvWholeSale.Name = "dgvWholeSale";
			this.dgvWholeSale.ReadOnly = true;
			this.dgvWholeSale.RowHeadersVisible = false;
			this.dgvWholeSale.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvWholeSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWholeSale.Size = new System.Drawing.Size(496, 274);
			this.dgvWholeSale.TabIndex = 10;
			this.dgvWholeSale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWholeSale_CellClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnDelete);
			this.groupBox3.Controls.Add(this.btnClose);
			this.groupBox3.Controls.Add(this.btnSave);
			this.groupBox3.Location = new System.Drawing.Point(448, 52);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(93, 182);
			this.groupBox3.TabIndex = 31;
			this.groupBox3.TabStop = false;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Image = global::Pharmacy.Properties.Resources.delete;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(6, 129);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(81, 49);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::Pharmacy.Properties.Resources.close;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(6, 71);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(81, 49);
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
			this.btnSave.Location = new System.Drawing.Point(6, 11);
			this.btnSave.Name = "btnSave";
			this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSave.Size = new System.Drawing.Size(81, 49);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "&Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// chkVATexempted
			// 
			this.chkVATexempted.AutoSize = true;
			this.chkVATexempted.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.chkVATexempted.Location = new System.Drawing.Point(284, 88);
			this.chkVATexempted.Name = "chkVATexempted";
			this.chkVATexempted.Size = new System.Drawing.Size(118, 20);
			this.chkVATexempted.TabIndex = 2;
			this.chkVATexempted.Text = "VAT Exempted";
			this.chkVATexempted.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.chkVATexempted.UseVisualStyleBackColor = true;
			// 
			// frmWholeSalePrice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(559, 566);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmWholeSalePrice";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Whole Sale Price";
			this.Load += new System.EventHandler(this.frmWholeSaleProducts_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvWholeSale)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvWholeSale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbPer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox chkVATexempted;
    }
}
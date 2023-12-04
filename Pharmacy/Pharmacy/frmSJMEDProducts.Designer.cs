namespace Pharmacy
{
    partial class frmSJMEDProducts
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
			this.chkVATexempted = new System.Windows.Forms.CheckBox();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dgvSJMEDProducts = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSJMEDProducts)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkVATexempted);
			this.groupBox1.Controls.Add(this.cmbType);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.cmbPer);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.txtUnitPrice);
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
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox1.Location = new System.Drawing.Point(14, 43);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(405, 198);
			this.groupBox1.TabIndex = 32;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Products Details";
			// 
			// chkVATexempted
			// 
			this.chkVATexempted.AutoSize = true;
			this.chkVATexempted.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.chkVATexempted.Location = new System.Drawing.Point(271, 28);
			this.chkVATexempted.Name = "chkVATexempted";
			this.chkVATexempted.Size = new System.Drawing.Size(118, 20);
			this.chkVATexempted.TabIndex = 51;
			this.chkVATexempted.Text = "VAT Exempted";
			this.chkVATexempted.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.chkVATexempted.UseVisualStyleBackColor = true;
			// 
			// cmbType
			// 
			this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Location = new System.Drawing.Point(116, 102);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(109, 24);
			this.cmbType.TabIndex = 48;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(102, 105);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 16);
			this.label5.TabIndex = 50;
			this.label5.Text = "*";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(15, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 16);
			this.label6.TabIndex = 49;
			this.label6.Text = "Product Type: ";
			// 
			// cmbPer
			// 
			this.cmbPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPer.FormattingEnabled = true;
			this.cmbPer.Location = new System.Drawing.Point(295, 103);
			this.cmbPer.Name = "cmbPer";
			this.cmbPer.Size = new System.Drawing.Size(92, 24);
			this.cmbPer.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(281, 106);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(13, 16);
			this.label10.TabIndex = 47;
			this.label10.Text = "*";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label11.Location = new System.Drawing.Point(231, 105);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(59, 16);
			this.label11.TabIndex = 46;
			this.label11.Text = "UM Per: ";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Red;
			this.label14.Location = new System.Drawing.Point(279, 151);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(13, 16);
			this.label14.TabIndex = 44;
			this.label14.Text = "*";
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.Location = new System.Drawing.Point(295, 149);
			this.txtUnitPrice.Name = "txtUnitPrice";
			this.txtUnitPrice.Size = new System.Drawing.Size(92, 22);
			this.txtUnitPrice.TabIndex = 5;
			this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label15.Location = new System.Drawing.Point(242, 150);
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
			this.label12.Location = new System.Drawing.Point(101, 149);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(13, 16);
			this.label12.TabIndex = 38;
			this.label12.Text = "*";
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(117, 146);
			this.txtUnit.MaxLength = 10;
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(108, 22);
			this.txtUnit.TabIndex = 3;
			this.txtUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnit_KeyPress);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label13.Location = new System.Drawing.Point(75, 149);
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
			this.label3.Location = new System.Drawing.Point(101, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 16);
			this.label3.TabIndex = 29;
			this.label3.Text = "*";
			// 
			// txtProductDescription
			// 
			this.txtProductDescription.Location = new System.Drawing.Point(116, 64);
			this.txtProductDescription.Name = "txtProductDescription";
			this.txtProductDescription.Size = new System.Drawing.Size(273, 22);
			this.txtProductDescription.TabIndex = 2;
			this.txtProductDescription.TextChanged += new System.EventHandler(this.txtProductDescription_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(11, 66);
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
			this.label7.Location = new System.Drawing.Point(101, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(13, 16);
			this.label7.TabIndex = 26;
			this.label7.Text = "*";
			// 
			// txtCode
			// 
			this.txtCode.Enabled = false;
			this.txtCode.Location = new System.Drawing.Point(116, 26);
			this.txtCode.MaxLength = 10;
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(109, 22);
			this.txtCode.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(59, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Code: ";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnDelete);
			this.groupBox3.Controls.Add(this.btnClose);
			this.groupBox3.Controls.Add(this.btnSave);
			this.groupBox3.Location = new System.Drawing.Point(425, 43);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(93, 198);
			this.groupBox3.TabIndex = 35;
			this.groupBox3.TabStop = false;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Image = global::Pharmacy.Properties.Resources.delete;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(6, 139);
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
			// dgvSJMEDProducts
			// 
			this.dgvSJMEDProducts.AllowUserToAddRows = false;
			this.dgvSJMEDProducts.AllowUserToDeleteRows = false;
			this.dgvSJMEDProducts.AllowUserToResizeRows = false;
			this.dgvSJMEDProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSJMEDProducts.Location = new System.Drawing.Point(16, 19);
			this.dgvSJMEDProducts.Name = "dgvSJMEDProducts";
			this.dgvSJMEDProducts.ReadOnly = true;
			this.dgvSJMEDProducts.RowHeadersVisible = false;
			this.dgvSJMEDProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvSJMEDProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSJMEDProducts.Size = new System.Drawing.Size(476, 274);
			this.dgvSJMEDProducts.TabIndex = 10;
			this.dgvSJMEDProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSJMEDProducts_CellClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvSJMEDProducts);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox2.Location = new System.Drawing.Point(13, 251);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(507, 308);
			this.groupBox2.TabIndex = 34;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "SJMED Product Details";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(14, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(361, 25);
			this.label1.TabIndex = 33;
			this.label1.Text = "SJMED Pharmacy Products Price";
			// 
			// frmSJMEDProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(532, 571);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSJMEDProducts";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmSJMEDProducts";
			this.Load += new System.EventHandler(this.frmSJMEDProducts_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSJMEDProducts)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvSJMEDProducts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chkVATexempted;
    }
}
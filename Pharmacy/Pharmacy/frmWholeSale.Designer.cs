namespace Pharmacy
{
    partial class frmWholeSale
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvProductsWS = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label24 = new System.Windows.Forms.Label();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.txtInvoiceNo = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.txtTotalWS = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.txtTypeWS = new System.Windows.Forms.TextBox();
			this.lblPer = new System.Windows.Forms.Label();
			this.dtpOrderWS = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtUnitPriceWS = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtQuantityWS = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtDateExpiry = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtProdDesc = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbCompanyWS = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtProdCode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dgvOrders = new System.Windows.Forms.DataGridView();
			this.grpClose = new System.Windows.Forms.GroupBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnCheckout = new System.Windows.Forms.Button();
			this.btnVoid = new System.Windows.Forms.Button();
			this.label20 = new System.Windows.Forms.Label();
			this.lblVatable = new System.Windows.Forms.Label();
			this.lblVat = new System.Windows.Forms.Label();
			this.lblVatPercent = new System.Windows.Forms.Label();
			this.lblGrandTotal = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.grpCheckOut = new System.Windows.Forms.GroupBox();
			this.grpVoid = new System.Windows.Forms.GroupBox();
			this.lblVATExempted = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductsWS)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
			this.grpClose.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.grpCheckOut.SuspendLayout();
			this.grpVoid.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Maroon;
			this.label1.Location = new System.Drawing.Point(17, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(294, 25);
			this.label1.TabIndex = 15;
			this.label1.Text = "SJMED Whole Sale Orders";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvProductsWS);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(22, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(342, 538);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Whole Sale Products";
			// 
			// dgvProductsWS
			// 
			this.dgvProductsWS.AllowUserToAddRows = false;
			this.dgvProductsWS.AllowUserToDeleteRows = false;
			this.dgvProductsWS.AllowUserToResizeRows = false;
			this.dgvProductsWS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductsWS.Location = new System.Drawing.Point(16, 26);
			this.dgvProductsWS.Name = "dgvProductsWS";
			this.dgvProductsWS.ReadOnly = true;
			this.dgvProductsWS.RowHeadersVisible = false;
			this.dgvProductsWS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProductsWS.Size = new System.Drawing.Size(309, 500);
			this.dgvProductsWS.TabIndex = 30;
			this.dgvProductsWS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label24);
			this.groupBox2.Controls.Add(this.txtStock);
			this.groupBox2.Controls.Add(this.label23);
			this.groupBox2.Controls.Add(this.txtInvoiceNo);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.txtTotalWS);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.txtTypeWS);
			this.groupBox2.Controls.Add(this.lblPer);
			this.groupBox2.Controls.Add(this.dtpOrderWS);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.txtUnitPriceWS);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.txtQuantityWS);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.txtDateExpiry);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtProdDesc);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.cmbCompanyWS);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtProdCode);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(372, 52);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(740, 217);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Whole Sale Product Details";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(254, 175);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(45, 16);
			this.label24.TabIndex = 59;
			this.label24.Text = "Stock:";
			// 
			// txtStock
			// 
			this.txtStock.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtStock.Location = new System.Drawing.Point(302, 171);
			this.txtStock.Name = "txtStock";
			this.txtStock.ReadOnly = true;
			this.txtStock.Size = new System.Drawing.Size(83, 22);
			this.txtStock.TabIndex = 58;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(438, 35);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(78, 16);
			this.label23.TabIndex = 57;
			this.label23.Text = "Invoice No.:";
			// 
			// txtInvoiceNo
			// 
			this.txtInvoiceNo.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtInvoiceNo.Location = new System.Drawing.Point(517, 30);
			this.txtInvoiceNo.Name = "txtInvoiceNo";
			this.txtInvoiceNo.ReadOnly = true;
			this.txtInvoiceNo.Size = new System.Drawing.Size(180, 22);
			this.txtInvoiceNo.TabIndex = 56;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.Red;
			this.label18.Location = new System.Drawing.Point(503, 178);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(13, 16);
			this.label18.TabIndex = 53;
			this.label18.Text = "*";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(466, 178);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(42, 16);
			this.label19.TabIndex = 52;
			this.label19.Text = "Total:";
			// 
			// txtTotalWS
			// 
			this.txtTotalWS.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtTotalWS.Location = new System.Drawing.Point(517, 174);
			this.txtTotalWS.Name = "txtTotalWS";
			this.txtTotalWS.ReadOnly = true;
			this.txtTotalWS.Size = new System.Drawing.Size(179, 22);
			this.txtTotalWS.TabIndex = 15;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.Red;
			this.label16.Location = new System.Drawing.Point(100, 139);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(13, 16);
			this.label16.TabIndex = 50;
			this.label16.Text = "*";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(62, 138);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(43, 16);
			this.label17.TabIndex = 49;
			this.label17.Text = "Type:";
			// 
			// txtTypeWS
			// 
			this.txtTypeWS.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtTypeWS.Location = new System.Drawing.Point(116, 135);
			this.txtTypeWS.Name = "txtTypeWS";
			this.txtTypeWS.ReadOnly = true;
			this.txtTypeWS.Size = new System.Drawing.Size(132, 22);
			this.txtTypeWS.TabIndex = 12;
			// 
			// lblPer
			// 
			this.lblPer.AutoSize = true;
			this.lblPer.Location = new System.Drawing.Point(623, 141);
			this.lblPer.Name = "lblPer";
			this.lblPer.Size = new System.Drawing.Size(0, 16);
			this.lblPer.TabIndex = 47;
			// 
			// dtpOrderWS
			// 
			this.dtpOrderWS.CustomFormat = "dd/MM/yyyy";
			this.dtpOrderWS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpOrderWS.Location = new System.Drawing.Point(519, 65);
			this.dtpOrderWS.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.dtpOrderWS.Name = "dtpOrderWS";
			this.dtpOrderWS.Size = new System.Drawing.Size(175, 22);
			this.dtpOrderWS.TabIndex = 4;
			this.dtpOrderWS.ValueChanged += new System.EventHandler(this.dtpOrderWS_ValueChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(504, 141);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(13, 16);
			this.label10.TabIndex = 45;
			this.label10.Text = "*";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(465, 141);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(42, 16);
			this.label11.TabIndex = 44;
			this.label11.Text = "Price:";
			// 
			// txtUnitPriceWS
			// 
			this.txtUnitPriceWS.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtUnitPriceWS.Location = new System.Drawing.Point(518, 137);
			this.txtUnitPriceWS.Name = "txtUnitPriceWS";
			this.txtUnitPriceWS.ReadOnly = true;
			this.txtUnitPriceWS.Size = new System.Drawing.Size(99, 22);
			this.txtUnitPriceWS.TabIndex = 14;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Red;
			this.label12.Location = new System.Drawing.Point(504, 104);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(13, 16);
			this.label12.TabIndex = 42;
			this.label12.Text = "*";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(449, 105);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(59, 16);
			this.label13.TabIndex = 41;
			this.label13.Text = "Quantity:";
			// 
			// txtQuantityWS
			// 
			this.txtQuantityWS.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtQuantityWS.Location = new System.Drawing.Point(518, 100);
			this.txtQuantityWS.MaxLength = 10;
			this.txtQuantityWS.Name = "txtQuantityWS";
			this.txtQuantityWS.Size = new System.Drawing.Size(99, 22);
			this.txtQuantityWS.TabIndex = 5;
			this.txtQuantityWS.TextChanged += new System.EventHandler(this.txtQuantityWS_TextChanged);
			this.txtQuantityWS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantityWS_KeyPress);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Red;
			this.label14.Location = new System.Drawing.Point(505, 69);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(13, 16);
			this.label14.TabIndex = 39;
			this.label14.Text = "*";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(433, 70);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(77, 16);
			this.label15.TabIndex = 38;
			this.label15.Text = "Date Order:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(100, 174);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(13, 16);
			this.label8.TabIndex = 36;
			this.label8.Text = "*";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(26, 174);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 16);
			this.label9.TabIndex = 35;
			this.label9.Text = "Date Expiry:";
			// 
			// txtDateExpiry
			// 
			this.txtDateExpiry.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtDateExpiry.Location = new System.Drawing.Point(115, 171);
			this.txtDateExpiry.Name = "txtDateExpiry";
			this.txtDateExpiry.ReadOnly = true;
			this.txtDateExpiry.Size = new System.Drawing.Size(133, 22);
			this.txtDateExpiry.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(100, 102);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 16);
			this.label5.TabIndex = 33;
			this.label5.Text = "*";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 103);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 16);
			this.label6.TabIndex = 32;
			this.label6.Text = "Description:";
			// 
			// txtProdDesc
			// 
			this.txtProdDesc.Location = new System.Drawing.Point(115, 99);
			this.txtProdDesc.Name = "txtProdDesc";
			this.txtProdDesc.Size = new System.Drawing.Size(269, 22);
			this.txtProdDesc.TabIndex = 2;
			this.txtProdDesc.TextChanged += new System.EventHandler(this.txtProdDesc_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(101, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 16);
			this.label3.TabIndex = 30;
			this.label3.Text = "*";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(61, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 16);
			this.label4.TabIndex = 29;
			this.label4.Text = "Code:";
			// 
			// cmbCompanyWS
			// 
			this.cmbCompanyWS.BackColor = System.Drawing.SystemColors.HighlightText;
			this.cmbCompanyWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbCompanyWS.FormattingEnabled = true;
			this.cmbCompanyWS.Location = new System.Drawing.Point(114, 31);
			this.cmbCompanyWS.Name = "cmbCompanyWS";
			this.cmbCompanyWS.Size = new System.Drawing.Size(270, 21);
			this.cmbCompanyWS.TabIndex = 1;
			this.cmbCompanyWS.SelectedIndexChanged += new System.EventHandler(this.cmbComapanyWS_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(100, 34);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(13, 16);
			this.label7.TabIndex = 27;
			this.label7.Text = "*";
			// 
			// txtProdCode
			// 
			this.txtProdCode.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtProdCode.Location = new System.Drawing.Point(116, 65);
			this.txtProdCode.Name = "txtProdCode";
			this.txtProdCode.ReadOnly = true;
			this.txtProdCode.Size = new System.Drawing.Size(132, 22);
			this.txtProdCode.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Company:";
			// 
			// btnCancel
			// 
			this.btnCancel.Image = global::Pharmacy.Properties.Resources.close22;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(6, 68);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(98, 40);
			this.btnCancel.TabIndex = 55;
			this.btnCancel.Text = "  &Cancel";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Image = global::Pharmacy.Properties.Resources.delete25;
			this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemove.Location = new System.Drawing.Point(6, 167);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(98, 40);
			this.btnRemove.TabIndex = 54;
			this.btnRemove.Text = "&Remove";
			this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Image = global::Pharmacy.Properties.Resources.add_jpg;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(6, 16);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(98, 40);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "  &Add";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgvOrders);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(370, 275);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(638, 315);
			this.groupBox3.TabIndex = 18;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Whole Sale Orders";
			// 
			// dgvOrders
			// 
			this.dgvOrders.AllowUserToAddRows = false;
			this.dgvOrders.AllowUserToDeleteRows = false;
			this.dgvOrders.AllowUserToResizeRows = false;
			this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrders.Location = new System.Drawing.Point(10, 20);
			this.dgvOrders.Name = "dgvOrders";
			this.dgvOrders.ReadOnly = true;
			this.dgvOrders.RowHeadersVisible = false;
			this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvOrders.Size = new System.Drawing.Size(609, 283);
			this.dgvOrders.TabIndex = 29;
			this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
			// 
			// grpClose
			// 
			this.grpClose.Controls.Add(this.btnClose);
			this.grpClose.Location = new System.Drawing.Point(5, 170);
			this.grpClose.Name = "grpClose";
			this.grpClose.Size = new System.Drawing.Size(94, 64);
			this.grpClose.TabIndex = 33;
			this.grpClose.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::Pharmacy.Properties.Resources.close;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(5, 10);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(84, 49);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "&Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnCheckout
			// 
			this.btnCheckout.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckout.Image = global::Pharmacy.Properties.Resources.logout;
			this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCheckout.Location = new System.Drawing.Point(5, 10);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnCheckout.Size = new System.Drawing.Size(98, 49);
			this.btnCheckout.TabIndex = 5;
			this.btnCheckout.Text = "Check&Out";
			this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCheckout.UseVisualStyleBackColor = false;
			this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
			// 
			// btnVoid
			// 
			this.btnVoid.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnVoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoid.Image = global::Pharmacy.Properties.Resources._void;
			this.btnVoid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVoid.Location = new System.Drawing.Point(5, 10);
			this.btnVoid.Name = "btnVoid";
			this.btnVoid.Size = new System.Drawing.Size(84, 49);
			this.btnVoid.TabIndex = 7;
			this.btnVoid.Text = "&Void";
			this.btnVoid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVoid.UseVisualStyleBackColor = false;
			this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label20.Location = new System.Drawing.Point(56, 23);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(68, 20);
			this.label20.TabIndex = 34;
			this.label20.Text = "Vatable:";
			// 
			// lblVatable
			// 
			this.lblVatable.AutoSize = true;
			this.lblVatable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVatable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblVatable.Location = new System.Drawing.Point(119, 24);
			this.lblVatable.Name = "lblVatable";
			this.lblVatable.Size = new System.Drawing.Size(18, 20);
			this.lblVatable.TabIndex = 35;
			this.lblVatable.Text = "0";
			// 
			// lblVat
			// 
			this.lblVat.AutoSize = true;
			this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblVat.Location = new System.Drawing.Point(119, 52);
			this.lblVat.Name = "lblVat";
			this.lblVat.Size = new System.Drawing.Size(18, 20);
			this.lblVat.TabIndex = 37;
			this.lblVat.Text = "0";
			// 
			// lblVatPercent
			// 
			this.lblVatPercent.AutoSize = true;
			this.lblVatPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVatPercent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblVatPercent.Location = new System.Drawing.Point(50, 51);
			this.lblVatPercent.Name = "lblVatPercent";
			this.lblVatPercent.Size = new System.Drawing.Size(74, 20);
			this.lblVatPercent.TabIndex = 36;
			this.lblVatPercent.Text = "Vat 12%:";
			// 
			// lblGrandTotal
			// 
			this.lblGrandTotal.AutoSize = true;
			this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGrandTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblGrandTotal.Location = new System.Drawing.Point(119, 108);
			this.lblGrandTotal.Name = "lblGrandTotal";
			this.lblGrandTotal.Size = new System.Drawing.Size(18, 20);
			this.lblGrandTotal.TabIndex = 39;
			this.lblGrandTotal.Text = "0";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label22.Location = new System.Drawing.Point(28, 107);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(97, 20);
			this.label22.TabIndex = 38;
			this.label22.Text = "Grand Total:";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.grpCheckOut);
			this.groupBox5.Controls.Add(this.grpVoid);
			this.groupBox5.Controls.Add(this.lblGrandTotal);
			this.groupBox5.Controls.Add(this.lblVatable);
			this.groupBox5.Controls.Add(this.grpClose);
			this.groupBox5.Controls.Add(this.lblVATExempted);
			this.groupBox5.Controls.Add(this.lblVat);
			this.groupBox5.Controls.Add(this.label21);
			this.groupBox5.Controls.Add(this.label20);
			this.groupBox5.Controls.Add(this.lblVatPercent);
			this.groupBox5.Controls.Add(this.label22);
			this.groupBox5.Location = new System.Drawing.Point(1014, 275);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(218, 315);
			this.groupBox5.TabIndex = 40;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Computation";
			// 
			// grpCheckOut
			// 
			this.grpCheckOut.Controls.Add(this.btnCheckout);
			this.grpCheckOut.Location = new System.Drawing.Point(104, 170);
			this.grpCheckOut.Name = "grpCheckOut";
			this.grpCheckOut.Size = new System.Drawing.Size(108, 64);
			this.grpCheckOut.TabIndex = 41;
			this.grpCheckOut.TabStop = false;
			// 
			// grpVoid
			// 
			this.grpVoid.Controls.Add(this.btnVoid);
			this.grpVoid.Location = new System.Drawing.Point(8, 239);
			this.grpVoid.Name = "grpVoid";
			this.grpVoid.Size = new System.Drawing.Size(94, 64);
			this.grpVoid.TabIndex = 42;
			this.grpVoid.TabStop = false;
			// 
			// lblVATExempted
			// 
			this.lblVATExempted.AutoSize = true;
			this.lblVATExempted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVATExempted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblVATExempted.Location = new System.Drawing.Point(119, 80);
			this.lblVATExempted.Name = "lblVATExempted";
			this.lblVATExempted.Size = new System.Drawing.Size(18, 20);
			this.lblVATExempted.TabIndex = 41;
			this.lblVATExempted.Text = "0";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label21.Location = new System.Drawing.Point(4, 79);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(120, 20);
			this.label21.TabIndex = 40;
			this.label21.Text = "VAT Exempted:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnAdd);
			this.groupBox4.Controls.Add(this.btnRemove);
			this.groupBox4.Controls.Add(this.btnCancel);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(1118, 52);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(112, 217);
			this.groupBox4.TabIndex = 56;
			this.groupBox4.TabStop = false;
			// 
			// frmWholeSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(1258, 609);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmWholeSale";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Whole Sale";
			this.Load += new System.EventHandler(this.frmWholeSale_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductsWS)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
			this.grpClose.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.grpCheckOut.ResumeLayout(false);
			this.grpVoid.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.GroupBox grpClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DataGridView dgvProductsWS;
        private System.Windows.Forms.TextBox txtProdCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCompanyWS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProdDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDateExpiry;
        private System.Windows.Forms.DateTimePicker dtpOrderWS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUnitPriceWS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQuantityWS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTypeWS;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTotalWS;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblVatable;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblVatPercent;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.GroupBox grpCheckOut;
        private System.Windows.Forms.GroupBox grpVoid;
		private System.Windows.Forms.Label lblVATExempted;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.GroupBox groupBox4;
    }
}
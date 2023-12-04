namespace Pharmacy
{
    partial class frmSJMEDSale
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
			this.txtStock = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtReciptNo = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.lblVatable = new System.Windows.Forms.Label();
			this.lblVatPercent = new System.Windows.Forms.Label();
			this.lblVat = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.grpClose = new System.Windows.Forms.GroupBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.lblGrandTotal = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.txtType = new System.Windows.Forms.TextBox();
			this.lblPer = new System.Windows.Forms.Label();
			this.dtpDateOrder = new System.Windows.Forms.DateTimePicker();
			this.grpCheckOut = new System.Windows.Forms.GroupBox();
			this.btnCheckout = new System.Windows.Forms.Button();
			this.label22 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.lblTotalVATExmpted = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.lblChange = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.txtAmoutReceive = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtUnitPrice = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lvOrders = new System.Windows.Forms.ListView();
			this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Discount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Promo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StockId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DiscountId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PromoPer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SSOId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label13 = new System.Windows.Forms.Label();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvProductsWS = new System.Windows.Forms.DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.txtDateExpiry = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPromo = new System.Windows.Forms.TextBox();
			this.cmbDiscount = new System.Windows.Forms.ComboBox();
			this.label27 = new System.Windows.Forms.Label();
			this.txtCustomer = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtProdDesc = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProdCode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.grpVoid = new System.Windows.Forms.GroupBox();
			this.btnVoid = new System.Windows.Forms.Button();
			this.gbPrint = new System.Windows.Forms.GroupBox();
			this.btnPrint = new System.Windows.Forms.Button();
			this.grpClose.SuspendLayout();
			this.grpCheckOut.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductsWS)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.grpVoid.SuspendLayout();
			this.gbPrint.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtStock
			// 
			this.txtStock.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtStock.Location = new System.Drawing.Point(333, 175);
			this.txtStock.Name = "txtStock";
			this.txtStock.ReadOnly = true;
			this.txtStock.Size = new System.Drawing.Size(92, 22);
			this.txtStock.TabIndex = 58;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label23.Location = new System.Drawing.Point(506, 35);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(82, 16);
			this.label23.TabIndex = 57;
			this.label23.Text = "Receipt No.:";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label24.Location = new System.Drawing.Point(286, 178);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(45, 16);
			this.label24.TabIndex = 59;
			this.label24.Text = "Stock:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(26, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(266, 25);
			this.label1.TabIndex = 43;
			this.label1.Text = "SJMED Pharmacy Sales";
			// 
			// txtReciptNo
			// 
			this.txtReciptNo.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtReciptNo.Location = new System.Drawing.Point(590, 31);
			this.txtReciptNo.Name = "txtReciptNo";
			this.txtReciptNo.ReadOnly = true;
			this.txtReciptNo.Size = new System.Drawing.Size(180, 22);
			this.txtReciptNo.TabIndex = 56;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label20.Location = new System.Drawing.Point(40, 20);
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
			this.lblVatable.Location = new System.Drawing.Point(103, 21);
			this.lblVatable.Name = "lblVatable";
			this.lblVatable.Size = new System.Drawing.Size(18, 20);
			this.lblVatable.TabIndex = 35;
			this.lblVatable.Text = "0";
			// 
			// lblVatPercent
			// 
			this.lblVatPercent.AutoSize = true;
			this.lblVatPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVatPercent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblVatPercent.Location = new System.Drawing.Point(27, 52);
			this.lblVatPercent.Name = "lblVatPercent";
			this.lblVatPercent.Size = new System.Drawing.Size(80, 20);
			this.lblVatPercent.TabIndex = 36;
			this.lblVatPercent.Text = "VAT 12%:";
			// 
			// lblVat
			// 
			this.lblVat.AutoSize = true;
			this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblVat.Location = new System.Drawing.Point(103, 52);
			this.lblVat.Name = "lblVat";
			this.lblVat.Size = new System.Drawing.Size(18, 20);
			this.lblVat.TabIndex = 37;
			this.lblVat.Text = "0";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.Red;
			this.label18.Location = new System.Drawing.Point(570, 179);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(13, 16);
			this.label18.TabIndex = 53;
			this.label18.Text = "*";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label19.Location = new System.Drawing.Point(534, 179);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(42, 16);
			this.label19.TabIndex = 52;
			this.label19.Text = "Total:";
			// 
			// grpClose
			// 
			this.grpClose.Controls.Add(this.btnClose);
			this.grpClose.Location = new System.Drawing.Point(8, 220);
			this.grpClose.Name = "grpClose";
			this.grpClose.Size = new System.Drawing.Size(94, 64);
			this.grpClose.TabIndex = 47;
			this.grpClose.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::Pharmacy.Properties.Resources.close;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(4, 11);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(86, 49);
			this.btnClose.TabIndex = 11;
			this.btnClose.Text = "&Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// txtTotal
			// 
			this.txtTotal.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtTotal.Location = new System.Drawing.Point(585, 176);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(179, 22);
			this.txtTotal.TabIndex = 15;
			// 
			// lblGrandTotal
			// 
			this.lblGrandTotal.AutoSize = true;
			this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGrandTotal.ForeColor = System.Drawing.Color.White;
			this.lblGrandTotal.Location = new System.Drawing.Point(102, 110);
			this.lblGrandTotal.Name = "lblGrandTotal";
			this.lblGrandTotal.Size = new System.Drawing.Size(19, 20);
			this.lblGrandTotal.TabIndex = 39;
			this.lblGrandTotal.Text = "0";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.Red;
			this.label16.Location = new System.Drawing.Point(110, 141);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(13, 16);
			this.label16.TabIndex = 50;
			this.label16.Text = "*";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label17.Location = new System.Drawing.Point(69, 139);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(43, 16);
			this.label17.TabIndex = 49;
			this.label17.Text = "Type:";
			// 
			// txtType
			// 
			this.txtType.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtType.Location = new System.Drawing.Point(124, 137);
			this.txtType.Name = "txtType";
			this.txtType.ReadOnly = true;
			this.txtType.Size = new System.Drawing.Size(126, 22);
			this.txtType.TabIndex = 12;
			this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
			// 
			// lblPer
			// 
			this.lblPer.AutoSize = true;
			this.lblPer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblPer.Location = new System.Drawing.Point(683, 108);
			this.lblPer.Name = "lblPer";
			this.lblPer.Size = new System.Drawing.Size(0, 16);
			this.lblPer.TabIndex = 47;
			// 
			// dtpDateOrder
			// 
			this.dtpDateOrder.CustomFormat = "dd/MM/yyyy";
			this.dtpDateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateOrder.Location = new System.Drawing.Point(590, 67);
			this.dtpDateOrder.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.dtpDateOrder.Name = "dtpDateOrder";
			this.dtpDateOrder.Size = new System.Drawing.Size(178, 22);
			this.dtpDateOrder.TabIndex = 4;
			// 
			// grpCheckOut
			// 
			this.grpCheckOut.Controls.Add(this.btnCheckout);
			this.grpCheckOut.Location = new System.Drawing.Point(110, 220);
			this.grpCheckOut.Name = "grpCheckOut";
			this.grpCheckOut.Size = new System.Drawing.Size(117, 64);
			this.grpCheckOut.TabIndex = 49;
			this.grpCheckOut.TabStop = false;
			// 
			// btnCheckout
			// 
			this.btnCheckout.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckout.Image = global::Pharmacy.Properties.Resources.logout;
			this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCheckout.Location = new System.Drawing.Point(6, 11);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnCheckout.Size = new System.Drawing.Size(106, 49);
			this.btnCheckout.TabIndex = 10;
			this.btnCheckout.Text = "Check &Out";
			this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCheckout.UseVisualStyleBackColor = false;
			this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label22.Location = new System.Drawing.Point(10, 109);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(97, 20);
			this.label22.TabIndex = 38;
			this.label22.Text = "Grand Total:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(571, 142);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(13, 16);
			this.label10.TabIndex = 45;
			this.label10.Text = "*";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.lblTotalVATExmpted);
			this.groupBox5.Controls.Add(this.lblGrandTotal);
			this.groupBox5.Controls.Add(this.label28);
			this.groupBox5.Controls.Add(this.lblChange);
			this.groupBox5.Controls.Add(this.grpClose);
			this.groupBox5.Controls.Add(this.label26);
			this.groupBox5.Controls.Add(this.grpCheckOut);
			this.groupBox5.Controls.Add(this.txtAmoutReceive);
			this.groupBox5.Controls.Add(this.label21);
			this.groupBox5.Controls.Add(this.label20);
			this.groupBox5.Controls.Add(this.lblVatable);
			this.groupBox5.Controls.Add(this.lblVatPercent);
			this.groupBox5.Controls.Add(this.lblVat);
			this.groupBox5.Controls.Add(this.label22);
			this.groupBox5.Location = new System.Drawing.Point(880, 320);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(233, 295);
			this.groupBox5.TabIndex = 48;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Computation";
			// 
			// lblTotalVATExmpted
			// 
			this.lblTotalVATExmpted.AutoSize = true;
			this.lblTotalVATExmpted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalVATExmpted.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblTotalVATExmpted.Location = new System.Drawing.Point(103, 82);
			this.lblTotalVATExmpted.Name = "lblTotalVATExmpted";
			this.lblTotalVATExmpted.Size = new System.Drawing.Size(18, 20);
			this.lblTotalVATExmpted.TabIndex = 64;
			this.lblTotalVATExmpted.Text = "0";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label28.Location = new System.Drawing.Point(5, 81);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(102, 20);
			this.label28.TabIndex = 63;
			this.label28.Text = "VAT Exempt:";
			// 
			// lblChange
			// 
			this.lblChange.AutoSize = true;
			this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblChange.Location = new System.Drawing.Point(99, 184);
			this.lblChange.Name = "lblChange";
			this.lblChange.Size = new System.Drawing.Size(24, 25);
			this.lblChange.TabIndex = 62;
			this.lblChange.Text = "0";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label26.Location = new System.Drawing.Point(19, 182);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(82, 24);
			this.label26.TabIndex = 61;
			this.label26.Text = "Change:";
			// 
			// txtAmoutReceive
			// 
			this.txtAmoutReceive.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtAmoutReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAmoutReceive.Location = new System.Drawing.Point(103, 140);
			this.txtAmoutReceive.MaxLength = 10;
			this.txtAmoutReceive.Name = "txtAmoutReceive";
			this.txtAmoutReceive.Size = new System.Drawing.Size(116, 31);
			this.txtAmoutReceive.TabIndex = 9;
			this.txtAmoutReceive.TextChanged += new System.EventHandler(this.txtAmoutReceive_TextChanged);
			this.txtAmoutReceive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmoutReceive_KeyDown);
			this.txtAmoutReceive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmoutReceive_KeyPress);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label21.Location = new System.Drawing.Point(42, 143);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(58, 24);
			this.label21.TabIndex = 40;
			this.label21.Text = "Cash:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label11.Location = new System.Drawing.Point(508, 144);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(68, 16);
			this.label11.TabIndex = 44;
			this.label11.Text = "Unit Price:";
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtUnitPrice.Location = new System.Drawing.Point(586, 139);
			this.txtUnitPrice.Name = "txtUnitPrice";
			this.txtUnitPrice.ReadOnly = true;
			this.txtUnitPrice.Size = new System.Drawing.Size(179, 22);
			this.txtUnitPrice.TabIndex = 14;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Red;
			this.label12.Location = new System.Drawing.Point(573, 108);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(13, 16);
			this.label12.TabIndex = 42;
			this.label12.Text = "*";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lvOrders);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(314, 320);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(560, 358);
			this.groupBox3.TabIndex = 46;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "SJMED Pharmacy Orders";
			// 
			// lvOrders
			// 
			this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader [] {
            this.Description,
            this.Quantity,
            this.Discount,
            this.Promo,
            this.Price,
            this.Total,
            this.StockId,
            this.DiscountId,
            this.PromoPer,
            this.SSOId});
			this.lvOrders.FullRowSelect = true;
			this.lvOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvOrders.Location = new System.Drawing.Point(7, 20);
			this.lvOrders.MultiSelect = false;
			this.lvOrders.Name = "lvOrders";
			this.lvOrders.Size = new System.Drawing.Size(543, 321);
			this.lvOrders.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvOrders.TabIndex = 50;
			this.lvOrders.UseCompatibleStateImageBehavior = false;
			this.lvOrders.View = System.Windows.Forms.View.Details;
			this.lvOrders.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvOrders_ItemSelectionChanged);
			// 
			// Description
			// 
			this.Description.Text = "Description";
			this.Description.Width = 240;
			// 
			// Quantity
			// 
			this.Quantity.Text = "Qty";
			// 
			// Discount
			// 
			this.Discount.Text = "SD";
			this.Discount.Width = 50;
			// 
			// Promo
			// 
			this.Promo.Text = "Promo";
			this.Promo.Width = 50;
			// 
			// Price
			// 
			this.Price.Text = "Price";
			this.Price.Width = 70;
			// 
			// Total
			// 
			this.Total.Text = "Total";
			this.Total.Width = 70;
			// 
			// StockId
			// 
			this.StockId.Text = "StockId";
			// 
			// DiscountId
			// 
			this.DiscountId.Text = "DiscountId";
			// 
			// PromoPer
			// 
			this.PromoPer.Text = "PromoPer";
			// 
			// SSOId
			// 
			this.SSOId.Text = "SSOId";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label13.Location = new System.Drawing.Point(517, 107);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(59, 16);
			this.label13.TabIndex = 41;
			this.label13.Text = "Quantity:";
			// 
			// txtQuantity
			// 
			this.txtQuantity.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtQuantity.Location = new System.Drawing.Point(588, 104);
			this.txtQuantity.MaxLength = 10;
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(91, 22);
			this.txtQuantity.TabIndex = 5;
			this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
			this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Red;
			this.label14.Location = new System.Drawing.Point(575, 70);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(13, 16);
			this.label14.TabIndex = 39;
			this.label14.Text = "*";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label15.Location = new System.Drawing.Point(503, 71);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(77, 16);
			this.label15.TabIndex = 38;
			this.label15.Text = "Date Order:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvProductsWS);
			this.groupBox1.Location = new System.Drawing.Point(26, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(281, 626);
			this.groupBox1.TabIndex = 44;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "SJMED Pharmacy Products";
			// 
			// dgvProductsWS
			// 
			this.dgvProductsWS.AllowUserToAddRows = false;
			this.dgvProductsWS.AllowUserToDeleteRows = false;
			this.dgvProductsWS.AllowUserToResizeRows = false;
			this.dgvProductsWS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductsWS.Location = new System.Drawing.Point(13, 22);
			this.dgvProductsWS.Name = "dgvProductsWS";
			this.dgvProductsWS.ReadOnly = true;
			this.dgvProductsWS.RowHeadersVisible = false;
			this.dgvProductsWS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProductsWS.Size = new System.Drawing.Size(254, 587);
			this.dgvProductsWS.TabIndex = 90;
			this.dgvProductsWS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsWS_CellClick);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label9.Location = new System.Drawing.Point(31, 177);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 16);
			this.label9.TabIndex = 35;
			this.label9.Text = "Date Expiry:";
			// 
			// txtDateExpiry
			// 
			this.txtDateExpiry.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtDateExpiry.Location = new System.Drawing.Point(124, 174);
			this.txtDateExpiry.Name = "txtDateExpiry";
			this.txtDateExpiry.ReadOnly = true;
			this.txtDateExpiry.Size = new System.Drawing.Size(126, 22);
			this.txtDateExpiry.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(111, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 16);
			this.label5.TabIndex = 33;
			this.label5.Text = "*";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtPromo);
			this.groupBox2.Controls.Add(this.cmbDiscount);
			this.groupBox2.Controls.Add(this.label27);
			this.groupBox2.Controls.Add(this.txtCustomer);
			this.groupBox2.Controls.Add(this.label24);
			this.groupBox2.Controls.Add(this.txtStock);
			this.groupBox2.Controls.Add(this.label23);
			this.groupBox2.Controls.Add(this.txtReciptNo);
			this.groupBox2.Controls.Add(this.btnCancel);
			this.groupBox2.Controls.Add(this.btnRemove);
			this.groupBox2.Controls.Add(this.btnAdd);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.txtTotal);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.txtType);
			this.groupBox2.Controls.Add(this.lblPer);
			this.groupBox2.Controls.Add(this.dtpDateOrder);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.txtUnitPrice);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.txtQuantity);
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
			this.groupBox2.Controls.Add(this.txtProdCode);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(313, 52);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(799, 264);
			this.groupBox2.TabIndex = 45;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "SJMED Product Details";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label7.Location = new System.Drawing.Point(269, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 16);
			this.label7.TabIndex = 64;
			this.label7.Text = "Promo%:";
			// 
			// txtPromo
			// 
			this.txtPromo.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtPromo.Location = new System.Drawing.Point(333, 65);
			this.txtPromo.Name = "txtPromo";
			this.txtPromo.ReadOnly = true;
			this.txtPromo.Size = new System.Drawing.Size(92, 22);
			this.txtPromo.TabIndex = 63;
			this.txtPromo.Text = "0";
			// 
			// cmbDiscount
			// 
			this.cmbDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDiscount.FormattingEnabled = true;
			this.cmbDiscount.Location = new System.Drawing.Point(333, 137);
			this.cmbDiscount.Name = "cmbDiscount";
			this.cmbDiscount.Size = new System.Drawing.Size(93, 24);
			this.cmbDiscount.TabIndex = 3;
			this.cmbDiscount.SelectedIndexChanged += new System.EventHandler(this.cmbDiscount_SelectedIndexChanged);
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label27.Location = new System.Drawing.Point(269, 141);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(66, 16);
			this.label27.TabIndex = 62;
			this.label27.Text = "Discount: ";
			// 
			// txtCustomer
			// 
			this.txtCustomer.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtCustomer.Location = new System.Drawing.Point(125, 31);
			this.txtCustomer.Name = "txtCustomer";
			this.txtCustomer.Size = new System.Drawing.Size(300, 22);
			this.txtCustomer.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.Image = global::Pharmacy.Properties.Resources.close22;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(585, 212);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(82, 39);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Image = global::Pharmacy.Properties.Resources.delete25;
			this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemove.Location = new System.Drawing.Point(118, 215);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(94, 39);
			this.btnRemove.TabIndex = 8;
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
			this.btnAdd.Location = new System.Drawing.Point(674, 211);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(94, 39);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "  &Add";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(109, 177);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(13, 16);
			this.label8.TabIndex = 36;
			this.label8.Text = "*";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(37, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 16);
			this.label6.TabIndex = 32;
			this.label6.Text = "Description:";
			// 
			// txtProdDesc
			// 
			this.txtProdDesc.Location = new System.Drawing.Point(124, 101);
			this.txtProdDesc.Name = "txtProdDesc";
			this.txtProdDesc.Size = new System.Drawing.Size(301, 22);
			this.txtProdDesc.TabIndex = 2;
			this.txtProdDesc.TextChanged += new System.EventHandler(this.txtProdDesc_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(110, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 16);
			this.label3.TabIndex = 30;
			this.label3.Text = "*";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(68, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 16);
			this.label4.TabIndex = 29;
			this.label4.Text = "Code:";
			// 
			// txtProdCode
			// 
			this.txtProdCode.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtProdCode.Location = new System.Drawing.Point(124, 66);
			this.txtProdCode.Name = "txtProdCode";
			this.txtProdCode.ReadOnly = true;
			this.txtProdCode.Size = new System.Drawing.Size(126, 22);
			this.txtProdCode.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(55, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Customer:";
			// 
			// grpVoid
			// 
			this.grpVoid.Controls.Add(this.btnVoid);
			this.grpVoid.Location = new System.Drawing.Point(880, 616);
			this.grpVoid.Name = "grpVoid";
			this.grpVoid.Size = new System.Drawing.Size(95, 64);
			this.grpVoid.TabIndex = 50;
			this.grpVoid.TabStop = false;
			// 
			// btnVoid
			// 
			this.btnVoid.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnVoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoid.Image = global::Pharmacy.Properties.Resources.void1;
			this.btnVoid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVoid.Location = new System.Drawing.Point(5, 11);
			this.btnVoid.Name = "btnVoid";
			this.btnVoid.Size = new System.Drawing.Size(86, 49);
			this.btnVoid.TabIndex = 12;
			this.btnVoid.Text = "  &Void";
			this.btnVoid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVoid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnVoid.UseVisualStyleBackColor = false;
			this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
			// 
			// gbPrint
			// 
			this.gbPrint.Controls.Add(this.btnPrint);
			this.gbPrint.Location = new System.Drawing.Point(1016, 618);
			this.gbPrint.Name = "gbPrint";
			this.gbPrint.Size = new System.Drawing.Size(95, 64);
			this.gbPrint.TabIndex = 51;
			this.gbPrint.TabStop = false;
			// 
			// btnPrint
			// 
			this.btnPrint.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrint.Image = global::Pharmacy.Properties.Resources.printer;
			this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrint.Location = new System.Drawing.Point(5, 11);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(86, 49);
			this.btnPrint.TabIndex = 12;
			this.btnPrint.Text = "&Print";
			this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPrint.UseVisualStyleBackColor = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// frmSJMEDSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(1149, 693);
			this.ControlBox = false;
			this.Controls.Add(this.gbPrint);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.grpVoid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSJMEDSale";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SJMED Pharmacy Sale";
			this.Load += new System.EventHandler(this.frmSJMEDSale_Load);
			this.grpClose.ResumeLayout(false);
			this.grpCheckOut.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductsWS)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.grpVoid.ResumeLayout(false);
			this.gbPrint.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReciptNo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Label lblVatable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblVatPercent;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox grpClose;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.DateTimePicker dtpDateOrder;
        private System.Windows.Forms.GroupBox grpCheckOut;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProductsWS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDateExpiry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProdDesc;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpVoid;
        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtAmoutReceive;
        private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txtCustomer;
		private System.Windows.Forms.ComboBox cmbDiscount;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Promo;
        private System.Windows.Forms.ColumnHeader Discount;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPromo;
        private System.Windows.Forms.ColumnHeader StockId;
		private System.Windows.Forms.ColumnHeader DiscountId;
		private System.Windows.Forms.ColumnHeader PromoPer;
		private System.Windows.Forms.ColumnHeader SSOId;
		private System.Windows.Forms.GroupBox gbPrint;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Label lblTotalVATExmpted;
		private System.Windows.Forms.Label label28;
    }
}
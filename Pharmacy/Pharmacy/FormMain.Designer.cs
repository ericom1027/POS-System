namespace Pharmacy
{
    partial class frmMain
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
            System.Windows.Forms.Timer tmrTime;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.panelManageUsers = new System.Windows.Forms.Panel();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnLogoutUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddResetUser = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelProuducts = new System.Windows.Forms.Panel();
            this.btnWholeSaleProducts = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnSJMEDProducts = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.pnlSale = new System.Windows.Forms.Panel();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnWholeSaleTrans = new System.Windows.Forms.Button();
            this.btnPharmaSale = new System.Windows.Forms.Button();
            this.panelDistributor = new System.Windows.Forms.Panel();
            this.btnAddDistributorAndProducts = new System.Windows.Forms.Button();
            this.btnDistributor = new System.Windows.Forms.Button();
            this.pnlStocks = new System.Windows.Forms.Panel();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnStockWS = new System.Windows.Forms.Button();
            this.btnStockPharmacy = new System.Windows.Forms.Button();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.btnPHReport = new System.Windows.Forms.Button();
            this.btnWSReport = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrDistributorButton = new System.Windows.Forms.Timer(this.components);
            this.tmrBtnManageUsers = new System.Windows.Forms.Timer(this.components);
            this.tmrBtnProducts = new System.Windows.Forms.Timer(this.components);
            this.tmrSale = new System.Windows.Forms.Timer(this.components);
            this.btnNearToExpire = new System.Windows.Forms.Button();
            this.btnExpiredProducts = new System.Windows.Forms.Button();
            this.btnStockShortage = new System.Windows.Forms.Button();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnWeeklySales = new System.Windows.Forms.Button();
            this.btnDailySales = new System.Windows.Forms.Button();
            this.tmrStockButton = new System.Windows.Forms.Timer(this.components);
            this.trmReport = new System.Windows.Forms.Timer(this.components);
            tmrTime = new System.Windows.Forms.Timer(this.components);
            this.gbMenu.SuspendLayout();
            this.panelManageUsers.SuspendLayout();
            this.panelProuducts.SuspendLayout();
            this.pnlSale.SuspendLayout();
            this.panelDistributor.SuspendLayout();
            this.pnlStocks.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrTime
            // 
            tmrTime.Enabled = true;
            tmrTime.Interval = 1000;
            tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // gbMenu
            // 
            this.gbMenu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbMenu.Controls.Add(this.panelManageUsers);
            this.gbMenu.Controls.Add(this.lblUser);
            this.gbMenu.Controls.Add(this.panelProuducts);
            this.gbMenu.Controls.Add(this.pnlSale);
            this.gbMenu.Controls.Add(this.panelDistributor);
            this.gbMenu.Controls.Add(this.pnlStocks);
            this.gbMenu.Controls.Add(this.pnlReport);
            this.gbMenu.ForeColor = System.Drawing.Color.Gray;
            this.gbMenu.Location = new System.Drawing.Point(-7, -8);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(183, 763);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            this.gbMenu.MouseHover += new System.EventHandler(this.gbMenu_MouseHover);
            // 
            // panelManageUsers
            // 
            this.panelManageUsers.Controls.Add(this.btnManageUser);
            this.panelManageUsers.Controls.Add(this.btnLogoutUser);
            this.panelManageUsers.Controls.Add(this.btnExit);
            this.panelManageUsers.Controls.Add(this.btnAddResetUser);
            this.panelManageUsers.Controls.Add(this.btnChangePassword);
            this.panelManageUsers.Location = new System.Drawing.Point(22, 80);
            this.panelManageUsers.Name = "panelManageUsers";
            this.panelManageUsers.Size = new System.Drawing.Size(137, 45);
            this.panelManageUsers.TabIndex = 15;
            // 
            // btnManageUser
            // 
            this.btnManageUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManageUser.Image = global::Pharmacy.Properties.Resources.users3031;
            this.btnManageUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUser.Location = new System.Drawing.Point(3, 3);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(132, 42);
            this.btnManageUser.TabIndex = 2;
            this.btnManageUser.Text = " Profile       ▼";
            this.btnManageUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageUser.UseVisualStyleBackColor = false;
            this.btnManageUser.Leave += new System.EventHandler(this.btnManageUser_Leave);
            this.btnManageUser.MouseHover += new System.EventHandler(this.btnManageUser_MouseHover);
            // 
            // btnLogoutUser
            // 
            this.btnLogoutUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogoutUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogoutUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoutUser.Location = new System.Drawing.Point(3, 85);
            this.btnLogoutUser.Name = "btnLogoutUser";
            this.btnLogoutUser.Size = new System.Drawing.Size(132, 42);
            this.btnLogoutUser.TabIndex = 5;
            this.btnLogoutUser.Text = "Logout";
            this.btnLogoutUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogoutUser.UseVisualStyleBackColor = false;
            this.btnLogoutUser.Click += new System.EventHandler(this.btnLogoutUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(3, 126);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 42);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddResetUser
            // 
            this.btnAddResetUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddResetUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddResetUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddResetUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddResetUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddResetUser.Location = new System.Drawing.Point(3, 44);
            this.btnAddResetUser.Name = "btnAddResetUser";
            this.btnAddResetUser.Size = new System.Drawing.Size(132, 42);
            this.btnAddResetUser.TabIndex = 3;
            this.btnAddResetUser.Text = "Add/Reset User";
            this.btnAddResetUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddResetUser.UseVisualStyleBackColor = false;
            this.btnAddResetUser.Click += new System.EventHandler(this.btnAddResetUser_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(3, 44);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(132, 42);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.Location = new System.Drawing.Point(24, 43);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 1;
            // 
            // panelProuducts
            // 
            this.panelProuducts.Controls.Add(this.btnWholeSaleProducts);
            this.panelProuducts.Controls.Add(this.btnDiscount);
            this.panelProuducts.Controls.Add(this.btnSJMEDProducts);
            this.panelProuducts.Controls.Add(this.btnProducts);
            this.panelProuducts.Location = new System.Drawing.Point(21, 151);
            this.panelProuducts.Name = "panelProuducts";
            this.panelProuducts.Size = new System.Drawing.Size(137, 45);
            this.panelProuducts.TabIndex = 15;
            // 
            // btnWholeSaleProducts
            // 
            this.btnWholeSaleProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWholeSaleProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWholeSaleProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWholeSaleProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWholeSaleProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWholeSaleProducts.Location = new System.Drawing.Point(2, 44);
            this.btnWholeSaleProducts.Name = "btnWholeSaleProducts";
            this.btnWholeSaleProducts.Size = new System.Drawing.Size(132, 44);
            this.btnWholeSaleProducts.TabIndex = 6;
            this.btnWholeSaleProducts.Text = "Whole Sale";
            this.btnWholeSaleProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWholeSaleProducts.UseVisualStyleBackColor = false;
            this.btnWholeSaleProducts.Click += new System.EventHandler(this.btnWholeSaleProducts_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.Location = new System.Drawing.Point(2, 130);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(132, 44);
            this.btnDiscount.TabIndex = 8;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnSJMEDProducts
            // 
            this.btnSJMEDProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSJMEDProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSJMEDProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSJMEDProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSJMEDProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSJMEDProducts.Location = new System.Drawing.Point(2, 87);
            this.btnSJMEDProducts.Name = "btnSJMEDProducts";
            this.btnSJMEDProducts.Size = new System.Drawing.Size(132, 44);
            this.btnSJMEDProducts.TabIndex = 7;
            this.btnSJMEDProducts.Text = "SJMED Pharmacy";
            this.btnSJMEDProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSJMEDProducts.UseVisualStyleBackColor = false;
            this.btnSJMEDProducts.Click += new System.EventHandler(this.btnSJMEDProducts_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProducts.Image = global::Pharmacy.Properties.Resources.products;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(2, 1);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(132, 44);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = " Products    ▼";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Leave += new System.EventHandler(this.btnProducts_Leave);
            this.btnProducts.MouseHover += new System.EventHandler(this.btnProducts_MouseHover);
            // 
            // pnlSale
            // 
            this.pnlSale.Controls.Add(this.btnSale);
            this.pnlSale.Controls.Add(this.btnWholeSaleTrans);
            this.pnlSale.Controls.Add(this.btnPharmaSale);
            this.pnlSale.Location = new System.Drawing.Point(20, 218);
            this.pnlSale.Name = "pnlSale";
            this.pnlSale.Size = new System.Drawing.Size(137, 45);
            this.pnlSale.TabIndex = 15;
            // 
            // btnSale
            // 
            this.btnSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSale.Image = global::Pharmacy.Properties.Resources.sales1;
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(3, 2);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(132, 42);
            this.btnSale.TabIndex = 7;
            this.btnSale.Text = " Sale          ▼";
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Leave += new System.EventHandler(this.btnSale_LostFocus);
            this.btnSale.MouseHover += new System.EventHandler(this.btnSale_MouseHover);
            // 
            // btnWholeSaleTrans
            // 
            this.btnWholeSaleTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWholeSaleTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWholeSaleTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWholeSaleTrans.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWholeSaleTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWholeSaleTrans.Location = new System.Drawing.Point(3, 43);
            this.btnWholeSaleTrans.Name = "btnWholeSaleTrans";
            this.btnWholeSaleTrans.Size = new System.Drawing.Size(132, 42);
            this.btnWholeSaleTrans.TabIndex = 8;
            this.btnWholeSaleTrans.Text = "Whole Sale";
            this.btnWholeSaleTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWholeSaleTrans.UseVisualStyleBackColor = false;
            this.btnWholeSaleTrans.Click += new System.EventHandler(this.btnWholeSaleTrans_Click);
            // 
            // btnPharmaSale
            // 
            this.btnPharmaSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPharmaSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPharmaSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharmaSale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPharmaSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPharmaSale.Location = new System.Drawing.Point(3, 84);
            this.btnPharmaSale.Name = "btnPharmaSale";
            this.btnPharmaSale.Size = new System.Drawing.Size(132, 42);
            this.btnPharmaSale.TabIndex = 9;
            this.btnPharmaSale.Text = "Pharmacy Sale";
            this.btnPharmaSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPharmaSale.UseVisualStyleBackColor = false;
            this.btnPharmaSale.Click += new System.EventHandler(this.btnPharmaSale_Click);
            // 
            // panelDistributor
            // 
            this.panelDistributor.Controls.Add(this.btnAddDistributorAndProducts);
            this.panelDistributor.Controls.Add(this.btnDistributor);
            this.panelDistributor.Location = new System.Drawing.Point(21, 286);
            this.panelDistributor.Name = "panelDistributor";
            this.panelDistributor.Size = new System.Drawing.Size(136, 45);
            this.panelDistributor.TabIndex = 14;
            // 
            // btnAddDistributorAndProducts
            // 
            this.btnAddDistributorAndProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddDistributorAndProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDistributorAndProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDistributorAndProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddDistributorAndProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDistributorAndProducts.Location = new System.Drawing.Point(3, 44);
            this.btnAddDistributorAndProducts.Name = "btnAddDistributorAndProducts";
            this.btnAddDistributorAndProducts.Size = new System.Drawing.Size(132, 44);
            this.btnAddDistributorAndProducts.TabIndex = 5;
            this.btnAddDistributorAndProducts.Text = "Add Distributor";
            this.btnAddDistributorAndProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddDistributorAndProducts.UseVisualStyleBackColor = false;
            this.btnAddDistributorAndProducts.Click += new System.EventHandler(this.btnAddDistributorAndProducts_Click);
            // 
            // btnDistributor
            // 
            this.btnDistributor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDistributor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistributor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistributor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDistributor.Image = global::Pharmacy.Properties.Resources.pharmacy_distribution_512;
            this.btnDistributor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDistributor.Location = new System.Drawing.Point(3, 3);
            this.btnDistributor.Name = "btnDistributor";
            this.btnDistributor.Size = new System.Drawing.Size(132, 42);
            this.btnDistributor.TabIndex = 4;
            this.btnDistributor.Text = " Distributors ▼";
            this.btnDistributor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDistributor.UseVisualStyleBackColor = false;
            this.btnDistributor.MouseLeave += new System.EventHandler(this.btnDistributor_Leave);
            this.btnDistributor.MouseHover += new System.EventHandler(this.btnDistributor_MouseHover);
            // 
            // pnlStocks
            // 
            this.pnlStocks.Controls.Add(this.btnStock);
            this.pnlStocks.Controls.Add(this.btnStockWS);
            this.pnlStocks.Controls.Add(this.btnStockPharmacy);
            this.pnlStocks.Location = new System.Drawing.Point(22, 359);
            this.pnlStocks.Name = "pnlStocks";
            this.pnlStocks.Size = new System.Drawing.Size(138, 45);
            this.pnlStocks.TabIndex = 17;
            // 
            // btnStock
            // 
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStock.Image = global::Pharmacy.Properties.Resources.stock;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(3, 3);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(132, 42);
            this.btnStock.TabIndex = 16;
            this.btnStock.Text = " Stocks       ▼";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Leave += new System.EventHandler(this.btnStock_LostFocus);
            this.btnStock.MouseHover += new System.EventHandler(this.btnStock_MouseHover);
            // 
            // btnStockWS
            // 
            this.btnStockWS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStockWS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockWS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStockWS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockWS.Location = new System.Drawing.Point(3, 44);
            this.btnStockWS.Name = "btnStockWS";
            this.btnStockWS.Size = new System.Drawing.Size(132, 44);
            this.btnStockWS.TabIndex = 17;
            this.btnStockWS.Text = "Whole Sale";
            this.btnStockWS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockWS.UseVisualStyleBackColor = false;
            this.btnStockWS.Click += new System.EventHandler(this.btnStockWS_Click);
            // 
            // btnStockPharmacy
            // 
            this.btnStockPharmacy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStockPharmacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockPharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockPharmacy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStockPharmacy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockPharmacy.Location = new System.Drawing.Point(3, 87);
            this.btnStockPharmacy.Name = "btnStockPharmacy";
            this.btnStockPharmacy.Size = new System.Drawing.Size(132, 44);
            this.btnStockPharmacy.TabIndex = 18;
            this.btnStockPharmacy.Text = "SJMED Pharmacy";
            this.btnStockPharmacy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockPharmacy.UseVisualStyleBackColor = false;
            this.btnStockPharmacy.Click += new System.EventHandler(this.btnStockPharmacy_Click);
            // 
            // pnlReport
            // 
            this.pnlReport.Controls.Add(this.btnPHReport);
            this.pnlReport.Controls.Add(this.btnWSReport);
            this.pnlReport.Controls.Add(this.btnReports);
            this.pnlReport.Location = new System.Drawing.Point(23, 433);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(137, 45);
            this.pnlReport.TabIndex = 15;
            // 
            // btnPHReport
            // 
            this.btnPHReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPHReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPHReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPHReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPHReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPHReport.Location = new System.Drawing.Point(3, 85);
            this.btnPHReport.Name = "btnPHReport";
            this.btnPHReport.Size = new System.Drawing.Size(132, 42);
            this.btnPHReport.TabIndex = 8;
            this.btnPHReport.Text = "BIR Pharmacy";
            this.btnPHReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPHReport.UseVisualStyleBackColor = false;
            this.btnPHReport.Click += new System.EventHandler(this.btnPHReport_Click);
            // 
            // btnWSReport
            // 
            this.btnWSReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWSReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWSReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWSReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWSReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWSReport.Location = new System.Drawing.Point(3, 44);
            this.btnWSReport.Name = "btnWSReport";
            this.btnWSReport.Size = new System.Drawing.Size(132, 42);
            this.btnWSReport.TabIndex = 7;
            this.btnWSReport.Text = "BIR Whole Sale";
            this.btnWSReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWSReport.UseVisualStyleBackColor = false;
            this.btnWSReport.Click += new System.EventHandler(this.btnWSReport_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReports.Image = global::Pharmacy.Properties.Resources.Generate_reports_Icon;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(3, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(132, 42);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = " Reports     ▼";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.MouseLeave += new System.EventHandler(this.btnReports_LostFocus);
            this.btnReports.MouseHover += new System.EventHandler(this.btnReports_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "SJMED PHARMACEUTICALS, INC.";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(282, 84);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(894, 84);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 21);
            this.lblTime.TabIndex = 13;
            // 
            // tmrDistributorButton
            // 
            this.tmrDistributorButton.Interval = 5;
            this.tmrDistributorButton.Tick += new System.EventHandler(this.tmrDistributorButton_Tick);
            // 
            // tmrBtnManageUsers
            // 
            this.tmrBtnManageUsers.Interval = 5;
            this.tmrBtnManageUsers.Tick += new System.EventHandler(this.tmrBtnManageUsers_Tick);
            // 
            // tmrBtnProducts
            // 
            this.tmrBtnProducts.Interval = 5;
            this.tmrBtnProducts.Tick += new System.EventHandler(this.tmrBtnProducts_Tick);
            // 
            // tmrSale
            // 
            this.tmrSale.Interval = 5;
            this.tmrSale.Tick += new System.EventHandler(this.tmrSale_Tick);
            // 
            // btnNearToExpire
            // 
            this.btnNearToExpire.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNearToExpire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNearToExpire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNearToExpire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNearToExpire.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNearToExpire.Image = global::Pharmacy.Properties.Resources.neartoexpire;
            this.btnNearToExpire.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNearToExpire.Location = new System.Drawing.Point(889, 143);
            this.btnNearToExpire.Name = "btnNearToExpire";
            this.btnNearToExpire.Size = new System.Drawing.Size(204, 88);
            this.btnNearToExpire.TabIndex = 14;
            this.btnNearToExpire.Text = "\r\nNear Expiry";
            this.btnNearToExpire.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNearToExpire.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNearToExpire.UseVisualStyleBackColor = false;
            this.btnNearToExpire.Click += new System.EventHandler(this.btnNearToExpire_Click);
            this.btnNearToExpire.MouseHover += new System.EventHandler(this.btnNearToExpire_MouseHover);
            // 
            // btnExpiredProducts
            // 
            this.btnExpiredProducts.BackColor = System.Drawing.Color.Crimson;
            this.btnExpiredProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExpiredProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpiredProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpiredProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExpiredProducts.Image = global::Pharmacy.Properties.Resources.expired;
            this.btnExpiredProducts.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnExpiredProducts.Location = new System.Drawing.Point(592, 143);
            this.btnExpiredProducts.Name = "btnExpiredProducts";
            this.btnExpiredProducts.Size = new System.Drawing.Size(204, 88);
            this.btnExpiredProducts.TabIndex = 10;
            this.btnExpiredProducts.Text = "\r\nExpired Products";
            this.btnExpiredProducts.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExpiredProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExpiredProducts.UseVisualStyleBackColor = false;
            this.btnExpiredProducts.Click += new System.EventHandler(this.btnExpiredProducts_Click);
            this.btnExpiredProducts.MouseHover += new System.EventHandler(this.btnExpiredProducts_MouseHover);
            // 
            // btnStockShortage
            // 
            this.btnStockShortage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStockShortage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStockShortage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockShortage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockShortage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStockShortage.Image = global::Pharmacy.Properties.Resources.outofstock;
            this.btnStockShortage.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnStockShortage.Location = new System.Drawing.Point(286, 143);
            this.btnStockShortage.Name = "btnStockShortage";
            this.btnStockShortage.Size = new System.Drawing.Size(204, 88);
            this.btnStockShortage.TabIndex = 9;
            this.btnStockShortage.Text = "\r\nStock Shortage\r\n\r\n\r\n";
            this.btnStockShortage.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStockShortage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStockShortage.UseVisualStyleBackColor = false;
            this.btnStockShortage.Click += new System.EventHandler(this.btnStockShortage_Click);
            this.btnStockShortage.MouseHover += new System.EventHandler(this.btnStockShortage_MouseHover);
            // 
            // btnMonthly
            // 
            this.btnMonthly.BackColor = System.Drawing.Color.ForestGreen;
            this.btnMonthly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthly.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMonthly.Image = global::Pharmacy.Properties.Resources.monthlysales;
            this.btnMonthly.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMonthly.Location = new System.Drawing.Point(889, 274);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(204, 88);
            this.btnMonthly.TabIndex = 8;
            this.btnMonthly.Text = "\r\nMonthly Sales";
            this.btnMonthly.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMonthly.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMonthly.UseVisualStyleBackColor = false;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            this.btnMonthly.MouseHover += new System.EventHandler(this.btnMonthly_MouseHover);
            // 
            // btnWeeklySales
            // 
            this.btnWeeklySales.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnWeeklySales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWeeklySales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeeklySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeeklySales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWeeklySales.Image = global::Pharmacy.Properties.Resources.weekly;
            this.btnWeeklySales.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnWeeklySales.Location = new System.Drawing.Point(592, 274);
            this.btnWeeklySales.Name = "btnWeeklySales";
            this.btnWeeklySales.Size = new System.Drawing.Size(204, 88);
            this.btnWeeklySales.TabIndex = 7;
            this.btnWeeklySales.Text = "\r\nWeekly Sales";
            this.btnWeeklySales.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnWeeklySales.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnWeeklySales.UseVisualStyleBackColor = false;
            this.btnWeeklySales.Click += new System.EventHandler(this.btnWeeklySales_Click);
            this.btnWeeklySales.MouseHover += new System.EventHandler(this.btnWeeklySales_MouseHover);
            // 
            // btnDailySales
            // 
            this.btnDailySales.BackColor = System.Drawing.Color.Brown;
            this.btnDailySales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDailySales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailySales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDailySales.Image = global::Pharmacy.Properties.Resources.daily;
            this.btnDailySales.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnDailySales.Location = new System.Drawing.Point(286, 271);
            this.btnDailySales.Name = "btnDailySales";
            this.btnDailySales.Size = new System.Drawing.Size(204, 88);
            this.btnDailySales.TabIndex = 6;
            this.btnDailySales.Text = "\r\nDaily Sales";
            this.btnDailySales.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDailySales.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDailySales.UseVisualStyleBackColor = false;
            this.btnDailySales.Click += new System.EventHandler(this.btnDailySales_Click);
            this.btnDailySales.MouseHover += new System.EventHandler(this.btnDailySales_MouseHover);
            // 
            // tmrStockButton
            // 
            this.tmrStockButton.Interval = 5;
            this.tmrStockButton.Tick += new System.EventHandler(this.tmrBtnStock_Tick);
            // 
            // trmReport
            // 
            this.trmReport.Interval = 5;
            this.trmReport.Tick += new System.EventHandler(this.trmReport_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Pharmacy.Properties.Resources.EIAT_medical_hub;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 624);
            this.ControlBox = false;
            this.Controls.Add(this.btnNearToExpire);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExpiredProducts);
            this.Controls.Add(this.btnStockShortage);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.btnWeeklySales);
            this.Controls.Add(this.btnDailySales);
            this.Controls.Add(this.gbMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SJMED PHARMACEUTICALS, INC.";
            this.Load += new System.EventHandler(this.fomMain_Load);
            this.Click += new System.EventHandler(this.FormMain_Click);
            this.MouseHover += new System.EventHandler(this.FormMain_MouseHover);
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.panelManageUsers.ResumeLayout(false);
            this.panelProuducts.ResumeLayout(false);
            this.pnlSale.ResumeLayout(false);
            this.panelDistributor.ResumeLayout(false);
            this.pnlStocks.ResumeLayout(false);
            this.pnlReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnDailySales;
        private System.Windows.Forms.Button btnWeeklySales;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnStockShortage;
        private System.Windows.Forms.Button btnExpiredProducts;        
        private System.Windows.Forms.Button btnDistributor;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panelDistributor;
        private System.Windows.Forms.Button btnAddDistributorAndProducts;
        private System.Windows.Forms.Timer tmrDistributorButton;
        private System.Windows.Forms.Button btnNearToExpire;
        private System.Windows.Forms.Panel panelManageUsers;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnAddResetUser;
        private System.Windows.Forms.Timer tmrBtnManageUsers;
        private System.Windows.Forms.Button btnLogoutUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelProuducts;
        private System.Windows.Forms.Button btnSJMEDProducts;
        private System.Windows.Forms.Button btnWholeSaleProducts;
        private System.Windows.Forms.Timer tmrBtnProducts;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Panel pnlSale;
        private System.Windows.Forms.Button btnPharmaSale;
        private System.Windows.Forms.Button btnWholeSaleTrans;
        private System.Windows.Forms.Timer tmrSale;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Panel pnlStocks;
        private System.Windows.Forms.Button btnStockWS;
        private System.Windows.Forms.Button btnStockPharmacy;
        private System.Windows.Forms.Timer tmrStockButton;
		private System.Windows.Forms.Panel pnlReport;
		private System.Windows.Forms.Button btnPHReport;
		private System.Windows.Forms.Button btnWSReport;
		private System.Windows.Forms.Timer trmReport;


    }
}


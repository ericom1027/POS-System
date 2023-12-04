using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Pharmacy
{
    public partial class frmMain : Form
    {
		frmMainController instanceMC = new frmMainController();

        //private bool xCheck = true;
        int intBtnNormal = 45;
        int intBtnDistributor1 = 45;
        int intBtnManageUsers2 = 45;
        int intBtnProducts = 45;
        int intBtnSale = 45;
        int intBtnStock = 45;
		int intBtnReport = 45;
        string strUserName = string.Empty;
        string strIdValue = string.Empty;
        int intUpdateTotal = 0;
        //int btn3 = 42;


        public frmMain(string strId)
        {
            InitializeComponent();
            getUserNameType(strId);            
        }

        private void getUserNameType(string strId)
        {
            var strValue = new PharmacyModel();
            var instGetUserInfor = new UserLoginController();
            var strArrayNameType = new PharmacyModel();

            strValue.strTypes = instGetUserInfor.strGetNameUserType(Convert.ToInt32(strId), "SP_GetNameUserType");
            strArrayNameType.strArrayValue = strValue.strTypes.Split(';');
            lblUser.Text = strArrayNameType.strArrayValue[0];

            strIdValue = strId;
            strUserName = strArrayNameType.strArrayValue[2];

            if (strArrayNameType.strArrayValue[1].ToString() == "1")
            {
                btnVisible(true);
            }
            else
            {
                btnVisible(false);
            }
            login_logoutLogs(lblUser.Text + " login");
        
        }

        private void btnVisible(Boolean blnTrueFalse)
        {
            //btnDailySales.Visible = blnTrueFalse;
            btnMonthly.Visible = blnTrueFalse;
            btnWeeklySales.Visible = blnTrueFalse;
            btnAddResetUser.Visible = blnTrueFalse;
            //btnAddDistributorAndProducts.Enabled = blnTrueFalse;
			btnDiscount.Enabled = blnTrueFalse;
			btnSJMEDProducts.Enabled = blnTrueFalse;
			btnWholeSaleProducts.Enabled = blnTrueFalse;
            btnPHReport.Enabled = blnTrueFalse;
            btnWSReport.Enabled = blnTrueFalse;
            btnAddDistributorAndProducts.Enabled = blnTrueFalse;
			btnStockPharmacy.Enabled = blnTrueFalse;
			btnStockWS.Enabled = blnTrueFalse;
			
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
			lblTime.Text = DateTime.Now.ToString("h:mm:ss tt");

			if (intUpdateTotal != 300)
			{
				intUpdateTotal = intUpdateTotal + 1;
			}
			else
			{
				intUpdateTotal = 0;
				getAllTotal();
			}
        }

        #region Main Form Load events

        private void fomMain_Load(object sender, EventArgs e)
        {

            //if (Properties.Settings.Default.KeyAccount != instanceMC.GetMACAddress())
            //{
            //    MessageBox.Show("Your Pharmacy System is not registered on this computer, Please contact your Vendor!", "License not Registered", MessageBoxButtons.OK);
            //    Application.Exit();
            //}            

			var strUser = new PharmacyModel();

			strUser.userSJMED = lblUser.Text;

            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

			getAllTotal();
        }

        private void FormMain_Click(object sender, EventArgs e)
        {
            btnMenuDropdownToNormal();
        }

        private void FormMain_MouseHover(object sender, EventArgs e)
        {
            btnMenuDropdownToNormal();
        }

        #endregion

        #region Button Profile events

        private void btnManageUser_MouseHover(object sender, EventArgs e)
        {
            btnMenuDropdownToNormal();
            this.panelManageUsers.Size = new Size(this.panelManageUsers.Size.Width, intBtnManageUsers2);
            tmrBtnManageUsers.Start();
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnMenuDropdownToNormal();
        }

        private void tmrBtnManageUsers_Tick(object sender, EventArgs e)
        {
            if (intBtnManageUsers2 > 200)
            {
                tmrBtnManageUsers.Stop();
            }
            else
            {
                this.panelManageUsers.Size = new Size(this.panelManageUsers.Size.Width, intBtnManageUsers2);
                intBtnManageUsers2 += 5;
            }
        }

        private void btnManageUser_Leave(object sender, EventArgs e)
        {

            tmrBtnManageUsers.Stop();
            intBtnManageUsers2 = 45;
        }

        private void btnAddResetUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUpdateUserShow = new frmAddUpdateUser();
            frmAddUpdateUserShow.ShowDialog();
        }

        private void btnLogoutUser_Click(object sender, EventArgs e)
        {
            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to logout?", "SJMED Pharma Inc System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
                login_logoutLogs(lblUser.Text + " logout");
                frmUserLogin frmUserLoginShow = new frmUserLogin();
                this.Hide();
                frmUserLoginShow.ShowDialog();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to exit?", "SJMED Pharma Inc System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
                login_logoutLogs(lblUser.Text + " logout");
                Application.Exit();
            }

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmShowFrmChangePassword = new frmChangePassword(strUserName, strIdValue);
            frmShowFrmChangePassword.ShowDialog();

        }

        private void login_logoutLogs(string strUserFullaName)
        {
            var instanceWriteLogs = new DistributorsController();

            instanceWriteLogs.writeErrorLogs(strUserFullaName);
        }


        #endregion

        #region Button Products events

        private void btnProducts_MouseHover(object sender, EventArgs e)
        {
            btnMenuDropdownToNormal();
            this.panelProuducts.Size = new Size(this.panelProuducts.Size.Width, intBtnProducts);
            tmrBtnProducts.Start();
        }

        private void tmrBtnProducts_Tick(object sender, EventArgs e)
        {
            if (intBtnProducts > 200)
            {

                tmrBtnProducts.Stop();
            }
            else
            {

                this.panelProuducts.Size = new Size(this.panelProuducts.Size.Width, intBtnProducts);
                intBtnProducts += 5;
            }
        }

        private void btnProducts_Leave(object sender, EventArgs e)
        {
            tmrBtnProducts.Stop();
            intBtnProducts = 45;
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            frmDiscount frmDiscountShow = new frmDiscount();
            frmDiscountShow.ShowDialog();
        }

        #endregion

        #region Button Sales Events

        private void btnSale_MouseHover(object sender, EventArgs e)
        {
            btnMenuDropdownToNormal();
            this.pnlSale.Size = new Size(this.pnlSale.Size.Width, intBtnSale);
            tmrSale.Start();
        }

		private void btnWholeSaleProducts_Click(object sender, EventArgs e)
		{
			frmWholeSalePrice frmWholeSaleShow = new frmWholeSalePrice();
			frmWholeSaleShow.ShowDialog();
		}


		private void btnSJMEDProducts_Click(object sender, EventArgs e)
		{
			frmSJMEDProducts fSJMEDProductShow = new frmSJMEDProducts();
			fSJMEDProductShow.ShowDialog();
		}

        private void btnWholeSaleTrans_Click(object sender, EventArgs e)
        {
            frmWholeSale frmWS = new frmWholeSale(string.Empty, string.Empty);
            frmWS.ShowDialog();

        }

        private void tmrSale_Tick(object sender, EventArgs e)
        {
            if (intBtnSale > 135)
            {
                tmrSale.Stop();
            }
            else
            {
                this.pnlSale.Size = new Size(this.pnlSale.Size.Width, intBtnSale);
                intBtnSale += 4;
            }
        }

        private void btnSale_LostFocus(object sender, EventArgs e)
        {
            tmrSale.Stop();
            intBtnSale = 45;
        }

        #endregion

		#region Button SJMED Sale

		private void btnPharmaSale_Click(object sender, EventArgs e)
		{
			frmSJMEDSale SJMEDSaleShow = new frmSJMEDSale(string.Empty, string.Empty, lblUser.Text);
			SJMEDSaleShow.ShowDialog();
		}

		#endregion

        #region Button Distributor Events

        private void btnDistributor_MouseHover(object sender, EventArgs e)
        {
            btnMenuDropdownToNormal();
            this.panelDistributor.Size = new Size(this.panelDistributor.Size.Width, intBtnDistributor1);
            tmrDistributorButton.Start();
        }

        private void btnDistributor_Leave(object sender, EventArgs e)
        {
            tmrDistributorButton.Stop();
            intBtnDistributor1 = 45;
        }

        private void tmrDistributorButton_Tick(object sender, EventArgs e)
        {
            if (intBtnDistributor1 > 135)
            {
                tmrDistributorButton.Stop();
            }
            else
            {
                this.panelDistributor.Size = new Size(this.panelDistributor.Size.Width, intBtnDistributor1);
                intBtnDistributor1 += 4;
            }
        }

        private void btnAddDistributorAndProducts_Click(object sender, EventArgs e)
        {
            frmDistributors myNewSubForm = new frmDistributors();
            myNewSubForm.ShowDialog();
        }

        #endregion

        #region Button Stock Events

        private void btnStockPharmacy_Click(object sender, EventArgs e)
        {
			frmSJMEDStock fSJMEDStock = new frmSJMEDStock();
			fSJMEDStock.ShowDialog();
        }

        private void btnStockWS_Click(object sender, EventArgs e)
        {
            frmStock frmSTK = new frmStock();

            frmSTK.ShowDialog();
        }

        private void tmrBtnStock_Tick(object sender, EventArgs e)
        {
            if (intBtnStock > 135)
            {
                tmrStockButton.Stop();
            }
            else
            {
                this.pnlStocks.Size = new Size(this.pnlStocks.Size.Width, intBtnStock);
                intBtnStock += 4;
            }
        }

        private void btnStock_LostFocus(object sender, EventArgs e)
        {
            tmrStockButton.Stop();
            intBtnStock = 45;
        }

        private void btnStock_MouseHover(object sender, EventArgs e)
        {
            btnMenuDropdownToNormal();
            this.pnlStocks.Size = new Size(this.pnlStocks.Size.Width, intBtnStock);
            tmrStockButton.Start();
        }

        #endregion

        #region Button Reports events

		private void trmReport_Tick(object sender, EventArgs e)
		{
			if (intBtnReport > 135)
			{
				trmReport.Stop();
			}
			else
			{
				this.pnlReport.Size = new Size(this.pnlReport.Size.Width, intBtnReport);
				intBtnReport += 4;
			}
		}

        private void btnReports_MouseHover(object sender, EventArgs e)
        {
			btnMenuDropdownToNormal();
			this.pnlReport.Size = new Size(this.pnlReport.Size.Width, intBtnReport);
			trmReport.Start();
        }

		private void btnReports_LostFocus(object sender, EventArgs e)
		{
			trmReport.Stop();
			intBtnReport = 45;
		}

		private void btnWSReport_Click(object sender, EventArgs e)
		{
			frmMonthlyDailyReport frmMDR = new frmMonthlyDailyReport("BIR Whole Sale");
			frmMDR.ShowDialog();
		}

		private void btnPHReport_Click(object sender, EventArgs e)
		{
			frmMonthlyDailyReport frmMDR = new frmMonthlyDailyReport("BIR SJMED Pharmacy");
			frmMDR.ShowDialog();
		}

        #endregion

        #region Reset All Panel Button to close

        public void btnMenuDropdownToNormal()
        {
            this.panelDistributor.Size = new Size(this.panelDistributor.Size.Width, intBtnNormal);
            this.panelManageUsers.Size = new Size(this.panelManageUsers.Size.Width, intBtnNormal);
            this.panelProuducts.Size = new Size(this.panelProuducts.Size.Width, intBtnNormal);
            this.pnlSale.Size = new Size(this.pnlSale.Size.Width, intBtnNormal);
            this.pnlStocks.Size = new Size(this.pnlStocks.Size.Width, intBtnNormal);
			this.pnlReport.Size = new Size(this.pnlReport.Size.Width, intBtnReport);
        }

        #endregion

        #region Buttonn Stock Shortage events

            private void btnStockShortage_MouseHover(object sender, EventArgs e)
            {
                btnMenuDropdownToNormal();
            }
        
        #endregion

        #region Button Expired Products events

            private void btnExpiredProducts_MouseHover(object sender, EventArgs e)
            {
                btnMenuDropdownToNormal();
            }

           

        #endregion

        #region Button Near to Expire Products events

            private void btnNearExpiry(object sender, EventArgs e)
            {
                btnMenuDropdownToNormal();
            }

            private void btnNearToExpire_MouseHover(object sender, EventArgs e)
            {
                btnMenuDropdownToNormal();
            }

        #endregion

        #region Button Daily Sales events

            private void btnDailySales_MouseHover(object sender, EventArgs e)
            {
                btnMenuDropdownToNormal();
            }

        #endregion

        private void gbMenu_MouseHover(object sender, EventArgs e)
        {
            btnMenuDropdownToNormal();
        }

        #region Button Weekly Sales events

        private void btnWeeklySales_MouseHover(object sender, EventArgs e)
        {
            btnMenuDropdownToNormal();
        }

        #endregion

        #region Button Monthly Sales events

        private void btnMonthly_MouseHover(object sender, EventArgs e)
        {
            btnMenuDropdownToNormal();
        }

       

        #endregion

		#region Get Total Expired, Near Expire and Out of Stock SJMED Phamacy Products

		private void getAllTotal()
		{
			mainObject mObj = new mainObject();
			{
				mObj.strShortageProduct = "0";
				mObj.strNearToExpired = "0";
				mObj.strExpired = "0";
				mObj.strShortageProduct = instanceMC.getTotal("SP_GetSJMEDStockShortage").ToString();
				mObj.strNearToExpired = instanceMC.getTotal("SP_GetLessThanSixMonthsDateExpiry").ToString();
				mObj.strExpired = instanceMC.getTotal("SP_GetSJMEDExpiredProducts").ToString();
			}

			btnStockShortage.Text = "\r\nStock Shortage\r\n\r\n\r\nTotal: " + mObj.strShortageProduct;
			btnNearToExpire.Text = "\r\nNear to Expire\r\n\r\n\r\nTotal: " + mObj.strNearToExpired;
			btnExpiredProducts.Text = "\r\nExpired Products\r\n\r\n\r\nTotal: " + mObj.strExpired;
		}

		#endregion

		#region Form Main Button 

		private void btnStockShortage_Click(object sender, EventArgs e)
		{
			frmReport frmProductStockShortageRep = new frmReport("SP_GetSJMEDProductsStockShortage", "DataSetShortageExpire", "Pharmacy.ExpireShortageSJMEDProducts.rdlc", "SJMED Products Stock Shortage", 7);
			frmProductStockShortageRep.ShowDialog();
		}

		private void btnExpiredProducts_Click(object sender, EventArgs e)
		{
			frmReport frmExpiredProductsRep = new frmReport("SP_GetSJMEDAllExpiredProducts", "DataSetShortageExpire", "Pharmacy.ExpireShortageSJMEDProducts.rdlc", "SJMED Products Expired", 7);
			frmExpiredProductsRep.ShowDialog();
		}

		private void btnNearToExpire_Click(object sender, EventArgs e)
		{
			frmReport frmNearExpireProductsRep = new frmReport("SP_GetSJMEDProductsLessThanSixMonthsDateExpiry", "DataSetShortageExpire", "Pharmacy.ExpireShortageSJMEDProducts.rdlc", "SJMED Products Near to Expire", 7);
			frmNearExpireProductsRep.ShowDialog();
		}

		private void btnDailySales_Click(object sender, EventArgs e)
		{

			frmMonthlyDailyReport frmMDR = new frmMonthlyDailyReport("Daily");
			frmMDR.ShowDialog();

		}

		private void btnMonthly_Click(object sender, EventArgs e)
		{
			frmMonthlyDailyReport frmMDR = new frmMonthlyDailyReport("Monthly");
			frmMDR.ShowDialog();
		}

		private void btnWeeklySales_Click(object sender, EventArgs e)
		{
			frmMonthlyDailyReport frmMDR = new frmMonthlyDailyReport("Weekly");
			frmMDR.ShowDialog();
		}

		#endregion

	}
    }


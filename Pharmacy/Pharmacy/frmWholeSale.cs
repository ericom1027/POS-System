using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class frmWholeSale : Form
    {
        WholeSaleController instanceClass = new WholeSaleController();
		WholeSaleObject WSOobj = new WholeSaleObject();
		DistributorsController instWriteErrorLogs = new DistributorsController();
        int intOrderId = 0;
        int intProductId = 0;
        int intOldProductId = 0;
        int intStockId = 0;
        int intOldQuantity = 0;
        string strVoidIVNo = string.Empty;
        string strVoidStatus = string.Empty;

        public frmWholeSale(string strInvoiceNo, string strVoid)
        {
            InitializeComponent();

            strVoidIVNo = strInvoiceNo;
            strVoidStatus = strVoid;
        }

        #region Form load event

        private void frmWholeSale_Load(object sender, EventArgs e)
        {
			

            AutoGenateInvoiceNo();
            getCompany();
            buttonVisibility(false);
            refreshWholeSaleProducts("");
            HideUnHideButtonCheckout();
            if (strVoidIVNo != string.Empty)
            {
                txtInvoiceNo.Text = strVoidIVNo;
                VoidControl();
            }
           
        }

        #endregion

        #region Fill the Company Combo Box control

        private void getCompany()
        {
            var getCompany = new WholeSaleController();

            DataTable dt = getCompany.DT("SP_GetDistributors");
            cmbCompanyWS.DisplayMember = "Company_Name";
            cmbCompanyWS.ValueMember = "Id";
            cmbCompanyWS.DataSource = dt;

            DataRow dr = dt.NewRow();
            dr["Company_Name"] = "--Select--";
            dr["Id"] = 0;
            dt.Rows.InsertAt(dr, 0);
            cmbCompanyWS.SelectedIndex = 0;

        }

        #endregion

        #region Filter product in Control text box Product Desc using TextChanged event

        private void txtProdDesc_TextChanged(object sender, EventArgs e)
        {
            refreshWholeSaleProducts(txtProdDesc.Text.Trim());
        }

        #endregion

        #region Button Close control event

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close this Whole Sale form?", "Close Whole Sale Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
                txtBoxClear();
                this.Close();
            }
        }

        #endregion

        #region Datagrid Products control Events

        public void refreshWholeSaleProducts(string strFilter)
        {

            var instClassGetWholeSale = new WholeSaleController();


            DataView dtView1 = new DataView(instClassGetWholeSale.withParDT("SP_FilterGetWholeSale", strFilter));
            dgvProductsWS.DataSource = dtView1;

            this.dgvProductsWS.Columns["ProductId"].Visible = false;
            this.dgvProductsWS.Columns["Code"].Visible = false;
            this.dgvProductsWS.Columns["Type_Of_Product"].Visible = false;
            this.dgvProductsWS.Columns["DateExpiry"].Visible = false;
            this.dgvProductsWS.Columns["Stock"].Visible = false;
            this.dgvProductsWS.Columns["Per"].Visible = false;
            this.dgvProductsWS.Columns["Price"].Visible = false;
            this.dgvProductsWS.Columns["StockId"].Visible = false;
            this.dgvProductsWS.Columns["Unit"].Visible = false;
            dgvProductsWS.AutoResizeColumns();
            dgvProductsWS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if ((dgvProductsWS.Rows.Count >= 1) && (e.RowIndex != -1))
            {
                intOldProductId = 0;
                intProductId = int.Parse(dgvProductsWS.SelectedCells[0].Value.ToString());
                txtProdCode.Text = dgvProductsWS.SelectedCells[1].Value.ToString();
                txtProdDesc.Text = dgvProductsWS.SelectedCells[2].Value.ToString();
                txtTypeWS.Text = dgvProductsWS.SelectedCells[3].Value.ToString();
                if (dgvProductsWS.SelectedCells[4].Value.ToString() != string.Empty)
                {
                    DateTime dtExpiryFormat = DateTime.Parse(dgvProductsWS.SelectedCells[4].Value.ToString());
                    txtDateExpiry.Text = dtExpiryFormat.ToString("MM/dd/yyyy");
                }
                else
                {
                    txtDateExpiry.Text = dgvProductsWS.SelectedCells[4].Value.ToString();
                }
                txtStock.Text = dgvProductsWS.SelectedCells[5].Value.ToString();
                lblPer.Text = dgvProductsWS.SelectedCells[9].Value.ToString() + " " + dgvProductsWS.SelectedCells[6].Value.ToString();
                txtUnitPriceWS.Text = dgvProductsWS.SelectedCells[7].Value.ToString();
                txtQuantityWS.Text = string.Empty;
                txtTotalWS.Text = string.Empty;
                intStockId = int.Parse(dgvProductsWS.SelectedCells[8].Value.ToString());
               
            }
        }

        #endregion

        #region Delete other character and accept digits only in Quantity control

        private void txtQuantityWS_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        #endregion

        #region Compute Quantity and Price to Get total Orders

        private void txtQuantityWS_TextChanged(object sender, EventArgs e)
        {
            if ((txtQuantityWS.Text != string.Empty) && (txtUnitPriceWS.Text != string.Empty))
            {
                if (int.Parse(txtQuantityWS.Text) > int.Parse(txtStock.Text))
                {
                    MessageBox.Show("Stock is not enough!", "Whole Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQuantityWS.Clear();
                    txtQuantityWS.Focus();
                }
                else
                {

                    WholeSaleObject WSCTotalObj = new WholeSaleObject();
                    {
                        WSCTotalObj.intQuantity = Convert.ToInt32(txtQuantityWS.Text);
                        WSCTotalObj.decPrice = Convert.ToDecimal(txtUnitPriceWS.Text);
                        txtTotalWS.Text = WSCTotalObj.decTotal.ToString();

                    }

                }
            }
        }
        #endregion

        #region Button Add and Update whole sale orders event

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // var instanceClass = new WholeSaleController();

            if (cmbCompanyWS.SelectedIndex == 0)
            {
                MessageBox.Show("Company field is required!", "Whole Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCompanyWS.Focus();
            }
            else if (txtProdCode.Text == string.Empty)
            {
                MessageBox.Show("Some fields is empty!", "Whole Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtQuantityWS.Text == string.Empty)
            {
                MessageBox.Show("Quantity field is required!", "Whole Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantityWS.Focus();
            }
            else
            {
                var strMessage = new PharmacyModel();
               
				WSOobj.intId = intOrderId;
				WSOobj.intCompanyId = Convert.ToInt32(cmbCompanyWS.SelectedValue.ToString());
				if (intOldProductId == 0)
				{
					WSOobj.intProductId = intProductId;
				}
				else
				{
					WSOobj.intProductId = intOldProductId;
				}

				WSOobj.DateOrder = DateTime.Parse(dtpOrderWS.Text);
				WSOobj.intQuantity = Convert.ToInt32(txtQuantityWS.Text);
				WSOobj.decPrice = Convert.ToDecimal(txtUnitPriceWS.Text);
				WSOobj.InvoiceNo = Int32.Parse(txtInvoiceNo.Text);
				WSOobj.StockId = intStockId;
                List<WholeSaleObject> objWSO = new List<WholeSaleObject>(2);
                objWSO.Add(WSOobj);
                WholeSaleObject WSOrder = objWSO[0];
                strMessage.strTypes = instanceClass.SaveUpdateWholeSaleOrder(WSOrder.intId, WSOrder.intCompanyId, WSOrder.intProductId, WSOrder.DateOrder, WSOrder.intQuantity, WSOrder.decTotal, (WSOobj.InvoiceNo), WSOobj.StockId);

                //value 1 is ADD and 2 is minus stock quantity
                if (strMessage.strTypes.Contains("successfully"))
                {
                   if(intOldProductId != 0)
                   {
                       if (intOldQuantity > WSOrder.intQuantity)
                       {
                           WSOrder.intQuantity = intOldQuantity - WSOrder.intQuantity;
                           instanceClass.updateStock(WSOrder.StockId, WSOrder.intQuantity, 1);
                       }
                       else if(intOldQuantity < WSOrder.intQuantity)
                       {
                           WSOrder.intQuantity = WSOrder.intQuantity - intOldQuantity;
                           instanceClass.updateStock(WSOrder.StockId, WSOrder.intQuantity, 2);
                       }
                   }
                   else
                   {
                       instanceClass.updateStock(WSOrder.StockId, WSOrder.intQuantity, 2);
                   }

                   if (strVoidStatus != string.Empty)
                   {
                       VoidObject VO = new VoidObject();
                       {
                           VO.OrderId = intOrderId;
                           VO.strReason = "Replace";
                       }

                       if (VO.OrderId != 0)
                       {
                           instanceClass.UpdateVoidWholeSaleOrders(VO.OrderId, VO.strReason);
                       }

                   }
                    txtBoxClear();
                    refreshWholeSaleOrders();
                    getGrandTotal();
                    buttonVisibility(false);
                    HideUnHideButtonCheckout();
                    MessageBox.Show(strMessage.strTypes, "Whole Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(strMessage.strTypes, "ERROR: Whole Sale Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        #endregion

        #region Datagrid Orders control events

        private void refreshWholeSaleOrders()
        {
            var getWholeSaleOrders = new WholeSaleController();

            DataTable dtViewOrders = new DataTable();

            if (strVoidStatus == string.Empty)
            {
                dtViewOrders = getWholeSaleOrders.getWholeSaleOrdersDT("SP_WholeSaleOrder", Convert.ToInt32(txtInvoiceNo.Text));
                dgvOrders.DataSource = dtViewOrders;
            }
            else
            {
                dtViewOrders = getWholeSaleOrders.withParDT("SP_VoidWholeSaleOrder", strVoidIVNo);
                dgvOrders.DataSource = dtViewOrders;
				
            }

			if (dtViewOrders.Rows.Count != 0)
			{
				cmbCompanyWS.SelectedValue = Convert.ToInt32(dtViewOrders.Rows [0] ["CompanyId"]);
				cmbCompanyWS.Enabled = false;
			}
			else
			{
				cmbCompanyWS.Enabled = true;
			}

            this.dgvOrders.Columns["OrderId"].Visible = false;
            this.dgvOrders.Columns["CompanyId"].Visible = false;
            this.dgvOrders.Columns["Type_Of_Product"].Visible = false;
            this.dgvOrders.Columns["Stock"].Visible = false;
            this.dgvOrders.Columns["Per"].Visible = false;
            this.dgvOrders.Columns["InvoiceNo"].Visible = false;
            this.dgvOrders.Columns["StockId"].Visible = false;
            this.dgvOrders.Columns["ProductId"].Visible = false;
            this.dgvOrders.Columns["Unit"].Visible = false;
            dgvOrders.AutoResizeColumns();
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (dtViewOrders.Rows.Count != 0)
            {
                txtInvoiceNo.Text = Convert.ToString(dtViewOrders.Rows[0]["InvoiceNo"]);
            }

            getGrandTotal();

        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvOrders.Rows.Count >= 1) && (e.RowIndex != -1))
            {
                dgvProductsWS.Enabled = false;
                buttonVisibility(true);
                btnAdd.Text = " &Update";
                intOrderId = int.Parse(dgvOrders.SelectedCells[0].Value.ToString());
                cmbCompanyWS.SelectedValue = int.Parse(dgvOrders.SelectedCells[1].Value.ToString());
                txtProdCode.Text = dgvOrders.SelectedCells[2].Value.ToString();
                txtProdDesc.Text = dgvOrders.SelectedCells[3].Value.ToString();
                txtTypeWS.Text = dgvOrders.SelectedCells[4].Value.ToString();
                if (dgvOrders.SelectedCells[5].Value.ToString() != string.Empty)
                {
                    DateTime dtExpiryFormat = DateTime.Parse(dgvOrders.SelectedCells[5].Value.ToString());
                    txtDateExpiry.Text = dtExpiryFormat.ToString("MM/dd/yyyy");
                }
                else
                {
                    txtDateExpiry.Text = dgvOrders.SelectedCells[5].Value.ToString();
                }

                txtQuantityWS.Text = dgvOrders.SelectedCells[6].Value.ToString();
                intOldQuantity = int.Parse(dgvOrders.SelectedCells[6].Value.ToString());
                txtStock.Text = dgvOrders.SelectedCells[7].Value.ToString();
                lblPer.Text = dgvOrders.SelectedCells[14].Value.ToString() + " " + dgvOrders.SelectedCells[8].Value.ToString();
                txtUnitPriceWS.Text = dgvOrders.SelectedCells[9].Value.ToString();
                txtTotalWS.Text = dgvOrders.SelectedCells[10].Value.ToString();
                intStockId = Int32.Parse(dgvOrders.SelectedCells[12].Value.ToString());
                intProductId = 0;
                intOldProductId = Int32.Parse(dgvOrders.SelectedCells[13].Value.ToString());
            }
            
        }

        #endregion

        #region Text Box Controls for Whole Sale Orders Form clear or make it Empty

        private void txtBoxClear()
        {
            dgvProductsWS.Enabled = true;
            intOrderId = 0;
            txtProdCode.Text = string.Empty;
            txtProdDesc.Text = string.Empty;
            txtTypeWS.Text = string.Empty;
            txtDateExpiry.Text = string.Empty;
            txtQuantityWS.Text = string.Empty;
            txtUnitPriceWS.Text = string.Empty;
            lblPer.Text = string.Empty;
            txtTotalWS.Text = string.Empty;
            txtStock.Text = string.Empty;
            //intOldProductId = 0;
            //intProductId = 0;
            intOldQuantity = 0;
            lblVatable.Text = "0";
            lblVat.Text = "0";
            lblGrandTotal.Text = "0";
            lblVATExempted.Text = "0";
        }

        #endregion

        #region Get the Grant Total of Whole Sale Orders

        private void getGrandTotal()
        {
				
				DataTable dt = new DataTable();
				

				if (strVoidIVNo != string.Empty)
				{

					dt = instanceClass.withParDT("SP_GetVOIDTotalWholeSaleOrders", txtInvoiceNo.Text);
				}
				else
				{
					dt = instanceClass.withParDT("SP_GetTotalWholeSaleOrders", txtInvoiceNo.Text);
				}

				if (dt.Rows.Count > 0)
				{
					WSOobj.TotalWithVAT = "0";
					lblVATExempted.Text = "0";
					lblGrandTotal.Text = "0";
					WSOobj.decDTWSTotal = 0;
					WSOobj.decWSTotal = 0;
					WSOobj.TotalWithVAT = string.Empty;

					try
					{
						for (int i = 0; i < dt.Rows.Count; i++)
						{
							WSOobj.VATExempted = instanceClass.CheckIfVatExempted("SP_CheckWSProductVatExempted", int.Parse(dt.Rows [i] ["ProductId"].ToString()));

							if (WSOobj.VATExempted == 1)
							{
								//lblVATExempted

								lblVATExempted.Text = (decimal.Parse(lblVATExempted.Text) + decimal.Parse(dt.Rows [i] ["Total"].ToString()).ToString());

								lblVATExempted.Text = string.Format("{0:0.00}", double.Parse(lblVATExempted.Text));
							}
							else
							{
								WSOobj.decDTWSTotal = decimal.Parse(dt.Rows [i] ["Total"].ToString());
								WSOobj.decWSTotal = WSOobj.decWSTotal + WSOobj.decDTWSTotal;
								WSOobj.TotalWithVAT = string.Format("{0:0.00}", WSOobj.decWSTotal);
							}

						}

						VATCompute();
						lblGrandTotal.Text = (decimal.Parse(lblGrandTotal.Text) + decimal.Parse(lblVATExempted.Text)).ToString();
					}
					catch(Exception ex) 
					{
						instWriteErrorLogs.writeErrorLogs("Error Whole Sale Total: " + ex.Message.ToString());
					}					
				}
        }

		private void VATCompute()
		{

			SJMEDSaleController instGetVAT = new SJMEDSaleController();

			try 
			{
				
				WSOobj.decGrandTotal = decimal.Parse(WSOobj.TotalWithVAT);
				WSOobj.dblVat = Convert.ToDouble(instGetVAT.getProductTotalStock("SP_GetDiscountValue", 1).ToString());
				lblVatable.Text = WSOobj.decVatable.ToString();
				lblVat.Text = WSOobj.discVatCalc.ToString();
				lblGrandTotal.Text = WSOobj.decGrandTotal.ToString();
			}
			catch(Exception ex)
			{
				instWriteErrorLogs.writeErrorLogs("Error Whole Sale VAT: " + ex.Message.ToString());
			
			}
			
		}

        #endregion

        #region Remove Orders

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var strMessage = new PharmacyModel();

            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to delete this Order?", "Delete Whole Sale Order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
                if (strVoidStatus != string.Empty)
                {
                    DataTable dt = new DataTable();
                    VoidObject VO = new VoidObject();
                    {
                        VO.OrderId = intOrderId;
                        VO.strReason = "Return";
                    }

                    if (VO.OrderId != 0)
                    {

                        dt = instanceClass.withParDT("SP_VoidCheckoutIsNull", VO.OrderId.ToString());

                        if (dt.Rows.Count > 0)
                        {
                            strMessage.strTypes = instanceClass.strDeleteWholeSaleOrder(intOrderId, intStockId, int.Parse(txtQuantityWS.Text), "SP_DeleteWholeSaleOrder");
                            if (strMessage.strTypes.Contains("successfully"))
                            {
                                instanceClass.updateStock(intStockId, int.Parse(txtQuantityWS.Text), 1);
                                txtBoxClear();
                                refreshWholeSaleOrders();
                                buttonVisibility(false);
                                HideUnHideButtonCheckout();
                                getGrandTotal();
                                MessageBox.Show(strMessage.strTypes, "Void Whole Sale Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(strMessage.strTypes, "Error Void Whole Sale Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else 
                        {
                            VO.strMessage = instanceClass.UpdateVoidWholeSaleOrders(VO.OrderId, VO.strReason);
                            if (VO.strMessage.Contains("successfully"))
                            {
                                instanceClass.updateStock(intStockId, int.Parse(txtQuantityWS.Text), 1);
                                txtBoxClear();
                                refreshWholeSaleOrders();
                                buttonVisibility(false);
                                HideUnHideButtonCheckout();
                                getGrandTotal();
                                MessageBox.Show(VO.strMessage, "Void Whole Sale Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(VO.strMessage, "Error Void Whole Sale Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot Remove, Please select in the Whole Sale Orders list!", "Void Whole Sale Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    strMessage.strTypes = instanceClass.strDeleteWholeSaleOrder(intOrderId, intStockId, int.Parse(txtQuantityWS.Text), "SP_DeleteWholeSaleOrder");

                    if (strMessage.strTypes.Contains("successfully"))
                    {
                        instanceClass.updateStock(intStockId, int.Parse(txtQuantityWS.Text), 1);
                        txtBoxClear();
                        refreshWholeSaleOrders();
                        buttonVisibility(false);
                        HideUnHideButtonCheckout();
                        getGrandTotal();

                        MessageBox.Show(strMessage.strTypes, "Whole Sale Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(strMessage.strTypes, "Whole Sale Order", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
            
        }

        #endregion

        #region Button Control visibility

        private void buttonVisibility(bool blnTrueFalse)
        {
            btnAdd.Text = "  &Add";
            btnRemove.Enabled = blnTrueFalse;
            btnCancel.Enabled = blnTrueFalse;
        }

        #endregion

        #region Button Cancel events

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to cancel this Whole Sale Orders form?", "Whole Sale Orders", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
                txtBoxClear();
                buttonVisibility(false);
                HideUnHideButtonCheckout();
                getGrandTotal();
                
            }
        }

        #endregion

        #region Automatic generate Invoice Number

        private void AutoGenateInvoiceNo()
        {

            WholeSaleObject newInvoiceNo = new WholeSaleObject();
            {
                newInvoiceNo.strInvoiceNo = instanceClass.getMaxNumber().ToString();
                txtInvoiceNo.Text = newInvoiceNo.autoGeneratedInvNo;
            }
        }

        #endregion

        #region Button Void event

        private void btnVoid_Click(object sender, EventArgs e)
        {
            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to Void some orders?", "Void Whole Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
                frmVoid frmWVD = new frmVoid(2, string.Empty);
                this.Hide();
                frmWVD.ShowDialog();
                this.Close();
            }
        }

        #endregion

        #region Date Orders value change event

        private void dtpOrderWS_ValueChanged(object sender, EventArgs e)
        {
            refreshWholeSaleOrders();
            HideUnHideButtonCheckout();
        }

        #endregion

        #region Button Checkout event

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            DialogResult dQuestionResuslt = MessageBox.Show("Make sure all the products orders are correct before checkout?", "Checkout Whole Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
                var strMessage = new PharmacyModel();

                WholeSaleObject wsoObj = new WholeSaleObject();
                {
                    //wsoObj.intId = intIdTotalWSO;
                    wsoObj.InvoiceNo = int.Parse(txtInvoiceNo.Text);
                    wsoObj.decVatableSetValue = decimal.Parse(lblVatable.Text);
                    wsoObj.decVatSetValue = decimal.Parse(lblVat.Text);
                    wsoObj.decGrandTotal = decimal.Parse(lblGrandTotal.Text);
					wsoObj.decVATExempted = decimal.Parse(lblVATExempted.Text);
					strMessage.strTypes = instanceClass.SaveUpdateTotalWholeSaleOrders(wsoObj.InvoiceNo, wsoObj.decVatableSetValue, wsoObj.decVatSetValue, wsoObj.decGrandTotal, wsoObj.decVATExempted);
                }

                if (strMessage.strTypes.Contains("successfull"))
                {
                    instanceClass.UpdateWholeSaleToCheckout(wsoObj.InvoiceNo, "Yes");

					frmReport frmRep = new frmReport("SP_ReportWSOSaleInvoice", "WSODataSet", "Pharmacy.ReportWSOInvoice.rdlc", wsoObj.InvoiceNo.ToString(), int.Parse("0"));
					this.Hide();
					frmRep.ShowDialog();
					this.Close();
                }
                else 
                {
                    MessageBox.Show(strMessage.strTypes, "Whole Sale Order Checkout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        #endregion

        #region Hide and un hide button Checkout

        private void HideUnHideButtonCheckout()
        {
            if (dgvOrders.Rows.Count == 0)
            {
                btnCheckout.Enabled = false;
            }
            else
            {
				btnCheckout.Enabled = true;
            }
        }

        #endregion

        #region Company Control box Selected Index Changed event

        private void cmbComapanyWS_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshWholeSaleOrders();
            HideUnHideButtonCheckout();
        }

        #endregion

        #region Disable Company and Visible Reason TextBox Control

        private void VoidControl()
        {
            if (strVoidStatus != string.Empty)
            {
                cmbCompanyWS.Enabled = false;
            }
            else
            {
                cmbCompanyWS.Enabled = true;
            }
        }

        #endregion

        #region Clear Object and Control after Checkout

        private void ClearAfterCheckout()
        {
            strVoidIVNo = string.Empty;
            strVoidStatus = string.Empty;
            cmbCompanyWS.SelectedIndex = 0;

        }

        #endregion

    }
}

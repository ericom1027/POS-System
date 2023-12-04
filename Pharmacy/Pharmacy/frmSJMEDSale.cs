using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Printing;

namespace Pharmacy
{
	public partial class frmSJMEDSale : Form
	{
		SJMEDSaleController instanceClass = new SJMEDSaleController();
		SJMEDSaleOrderObject SJMEDSO = new SJMEDSaleOrderObject();
		VoidObject VO = new VoidObject();
		PharmacyModel getUser = new PharmacyModel();
		DistributorsController instWriteErrorLogs = new DistributorsController();

		public frmSJMEDSale(string strReceiptNo, string strVoid, string strUser)
		{

			InitializeComponent();
			VO.strReceiptNo = strReceiptNo;
			VO.strVoidStatus = strVoid;
			getUser.userSJMED = strUser;

		}

		#region Text Box Product Description events

		private void txtProdDesc_TextChanged(object sender, EventArgs e)
		{
			SJMEDSO.strDesc = txtProdDesc.Text;
			refreshSJMEDSaleProducts(SJMEDSO.strDesc);
		}

		#endregion

		private void frmSJMEDSale_Load(object sender, EventArgs e)
		{

			if (VO.strVoidStatus != string.Empty)
			{
				txtReciptNo.Text = VO.strReceiptNo;
		
			}
			else
			{
				AutoGenateReceiptNo();
			}

			gbPrint.Visible = false;
			GetTempSJMEDOrders();
			getTotalOrders();
			lvOrders.Scrollable = false;
			btnCheckout.Enabled = false;
			getDiscount();
			refreshSJMEDSaleProducts(string.Empty);
			buttonVisibility(false);
			txtCustomer.Focus();
			checkGrandTotal();
		}

		#region Fill the Discount Combo Box control

		private void getDiscount()
		{

			DataTable dt = instanceClass.DT("SP_GetDiscount");
			cmbDiscount.DisplayMember = "Description";
			cmbDiscount.ValueMember = "Id";
			cmbDiscount.DataSource = dt;

			DataRow dr = dt.NewRow();
			dr ["Description"] = "--Select--";
			dr ["Id"] = 0;
			dt.Rows.InsertAt(dr, 0);
			cmbDiscount.SelectedIndex = 0;

		}

		#endregion

		#region Automatic generate Receipt Number

		private void AutoGenateReceiptNo()
		{
			SJMEDSO.strReceiptNo = instanceClass.getMaxNumber().ToString();
			txtReciptNo.Text = SJMEDSO.autoGenerateReceiptNo;
		}

		#endregion

		#region Datagrid SJMED Sale Products control Events

		public void refreshSJMEDSaleProducts(string strFilter)
		{

			DataView dtView1 = new DataView(instanceClass.withParDT("SP_FilterGetSJMEDSaleProducts", strFilter));
			dgvProductsWS.DataSource = dtView1;

			this.dgvProductsWS.Columns ["Id"].Visible = false;
			this.dgvProductsWS.Columns ["Code"].Visible = false;
			this.dgvProductsWS.Columns ["Type_Of_Product"].Visible = false;
			this.dgvProductsWS.Columns ["DateExpiry"].Visible = false;
			this.dgvProductsWS.Columns ["Stock"].Visible = false;
			this.dgvProductsWS.Columns ["Per"].Visible = false;
			this.dgvProductsWS.Columns ["Price"].Visible = false;
			this.dgvProductsWS.Columns ["StockId"].Visible = false;
			this.dgvProductsWS.Columns ["Unit"].Visible = false;
			this.dgvProductsWS.Columns ["Promo"].Visible = false;
			this.dgvProductsWS.Columns ["PromoExpire"].Visible = false;
			//this.dgvProductsWS.Columns ["VATExempted"].Visible = false;
			dgvProductsWS.AutoResizeColumns();
			dgvProductsWS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

		}

		private void dgvProductsWS_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if ((dgvProductsWS.Rows.Count >= 1) && (e.RowIndex != -1))
			{
				SJMEDSO.intOldProductId = 0;
				SJMEDSO.intProductId = int.Parse(dgvProductsWS.SelectedCells [0].Value.ToString());
				txtProdCode.Text = dgvProductsWS.SelectedCells [1].Value.ToString();
				txtProdDesc.Text = dgvProductsWS.SelectedCells [2].Value.ToString();
				txtType.Text = dgvProductsWS.SelectedCells [3].Value.ToString();

				if (dgvProductsWS.SelectedCells [4].Value.ToString() != string.Empty)
				{
					DateTime dtExpiryFormat = DateTime.Parse(dgvProductsWS.SelectedCells [4].Value.ToString());
					txtDateExpiry.Text = dtExpiryFormat.ToString("MM/dd/yyyy");
				}
				else
				{
					txtDateExpiry.Text = dgvProductsWS.SelectedCells [4].Value.ToString();
				}
				txtStock.Text = dgvProductsWS.SelectedCells [5].Value.ToString();
				lblPer.Text = dgvProductsWS.SelectedCells [6].Value.ToString() + " " + dgvProductsWS.SelectedCells [7].Value.ToString();
				txtUnitPrice.Text = dgvProductsWS.SelectedCells [8].Value.ToString();
				txtQuantity.Text = string.Empty;
				txtTotal.Text = string.Empty;
				txtPromo.Text = dgvProductsWS.SelectedCells [10].Value.ToString();
				SJMEDSO.intStockId = Int32.Parse(dgvProductsWS.SelectedCells [9].Value.ToString());
				if (dgvProductsWS.SelectedCells [11].Value.ToString() != string.Empty)
				{
					SJMEDSO.dtPromoExpiry = DateTime.Parse(dgvProductsWS.SelectedCells [11].Value.ToString());
					if (DateTime.Today > SJMEDSO.dtPromoExpiry)
					{
						txtPromo.Text = string.Empty;
					}
					else
					{
						txtPromo.Text = dgvProductsWS.SelectedCells [10].Value.ToString();
					}
				}

				//SJMEDSO.VATExempted = int.Parse(dgvProductsWS.SelectedCells [12].Value.ToString());

			}
		}

		#endregion

		#region Hide and un hide button Checkout

		private void HideUnHideButtonCheckout()
		{

			if (lvOrders.Items.Count == 0)
			{
				grpCheckOut.Visible = false;
			}
			else
			{
				grpCheckOut.Visible = true;
			}
		}

		#endregion

		#region Text Box Controls for SJMED Orders Form clear or make it Empty

		private void txtBoxClear()
		{
			dgvProductsWS.Enabled = true;

			txtProdCode.Text = string.Empty;
			txtProdDesc.Text = string.Empty;
			txtType.Text = string.Empty;
			txtDateExpiry.Text = string.Empty;
			txtQuantity.Text = string.Empty;
			txtUnitPrice.Text = string.Empty;
			lblPer.Text = string.Empty;
			txtTotal.Text = string.Empty;
			txtStock.Text = string.Empty;
			txtPromo.Text = string.Empty;
			if (lvOrders.Items.Count == 0)
			{
				txtAmoutReceive.Enabled = false;
				lblVatable.Text = "0";
				lblVat.Text = "0";
				lblGrandTotal.Text = "0";
                lblTotalVATExmpted.Text = "0";
			}
			else
			{
				txtAmoutReceive.Enabled = true;
			}

			SJMEDSO.intStockId = 0;
			//SJMEDSO.intLVOldQty = 0;
			SJMEDSO.intProductId = 0;
			SJMEDSO.intOldQty = 0;
			if (VO.strVoidStatus == string.Empty)
			{
				txtAmoutReceive.Text = string.Empty;
				lblChange.Text = "0";
			}
			cmbDiscount.SelectedIndex = 0;
			//SJMEDSO.blnAmtRecIsKeyPress = false;
			SJMEDSO.ProDiscount = string.Empty;
			SJMEDSO.SPDiscount = string.Empty;
		}

		#endregion

		#region Text Box Quantity events

		private void txtQuantity_TextChanged(object sender, EventArgs e)
		{
			ComputeDiscount();
		}

		private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
		{
			const char Delete = (char)8;
			e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
		}

		#endregion

		#region ListView SJMED Orders events

		private void lvOrders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (lvOrders.Items.Count > 0)
			{
				if (e.IsSelected)
				{
					lblPer.Text = string.Empty;
					txtProdDesc.Text = lvOrders.Items [lvOrders.FocusedItem.Index].Text;
					txtQuantity.Text = lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [1].Text;
					SJMEDSO.intOldQty = int.Parse(lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [1].Text);
					SJMEDSO.ProDiscount = lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [3].Text;
					txtUnitPrice.Text = lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [4].Text;
					txtTotal.Text = lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [5].Text;
					SJMEDSO.intStockId = int.Parse(lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [6].Text);
					txtStock.Text = instanceClass.getProductTotalStock("SP_GetSJMEDProductTotalStock", SJMEDSO.intStockId).ToString();
					SJMEDSO.intType = Convert.ToInt32(instanceClass.getProductTotalStock("SP_GetSJMEDProductType", SJMEDSO.intStockId));
					if (SJMEDSO.intType == 3)
					{
						cmbDiscount.Enabled = false;
					}
					else
					{
						cmbDiscount.Enabled = true;
					}

					if (lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [7].Text != string.Empty)
					{	
						cmbDiscount.SelectedValue = int.Parse(lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [7].Text);
					}

					txtPromo.Text = lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [8].Text;

					if ((VO.strVoidStatus != string.Empty))
					{
						//VO.SJMEDTotalSalesOrdersId = int.Parse(lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [8].Text);
						VO.SJMEDSalesOrderId = int.Parse(lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [9].Text);
					}

					buttonVisibility(true);
					btnAdd.Text = "&Update";
					dgvProductsWS.Enabled = false;
				}


			}
		}

		#endregion

		#region Check if ListView Orders is Empty to reset

		private void CheckLVOrdersContent()
		{
			buttonVisibility(false);
			txtBoxClear();
			txtCustomer.Focus();
		}

		#endregion

		#region Update SJMED Products Stock

		private void UpdateSJMEDProductStock()
		{
			if (SJMEDSO.intOldQty != 0)
			{
				if (SJMEDSO.intOldQty > SJMEDSO.intQuantity)
				{
					SJMEDSO.intQuantity = SJMEDSO.intOldQty - SJMEDSO.intQuantity;
					instanceClass.updateSJMEDStock(SJMEDSO.intStockId, SJMEDSO.intQuantity, 1);
				}
				else if (SJMEDSO.intOldQty < SJMEDSO.intQuantity)
				{
					SJMEDSO.intQuantity = SJMEDSO.intQuantity - SJMEDSO.intOldQty;
					instanceClass.updateSJMEDStock(SJMEDSO.intStockId, SJMEDSO.intQuantity, 2);
				}
			}
			else
			{
				instanceClass.updateSJMEDStock(SJMEDSO.intStockId, SJMEDSO.intQuantity, 2);
			}

		}

		#endregion

		#region Text Box Type events to disable and enabled the Combo Box Discount

		private void txtType_TextChanged(object sender, EventArgs e)
		{
			if ((txtType.Text == "Others") || (txtType.Text == string.Empty))
			{
				cmbDiscount.Enabled = false;
				cmbDiscount.SelectedIndex = 0;
			}
			else
			{
				cmbDiscount.Enabled = true;
				cmbDiscount.SelectedIndex = 0;
			}
		}

		#endregion

		#region Get Computation of VAT
		
		private void ComputeVAT()
		{
			SJMEDSO.decGrandTotal = decimal.Parse(SJMEDSO.strOldGrandTotal);
			SJMEDSO.dblVat = Convert.ToDouble(instanceClass.getProductTotalStock("SP_GetDiscountValue", 1).ToString());
			lblVatable.Text = string.Format("{0:0.00}", double.Parse(SJMEDSO.decVatable.ToString()));
			lblVat.Text = string.Format("{0:0.00}", SJMEDSO.discVatCalc);
			lblGrandTotal.Text = SJMEDSO.decGrandTotal.ToString();
		}

		#endregion

		#region Get Grand Total and Vatable and Vat computation

		private void getTotalOrders()
		{
			if (lvOrders.Items.Count > 0)
			{
				SJMEDSO.strOldGrandTotal = "0";
				lblGrandTotal.Text = "0";
				lblTotalVATExmpted.Text = "0";

				for (int i = 0; i < lvOrders.Items.Count; i++)
				{
					SJMEDSO.VATExempted = instanceClass.CheckIfVatExempted("SP_CheckSJMEDProductVatExempted", int.Parse(lvOrders.Items [i].SubItems [6].Text));

					if (SJMEDSO.VATExempted == 1)
					{
						
						lblTotalVATExmpted.Text = (decimal.Parse(lblTotalVATExmpted.Text) + decimal.Parse(lvOrders.Items [i].SubItems [5].Text)).ToString();
						
						lblTotalVATExmpted.Text = string.Format("{0:0.00}", double.Parse(lblTotalVATExmpted.Text));
					}
					else
					{
						SJMEDSO.strOldGrandTotal = (decimal.Parse(SJMEDSO.strOldGrandTotal) + decimal.Parse(lvOrders.Items [i].SubItems [5].Text)).ToString();
						
					}
					
				}

				ComputeVAT();
				lblGrandTotal.Text = (decimal.Parse(lblGrandTotal.Text) + decimal.Parse(lblTotalVATExmpted.Text)).ToString();
				checkGrandTotal();
			}

		}

		#endregion

		#region Get value in Temp Orders Table

		private void GetTempSJMEDOrders()
		{
			
			DataTable dt = new DataTable();

			if (VO.strVoidStatus != string.Empty)
			{
				dt = instanceClass.withParDT("SP_GetAllDataInVoidSJMEDOrders", txtReciptNo.Text);
			}
			else
			{
				dt = instanceClass.withParDT("SP_GetAllDataInTempSJMEDOrders", txtReciptNo.Text);
			}


			if (dt.Rows.Count > 0)
			{

				try
				{
					for (int i = 0; i < dt.Rows.Count; i++)
					{

						ListViewItem item = new ListViewItem(dt.Rows [i] ["Description"].ToString());
						item.SubItems.Add(dt.Rows [i] ["Qty"].ToString());
						item.SubItems.Add(dt.Rows [i] ["SD"].ToString());
						item.SubItems.Add(dt.Rows [i] ["ProDiscount"].ToString());
						item.SubItems.Add(dt.Rows [i] ["Price"].ToString());
						item.SubItems.Add(dt.Rows [i] ["Total"].ToString());
						item.SubItems.Add(dt.Rows [i] ["StockId"].ToString());
						//MessageBox.Show(dt.Rows [i] ["DiscountId"].ToString());
						item.SubItems.Add(dt.Rows [i] ["DiscountId"].ToString());
						item.SubItems.Add(dt.Rows [i] ["Promo"].ToString());
						if (VO.strVoidStatus != string.Empty)
						{
							
							item.SubItems.Add(dt.Rows [i] ["SSOId"].ToString());
							txtAmoutReceive.Text = dt.Rows [i] ["AmountReceived"].ToString();
							lblChange.Text = dt.Rows [i] ["Changed"].ToString();
							//VO.SJMEDSalesOrderId = int.Parse(dt.Rows [i]["SSOId"].ToString());
							//VO.SJMEDTotalSalesOrdersId = int.Parse(dt.Rows [i] ["TSOId"].ToString());
						}
						lvOrders.Items.Add(item);
						if (VO.strVoidStatus == string.Empty)
						{
							txtReciptNo.Text = dt.Rows [i] ["ReceiptNo"].ToString();
						}
						txtCustomer.Text = dt.Rows [i] ["Customer"].ToString();
						dtpDateOrder.Text = dt.Rows [i] ["DateOrder"].ToString();
						//MessageBox.Show(dt.Rows [i] ["Total"].ToString());
					}

				}
				catch (Exception ex)
				{

					instWriteErrorLogs.writeErrorLogs("Error populate orders Items: " + ex.Message.ToString());
				}


				getTotalOrders();
			}
		}

		#endregion

		#region Text Box Amount Receive event

		private void txtAmoutReceive_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			decimal x;
			if (ch == (char)Keys.Back)
			{
				e.Handled = false;
			}
			else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtAmoutReceive.Text + ch, out x))
			{
				e.Handled = true;
			}
		}

		private void txtAmoutReceive_KeyDown(object sender, KeyEventArgs e)
		{
            if (txtAmoutReceive.Text != string.Empty)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtAmoutReceive.Text != string.Empty)
                    {
                        SJMEDSO.decGrandTotal = decimal.Parse(lblGrandTotal.Text);
                        SJMEDSO.decAmtRec = decimal.Parse(txtAmoutReceive.Text);
                        lblChange.Text = SJMEDSO.decChange.ToString();
                        btnCheckout.Focus();
                    }

                    if (decimal.Parse(txtAmoutReceive.Text) < decimal.Parse(lblGrandTotal.Text))
                    {
                        MessageBox.Show("Amount Receive is not enough to the total amount product purchase!", "SJMED Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAmoutReceive.Focus();

                    }
                    else
                    {
                        btnCheckout.Enabled = true;

                    }
                }
            }
			
		}

		private void txtAmoutReceive_TextChanged(object sender, EventArgs e)
		{
			if (txtAmoutReceive.Text == string.Empty)
			{
				btnCheckout.Enabled = false;
			}
			else if (decimal.Parse(txtAmoutReceive.Text) < decimal.Parse(lblGrandTotal.Text))
			{
				btnCheckout.Enabled = false;
			}
		}

		#endregion

		#region Check if Grand Total not equal to Zero or < Zero to enable Amount Receive and Checkout control

		private void checkGrandTotal()
		{
			if (Convert.ToDecimal(lblGrandTotal.Text) <= Convert.ToDecimal(0.00))
			{
				txtAmoutReceive.Enabled = false;
				//btnCheckout.Enabled = false;
			}
			else
			{
				txtAmoutReceive.Enabled = true;
				//btnCheckout.Enabled = true;
			}
		}

		#endregion

		#region Button Cancel events

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to cancel this SJMED Product Order form?", "Whole Sale Orders", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (dQuestionResuslt == DialogResult.Yes)
			{
				dgvProductsWS.Enabled = true;
				txtBoxClear();
				buttonVisibility(false);
				HideUnHideButtonCheckout();
				//getGrandTotal();

			}
		}

		#endregion

		#region Button Close events

		private void btnClose_Click(object sender, EventArgs e)
		{
			//if ((lvOrders.Items.Count > 0) && VO.strVoidStatus == string.Empty)
			//{
			//    MessageBox.Show("Please remove all the item in the SJMED Pharmacy Orders table before you can close!", "SJMED Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//}
			//else
			//{
			DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close this SJMED Sale form?", "Close Whole Sale Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (dQuestionResuslt == DialogResult.Yes)
			{
				txtBoxClear();
				this.Close();
			}

			//}

		}

		#endregion

		#region Button Remove events

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (lvOrders.Items.Count > 0)
			{
				if (txtQuantity.Text != string.Empty)
				{
					SJMEDSO.intQuantity = int.Parse(txtQuantity.Text);
					instanceClass.updateSJMEDStock(SJMEDSO.intStockId, SJMEDSO.intQuantity, 1);
					lvOrders.Items.Remove(lvOrders.SelectedItems [0]);

					lblGrandTotal.Text = (decimal.Parse(SJMEDSO.strOldGrandTotal) - decimal.Parse(txtTotal.Text)).ToString();

					if (VO.strVoidStatus != string.Empty)
					{
						VO.strMessage = instanceClass.UpdateVoidSJMEDSaleOrders(VO.SJMEDSalesOrderId, "Return");
						VO.SJMEDSalesOrderId = 0;
					}
					else
					{
						instanceClass.strDeleteSJMEDOrders(SJMEDSO.intStockId.ToString(), "SP_DeleteTempSJMEDPerProductsOrder");
					}
					CheckLVOrdersContent();
					getTotalOrders();
				}
				else
				{
					MessageBox.Show("Please select item to remove in SJMED Pharmacy Orders!", "SJMED Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				//buttonVisibility(false);
			}

		}

		#endregion

		#region Button Add events

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (txtPromo.Text != string.Empty)
			{
				SJMEDSO.intPromo = int.Parse(txtPromo.Text);
			}
			else
			{
				SJMEDSO.intPromo = 0;
			}

			if (btnAdd.Text == "&Update")
			{
				if (SJMEDSO.intOldQty != 0)
				{
					SJMEDSO.intOldStock = SJMEDSO.intOldQty + int.Parse(txtStock.Text);
				}


				if (txtQuantity.Text == string.Empty)
				{
					MessageBox.Show("Quantity field is required!", "SJMED Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtQuantity.Focus();

				}
				else if (SJMEDSO.intOldStock < int.Parse(txtQuantity.Text))
				{
					MessageBox.Show("Cannot Update Order, Product stock is not enough!", "SJMED Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtQuantity.Focus();
				}
				else
				{
					try
					{
						lvOrders.Items [lvOrders.FocusedItem.Index].Text = txtProdDesc.Text;
						lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [1].Text = txtQuantity.Text;
						if (cmbDiscount.SelectedIndex != 0)
						{
							lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [2].Text = SJMEDSO.SPDiscount;

						}
						else
						{
							lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [2].Text = string.Empty;

						}
						lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [3].Text = SJMEDSO.ProDiscount;
						lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [4].Text = txtUnitPrice.Text;
						lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [5].Text = txtTotal.Text;
						lvOrders.Items [lvOrders.FocusedItem.Index].SubItems [7].Text = cmbDiscount.SelectedValue.ToString();
						SJMEDSO.intQuantity = int.Parse(txtQuantity.Text);

						if (VO.strVoidStatus != string.Empty)
						{
							if (SJMEDSO.intOldQty != SJMEDSO.intQuantity)
							{
								VO.strMessage = instanceClass.UpdateVoidSJMEDSaleOrders(VO.SJMEDSalesOrderId, "Replace");
								VO.SJMEDSalesOrderId = 0;
							}
						}
						else
						{
							instanceClass.SaveUpdateTempOrders(txtProdDesc.Text, SJMEDSO.intQuantity, SJMEDSO.SPDiscount, SJMEDSO.intPromo, decimal.Parse(txtUnitPrice.Text), decimal.Parse(txtTotal.Text), SJMEDSO.intStockId, txtReciptNo.Text, txtCustomer.Text, DateTime.Parse(dtpDateOrder.Text), int.Parse(cmbDiscount.SelectedValue.ToString()), SJMEDSO.ProDiscount);
						}

						UpdateSJMEDProductStock();
						getTotalOrders();
						CheckLVOrdersContent();


					}
					catch(Exception ex) 
					{
						MessageBox.Show("Update ERROR: " + ex.Message.ToString(), "ERROR SJMED Update Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}

			}
			else
			{
				if (txtProdCode.Text == string.Empty)
				{
					MessageBox.Show("Cannot Add Order, Some required field is empty!", "SJMED Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (txtQuantity.Text == string.Empty)
				{
					MessageBox.Show("Quantity field is required!", "SJMED Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtQuantity.Focus();
				}
				else if (int.Parse(txtStock.Text) < int.Parse(txtQuantity.Text))
				{
					MessageBox.Show("Cannot Add Order, Product stock is not enough!", "SJMED Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtQuantity.Focus();
				}
				else
				{

					string strPice = string.Format("{0:0.00}", double.Parse(txtUnitPrice.Text));
					ListViewItem item = new ListViewItem(txtProdDesc.Text);
					item.SubItems.Add(txtQuantity.Text);
					if (cmbDiscount.SelectedIndex != 0)
					{
						item.SubItems.Add(SJMEDSO.SPDiscount);
					}
					else
					{
						item.SubItems.Add(string.Empty);
					}

					item.SubItems.Add(SJMEDSO.ProDiscount);
					item.SubItems.Add(strPice);
					item.SubItems.Add(txtTotal.Text);
					item.SubItems.Add(SJMEDSO.intStockId.ToString());
					item.SubItems.Add(cmbDiscount.SelectedIndex.ToString());
					item.SubItems.Add(txtPromo.Text);
					if (VO.strVoidStatus != string.Empty)
					{
						//item.SubItems.Add("0");
						item.SubItems.Add(VO.SJMEDSalesOrderId.ToString());
					}

					//item.SubItems.Add(SJMEDSO.VATExempted.ToString());
					lvOrders.Items.Add(item);

					SJMEDSO.intQuantity = int.Parse(txtQuantity.Text);

					if (VO.strVoidStatus == string.Empty)
					{
						instanceClass.SaveUpdateTempOrders(txtProdDesc.Text, SJMEDSO.intQuantity, SJMEDSO.SPDiscount, SJMEDSO.intPromo, decimal.Parse(txtUnitPrice.Text), decimal.Parse(txtTotal.Text), SJMEDSO.intStockId, txtReciptNo.Text, txtCustomer.Text, DateTime.Parse(dtpDateOrder.Text), Int32.Parse(cmbDiscount.SelectedValue.ToString()), SJMEDSO.ProDiscount);
					}

					getTotalOrders();
					UpdateSJMEDProductStock();
					CheckLVOrdersContent();

				}

			}



		}

		#endregion

		#region Button Control visibility

		private void buttonVisibility(bool blnTrueFalse)
		{
			btnAdd.Text = "  &Add";
			btnRemove.Visible = blnTrueFalse;
			btnCancel.Visible = blnTrueFalse;


		}

		#endregion

		#region Button Check out event

		private void btnCheckout_Click(object sender, EventArgs e)
		{
			if (lvOrders.Items.Count == 0)
			{
				MessageBox.Show("No orders to be checkout!", "SJMED Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (txtAmoutReceive.Text == string.Empty)
			{
				MessageBox.Show("Amount Receive field is required!", "SJMED Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtAmoutReceive.Focus();
			}
			else
			{
				DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to Checkout?", "Checkout SJMED Pharmacy Orders", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (dQuestionResuslt == DialogResult.Yes)
				{

					if (lvOrders.Items.Count > 0)
					{


						for (int i = 0; i < lvOrders.Items.Count; i++)
						{
							SJMEDSO.strCustomer = txtCustomer.Text;
							SJMEDSO.intProductId = int.Parse(lvOrders.Items [i].SubItems [6].Text);
							SJMEDSO.dtOrder = DateTime.Parse(dtpDateOrder.Text + " " + string.Format("{0:H:mm:ss}", DateTime.Now));
							SJMEDSO.intQuantity = int.Parse(lvOrders.Items [i].SubItems [1].Text);
							SJMEDSO.SPDiscount = lvOrders.Items [i].SubItems [2].Text;

							if (lvOrders.Items [i].SubItems [7].Text != string.Empty)
							{
								SJMEDSO.intDiscount = int.Parse(lvOrders.Items [i].SubItems [7].Text);
							}
							else
							{
								SJMEDSO.intDiscount = 0;
							}
							if (lvOrders.Items [i].SubItems [8].Text != string.Empty)
							{
								SJMEDSO.intPromo = int.Parse(lvOrders.Items [i].SubItems [8].Text);
							}
							else
							{
								SJMEDSO.intPromo = 0;
							}
							SJMEDSO.decPrice = decimal.Parse(lvOrders.Items [i].SubItems [4].Text);
							SJMEDSO.decInsertTotal = decimal.Parse(lvOrders.Items [i].SubItems [5].Text);
							SJMEDSO.strReceiptNo = txtReciptNo.Text;
							SJMEDSO.ProDiscount = lvOrders.Items [i].SubItems [3].Text;
							if (VO.strVoidStatus != string.Empty)
							{
								VO.SJMEDSalesOrderId = int.Parse(lvOrders.Items [i].SubItems [9].Text);
								instWriteErrorLogs.writeErrorLogs("Void CO Product:" + lvOrders.Items [i].Text + ";QTY:" + SJMEDSO.intQuantity + ";ORNo.:" + SJMEDSO.strReceiptNo + ";Serve by:" + getUser.userSJMED);
							}
							else
							{
								VO.SJMEDSalesOrderId = 0;
								instWriteErrorLogs.writeErrorLogs("CO Product:" + lvOrders.Items [i].Text + ";QTY:" + SJMEDSO.intQuantity + ";ORNo.:" + SJMEDSO.strReceiptNo + ";Serve by:" + getUser.userSJMED);
							}
							
							SJMEDSO.strResults = instanceClass.SaveUpdateSJMEDProductOrders(VO.SJMEDSalesOrderId, SJMEDSO.intProductId, SJMEDSO.dtOrder, SJMEDSO.intQuantity, SJMEDSO.intDiscount, SJMEDSO.intPromo, SJMEDSO.decPrice, SJMEDSO.decInsertTotal, SJMEDSO.strReceiptNo, SJMEDSO.SPDiscount, SJMEDSO.ProDiscount);

						}


					}

					if (SJMEDSO.strResults.Contains("successfull"))
					{
						SJMEDSO.decVatableSetValue = decimal.Parse(lblVatable.Text);
						SJMEDSO.decVatSetValue = decimal.Parse(lblVat.Text);
						SJMEDSO.decGrandTotal = decimal.Parse(lblGrandTotal.Text);
						SJMEDSO.decAmtRec = decimal.Parse(txtAmoutReceive.Text);
						SJMEDSO.decChangeSetValue = decimal.Parse(lblChange.Text);
						SJMEDSO.strReceiptNo = txtReciptNo.Text;
						SJMEDSO.strReceiptNoPrint = txtReciptNo.Text;
						SJMEDSO.strCustomer = txtCustomer.Text;
						SJMEDSO.TotalVatExempted = decimal.Parse(lblTotalVATExmpted.Text);

						instanceClass.SaveUpdateSJMEDTotalSales(SJMEDSO.decVatableSetValue, SJMEDSO.decVatSetValue, SJMEDSO.decGrandTotal, SJMEDSO.decAmtRec, SJMEDSO.decChangeSetValue, SJMEDSO.strReceiptNo, SJMEDSO.strCustomer, SJMEDSO.TotalVatExempted);

						if (VO.strVoidStatus == string.Empty)
						{
							instanceClass.strDeleteSJMEDOrders(txtReciptNo.Text, "SP_DeleteTempSJMEDOrdersData");
						}
						//MessageBox.Show("Checkout has been process successfully!", "SJMED Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);

						
						lvOrders.Items.Clear();
						clearAfterCheckOut();
						CheckLVOrdersContent();
						AutoGenateReceiptNo();
						checkGrandTotal();
						GetTempSJMEDOrders();
						printReceipt();

					}
					else
					{
						MessageBox.Show("Checkout ERROR: " + SJMEDSO.strResults, "ERROR SJMED Sale Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}


				}

			}

		}

		#endregion

		#region Discount Computation

		private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((txtQuantity.Text != string.Empty) && (txtUnitPrice.Text != string.Empty))
			{
				//SJMEDSO.intDiscount = int.Parse(cmbDiscount.SelectedValue.ToString());
				ComputeDiscount();
			}
			
		}

		private void ComputeDiscount()
		{
			ComputeWithOutDiscount();

			if (cmbDiscount.SelectedIndex > 0)
			{
				if ((txtPromo.Text == string.Empty) || (txtPromo.Text == "0"))
				{
					SJMEDSO.dblDiscount = Convert.ToDouble(instanceClass.getProductTotalStock("SP_GetDiscountValue", int.Parse(cmbDiscount.SelectedValue.ToString())));
					SJMEDSO.decProdOrderTotal = decimal.Parse(txtTotal.Text);
					txtTotal.Text = string.Format("{0:0.00}", double.Parse(SJMEDSO.decTotalDiscount.ToString()));
					SJMEDSO.SPDiscount = "-" + string.Format("{0:0.00}", double.Parse(SJMEDSO.dblDiscountCalc.ToString()));
				}
			}
			else
			{
				if ((txtPromo.Text != "0") && (txtPromo.Text != string.Empty))
				{

					if ((txtQuantity.Text != string.Empty) && (txtUnitPrice.Text != string.Empty))
					{
						SJMEDSO.dblPromoDiscount = Convert.ToDouble(txtPromo.Text);
						SJMEDSO.decPromodOrderTotal = decimal.Parse(txtTotal.Text);
						txtTotal.Text = string.Format("{0:0.00}", double.Parse(SJMEDSO.decPromoTotalDiscount.ToString()));
						SJMEDSO.ProDiscount = "-" + string.Format("{0:0.00}", double.Parse(SJMEDSO.dblPromoDiscountCalc.ToString()));
					}
				}
			}
		}

		#endregion

		#region Computation with out Discount

		private void ComputeWithOutDiscount()
		{

			if ((txtQuantity.Text != string.Empty) && (txtUnitPrice.Text != string.Empty))
			{
				SJMEDSO.intQuantity = int.Parse(txtQuantity.Text);
				SJMEDSO.decPrice = decimal.Parse(txtUnitPrice.Text);
				txtTotal.Text = string.Format("{0:0.00}", double.Parse(SJMEDSO.decTotal.ToString()));
			}

		}

		#endregion

		#region Button Void events

		private void btnVoid_Click(object sender, EventArgs e)
		{
			frmVoid fVoid = new frmVoid(1, getUser.userSJMED);
			this.Hide();
			fVoid.ShowDialog();
			this.Close();
		}

		#endregion

		#region Clear Void Object After Checkout

		private void clearAfterCheckOut()
		{
			VO.strReceiptNo = string.Empty;
			VO.strVoidStatus = string.Empty;
			txtCustomer.Text = string.Empty;
		}

		#endregion

		#region Print Receipt

		private void btnPrint_Click(object sender, EventArgs e)
		{
			printReceipt();
		}

		private void printReceipt()
		{

			PrintDialog pDlog = new PrintDialog();
			PrintDocument pDoc = new PrintDocument();

			pDlog.Document = pDoc;

			pDoc.PrintPage += new PrintPageEventHandler(print_doc);
			DialogResult pResult = pDlog.ShowDialog();

			if (pResult == DialogResult.OK)
			{
				pDoc.Print();
			}

		}

		private void print_doc(object sender, PrintPageEventArgs e)
		{
			string s1 = string.Empty;
			string text = string.Empty;
			string Vat = "0";
			string gTotal = "0";
			string Cash = "0";
			string Change = "0";
			string ReceiptNo = string.Empty;
			string Customer = string.Empty;
			string DateOrder = string.Empty;
			int startX = 10;
			int startY = 10;
			int offset = 0;
			int intHeight = 90;

			Graphics g = e.Graphics;
			FontFamily fontFamily = new FontFamily("Courier New");
			Font font = new Font(fontFamily, 8.0F, FontStyle.Regular);
			int dy = (int)font.GetHeight(e.Graphics);
			SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));

			text = text + "SJMED PHARMACEUTICALS, INC.\n".PadLeft(41);
			text = text + "Buenaflor St. Dumangas, Iloilo\n".PadLeft(42);
			text = text + "Tel No.: 0966-398-2909\n\n".PadLeft(39);
			text = text + "-".PadLeft(50, '-') + "\n";
			text = text + "Description\tQty x Price\tTotal\n";
			text = text + "-".PadLeft(50, '-') + "\n";

			DataTable dt = new DataTable();
			dt = instanceClass.withParDT("SP_ReceiptSaleSJMED", SJMEDSO.strReceiptNoPrint);


			for (int i = 0; i < dt.Rows.Count; i++)
			{
				
				
				string strQty = dt.Rows [i] ["Qty"].ToString().Trim();
				string strPrice = dt.Rows [i] ["Price"].ToString().Trim();
				string strTotal = dt.Rows [i] ["Total"].ToString().Trim();
				string strDesc = dt.Rows [i] ["Description"].ToString().Trim();
				string strSPDiscount = dt.Rows [i] ["SPDiscount"].ToString().Trim();
				string strProDiscount = dt.Rows [i] ["ProDiscount"].ToString().Trim();
				int varLenght = strDesc.Length;
				string strValue = string.Empty;
				string scnValue = string.Empty;
				string scndValue = string.Empty;
				int scdLenght = 0;
				int intStrValueLenght = 0;

				if (varLenght > 22)
				{
					string [] strDescSplit = strDesc.Split(' ');
					if (strDescSplit.Length > 2)
					{
						strValue = strDescSplit [0] + " " + strDescSplit [1];
						intStrValueLenght = strValue.Length + 1;
						scdLenght = varLenght - intStrValueLenght;
						scndValue = strDesc.Substring(intStrValueLenght, scdLenght);
					}
					else
					{
						scdLenght = varLenght - 22;
						strValue = strDesc.Substring(0, 22);
						scndValue = strDesc.Substring(22, scdLenght);
					}
					
				}
				else
				{
					strValue = strDesc;
				}

				text = text + strValue + "\t" + strQty + " x " + strPrice + "\t" + strTotal + "\n";
				intHeight = intHeight + (int)dy + 5;

				if ((scndValue != string.Empty) || (strSPDiscount != string.Empty) || (strProDiscount != string.Empty))
				{
					if (scndValue != string.Empty)
					{
						scndValue = scndValue + "  ";
					}
					else
					{
						scndValue = string.Empty;
					}

					if (strSPDiscount != string.Empty)
					{
						strSPDiscount = "Discount( " + strSPDiscount + " )  ";
					}
					else
					{
						strSPDiscount = string.Empty;
					}

					if (strProDiscount != string.Empty)
					{
						strProDiscount = "Promo( " + strProDiscount + " )  ";
					}
					else
					{
						strProDiscount = string.Empty;
					}

					text = text + scndValue + strSPDiscount + strProDiscount + "\n";

					intHeight = intHeight + (int)dy + 4;

				}

				Vat = dt.Rows [i] ["VAT"].ToString();
				gTotal = dt.Rows [i] ["GrandTotal"].ToString();
				Cash = dt.Rows [i] ["AmountReceived"].ToString();
				Change = dt.Rows [i] ["Changed"].ToString();
				ReceiptNo = dt.Rows [i] ["ReceiptNo"].ToString();
				Customer = dt.Rows [i] ["Customer"].ToString();
				DateOrder = dt.Rows [i] ["DateOrder"].ToString();

			}


			StringFormat stringFormat = new StringFormat(StringFormatFlags.NoWrap);
			float [] tabs = { 200, 100, 100, 100 };
			stringFormat.SetTabStops(0, tabs);
			SizeF size = e.Graphics.MeasureString(text, font, 100, stringFormat);
			e.Graphics.DrawString(text, font, solidBrush, new RectangleF(10, 10, 650, size.Height), stringFormat);
			//Font f2 = new Font("Times New Roman", 9);
			int titleHeight = (int)size.Height + 1;
			//Rectangle rect = new Rectangle(10, 10, 650, titleHeight);
			//rect.Offset(0, titleHeight);
			//rect.Height -= titleHeight;

			offset = titleHeight + 15;

			g.DrawString("Vat:" + Vat + " Total:" + gTotal + " Cash:" + Cash + " Changed:" + Change, font, solidBrush, startX, startY + offset);

			g.DrawString("Receipt No.:" + ReceiptNo + " Customer:" + Customer, font, solidBrush, startX, startY + offset + 25);

			g.DrawString("Date:" + string.Format("{0:MM/dd/yyyy h:mm tt}", DateTime.Parse(DateOrder)) + " Serve By:" + getUser.userSJMED, font, solidBrush, startX, startY + offset + 45);

			g.DrawString("Product can return with in 7 days.".PadLeft(41), font, solidBrush, startX, startY + offset + 70);

			g.DrawString("Thank You.".PadLeft(29), font, solidBrush, startX, startY + offset + 80);

			g.DrawString("Plese Come Again".PadLeft(32), font, solidBrush, startX, startY + offset + 90);

		}

		
		#endregion
		
	}
}

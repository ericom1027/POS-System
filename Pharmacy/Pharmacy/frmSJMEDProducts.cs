﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Pharmacy
{
    public partial class frmSJMEDProducts : Form
    {
		SJMEDProductsController instanceClass = new SJMEDProductsController();
		PharmacyModel strMessage = new PharmacyModel();
		SJMEDProductsObject SPO = new SJMEDProductsObject(); 
		
		int intId = 0;
		string strOldDescription = string.Empty;

        public frmSJMEDProducts()
        {
            InitializeComponent();
        }

		private void frmSJMEDProducts_Load(object sender, EventArgs e)
		{
			GetCodeNo();
			fillCmbUMPer();
			fillCmbTypeProducts();
			refreshSJMEDProducts(string.Empty);
		}

		#region DataGrid SJMED Products events

		public void refreshSJMEDProducts(string strFilter)
		{

			if (strFilter != string.Empty)
			{
				DataTable dtView1 = new DataTable();
				dtView1 = instanceClass.withParDT("SP_GetSJMEDProducts", strFilter);
				dgvSJMEDProducts.DataSource = dtView1;
			}
			else
			{
				DataView dtView2 = new DataView(instanceClass.DT("SP_GetSJMEDProducts"));
				dgvSJMEDProducts.DataSource = dtView2;
			}

			this.dgvSJMEDProducts.Columns ["Id"].Visible = false;
			this.dgvSJMEDProducts.Columns ["Type_Of_Product"].Visible = false;
			this.dgvSJMEDProducts.Columns ["UM"].Visible = false;
			this.dgvSJMEDProducts.Columns ["VATExempted"].Visible = false;
			dgvSJMEDProducts.AutoResizeColumns();
			dgvSJMEDProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

		}

		private void dgvSJMEDProducts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if ((dgvSJMEDProducts.Rows.Count >= 1) && (e.RowIndex != -1))
			{
				btnClose.Text = "&New";
				btnClose.Image = Properties.Resources.dashboard;
				btnSave.Text = "   &Update";
				btnDelete.Enabled = true;
				intId = Convert.ToInt32(dgvSJMEDProducts.SelectedCells [0].Value.ToString());

				//WholeSaleProductsObject WSPO = new WholeSaleProductsObject();
				//{
				//    WSPO.strCodeNo = dgvSJMEDProducts.SelectedCells [1].Value.ToString();
				//    WSPO.strCodeNo = WSPO.autoGeneratedCodeNo;
				//}
				txtCode.Text = dgvSJMEDProducts.SelectedCells [1].Value.ToString();
				txtProductDescription.Text = dgvSJMEDProducts.SelectedCells [2].Value.ToString();
				strOldDescription = dgvSJMEDProducts.SelectedCells [2].Value.ToString();
				cmbType.SelectedValue = dgvSJMEDProducts.SelectedCells [3].Value.ToString();
				txtUnit.Text = dgvSJMEDProducts.SelectedCells [4].Value.ToString();
				cmbPer.SelectedValue = dgvSJMEDProducts.SelectedCells [5].Value.ToString();
				txtUnitPrice.Text = dgvSJMEDProducts.SelectedCells [6].Value.ToString();
				if (int.Parse(dgvSJMEDProducts.SelectedCells [7].Value.ToString()) == 1)
				{
					chkVATexempted.Checked = true;
				}
				else
				{
					chkVATexempted.Checked = false;
				}
			}

		}

		#endregion

		#region Get Auto Generated Code No

		private void GetCodeNo()
		{

			WholeSaleProductsObject newCodeNo = new WholeSaleProductsObject();
			{
				newCodeNo.strCodeNo = instanceClass.getMaxNoForCodeNo().ToString();
				txtCode.Text = newCodeNo.autoGeneratedCodeNo;
			}
		}

		#endregion

		#region Combo Box UM Per

		private void fillCmbUMPer()
		{

			DataTable dt = instanceClass.DT("SP_GetUMPer");

			cmbPer.DisplayMember = "Per";
			cmbPer.ValueMember = "Id";
			cmbPer.DataSource = dt;

			DataRow dr = dt.NewRow();
			dr ["Per"] = "--Select--";
			dr ["Id"] = 0;
			dt.Rows.InsertAt(dr, 0);
			cmbPer.SelectedIndex = 0;
		}

		#endregion

		#region Combo Box Product Type

		private void fillCmbTypeProducts()
		{
			//var getProductType = new StockController();

			DataTable dt = instanceClass.DT("SP_GetProductType");


			cmbType.DisplayMember = "Type_Of_Product";
			cmbType.ValueMember = "Id";
			cmbType.DataSource = dt;

			DataRow dr = dt.NewRow();
			dr ["Type_Of_Product"] = "--Select--";
			dr ["Id"] = 0;
			dt.Rows.InsertAt(dr, 0);
			cmbType.SelectedIndex = 0;
		}

		#endregion
		
		#region Text Box Product Descrition Text Changed event

			private void txtProductDescription_TextChanged(object sender, EventArgs e)
			{
				refreshSJMEDProducts(txtProductDescription.Text.Trim());
			}

		#endregion

		#region Text Box Controll clear events

			private void textBoxClear()
			{

				intId = 0;
				strOldDescription = string.Empty;
				txtCode.Text = string.Empty;
				txtProductDescription.Text = string.Empty;
				txtUnit.Text = string.Empty;
				txtUnitPrice.Text = string.Empty;
				btnClose.Text = "&Close";
				btnClose.Image = Properties.Resources.close;
				btnSave.Text = "&Save";
				btnDelete.Enabled = false;
				cmbPer.SelectedValue = 0;
				cmbType.SelectedValue = 0;
				txtProductDescription.Focus();
				chkVATexempted.Checked = false;

			}

			#endregion

		#region  Text Box Unit key press events

			private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
			{
				const char Delete = (char)8;
				e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
			}

			
		#endregion
		
		#region  Text Box Price key press events

			private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
			{
				char ch = e.KeyChar;
				decimal x;
				if (ch == (char)Keys.Back)
				{
					e.Handled = false;
				}
				else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtUnitPrice.Text + ch, out x))
				{
					e.Handled = true;
				}
			}

		#endregion
		
		#region Button Close click event

			private void btnClose_Click(object sender, EventArgs e)
			{
				if (btnClose.Text == "&New")
				{
					textBoxClear();
					GetCodeNo();
				}
				else
				{
					DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close this SJMED Products form?", "Close Whole Sale Price Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

					if (dQuestionResuslt == DialogResult.Yes)
					{
						textBoxClear();
						this.Close();
					}
				}
			}
			
			#endregion

		#region Button Save click event

			private void btnSave_Click(object sender, EventArgs e)
			{
				var strIntMessage = new PharmacyModel();
				if (txtProductDescription.Text != string.Empty)
				{
					if (strOldDescription != txtProductDescription.Text)
					{
						strIntMessage.intNumber = instanceClass.CheckProductDesction("SP_CheckSJMEDProductName", txtProductDescription.Text.Trim());
					}
				}

				if (txtProductDescription.Text == string.Empty)
				{
					MessageBox.Show("Product Description field is required!", "SJMED Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtProductDescription.Focus();
				}
				else if (strIntMessage.intNumber == 1)
				{
					MessageBox.Show("Product name already exist!", "SJMED Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtProductDescription.Focus();
				}

				else if (txtUnit.Text == string.Empty)
				{
					MessageBox.Show("Unit field is required!", "SJMED Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtUnit.Focus();
				}
				else if (cmbPer.SelectedIndex == 0)
				{
					MessageBox.Show("UM Per field is required!", "SJMED Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
					cmbPer.Focus();
				}
				else if (txtUnitPrice.Text == string.Empty)
				{
					MessageBox.Show("Unit price field is required!", "SJMED Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtUnitPrice.Focus();
				}
				else
				{
					var strMessage = new PharmacyModel();
					if (chkVATexempted.Checked == true)
					{
						SPO.intVATExempted = 1;
					}
					else 
					{
						SPO.intVATExempted = 0;
					}
					SPO.intIdSJMEDProd = intId;
					SPO.strCodeNo = txtCode.Text;
					SPO.strDescription = txtProductDescription.Text.Trim();
					SPO.intType = int.Parse(cmbType.SelectedValue.ToString());
					SPO.intUnit = Int32.Parse(txtUnit.Text);
					SPO.intUM = int.Parse(cmbType.SelectedValue.ToString());
					SPO.decPrice = decimal.Parse(txtUnitPrice.Text);

					strMessage.strTypes = instanceClass.SaveUpdateSJMEDProducts(SPO.intIdSJMEDProd, SPO.strCodeNo, SPO.strDescription, SPO.intType, SPO.intUnit, SPO.intUM, SPO.decPrice, SPO.intVATExempted);

					if (strMessage.strTypes.Contains("successfully"))
					{
						if (strMessage.strTypes.Contains("added"))
						{
							insertInStock();
						}
						//insertInStock();
						textBoxClear();
						GetCodeNo();
						refreshSJMEDProducts(string.Empty);
						MessageBox.Show(strMessage.strTypes, "SJMED Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show(strMessage.strTypes, "SJMED Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}

			}

			#endregion

		#region Button Delete event

			private void btnDelete_Click(object sender, EventArgs e)
			{
				var intProductId = new PharmacyModel();
				DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to delete this SJMED Product?", "Delete SJMED Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (dQuestionResuslt == DialogResult.Yes)
				{
					intProductId.intNumber = intId;
					strMessage.strTypes = instanceClass.strDeleteSJMEDProduct(intProductId.intNumber, "SP_DeleteSJMEDProducts");

					if (strMessage.strTypes.Contains("successfully"))
					{
						MessageBox.Show(strMessage.strTypes, "SJMED Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
						textBoxClear();
						refreshSJMEDProducts(string.Empty);
						GetCodeNo();
					}
					else
					{
						MessageBox.Show(strMessage.strTypes, "SJMED Products", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}
				}
			}

			#endregion

		#region INSERT DATA in StockWS Table

			private void insertInStock()
			{
				var strStatus = new PharmacyModel();

				SJMEDStockController insStockController = new SJMEDStockController();

				StockObject SO = new StockObject();
				{

					SO.ProductId = instanceClass.CheckProductDesction("SP_GetSJMEDProductId", txtCode.Text);
					SO.intId = 0;
					SO.ProductType = 0;
					SO.intQuantity = 0;
					SO.dtDateExpiry = DateTime.Today;
					SO.intPromo = 0;
					SO.dtPromoExpiry = DateTime.Today;
					strStatus.strTypes = insStockController.SaveUpdateSJMEDStock(SO.intId, SO.ProductId, SO.intQuantity, SO.dtDateExpiry, SO.intPromo, SO.dtPromoExpiry);
				}
			}

			#endregion  
		
    }
}
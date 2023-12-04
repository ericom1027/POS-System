﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy
{
    public partial class frmWholeSalePrice : Form
    {
        
        WholeSalePriceController instanceClass = new WholeSalePriceController();
        PharmacyModel strMessage = new PharmacyModel();
        private Int32 intId = 0;
      
        private string strOldDescription;
        
        public frmWholeSalePrice()
        {
            InitializeComponent();
        }

        private void frmWholeSaleProducts_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            refreshWholeSaleProducts(string.Empty);
            GetCodeNo();
            fillCmbUMPer();
        }

		#region DataGrid Whole Sale Price events

        public void refreshWholeSaleProducts(string strFilter)
        {

            var instClassGetWholeSale = new WholeSalePriceController();

            if (strFilter != string.Empty)
            {
                DataTable dtView1 = new DataTable();
				dtView1 = instClassGetWholeSale.withParDT("SP_GetWholeSaleProducts", strFilter);
				dgvWholeSale.DataSource = dtView1;
            }
            else
            {
                DataView dtView2 = new DataView(instClassGetWholeSale.DT("SP_GetWholeSaleProducts"));
                dgvWholeSale.DataSource = dtView2;
            }

            this.dgvWholeSale.Columns["Id"].Visible = false;
            this.dgvWholeSale.Columns["UMId"].Visible = false;
			this.dgvWholeSale.Columns ["VATExempted"].Visible = false;
            dgvWholeSale.AutoResizeColumns();
            dgvWholeSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

		private void dgvWholeSale_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if ((dgvWholeSale.Rows.Count >= 1) && (e.RowIndex != -1))
			{
				btnClose.Text = "&New";
				btnClose.Image = Properties.Resources.dashboard;
                btnSave.Text = " &Update";
				btnDelete.Enabled = true;
				intId = Convert.ToInt32(dgvWholeSale.SelectedCells [0].Value.ToString());
                
                WholeSaleProductsObject WSPO = new WholeSaleProductsObject();
                {
                    WSPO.strCodeNo = dgvWholeSale.SelectedCells[1].Value.ToString();
                    WSPO.strCodeNo = WSPO.autoGeneratedCodeNo;
                }
                txtCode.Text = WSPO.strCodeNo;
				txtProductDescription.Text = dgvWholeSale.SelectedCells [2].Value.ToString();
				strOldDescription = dgvWholeSale.SelectedCells [2].Value.ToString();
				txtUnit.Text = dgvWholeSale.SelectedCells [3].Value.ToString();
                cmbPer.SelectedValue = dgvWholeSale.SelectedCells[6].Value.ToString();
				txtUnitPrice.Text = dgvWholeSale.SelectedCells [5].Value.ToString();
				if (int.Parse(dgvWholeSale.SelectedCells [7].Value.ToString()) == 1)
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
                DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close this Whole Sale Price form?", "Close Whole Sale Price Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

                var intCheckProdDesc = new PharmacyModel();
                var strIntMessage = new PharmacyModel();
				//var strUnitPrice = new PharmacyModel();
                RegexValidation instCheckUnitPrice = new RegexValidation();
				WholeSaleProductsObject WSPO = new WholeSaleProductsObject();

                if (txtProductDescription.Text != string.Empty)
                {
                    if (strOldDescription != txtProductDescription.Text)
                    {
                        strIntMessage.intNumber = instanceClass.CheckProductDesction("SP_CheckWSPDescrptionOrCode", txtProductDescription.Text.Trim());
                    }
                }

				//if(txtUnitPrice.Text != string.Empty)
				//{
				//    strUnitPrice.strTypes = instCheckUnitPrice.strTextBoxCheckContains(@"(?<=^| )\d+(\.\d+)?(?=$| )|(?<=^| )\.\d+(?=$| )", txtUnitPrice.Text);
                
				//}

                if (txtProductDescription.Text == string.Empty)
                {
                    MessageBox.Show("Product Description field is required!", "Whole Sale Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductDescription.Focus();
                }
                else if (strIntMessage.intNumber == 1)
                {
                    MessageBox.Show("Product name already exist!", "Whole Sale Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductDescription.Focus();
                }

                else if (txtUnit.Text == string.Empty)
                {
                    MessageBox.Show("Unit field is required!", "Whole Sale Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUnit.Focus();
                }
                else if (cmbPer.SelectedIndex == 0)
                {
                    MessageBox.Show("UM Per field is required!", "Whole Sale Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbPer.Focus();
                }
                else if (txtUnitPrice.Text == string.Empty)
                {
                    MessageBox.Show("Unit price field is required!", "Whole Sale Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUnitPrice.Focus();
                }
				//else if (strUnitPrice.strTypes == "False")
				//{
				//    MessageBox.Show("Price field is wrong!", "Whole Sale Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//    txtUnitPrice.Focus();
				//}
                else
                {
                    
					WSPO.intIdWSP = intId;
					WSPO.strCodeNo = txtCode.Text;
					WSPO.strCodeNo = WSPO.autoGeneratedCodeNo;
					WSPO.strDescription = txtProductDescription.Text;
					WSPO.intUnit = Convert.ToInt32(txtUnit.Text);
					WSPO.decPrice = Convert.ToDecimal(txtUnitPrice.Text);
					WSPO.intUM = int.Parse(cmbPer.SelectedValue.ToString());

					if (chkVATexempted.Checked == true)
					{
						WSPO.intVATExempted = 1;
					}
					else
					{
						WSPO.intVATExempted = 0;
					}

                    List<WholeSaleProductsObject> objWSPO = new List<WholeSaleProductsObject>(2);
                    objWSPO.Add(WSPO);
                    WholeSaleProductsObject WSPObject = objWSPO[0];

					strMessage.strTypes = instanceClass.SaveUpdateDistributor(WSPObject.intIdWSP, WSPObject.strCodeNo, WSPObject.strDescription, WSPObject.intUnit, WSPO.intUM, WSPObject.decPrice, WSPObject.intVATExempted);
                    if (strMessage.strTypes.Contains("successfully"))
                    {
						if (strMessage.strTypes.Contains("added"))
						{
							insertInStock();
						}
                        
                        MessageBox.Show(strMessage.strTypes, "Whole Sale Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxClear();
                        GetCodeNo();
                        refreshWholeSaleProducts(string.Empty);
                        
                    }
                    else
                    {
                        MessageBox.Show(strMessage.strTypes, "Whole Sale Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        #endregion

        #region INSERT DATA in StockWS Table

            private void insertInStock()
            {
                var strStatus = new PharmacyModel();
               
                StockController insStockController = new StockController();
               
                StockObject SO = new StockObject();
                {

                    SO.ProductId = instanceClass.CheckProductDesction("SP_GetProductId", txtCode.Text);
                    SO.intId = 0;
                    SO.ProductType = 0;
                    SO.intQuantity = 0;
                    SO.dtDateExpiry = DateTime.Today;
                    strStatus.strTypes = insStockController.SaveUpdateStock(SO.intId, SO.ProductId, SO.ProductType, SO.intQuantity, SO.dtDateExpiry); 
                }
            }
            
        #endregion  

		#region Button Delete event

			private void btnDelete_Click(object sender, EventArgs e)
			{
                var intProductId = new PharmacyModel();
                DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to delete this Product?", "Delete Whole Sale Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dQuestionResuslt == DialogResult.Yes)
                {
                    intProductId.intNumber = intId;
                    strMessage.strTypes = instanceClass.strDeleteWholeSaleProduct(intProductId.intNumber, "SP_DeleteWholeSaleProducts");

                    if (strMessage.strTypes.Contains("successfully"))
                    {
                        MessageBox.Show(strMessage.strTypes, "Whole Sale Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxClear();
                        refreshWholeSaleProducts(string.Empty);
                        GetCodeNo();
                    }
                    else
                    {
                        MessageBox.Show(strMessage.strTypes, "Whole Sale Products", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
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
                txtProductDescription.Focus();
				chkVATexempted.Checked = false;
				
			}

			#endregion

		#region Text Box Product Descrition Text Changed event

            private void txtProductDescription_TextChanged(object sender, EventArgs e)
            {
                refreshWholeSaleProducts(txtProductDescription.Text.Trim());
            }    

            #endregion

		#region  Text Box Unit key press events

			private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
			{
				const char Delete = (char)8;
				e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
			}

		#endregion

		#region  Text Box Unit Price key press events

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
                var getPer = new WholeSalePriceController();

                DataTable dt = getPer.DT("SP_GetUMPer");

                cmbPer.DisplayMember = "Per";
                cmbPer.ValueMember = "Id";
                cmbPer.DataSource = dt;

                DataRow dr = dt.NewRow();
                dr["Per"] = "--Select--";
                dr["Id"] = 0;
                dt.Rows.InsertAt(dr, 0);
                cmbPer.SelectedIndex = 0;
            }

        #endregion
			

    }
}

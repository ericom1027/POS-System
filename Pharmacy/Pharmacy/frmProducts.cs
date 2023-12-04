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
    public partial class frmProducts : Form
    {
        string strId, strOldProductName, strOldTypeOfBrand;

        public frmProducts()
        {            
            InitializeComponent();
        }

        private void changedControlStatus()
        {
            buttonControl(false);
            buttonControl_close(true);
            btnSave.Text = "      Save";            
        }

        public void buttonControl(Boolean blVisibility)
        {
            btnDelete.Visible = blVisibility;
            btnCancel.Visible = blVisibility;
        }

        public void buttonControl_close(Boolean blVisibility)
        {
            btnClose.Visible = blVisibility;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            buttonControl(false);
            refreshDgvProducts();
            fillCmbTypeProducts();
            dtpDateExpiry.MinDate = DateTime.Today;
        }

        public void refreshDgvProducts()
        {            
            var instanceGetProducts = new DistributorsController();
            dgvProducts.DataSource = instanceGetProducts.DT("SP_GetPharmacyProducts");
            this.dgvProducts.Columns["Id"].Visible = false;
            this.dgvProducts.Columns["ProductType"].Visible = false;
            this.dgvProducts.Columns["Price"].Visible = false;
            this.dgvProducts.Columns["Promo_Discount"].Visible = false;
            this.dgvProducts.Columns["Promo_Date_Expiry"].Visible = false;
            this.dgvProducts.Columns[1].HeaderText = "Product Name";
            dgvProducts.AutoResizeColumns();
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvProducts.Rows.Count >= 1) && (e.RowIndex != -1))
            {                
                var intanceProductName = new OldNewProductName();
                List<OldNewProductName> objListProductName = new List<OldNewProductName>(2);
                btnSave.Text = "        Update";
                buttonControl(true);
                buttonControl_close(false);
                strId = dgvProducts.SelectedCells[0].Value.ToString();
                txtProductName.Text = dgvProducts.SelectedCells[1].Value.ToString();
                strOldProductName = dgvProducts.SelectedCells[1].Value.ToString();                
                cmbProductType.SelectedValue = dgvProducts.SelectedCells[2].Value.ToString();
                strOldTypeOfBrand = dgvProducts.SelectedCells[2].Value.ToString();
                txtUnitPrice.Text = dgvProducts.SelectedCells[3].Value.ToString();
                txtDiscount.Text = dgvProducts.SelectedCells[4].Value.ToString();

                if (dgvProducts.SelectedCells[5].Value.ToString() != string.Empty)
                {
                    var dtOldDateExpiry = new PharmacyModel();
                    dtOldDateExpiry.dtValue = DateTime.Parse(dgvProducts.SelectedCells[5].Value.ToString());
                    if (dtOldDateExpiry.dtValue < DateTime.Today)
                    {
                        dtpDateExpiry.MinDate = dtOldDateExpiry.dtValue;
                    }
                }


                dtpDateExpiry.Text = dgvProducts.SelectedCells[5].Value.ToString();

            }
        }

        private void fillCmbTypeProducts()
        {
            var getTypeOfProducts = new UserLoginController();

            DataTable dt = getTypeOfProducts.DT("SP_GetProductType");

            cmbProductType.DisplayMember = "Type_Of_Product";
            cmbProductType.ValueMember = "Id";
            cmbProductType.DataSource = dt;

            DataRow dr = dt.NewRow();
            dr["Type_Of_Product"] = "--Select--";
            dr["Id"] = 0;
            dt.Rows.InsertAt(dr, 0);
            cmbProductType.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var instanceClass = new PharmacyProductsController();
            var instanceClassCheck = new DistributorsController();
            var intTotalValue = new PharmacyModel();
            var strUnitPrice = new PharmacyModel();
            var strUpdateAddMessage = new PharmacyModel();
            var strDiscount = new PharmacyModel();

            if(txtDiscount.Text != string.Empty)
            {
                strDiscount.strTypes = instanceClassCheck.strTextBoxCheckContains("^[0-9]+$", txtDiscount.Text);
            }

            strUnitPrice.strTypes = instanceClassCheck.strTextBoxCheckContains(@"(?<=^| )\d+(\.\d+)?(?=$| )|(?<=^| )\.\d+(?=$| )", txtUnitPrice.Text);
            
            if (txtProductName.Text == String.Empty)
            {
                MessageBox.Show("Product name is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
            }              
            else if (cmbProductType.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Type of product is invalid!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProductType.Focus();
            }            
            else if ((txtUnitPrice.Text.Trim() == string.Empty) || (strUnitPrice.strTypes == "False") || (txtUnitPrice.Text == "0"))
            {
                MessageBox.Show("Uint price is empty or invalid!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnitPrice.Focus();
            }
            else if ((txtDiscount.Text != string.Empty) && (strDiscount.strTypes == "False"))
            {
                MessageBox.Show("Discount field is invalid!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiscount.Focus();
            }
            else if ((txtDiscount.Text != string.Empty) && (DateTime.Parse(dtpDateExpiry.Text) < DateTime.Today))
            {
                MessageBox.Show("Date expiry is invalid!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDateExpiry.Focus();
            }
            else
            {
                var strArrayNewProductName = new PharmacyModel();
                PharmacyProductDetails PPD = new PharmacyProductDetails();
                {
                    if (cmbProductType.SelectedValue.ToString() == "7")
                    {
                        if (txtProductName.Text.Contains("["))
                        {
                            strArrayNewProductName.strArrayValue = txtProductName.Text.Split(' ');
                            PPD.strProductName = strArrayNewProductName.strArrayValue[0];
                            intTotalValue.intNumber = instanceClass.CheckProductName("SP_CheckProductName", PPD.strProductName);
                        }
                        else
                        {
                            PPD.strProductName = txtProductName.Text;
                            intTotalValue.intNumber = instanceClass.CheckProductName("SP_CheckProductName", PPD.strProductName);
                        }
                    }
                    else
                    {

                        if (strId != string.Empty)
                        {
                            PPD.intId = Convert.ToInt32(strId);
                            if (txtProductName.Text.Contains("["))
                            {
                                if (strOldTypeOfBrand == cmbProductType.SelectedValue.ToString())
                                {
                                    //intTotalValue.intNumber = "No changed";
                                    PPD.strProductName = txtProductName.Text;
                                }
                                else
                                {
                                    strArrayNewProductName.strArrayValue = txtProductName.Text.Split(' ');
                                    PPD.strProductName = strArrayNewProductName.strArrayValue[0] + @" [" + cmbProductType.Text.Substring(0, 1) + cmbProductType.Text.Substring(8, 1) + @"]";
                                    intTotalValue.intNumber = instanceClass.CheckProductName("SP_CheckProductName", PPD.strProductName);
                                }

                            }
                            else
                            {
                                PPD.strProductName = txtProductName.Text + @" [" + cmbProductType.Text.Substring(0, 1) + cmbProductType.Text.Substring(8, 1) + @"]";
                                intTotalValue.intNumber = instanceClass.CheckProductName("SP_CheckProductName", PPD.strProductName);
                            }
                        }
                        else
                        {
                            PPD.strProductName = txtProductName.Text + @" [" + cmbProductType.Text.Substring(0, 1) + cmbProductType.Text.Substring(8, 1) + @"]";
                            intTotalValue.intNumber = instanceClass.CheckProductName("SP_CheckProductName", PPD.strProductName);
                        }

                    }

                    PPD.intTypeOfProduct = Convert.ToInt32(cmbProductType.SelectedValue.ToString());
                    PPD.decUnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                    if (txtDiscount.Text == string.Empty)
                    {
                        txtDiscount.Text = "0";
                    }
                    PPD.intDiscount = Convert.ToInt16(txtDiscount.Text);
                    PPD.dtDateExpiry = DateTime.Parse(dtpDateExpiry.Text);
                }

                if (intTotalValue.intNumber == 1)
                {
                    MessageBox.Show("Product name is already exists!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.Focus();
                }
                else
                {
                    List<PharmacyProductDetails> objPharmacyProductDetails = new List<PharmacyProductDetails>(2);
                    objPharmacyProductDetails.Add(PPD);
                    PharmacyProductDetails PPDobject = objPharmacyProductDetails[0];

                    strUpdateAddMessage.strTypes = instanceClass.AddUpdatePharmacyProducts(PPDobject.intId, PPDobject.strProductName, PPDobject.intTypeOfProduct, PPDobject.decUnitPrice, PPD.intDiscount, PPD.dtDateExpiry);
                    if (strUpdateAddMessage.strTypes.Contains("successfully"))
                    {
                        MessageBox.Show(strUpdateAddMessage.strTypes, "SJMED Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshDgvProducts();
                        textBoxClear();
                    }
                    else
                    {
                        MessageBox.Show(strUpdateAddMessage.strTypes, "Cannot Save!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }

        }

        private void textBoxClear()
        {
            strOldProductName = string.Empty;
            strId = string.Empty;
            txtProductName.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            cmbProductType.SelectedIndex = 0;
            txtDiscount.Text = string.Empty;
            dtpDateExpiry.Text = DateTime.Today.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close this Products form?", "Close Distributor Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
                textBoxClear();
                this.Close();
            }             
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to cancel?", "Products Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
                textBoxClear();
                changedControlStatus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (strId == string.Empty)
            {
                MessageBox.Show("Product not found!", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dQuestionResuslt = MessageBox.Show("" + txtProductName.Text + ", Are your sure you want to delete?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dQuestionResuslt == DialogResult.Yes)
                {
                    var strDeleteMessage = new PharmacyModel();
                    var deleteProduct = new PharmacyProductsController();
                    strDeleteMessage.strTypes = deleteProduct.strDeleteDistributorProduct(Convert.ToInt16(strId), "SP_DeletePharmacyProducts");

                    if (strDeleteMessage.strTypes.Contains("successfully"))
                    {
                        MessageBox.Show(txtProductName.Text + strDeleteMessage.strTypes, "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
                        MessageBox.Show(strDeleteMessage.strTypes, "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                    
                    changedControlStatus();
                    refreshDgvProducts();
                    textBoxClear();
                }

            }
        }
       
    }
}

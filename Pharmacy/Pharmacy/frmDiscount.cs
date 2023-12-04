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
    public partial class frmDiscount : Form
    {
        string strId;
        private bool xCheck = true;

        public frmDiscount()
        {
            InitializeComponent();
            //this.FormClosing += Form1_FormClosing;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var strDiscount = new PharmacyModel();
            var instanceClassDC = new DiscountController();

            if(txtDiscount.Text != string.Empty)
            {
                strDiscount.strTypes = instanceClassDC.strTextBoxCheckContains("^[0-9]+$", txtDiscount.Text);
            }

            if(txtDiscountName.Text == string.Empty)
            {
                MessageBox.Show("Discount description is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiscountName.Focus();
            }
            else if(txtDiscount.Text == string.Empty)
            {
                MessageBox.Show("Discount is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiscount.Focus();
            }
            else if (strDiscount.strTypes == "False")
            {
                MessageBox.Show("Discount is invalid!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiscount.Focus();
            }
            else
            {
                DiscountObject DCO = new DiscountObject();
                {
                    if (strId != string.Empty)
                    {
                        DCO.intId = Convert.ToInt32(strId);
                    }
                    else
                    {
                        DCO.intId = 0;
                    }
                    
                    DCO.strDiscountDesc = txtDiscountName.Text;
                    DCO.intDiscount = Convert.ToInt32(txtDiscount.Text);
                }

                List<DiscountObject> objDCO = new List<DiscountObject>(2);
                objDCO.Add(DCO);
                DiscountObject _objDCO = objDCO[0];
                var strStatus = new PharmacyModel();
                strStatus.strTypes = instanceClassDC.SaveUpdateDistributor(_objDCO.intId, _objDCO.strDiscountDesc, _objDCO.intDiscount);
                if (strStatus.strTypes.Contains("successfully"))
                {
                    MessageBox.Show(strStatus.strTypes, "SJMED Discounts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshDGVDiscount();
                    textBoxClear();
                }
                else
                {
                    MessageBox.Show(strStatus.strTypes, "Cannot Save!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            xCheck = false;
            if (btnClose.Text == "&Close")
            {
                DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close this Discount form?", "Close Distributor Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dQuestionResuslt == DialogResult.Yes)
                {
                    textBoxClear();
                    this.Close();
                }
            }
            else
            {
                //btnClose.Text = "&New";
                textBoxClear();
                txtDiscountName.Focus();
            }
            
        }

        private void textBoxClear()
        {
            strId = string.Empty;
            txtDiscountName.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            btnDelete.Visible = false;
            btnClose.Text = "&Close";
            btnClose.Image = Properties.Resources.close;
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            refreshDGVDiscount();
            txtDiscountName.Focus();
        }

        private void refreshDGVDiscount()
        {
            var instanceGetProducts = new DiscountController();

			dgvDiscountName.DataSource = instanceGetProducts.DT("SP_GetDiscount");
            this.dgvDiscountName.Columns["Id"].Visible = false;
            this.dgvDiscountName.Columns["Discount"].Visible = false;

            this.dgvDiscountName.Columns[1].HeaderText = "Description";
            dgvDiscountName.AutoResizeColumns();
            dgvDiscountName.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvDiscountName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvDiscountName.Rows.Count >= 1) && (e.RowIndex != -1))
            {
                //btnSave.Text = "     &Update";
                btnClose.Text = "&New";
                btnDelete.Visible = true;
                strId = dgvDiscountName.SelectedCells[0].Value.ToString();
                txtDiscountName.Text = dgvDiscountName.SelectedCells[1].Value.ToString();
                txtDiscount.Text = dgvDiscountName.SelectedCells[2].Value.ToString();
                btnClose.Image = Properties.Resources.dashboard;
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
                DialogResult dQuestionResuslt = MessageBox.Show("" + txtDiscountName.Text + ", Are your sure you want to delete?", "Delete Discount", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dQuestionResuslt == DialogResult.Yes)
                {
                    var strDeleteMessage = new PharmacyModel();
                    var deleteDiscount = new DiscountController();
                    strDeleteMessage.strTypes = deleteDiscount.strDeleteDiscount(Convert.ToInt16(strId), "SP_DeleteDiscount");

                    if (strDeleteMessage.strTypes.Contains("successfully"))
                    {
                        MessageBox.Show(txtDiscountName.Text + strDeleteMessage.strTypes, "Discount Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(strDeleteMessage.strTypes, "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    refreshDGVDiscount();
                    textBoxClear();
                }

            }
        }

        private void frmDiscount_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(xCheck == true)
            {
                DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close this Discount form?", "Close Distributor Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dQuestionResuslt == DialogResult.Yes)
                {
                    textBoxClear();
                    this.Close();
                }
            
            }
            
        }

    }
}

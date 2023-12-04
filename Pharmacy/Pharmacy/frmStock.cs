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
    public partial class frmStock : Form
    {

        StockController instanceSC = new StockController();
		StockObject SO = new StockObject();

        public frmStock()
        {
            InitializeComponent();
        }


        #region Form Stock Load Events

        private void frmStock_Load(object sender, EventArgs e)
        {
            fillCmbTypeProducts();
            refreshStocks(string.Empty);
            setMinimumDate();
        }

        #endregion

        #region Text Box Product Descrition Text Changed event

        private void txtProductDescription_TextChange(object sender, EventArgs e)
        {
            refreshStocks(txtProductDescription.Text.Trim());
        }

        #endregion

        #region Button Save Event

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today.AddDays(1).AddMonths(6);


			if (SO.intId == 0)
            {
                MessageBox.Show("Product not found!", "Products Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvStock.Focus();
            }
            else if(cmbType.SelectedIndex == 0)
            {
                MessageBox.Show("Type field is required!", "Products Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbType.Focus();
            }
            else if (date > DateTime.Parse(dtpDateExpiry.Text))
            {
                MessageBox.Show("Date Expiry is invalid, atleast more than six months from date today!", "Products Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpDateExpiry.Focus();
            }
            else
            {
				//SO.intId = intStockId;
				SO.ProductId = 0;
				SO.ProductType = Int32.Parse(cmbType.SelectedValue.ToString());
				SO.intQuantity = Int32.Parse(txtUnit.Text);
				SO.dtDateExpiry = DateTime.Parse(dtpDateExpiry.Text);
                

                SO.strStatus = instanceSC.SaveUpdateStock(SO.intId, SO.ProductId, SO.ProductType, SO.intQuantity, SO.dtDateExpiry);

                if (SO.strStatus.Contains("successfully"))
                {
                    MessageBox.Show(SO.strStatus, "Products Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshStocks(string.Empty);
                    textBoxClear();
                }
                else
                {
                    MessageBox.Show(SO.strStatus, "ERROR Products Stocks", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxClear();
                }

            }


        }

        #endregion

        #region Control Object Clear TxtBox and Combo box

        private void textBoxClear()
        {
			SO.intId = 0;
            txtProductDescription.Text = string.Empty;
            cmbType.SelectedValue = 0;
            txtUnit.Text = string.Empty;
            setMinimumDate();
        }


        #endregion

        #region  Text Box Unit key press events

        private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        #endregion

        #region DataGrid Whole Sale Price events

        private void refreshStocks(string strFilter)
        {
            
            var instClassGetWholeSale = new StockController();
            DataTable dtView1 = new DataTable();
            dtView1 = instClassGetWholeSale.withParDT("SP_GetAllStocks", strFilter);
            dgvStock.DataSource = dtView1;
            this.dgvStock.Columns["intId"].Visible = false;
            this.dgvStock.Columns["ProductType"].Visible = false;
            this.dgvStock.Columns["DateExpiry"].HeaderText = "Date Expiry";
            dgvStock.AutoResizeColumns();
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvStock.Rows.Count >= 1) && (e.RowIndex != -1))
            {

				SO.intId = Convert.ToInt32(dgvStock.SelectedCells [0].Value.ToString());
                txtProductDescription.Text = dgvStock.SelectedCells[1].Value.ToString();
                cmbType.SelectedValue = dgvStock.SelectedCells[2].Value.ToString();
                txtUnit.Text = dgvStock.SelectedCells[4].Value.ToString();

                if (dgvStock.SelectedCells[5].Value.ToString() != string.Empty)
                {
                    var dtOldDateExpiry = new PharmacyModel();
                    dtOldDateExpiry.dtValue = DateTime.Parse(dgvStock.SelectedCells[5].Value.ToString());
                    dtpDateExpiry.MinDate = dtOldDateExpiry.dtValue;
                    dtpDateExpiry.Text = dgvStock.SelectedCells[5].Value.ToString();
                }
            }
        }

        #endregion

        #region Button Close click event

        private void btnClose_Click(object sender, EventArgs e)
        {
                DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close this Whole Sale Stock form?", "Close Whole Sale Stock Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dQuestionResuslt == DialogResult.Yes)
                {
                    this.Close();
                }
            
        }

        #endregion

        #region Combo Box UM Per

        private void fillCmbTypeProducts()
        {
            var getProductType = new StockController();

            DataTable dt = getProductType.DT("SP_GetProductType");


            cmbType.DisplayMember = "Type_Of_Product";
            cmbType.ValueMember = "Id";
            cmbType.DataSource = dt;

            DataRow dr = dt.NewRow();
            dr["Type_Of_Product"] = "--Select--";
            dr["Id"] = 0;
            dt.Rows.InsertAt(dr, 0);
            cmbType.SelectedIndex = 0;
        }

        #endregion

        #region Set Minimum Date

        private void setMinimumDate()
        {
            DateTime date = DateTime.Today.AddDays(1).AddMonths(6);
            dtpDateExpiry.MinDate = date;
        }

        #endregion

    }
}

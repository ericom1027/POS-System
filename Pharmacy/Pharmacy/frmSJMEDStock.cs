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
    public partial class frmSJMEDStock : Form
    {
		SJMEDStockController instanceClass = new SJMEDStockController();
		StockObject SPO = new StockObject();
		
        public frmSJMEDStock()
        {
            InitializeComponent();
        }

		private void frmSJMEDStock_Load(object sender, EventArgs e)
		{
			setMinimumDate();
			refreshStocks(string.Empty);
		}

		#region DataGrid SJMED Stock events

		private void refreshStocks(string strFilter)
		{

			//var instClassGetWholeSale = new StockController();
			DataTable dtView1 = new DataTable();
			dtView1 = instanceClass.withParDT("SP_GetAllSJMEDStocks", strFilter);
			dgvStock.DataSource = dtView1;
			this.dgvStock.Columns ["Id"].Visible = false;
			this.dgvStock.Columns ["ProductId"].Visible = false;
			this.dgvStock.Columns ["DateExpiry"].HeaderText = "Date Expiry";
			//this.dgvStock.Columns ["Promo"].Visible = false;
			this.dgvStock.Columns ["PromoExpire"].HeaderText = "Promo Expiry";
			dgvStock.AutoResizeColumns();
			dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

		}

		private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if ((dgvStock.Rows.Count >= 1) && (e.RowIndex != -1))
			{

				SPO.intIdSJMEDStock = Convert.ToInt32(dgvStock.SelectedCells [0].Value.ToString());
				SPO.intIdSJMEDProd = Convert.ToInt32(dgvStock.SelectedCells [1].Value.ToString());
				txtProductDescription.Text = dgvStock.SelectedCells [2].Value.ToString();
				txtUnit.Text = dgvStock.SelectedCells [3].Value.ToString();

				if (dgvStock.SelectedCells [4].Value.ToString() != string.Empty)
				{
					var dtOldDateExpiry = new PharmacyModel();
					dtOldDateExpiry.dtValue = DateTime.Parse(dgvStock.SelectedCells [4].Value.ToString());
					dtpDateExpiry.MinDate = dtOldDateExpiry.dtValue;
					dtpDateExpiry.Text = dgvStock.SelectedCells [4].Value.ToString();
				}

				txtPromo.Text = dgvStock.SelectedCells [5].Value.ToString();

				if (dgvStock.SelectedCells [6].Value.ToString() != string.Empty)
				{
					
					var dtPromoOldExpiry = new PharmacyModel();
					dtPromoOldExpiry.dtValue = DateTime.Parse(dgvStock.SelectedCells [6].Value.ToString());
					dpPromoExpiry.MinDate = dtPromoOldExpiry.dtValue;
					dpPromoExpiry.Text = dgvStock.SelectedCells [6].Value.ToString();
				}
			}
		}

		#endregion

		#region Text Box Product Descrition Text Changed event

		private void txtProductDescription_TextChanged(object sender, EventArgs e)
		{
			SPO.strDescription = txtProductDescription.Text;
			refreshStocks(SPO.strDescription);
		}


		#endregion

		#region  Text Box Unit key press events

		private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
		{
			const char Delete = (char)8;
			e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
		}

		private void txtPromo_KeyPress(object sender, KeyPressEventArgs e)
		{
			const char Delete = (char)8;
			e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
		}

		#endregion

		#region Set Minimum Date

		private void setMinimumDate()
		{
			DateTime date = DateTime.Today.AddDays(1).AddMonths(6);
			dtpDateExpiry.MinDate = date;
			DateTime dtPromo = DateTime.Today.AddDays(1);
			dpPromoExpiry.MinDate = dtPromo;
		}

		#endregion

		#region Button Close click event

		private void btnClose_Click(object sender, EventArgs e)
		{
			DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close this SJMED Product Stock form?", "SJMED Product Stock Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (dQuestionResuslt == DialogResult.Yes)
			{
				this.Close();
			}
		}

		#endregion

		#region Button Save Event

		private void btnSave_Click(object sender, EventArgs e)
		{
			var strStatus = new PharmacyModel();

			DateTime date = DateTime.Today.AddDays(1).AddMonths(6);

			if (SPO.intIdSJMEDStock == 0)
			{
				MessageBox.Show("Product not found, Please in the SJMED Product Stocks!", "SJMED Products Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
				dgvStock.Focus();
			}
			else if (date > DateTime.Parse(dtpDateExpiry.Text))
			{
				MessageBox.Show("Date Expiry is invalid, atleast more than six months from date today!", " SJMED Products Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
				dtpDateExpiry.Focus();
			}
			else
			{
				SPO.intQuantity = Int32.Parse(txtUnit.Text);
				SPO.dtDateExpiry = DateTime.Parse(dtpDateExpiry.Text);
				if (txtPromo.Text != string.Empty)
				{
					SPO.intPromo = Int32.Parse(txtPromo.Text);
					SPO.dtPromoExpiry = DateTime.Parse(dpPromoExpiry.Text);
				}
				else
				{
					SPO.intPromo = 0;
				}
				strStatus.strTypes = instanceClass.SaveUpdateSJMEDStock(SPO.intIdSJMEDStock, SPO.intIdSJMEDProd, SPO.intQuantity, SPO.dtDateExpiry, SPO.intPromo, SPO.dtPromoExpiry);

				if (strStatus.strTypes.Contains("successfully"))
				{
					MessageBox.Show(strStatus.strTypes, "Products Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
					refreshStocks(string.Empty);
					textBoxClear();
				}
				else
				{
					MessageBox.Show(strStatus.strTypes, "ERROR Products Stocks", MessageBoxButtons.OK, MessageBoxIcon.Error);
					textBoxClear();
				}
			}
		}

		#endregion

		#region Control Object Clear TxtBox and Combo box

		private void textBoxClear()
		{
			SPO.intIdSJMEDProd = 0;
			txtProductDescription.Text = string.Empty;
			txtUnit.Text = string.Empty;
			setMinimumDate();
		}


		#endregion

		

    }
}

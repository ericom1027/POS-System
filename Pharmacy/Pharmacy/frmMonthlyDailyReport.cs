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
	public partial class frmMonthlyDailyReport : Form
	{
		reportObject RO = new reportObject();

		public frmMonthlyDailyReport(string strMonthOrDaily)
		{
			InitializeComponent();
			RO.MonthlyOrDaily = strMonthOrDaily;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if ((cmbCategory.Text == string.Empty) && (!RO.MonthlyOrDaily.Contains("BIR")))
			{
				MessageBox.Show("Category field is required!", "Report Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
				cmbCategory.Focus();
			}
			else 
			{
				if (RO.MonthlyOrDaily.Contains("BIR"))
				{
					
					 RO.iCase = 8;
					 if (RO.MonthlyOrDaily == "BIR Whole Sale")
					 {
						 frmReport frmBIRWholeSaleRep = new frmReport("SP_BIRWSreport", "DataSetBIRWS", "Pharmacy.BIRReport.rdlc", dtpDateOrder.Text, RO.iCase);
						 this.Hide();
						 frmBIRWholeSaleRep.ShowDialog();
						 this.Close();
					 }
					 else 
					 {
						 frmReport frmBIRSJMEDPharmacy = new frmReport("SP_BIRSJMEDPharmacySalesReport", "DataSetSJMEDPharmacy", "Pharmacy.BIRSJMEDPharmacyReport.rdlc", dtpDateOrder.Text, RO.iCase);
						 this.Hide();
						 frmBIRSJMEDPharmacy.ShowDialog();
						 this.Close();
					 }
					
					
				}
				else 
				{

					if (RO.MonthlyOrDaily != "Monthly")
					{
						if (RO.MonthlyOrDaily == "Daily")
						{
							if (cmbCategory.Text == "Pharmacy")
							{
								RO.iCase = 1;
							}
							else
							{
								RO.iCase = 3;
							}
						}
						else
						{

							if (cmbCategory.Text == "Pharmacy")
							{
								RO.iCase = 5;
							}
							else
							{
								RO.iCase = 6;
							}

						}

						if (cmbCategory.Text == "Pharmacy")
						{
							//SJMED Pharmacy Daily Report
							frmReport frmDailyRep = new frmReport("SP_DailyMonthlySalesReport", "DataSetDaily", "Pharmacy.MonthlyDailyReport.rdlc", dtpDateOrder.Text, RO.iCase);
							this.Hide();
							frmDailyRep.ShowDialog();
							this.Close();
						}
						else
						{
							//SJMED Whole Sale Daily Report
							frmReport frmDailyRep = new frmReport("SP_WSDailyMonthlySalesReport", "DataSetWSO", "Pharmacy.WholeSaleReport.rdlc", dtpDateOrder.Text, RO.iCase);
							this.Hide();
							frmDailyRep.ShowDialog();
							this.Close();
						}

					}
					else
					{

						if (cmbCategory.Text == "Pharmacy")
						{
							//SJMED Pharmacy Monthly Report
							frmReport frmMonthlyRep = new frmReport("SP_DailyMonthlySalesReport", "DataSetDaily", "Pharmacy.MonthlyDailyReport.rdlc", dtpDateOrder.Text, int.Parse("2"));
							this.Hide();
							frmMonthlyRep.ShowDialog();
							this.Close();
						}
						else
						{
							//SJMED Whole Sale Monthly Report
							frmReport frmMonthlyRep = new frmReport("SP_WSDailyMonthlySalesReport", "DataSetWSO", "Pharmacy.WholeSaleReport.rdlc", dtpDateOrder.Text, int.Parse("4"));
							this.Hide();
							frmMonthlyRep.ShowDialog();
							this.Close();
						}


					}
				
				}

				
			
			}
			
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close this Report form?", "Close Report Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (dQuestionResuslt == DialogResult.Yes)
			{
				this.Close();
			}         
		}

		private void frmMonthlyDailyReport_Load(object sender, EventArgs e)
		{
			if ((RO.MonthlyOrDaily == "Daily") || RO.MonthlyOrDaily == "Weekly")
			{
				lblReport.Text = "SJMED " + RO.MonthlyOrDaily + " Report";
				dtpDateOrder.CustomFormat = "dd/MM/yyyy";
			}
			else
			{
				if (RO.MonthlyOrDaily.Contains("BIR"))
				{
					cmbCategory.Enabled = false;
					lblReport.Text = RO.MonthlyOrDaily;
				}
				else
				{
					lblReport.Text = "SJMED Monthly Report";
				}
				
				dtpDateOrder.CustomFormat = "MMMM yyyy";
				dtpDateOrder.ShowUpDown = true;
			}
		}
	}
}

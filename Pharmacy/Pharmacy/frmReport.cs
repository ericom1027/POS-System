using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Printing;

namespace Pharmacy
{
    public partial class frmReport : Form
    {
		System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
		Boolean blnTrueOfFale = true;
		reportObject RO = new reportObject();
		DistributorsController instanceWriteLogs = new DistributorsController();

        public frmReport(string SP, string strDataSet, string strReportRDLC, string strParameter, int intCase)
        {
            InitializeComponent();
			RO.strSP = SP;
			RO.strDataSet = strDataSet;
			RO.strRDLC = strReportRDLC;
			RO.strParameter = strParameter;
			RO.iCase = intCase;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
			int intCase = RO.iCase;
			
			switch(intCase)
			{
				case 1:

						//SJMED Pharmacy Report Daily
					reportDailyMonthly(RO.strSP, RO.strDataSet, RO.strRDLC, DateTime.Parse(RO.strParameter), DateTime.Parse(RO.strParameter), "Daily");

				break;

				case 2:
						//SJMED Pharmacy Report Monthly
					reportDailyMonthly(RO.strSP, RO.strDataSet, RO.strRDLC, DateTime.Parse(RO.strParameter), DateTime.Parse(RO.strParameter), "Monthly");

				break;

				case 3:
						//SJMED Whole Sale Report Daily
						reportDailyMonthly(RO.strSP, RO.strDataSet, RO.strRDLC, DateTime.Parse(RO.strParameter), DateTime.Parse(RO.strParameter), "Daily");
				break;

				case 4:
						//SJMED Whole Sale Report Monthly
					   reportDailyMonthly(RO.strSP, RO.strDataSet, RO.strRDLC, DateTime.Parse(RO.strParameter), DateTime.Parse(RO.strParameter), "Monthly");
				break;

				case 5:
						//SJMED Pharmacy Report Weekly
						reportDailyMonthly(RO.strSP, RO.strDataSet, RO.strRDLC, DateTime.Parse(RO.strParameter), DateTime.Parse(RO.strParameter), "Weekly");
				break;

				case 6:
						//SJMED Whole Sale Report Weekly
						reportDailyMonthly(RO.strSP, RO.strDataSet, RO.strRDLC, DateTime.Parse(RO.strParameter), DateTime.Parse(RO.strParameter), "Weekly");
				break;
				
				case 7:
						//SJMED Shortage Expired and Near Expired Products
						reportDailyMonthly(RO.strSP, RO.strDataSet, RO.strRDLC, DateTime.Now, DateTime.Now, RO.strParameter);
				break;

				case 8:

						//SJMED Whole Sale BIR Report Monthly
						BIR_Report(RO.strSP, RO.strDataSet, RO.strRDLC, DateTime.Parse(RO.strParameter), DateTime.Parse(RO.strParameter));

				break;

				default:
						//SJMED Checkout Products Invoice Whole Sale Orders
						reportLoad(RO.strSP, RO.strDataSet, RO.strRDLC, RO.strParameter);
				break;
			}

			
			
        }

        private void reportLoad(string strSP, string strDataSet, string strChooseReport, string strParameter)
        {
            SJMEDDataSet SDS = new SJMEDDataSet();
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(strSP, conn);
                da.SelectCommand = cmd;
                cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add(new SqlParameter("@strInvoiceNo", strParameter));
                da.Fill(ds, strDataSet);
            }

			
			pg.Margins.Top = 20;
			pg.Margins.Bottom = 20;
			pg.Margins.Left = 78;
			pg.Margins.Right = 60;

            SJMEDreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            SJMEDreportViewer.LocalReport.DataSources.Clear();
            SJMEDreportViewer.LocalReport.ReportEmbeddedResource = strChooseReport;
            SJMEDreportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource(strDataSet, ds.Tables[0]));
			SJMEDreportViewer.LocalReport.Refresh();
			SJMEDreportViewer.SetPageSettings(pg);
			this.SJMEDreportViewer.RefreshReport();

        }

		private void reportDailyMonthly(string strSP, string strDataSet, string strChooseReport, DateTime DateFrom, DateTime DateTo, string strScndLabel)
		{
			SJMEDDataSet SDS = new SJMEDDataSet();
			DataSet ds = new DataSet();

			if ((strScndLabel == "Daily") || (strScndLabel == "Weekly"))
			{
				if (strScndLabel == "Daily")
				{
					RO.DateOrderParmater = string.Format("{0:MMMM dd yyyy}", DateFrom);
					RO.DateFrom = string.Format("{0:dd/MM/yyyy}", DateFrom) + " 00:00:00";
					RO.DateTo = string.Format("{0:dd/MM/yyyy}", DateTo) + " 23:59:59";
				}
				else 
				{
					RO.DateFrom = string.Format("{0:dd/MM/yyyy}", DateFrom) + " 00:00:00";
					RO.DateTo = string.Format("{0:dd/MM/yyyy}", DateTo) + " 23:59:59";
					DateTime dtDateTo = Convert.ToDateTime(string.Format("{0:dd/MM/yyyy}", DateTo) + " 23:59:59").AddDays(6);
					RO.DateTo = string.Format("{0:dd/MM/yyyy}", dtDateTo) + " 23:59:59";
					RO.DateOrderParmater = string.Format("{0:MMMM dd yyyy}", DateFrom) + " to " + string.Format("{0:MMMM dd yyyy}", dtDateTo);
				}
				
			}
			else if (strScndLabel == "Monthly")
			{
				RO.DateOrderParmater = string.Format("{0:MMMM yyyy}", DateFrom);
				DateTime firstOfNextMonth = new DateTime(DateFrom.Year, DateFrom.Month, 1);
				DateTime getLastDayOftheMonth = new DateTime(DateFrom.Year, DateFrom.Month, 1).AddMonths(1);
				DateTime lastOfThisMonth = getLastDayOftheMonth.AddDays(-1);

				RO.DateFrom = string.Format("{0:dd/MM/yyyy}", firstOfNextMonth) + " 00:00:00";
				RO.DateTo = string.Format("{0:dd/MM/yyyy}", lastOfThisMonth) + " 23:59:59";
			}
			else
			{
				RO.DateOrderParmater = string.Format("{0:MMMM dd yyyy}", DateTime.Now);
				strScndLabel = RO.strParameter;
			}

			try
			{
				using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
				{
					if (conn.State == ConnectionState.Closed)
					{
						conn.Open();
					}

					SqlDataAdapter da = new SqlDataAdapter();
					SqlCommand cmd = new SqlCommand(strSP, conn);
					da.SelectCommand = cmd;
					cmd.CommandType = CommandType.StoredProcedure;
					if ((strScndLabel == "Daily") || (strScndLabel == "Weekly") || (strScndLabel == "Monthly"))
					{
						cmd.Parameters.Add(new SqlParameter("@DateFrom", DateTime.Parse(RO.DateFrom)));
						cmd.Parameters.Add(new SqlParameter("@DateTo", DateTime.Parse(RO.DateTo)));
					}
					da.Fill(ds, strDataSet);
				}
			}
			catch(Exception ex)
			{
				instanceWriteLogs.writeErrorLogs("Daily and Montly Report Error: " + ex.Message.ToString());
			}

			pg.Margins.Top = 20;
			pg.Margins.Bottom = 20;
			pg.Margins.Left = 78;
			pg.Margins.Right = 60;

			SJMEDreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
			SJMEDreportViewer.LocalReport.DataSources.Clear();
			SJMEDreportViewer.LocalReport.ReportEmbeddedResource = strChooseReport;
			SJMEDreportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource(strDataSet, ds.Tables [0]));
			Microsoft.Reporting.WinForms.ReportParameter [] rSaleParameter = new Microsoft.Reporting.WinForms.ReportParameter []
			{
				new Microsoft.Reporting.WinForms.ReportParameter("ParaSecdLabel", strScndLabel),
				new Microsoft.Reporting.WinForms.ReportParameter("DateReport", RO.DateOrderParmater)
				//new Microsoft.Reporting.WinForms.ReportParameter("WSScndLabel", strScndLabel),
				//new Microsoft.Reporting.WinForms.ReportParameter("DateOrder", RO.DateOrderParmater)
			};
			SJMEDreportViewer.LocalReport.SetParameters(rSaleParameter);
			SJMEDreportViewer.LocalReport.Refresh();
			SJMEDreportViewer.SetPageSettings(pg);
			this.SJMEDreportViewer.RefreshReport();

		}

		private void BIR_Report(string strSP, string strDataSet, string strChooseReport, DateTime DateFrom, DateTime DateTo)
		{
			SJMEDDataSet SDS = new SJMEDDataSet();
			DataSet ds = new DataSet();

			RO.DateOrderParmater = string.Format("{0:MMMM yyyy}", DateFrom);
			DateTime firstOfNextMonth = new DateTime(DateFrom.Year, DateFrom.Month, 1);
			DateTime getLastDayOftheMonth = new DateTime(DateFrom.Year, DateFrom.Month, 1).AddMonths(1);
			DateTime lastOfThisMonth = getLastDayOftheMonth.AddDays(-1);

			RO.DateFrom = string.Format("{0:dd/MM/yyyy}", firstOfNextMonth) + " 00:00:00";
			RO.DateTo = string.Format("{0:dd/MM/yyyy}", lastOfThisMonth) + " 23:59:59";

			RO.DateToday = string.Format("{0:MMMM dd yyyy}", DateTime.Now);

			try
			{
				using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
				{
					if (conn.State == ConnectionState.Closed)
					{
						conn.Open();
					}

					SqlDataAdapter da = new SqlDataAdapter();
					SqlCommand cmd = new SqlCommand(strSP, conn);
					da.SelectCommand = cmd;
					cmd.CommandType = CommandType.StoredProcedure;
					//if ((strScndLabel == "Daily") || (strScndLabel == "Weekly") || (strScndLabel == "Monthly"))
					//{
					cmd.Parameters.Add(new SqlParameter("@DateFrom", DateTime.Parse(RO.DateFrom)));
					cmd.Parameters.Add(new SqlParameter("@DateTo", DateTime.Parse(RO.DateTo)));
					//}
					da.Fill(ds, strDataSet);
				}
			}
			catch (Exception ex)
			{
				instanceWriteLogs.writeErrorLogs("BIR Report Error: " + ex.Message.ToString());
			}

			pg.Margins.Top = 20;
			pg.Margins.Bottom = 20;
			pg.Margins.Left = 78;
			pg.Margins.Right = 60;

			SJMEDreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
			SJMEDreportViewer.LocalReport.DataSources.Clear();
			SJMEDreportViewer.LocalReport.ReportEmbeddedResource = strChooseReport;
			SJMEDreportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource(strDataSet, ds.Tables [0]));
			Microsoft.Reporting.WinForms.ReportParameter [] rSaleParameter = new Microsoft.Reporting.WinForms.ReportParameter []
			{
				new Microsoft.Reporting.WinForms.ReportParameter("DateToday", RO.DateToday),
				new Microsoft.Reporting.WinForms.ReportParameter("DateReport", RO.DateOrderParmater)
				
			};
			SJMEDreportViewer.LocalReport.SetParameters(rSaleParameter);
			SJMEDreportViewer.LocalReport.Refresh();
			SJMEDreportViewer.SetPageSettings(pg);
			this.SJMEDreportViewer.RefreshReport();

		}

        private void frmReport_FormClosed(object sender, FormClosedEventArgs e)
        {
			if (blnTrueOfFale != false)
			{
				DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to closed this Report?", "SJMED Report Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (dQuestionResuslt == DialogResult.Yes)
				{
					
					SJMEDreportViewer.Dispose();
					this.Close();
				}
			}
            
        }

		private void SJMEDreportViewer_Print(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
		{
			blnTrueOfFale = false;
			this.Close();
		}

    }
}

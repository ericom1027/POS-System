namespace Pharmacy
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.SJMEDreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// SJMEDreportViewer
			// 
			this.SJMEDreportViewer.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.SJMEDreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DateSetWSO";
			reportDataSource1.Value = null;
			this.SJMEDreportViewer.LocalReport.DataSources.Add(reportDataSource1);
			this.SJMEDreportViewer.LocalReport.ReportEmbeddedResource = "Pharmacy.WholeSaleOrderInvoiceReport.rdlc";
			this.SJMEDreportViewer.Location = new System.Drawing.Point(0, 0);
			this.SJMEDreportViewer.Name = "SJMEDreportViewer";
			this.SJMEDreportViewer.Size = new System.Drawing.Size(699, 666);
			this.SJMEDreportViewer.TabIndex = 0;
			this.SJMEDreportViewer.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.SJMEDreportViewer_Print);
			// 
			// frmReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 666);
			this.Controls.Add(this.SJMEDreportViewer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Report";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReport_FormClosed);
			this.Load += new System.EventHandler(this.frmReport_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer SJMEDreportViewer;

        //private SJMEDDataSet SJMEDDataSet;
        //private SJMEDDataSetTableAdapters.viewGetDistributorsProductsTableAdapter viewGetDistributorsProductsTableAdapter;
    }
}
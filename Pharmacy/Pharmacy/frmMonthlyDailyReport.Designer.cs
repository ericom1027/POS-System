namespace Pharmacy
{
	partial class frmMonthlyDailyReport
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
			this.lblReport = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.dtpDateOrder = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblReport
			// 
			this.lblReport.AutoSize = true;
			this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReport.ForeColor = System.Drawing.Color.White;
			this.lblReport.Location = new System.Drawing.Point(76, 19);
			this.lblReport.Name = "lblReport";
			this.lblReport.Size = new System.Drawing.Size(173, 20);
			this.lblReport.TabIndex = 13;
			this.lblReport.Text = "SJMED Daily Report";
			this.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(31, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 20);
			this.label1.TabIndex = 15;
			this.label1.Text = "Date:";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::Pharmacy.Properties.Resources.close22;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.Location = new System.Drawing.Point(230, 187);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 33);
			this.btnClose.TabIndex = 37;
			this.btnClose.Text = "&Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.Image = global::Pharmacy.Properties.Resources.ok22k;
			this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.Location = new System.Drawing.Point(149, 188);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 30);
			this.btnOk.TabIndex = 36;
			this.btnOk.Text = "  &Ok";
			this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// dtpDateOrder
			// 
			this.dtpDateOrder.CustomFormat = "dd/MM/yyyy";
			this.dtpDateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateOrder.Location = new System.Drawing.Point(81, 79);
			this.dtpDateOrder.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.dtpDateOrder.Name = "dtpDateOrder";
			this.dtpDateOrder.Size = new System.Drawing.Size(194, 26);
			this.dtpDateOrder.TabIndex = 38;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(5, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 20);
			this.label2.TabIndex = 39;
			this.label2.Text = "Category:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbCategory);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.dtpDateOrder);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 42);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(295, 127);
			this.groupBox1.TabIndex = 40;
			this.groupBox1.TabStop = false;
			// 
			// cmbCategory
			// 
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Items.AddRange(new object [] {
            "Pharmacy",
            "Whole Sale"});
			this.cmbCategory.Location = new System.Drawing.Point(81, 29);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(194, 28);
			this.cmbCategory.TabIndex = 0;
			// 
			// frmMonthlyDailyReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(319, 233);
			this.ControlBox = false;
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lblReport);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMonthlyDailyReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sales Report";
			this.Load += new System.EventHandler(this.frmMonthlyDailyReport_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblReport;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.DateTimePicker dtpDateOrder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbCategory;
	}
}
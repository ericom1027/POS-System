namespace Pharmacy
{
    partial class frmUserLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserLogin));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(1, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(422, 56);
			this.panel1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Maroon;
			this.label2.Location = new System.Drawing.Point(87, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(251, 27);
			this.label2.TabIndex = 14;
			this.label2.Text = "SJMED Pharma Inc";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.btnExit);
			this.panel2.Controls.Add(this.btnOk);
			this.panel2.Location = new System.Drawing.Point(1, 188);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(422, 56);
			this.panel2.TabIndex = 2;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Image = global::Pharmacy.Properties.Resources.exit;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExit.Location = new System.Drawing.Point(322, 12);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 30);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "  &Exit";
			this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.Image = global::Pharmacy.Properties.Resources.ok;
			this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.Location = new System.Drawing.Point(241, 12);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 30);
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "  &Ok";
			this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(146, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 18);
			this.label3.TabIndex = 26;
			this.label3.Text = "Username:";
			// 
			// txtUsername
			// 
			this.txtUsername.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtUsername.Location = new System.Drawing.Point(242, 84);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(156, 20);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_PressEnter);
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtPassword.Location = new System.Drawing.Point(242, 129);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(156, 20);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyPressEnter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(146, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 18);
			this.label1.TabIndex = 28;
			this.label1.Text = "Password:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Pharmacy.Properties.Resources.Lock;
			this.pictureBox1.Location = new System.Drawing.Point(12, 61);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 121);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// frmUserLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(423, 242);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmUserLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User Login";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserLogin_FormClosed);
			this.Load += new System.EventHandler(this.frmUserLogin_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;

    }
}
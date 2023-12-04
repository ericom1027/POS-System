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
    public partial class frmVoid : Form
    {
        VoidController instanceVC = new VoidController();
		VoidObject VO = new VoidObject();
		PharmacyModel getUser = new PharmacyModel();

        public frmVoid(int intFrmVoid, string strUser)
        {
            InitializeComponent();

			//1 is to Show SJMED Sale or 2 = Show Whole Sale Void
			VO.intShowFormUse = intFrmVoid;
			getUser.userSJMED = strUser;
        }

        private void frmVoid_Load(object sender, EventArgs e)
        {
			if (VO.intShowFormUse == 1)
			{
				lblInvoice.Text = "Receipt No. ";
			}
			else
			{
				lblInvoice.Text = "Invoice No. ";
			}
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            CheckInvoiceNoAndPassword();
            
        }

        public void UserLoginValidation()
        {
            var strMessage = new PharmacyModel();
            var boolTrueOrFalse = new PharmacyModel();

            strMessage.strTypes = instanceVC.strUserLogin("SP_UserLogin", "void", txtPassword.Text);

            boolTrueOrFalse.boolTrueOrFalse = strMessage.strTypes.All(char.IsDigit);
            if (boolTrueOrFalse.boolTrueOrFalse == true)
            {
				if (VO.intShowFormUse == 1)
				{
					frmSJMEDSale frmSJMEDSO = new frmSJMEDSale(Properties.Settings.Default.ReceiptNo + txtInvoiceNo.Text, "Yes", getUser.userSJMED);
					this.Hide();
					frmSJMEDSO.ShowDialog();
					this.Close();
				}
				else
				{
					frmWholeSale frmWWS = new frmWholeSale(txtInvoiceNo.Text, "Yes");
					this.Hide();
					frmWWS.ShowDialog();
					this.Close();
				}
                
            }
            else
            {
                MessageBox.Show(strMessage.strTypes, "Void Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (strMessage.strTypes.Contains("Password"))
                {
                    txtPassword.Text = string.Empty;
                    txtPassword.Focus();
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close this Void form?", "Close Void Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
				if (VO.intShowFormUse == 1)
				{
					frmSJMEDSale frmSJMEDSO = new frmSJMEDSale(string.Empty, string.Empty, getUser.userSJMED);
					this.Hide();
					frmSJMEDSO.ShowDialog();
					this.Close();
				}
				else
				{
					frmWholeSale frmWWS = new frmWholeSale(string.Empty, string.Empty);
					this.Hide();
					frmWWS.ShowDialog();
					this.Close();
				}
            }         
        }

        private void txtInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtPassword_KeyPressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckInvoiceNoAndPassword();
            }
        }

        private void CheckInvoiceNoAndPassword()
        {
            VoidObject VOJ = new VoidObject();
            {
                VOJ.InvoiceNo = Int32.Parse(txtInvoiceNo.Text);
				if (VO.intShowFormUse == 1)
				{
					VOJ.RetInvoiceNo = instanceVC.checkReceiptNo(Properties.Settings.Default.ReceiptNo + txtInvoiceNo.Text, "SP_CheckReceiptNoIsExists");
				}
				else
				{
					VOJ.RetInvoiceNo = instanceVC.GetInvoiceNo(VOJ.InvoiceNo, "SP_GetCheckInvoiceNo");
				}
               
            }

            if (VOJ.RetInvoiceNo != 0)
            {
                UserLoginValidation();
            }
            else
            {
                MessageBox.Show(lblInvoice.Text + " doesn't exists or no record to be void!", "Void Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInvoiceNo.Focus();
            }
        
        }

    }
}

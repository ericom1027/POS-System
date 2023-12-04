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
    public partial class frmChangePassword : Form
    {
        string strUserNameValue = string.Empty;
        string strIdValue = string.Empty;
        
        public frmChangePassword(string strUserName, string strId)
        {
            InitializeComponent();
            strUserNameValue = strUserName.Trim();
            strIdValue = strId.Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var instUserLogin = new UserLoginController();
            var strMessage = new PharmacyModel();
            var boolTrueOrFalse = new PharmacyModel();

            strMessage.strTypes = instUserLogin.strUserLogin("SP_UserLogin", strUserNameValue, txtOldPassword.Text);

            boolTrueOrFalse.boolTrueOrFalse = strMessage.strTypes.All(char.IsDigit);
            if (boolTrueOrFalse.boolTrueOrFalse == false)
            {
                MessageBox.Show("Old Password is invalid!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPassword.Focus();
            }
            else if(txtOldPassword.Text == string.Empty)
            {
                MessageBox.Show("Old Password is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPassword.Focus();
            }
            else if(txtNewPassword.Text == string.Empty)
            {
                MessageBox.Show("New Password is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Focus();
            }
            else if(txtConfirmNewPassword.Text == string.Empty)
            {
                MessageBox.Show("Confirm Password is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmNewPassword.Focus();            
            }
            else if (txtNewPassword.Text.Trim() != txtConfirmNewPassword.Text.Trim())
            {
                MessageBox.Show("New password and confirm password did not match!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Focus();
            }
            else
            {
                var instanceClass = new UserLoginController();
                var strValueMessage = new PharmacyModel();
                strValueMessage.strTypes = instanceClass.AddUpdateUserAccounts(strIdValue, strUserNameValue, txtNewPassword.Text, "", "", "");

                if (strValueMessage.strTypes.Contains("successfully"))
                {
                    MessageBox.Show("Your new password has been successfully changed!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxClear();
                }
                else
                {
                    MessageBox.Show(strValueMessage.strTypes, "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close this Change Password form?", "Close Distributor Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {                
                this.Close();
            }         
        }

        private void txtBoxClear()
        {

            txtOldPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtConfirmNewPassword.Text = string.Empty;
        }

    }
}

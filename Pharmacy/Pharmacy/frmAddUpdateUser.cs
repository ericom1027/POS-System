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
    public partial class frmAddUpdateUser : Form
    {
        string strId = string.Empty;
        string StrOldUsername = string.Empty;
        
        public frmAddUpdateUser()
        {
            InitializeComponent();
        }

        private void changedControlStatus()
        {  
            buttonControl(false);
            buttonControl_close(true);          
            btnSave.Text = "      Save";
            gbAddResetUserAccount.Text = "Add new user account";
        }

        public void buttonControl(Boolean blVisibility)
        {
            //gbAddResetUserAccount.Text = "Add new user account";
            btnDelete.Visible = blVisibility;
            btnCancel.Visible = blVisibility;
        }

        public void buttonControl_close(Boolean blVisibility)
        {
            btnClose.Visible = blVisibility;
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            buttonControl(false);
            FillComboBoxType();
            refreshDGVUsers();
        }

        private void FillComboBoxType()
        {
            var getUserType = new UserLoginController();

            DataTable dt = getUserType.DT("SP_GetUserRole");
            cmbRole.DisplayMember = "UserType";
            cmbRole.ValueMember = "intId";
            cmbRole.DataSource = dt;

            DataRow dr = dt.NewRow();
            dr["UserType"] = "--Select--";
            dr["intId"] = 0;
            dt.Rows.InsertAt(dr, 0);
            cmbRole.SelectedIndex = 0;

        }

        public void refreshDGVUsers()
        {
            var intGetDistributor = new UserLoginController();

            dgvUsers.DataSource = intGetDistributor.DT("SP_GetUsers");
            this.dgvUsers.Columns["intId"].Visible = false;
            this.dgvUsers.Columns["Username"].Visible = false;
            this.dgvUsers.Columns["FirstName"].Visible = false;
            this.dgvUsers.Columns["LastName"].Visible = false;
            this.dgvUsers.Columns["Type"].Visible = false;
            dgvUsers.AutoResizeColumns();
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var instanceClass = new UserLoginController();
            var strValue = new PharmacyModel();
            var strUpdateAdd = new PharmacyModel();
            var intTotal = new PharmacyModel();

            if ((StrOldUsername != txtUsername.Text) && (txtUsername.Text != string.Empty))
            {
                intTotal.intNumber = instanceClass.CheckUserName(txtUsername.Text, "SP_CheckUserName");
            }

            if (txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Username field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (intTotal.intNumber == 1)
            {
                MessageBox.Show(txtUsername.Text + " username already exist!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if(txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                MessageBox.Show("Password and Confirm password did not match!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if(txtPassword.Text == String.Empty)
            {
                MessageBox.Show("Password is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if(txtConfirmPassword.Text == string.Empty)
            {
                MessageBox.Show("Confirm password is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
            }
            else if (txtFirstName.Text == string.Empty)
            {
                MessageBox.Show("First Name is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
            }
            else if (txtLastName.Text == string.Empty)
            {
                MessageBox.Show("Last Name is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
            }
            else if (cmbRole.SelectedIndex == 0)
            {
                MessageBox.Show("User role is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRole.Focus();
            }
            else
            {
                strValue.strTypes = instanceClass.AddUpdateUserAccounts(strId, txtUsername.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text, cmbRole.SelectedValue.ToString());

                if (strValue.strTypes.Contains("successfully"))
                {
                    if (btnSave.Text.Trim() == "Update")
                    {
                        strUpdateAdd.strTypes = " updated";
                        changedControlStatus();
                    }
                    else
                    {
                        strUpdateAdd.strTypes = " added";
                    }

                    MessageBox.Show("Username " + txtUsername.Text + strUpdateAdd.strTypes + " successfully", "Add/Reset User Accounts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshDGVUsers();
                    txtBoxClear();
                }
            
            }            
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvUsers.Rows.Count >= 1) && (e.RowIndex != -1))
            {
                txtBoxClear();
                gbAddResetUserAccount.Text = "Reset Password";
                btnSave.Text = "        Update";
                buttonControl(true);
                buttonControl_close(false);
                strId = dgvUsers.SelectedCells[0].Value.ToString();
                if ((strId == "9") || (strId == "5"))
                {
                    txtUsername.Enabled = false;
                    btnDelete.Enabled = false;
                    cmbRole.Enabled = false;
                }
                else
                {   
                    txtUsername.Enabled = true;
                    btnDelete.Enabled = true;
                    cmbRole.Enabled = true;
                }
                txtUsername.Text = dgvUsers.SelectedCells[2].Value.ToString();
                StrOldUsername = dgvUsers.SelectedCells[2].Value.ToString();
                txtFirstName.Text = dgvUsers.SelectedCells[3].Value.ToString();
                txtLastName.Text = dgvUsers.SelectedCells[4].Value.ToString();
                cmbRole.SelectedValue = dgvUsers.SelectedCells[5].Value.ToString();
                
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close this User Accounts form?", "Close Distributor Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
                txtBoxClear();
                this.Close();
            }         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to cancel?", "Distributor Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
                txtBoxClear();
                changedControlStatus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (strId == "9")
            //{
            //    MessageBox.Show("Void user account cannot be deleted, you can only change password!", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtUsername.Focus();
            //}
            //else
            //{
                if (strId == string.Empty)
                {
                    MessageBox.Show("User account not found!", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dQuestionResuslt = MessageBox.Show("" + txtUsername.Text + ", Are your sure you want to delete?", "Delete User Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dQuestionResuslt == DialogResult.Yes)
                    {
                        var strDeleteMessage = new PharmacyModel();
                        var deleteCompany = new DistributorsController();
                        strDeleteMessage.strTypes = deleteCompany.strDeleted(Convert.ToInt16(strId), "", "SP_DeleteUserAccount");
                        MessageBox.Show(txtUsername.Text + " user account has been successfully deleted!", "User Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changedControlStatus();
                        refreshDGVUsers();
                        txtBoxClear();
                    }

                }
            
           // }
           
        }

        private void txtBoxClear()
        {
            strId = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            cmbRole.SelectedIndex = 0;
            //gbAddResetUserAccount.Text = "Add new user account";
        }

        }
    }

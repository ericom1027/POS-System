using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace Pharmacy
{
    public partial class frmDistributors : Form
    {
        string strID;
        string strDecimalTotalNet = string.Empty;
        string strDecimalTotalAmount = string.Empty;
        string strOldCompanyName = string.Empty;

        public frmDistributors()
        {
            InitializeComponent();
        }        

        private void btnClose_Click(object sender, EventArgs e)
        {
           // xCheck = false;
            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close this Distributor form?", "Close Distributor Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
                txtBoxClear();
                this.Close();
            }         
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var intanceClass = new DistributorsController();
            var strValue = new PharmacyModel();
            var strUpdateAdd = new PharmacyModel();
            var strCheckCompanyTextBox = new PharmacyModel();
            var strCheckAddressTextBox = new PharmacyModel();
            var strEmailAdd = new PharmacyModel();
            var intTotal = new PharmacyModel();

            strCheckCompanyTextBox.strTypes = intanceClass.strCheckTxtBoxEmpty(txtCompany.Text, "Company field is required!");
            strCheckAddressTextBox.strTypes = intanceClass.strCheckTxtBoxEmpty(txtAddress.Text, "Address field is required!");
            strEmailAdd.strTypes = intanceClass.strTextBoxCheckContains(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", txtEmailAdd.Text);

            if (strOldCompanyName != txtCompany.Text)
            {
                intTotal.intNumber = intanceClass.CheckCompanyName(txtCompany.Text.Trim(), "SP_CheckCompany");
            }

            if ((strCheckCompanyTextBox.strTypes != string.Empty) && (strCheckCompanyTextBox.strTypes != null))
            {
                MessageBox.Show(strCheckCompanyTextBox.strTypes.ToString(), "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCompany.Focus();
            }
            else if (intTotal.intNumber == 1)
            {
                MessageBox.Show("Company name already exists!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCompany.Focus();
            }
            else if ((strCheckAddressTextBox.strTypes != string.Empty) && (strCheckAddressTextBox.strTypes != null))
            {
                MessageBox.Show(strCheckAddressTextBox.strTypes.ToString(), "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
            }
            else if ((txtEmailAdd.Text != string.Empty) && (txtEmailAdd.Text != null) && (strEmailAdd.strTypes == "False"))
            {
                MessageBox.Show("Email address is wrong!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAdd.Focus();
            }
            else
            {
                strValue.strTypes = intanceClass.SaveUpdateDistributor(strID, txtCompany.Text, txtAddress.Text, txtHandPhone.Text, txtTIN.Text, txtEmailAdd.Text, txtContactPerson.Text);

                if (strValue.strTypes == "True")
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

                    MessageBox.Show("Distributor " + txtCompany.Text + strUpdateAdd.strTypes + " successfully", "Add/Update Distributor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshDistributor();
                    txtBoxClear();
                }

            }
           
        }        

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            if (strID == string.Empty)
            {
                MessageBox.Show("Company not found!", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dQuestionResuslt = MessageBox.Show("" + txtCompany.Text + " All products will also be delete, Are your sure you want to delete?", "Delete Distributor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dQuestionResuslt == DialogResult.Yes)
                {
                    var strDeleteMessage = new PharmacyModel();
                    var deleteCompany = new DistributorsController();
                    strDeleteMessage.strTypes = deleteCompany.strDeleted(Convert.ToInt16(strID), txtCompany.Text, "SP_DeleteCompany");
                    MessageBox.Show(strDeleteMessage.strTypes + " has been successfully deleted!", "Company Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    changedControlStatus();
                    refreshDistributor();
                    txtBoxClear();
                }

            }
           
        }
        
        public void refreshDistributor()
        {
            var intGetDistributor = new DistributorsController();                      
            dgvDistributors.DataSource = intGetDistributor.DT("SP_GetDistributors");
            this.dgvDistributors.Columns["Id"].Visible = false;
            this.dgvDistributors.Columns["Active"].Visible = false;
            dgvDistributors.AutoResizeColumns();
            dgvDistributors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;           

            
        }        

        private void frmDistributors_Load(object sender, EventArgs e)
        {           
            buttonControl(false);
            refreshDistributor();
        }
             
        public void buttonControl(Boolean blVisibility)
        {
            btnDelete.Visible = blVisibility;
            btnCancel.Visible = blVisibility;
        }

        public void buttonControl_close(Boolean blVisibility)
        {            
            btnClose.Visible = blVisibility;
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

        private void txtBoxClear()
        {
            strID = string.Empty;
            txtCompany.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtHandPhone.Text = string.Empty;
            txtTIN.Text = string.Empty;
            txtEmailAdd.Text = string.Empty;
            txtContactPerson.Text = string.Empty;
        }
               
        private void changedControlStatus()
        {
            buttonControl(false);
            buttonControl_close(true);
            //txtBoxClear();
            btnSave.Text = "      Save";
        }
  
        private void txtHandPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void dgvDistributors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvDistributors.Rows.Count >= 1) && (e.RowIndex != -1))
            {
                btnSave.Text = "        Update";
                buttonControl(true);
                buttonControl_close(false);
                strID = dgvDistributors.SelectedCells[0].Value.ToString();
                txtCompany.Text = dgvDistributors.SelectedCells[1].Value.ToString();
                strOldCompanyName = dgvDistributors.SelectedCells[1].Value.ToString();
                txtAddress.Text = dgvDistributors.SelectedCells[2].Value.ToString();
                txtHandPhone.Text = dgvDistributors.SelectedCells[3].Value.ToString();
                txtTIN.Text = dgvDistributors.SelectedCells[4].Value.ToString();
                txtEmailAdd.Text = dgvDistributors.SelectedCells[5].Value.ToString();
                txtContactPerson.Text = dgvDistributors.SelectedCells[6].Value.ToString();
            }
        }

        
    }
}

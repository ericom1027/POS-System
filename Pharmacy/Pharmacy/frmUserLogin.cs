using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class frmUserLogin : Form
    {
        UserLoginController instUserLogin = new UserLoginController();
        frmMainController instanceMC = new frmMainController();

        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void frmUserLogin_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.KeyAccount != instanceMC.GetMACAddress())
            {
                MessageBox.Show("Your Pharmacy System is not registered on this computer, Please contact your Vendor!", "License not Registered", MessageBoxButtons.OK);
                Application.Exit();
            }           

			//string gifPath = System.IO.Path.GetDirectoryName(Application.StartupPath) + @"\" + Properties.Settings.Default.gifPath;
			////MessageBox.Show(gifPath);
			//pictureBox1.Image = Image.FromFile(gifPath);

            //MessageBox.Show(instUserLogin.GetMACAddress(), "MacAddress", MessageBoxButtons.OK);

        }

        private void frmUserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            UserLoginValidation(); 
        }

        public void UserLoginValidation()
        {
            
            var strMessage = new PharmacyModel();
            var boolTrueOrFalse = new PharmacyModel();            

            strMessage.strTypes = instUserLogin.strUserLogin("SP_UserLogin", txtUsername.Text, txtPassword.Text);

            boolTrueOrFalse.boolTrueOrFalse = strMessage.strTypes.All(char.IsDigit);
            if (boolTrueOrFalse.boolTrueOrFalse == true)
            {

                frmMain frmMainShow = new frmMain(strMessage.strTypes);
                this.Hide();
                frmMainShow.ShowDialog();
                this.Close(); 
            }
            else
            {
                MessageBox.Show(strMessage.strTypes, "User Login Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (strMessage.strTypes.Contains("Password"))
                {
                    txtPassword.Focus();
                }
                else
                {
                    txtUsername.Focus();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPressEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                UserLoginValidation(); 
            }
        }

        private void txtUsername_PressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }
      
    }
}

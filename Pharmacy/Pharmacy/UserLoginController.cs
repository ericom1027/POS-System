using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Pharmacy
{
    class UserLoginController
    {

        #region Validate User Login Information Username and Password

        public string strUserLogin(string SP, string strUserName, string strPassword)
        {

            var strMessage = new PharmacyModel();
            var instWriteLogs = new DistributorsController();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SP, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Username", strUserName.ToUpper()));
                    cmd.Parameters.Add(new SqlParameter("@Password", strPassword));
                    SqlParameter strValue = new SqlParameter("@responseMessage", SqlDbType.NVarChar, 250);
                    strValue.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(strValue);
                    SqlDataReader reader = cmd.ExecuteReader();
                    strMessage.strTypes = strValue.Value.ToString();
                    reader.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                instWriteLogs.writeErrorLogs("Error: " + ex.Message.ToString());
            }

            return strMessage.strTypes;

        }

        #endregion

        #region Return Users information in Data Table

        public DataTable DT(string strSP)
        {
            var writeErrorLogs = new DistributorsController();
            DataTable dt = new DataTable();

            try
            {
                SqlConnection myConn = new SqlConnection(Properties.Settings.Default.DBConn);
                myConn.Open();
                SqlCommand myCmd = new SqlCommand(strSP, myConn);
                myCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.Fill(dt);
                myConn.Close();
                myConn.Dispose();

            }
            catch (Exception ex)
            {
                writeErrorLogs.writeErrorLogs("Error: " + ex.Message.ToString());
            }

            return dt;
        }

        #endregion

        #region Add Update User Accounts

        public string AddUpdateUserAccounts(string strIntId, string strUsername, string strPassword, string strFirstName, string strLastName, string strType)
        {
            var instWriteErrorLogs = new DistributorsController();
            var strSaveResults = new PharmacyModel();
            var strUsersIDSave = new PharmacyModel();
            var strStrTypeId = new PharmacyModel();
            strUsersIDSave.strTypes = strIntId;
            strStrTypeId.strTypes = strType;

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    conn.Open();
                    SqlCommand sqlcmd = new SqlCommand("SP_UserAccountsAddUpdate", conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    if ((strUsersIDSave.strTypes != "") && (strUsersIDSave.strTypes != null))
                    {
                        sqlcmd.Parameters.Add(new SqlParameter("@intId", Convert.ToInt64(strIntId)));
                    }
                    sqlcmd.Parameters.Add(new SqlParameter("@Username", strUsername));
                    sqlcmd.Parameters.Add(new SqlParameter("@Password", strPassword));
                    sqlcmd.Parameters.Add(new SqlParameter("@FirstName", strFirstName));
                    sqlcmd.Parameters.Add(new SqlParameter("@LastName", strLastName));
                    if ((strStrTypeId.strTypes != "") && (strStrTypeId.strTypes != null))
                    {
                        sqlcmd.Parameters.Add(new SqlParameter("@Type", Convert.ToInt32(strType)));
                    }
                    SqlParameter strValue = new SqlParameter("@responseMessage", SqlDbType.NVarChar, 250);
                    strValue.Direction = ParameterDirection.Output;
                    sqlcmd.Parameters.Add(strValue);
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                    strSaveResults.strTypes = strValue.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                strSaveResults.strTypes = "Error: " + ex.Message.ToString();
                instWriteErrorLogs.writeErrorLogs(strSaveResults.strTypes);
            }

            return strSaveResults.strTypes;
        }

        #endregion

        #region Check New or Change Username

        public int CheckUserName(string strUserName, string SP)
        {
            var instWriteErrorLogs = new DistributorsController();
            var intTotal = new PharmacyModel();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SP, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@UserName", strUserName));
                    SqlParameter intValue = new SqlParameter("@IntTotal", SqlDbType.Int);
                    intValue.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(intValue);
                    SqlDataReader reader = cmd.ExecuteReader();
                    intTotal.intNumber = Convert.ToInt16(intValue.Value);
                    reader.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                instWriteErrorLogs.writeErrorLogs("Error: " + ex.Message.ToString());
            }

            return intTotal.intNumber;
        }

        #endregion

        #region Get User type 

        public string strGetNameUserType(Int32 intId, string SP)
        {
            var instWriteErrorLogs = new DistributorsController();
            var strNameUserTypeValue = new PharmacyModel();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand(SP, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@intId", intId));
                    SqlParameter strNameTypeValue = new SqlParameter("@strValue", SqlDbType.NVarChar, 250);
                    strNameTypeValue.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(strNameTypeValue);
                    SqlDataReader reader = cmd.ExecuteReader();
                    strNameUserTypeValue.strTypes = strNameTypeValue.Value.ToString();
                    reader.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                instWriteErrorLogs.writeErrorLogs("Error: " + ex.Message.ToString());
            }
            finally
            {

            }

            return strNameUserTypeValue.strTypes;
        }

        #endregion

    
    }
}

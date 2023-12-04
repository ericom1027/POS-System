using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Pharmacy
{
    class DiscountController
    {

        #region Return Data Table without Parameter

        public DataTable DT(string strSP)
        {
            var writeLogs = new DistributorsController();
            DataTable dt = new DataTable();

            try
            {
                SqlConnection myConn = new SqlConnection(Properties.Settings.Default.DBConn);
                if(myConn.State == ConnectionState.Closed)
                {
                    myConn.Open();
                }
                SqlCommand myCmd = new SqlCommand(strSP, myConn);
                myCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.Fill(dt);
                myConn.Close();
                myConn.Dispose();

            }
            catch (Exception ex)
            {
                writeLogs.writeErrorLogs("Error: " + ex.Message.ToString());
            }

            return dt;
        }

        #endregion

        #region Add Update Discount

        public string SaveUpdateDistributor(Int32 intID, string strDiscountDesc, Int32 intDiscount)
        {
            var strSaveResults = new PharmacyModel();
            var instanceWriteLogs = new DistributorsController();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    if (conn.State == ConnectionState.Closed) 
                    {
                        conn.Open();
                    }
                    SqlCommand sqlcmd = new SqlCommand("SP_AddUpdateDiscount", conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    if(intID != 0)
                    {
                        sqlcmd.Parameters.Add(new SqlParameter("@intId", intID));
                    }
                    sqlcmd.Parameters.Add(new SqlParameter("@DiscountDesc", strDiscountDesc));
                    sqlcmd.Parameters.Add(new SqlParameter("@Discount", intDiscount));
                    SqlParameter strValue = new SqlParameter("@strStatus", SqlDbType.NVarChar, 250);
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
                instanceWriteLogs.writeErrorLogs(strSaveResults.strTypes);
            }
            
            return strSaveResults.strTypes;
        }

        #endregion

        #region Validation Object using regex

        public string strTextBoxCheckContains(string strRegex, string strTxtBoxContains)
        {
            var strRtrValue = new PharmacyModel();

            Regex regexContains = new Regex(strRegex);
            if (regexContains.IsMatch(strTxtBoxContains))
            {
                strRtrValue.strTypes = "True";
            }
            else
            {
                strRtrValue.strTypes = "False";
            }

            return strRtrValue.strTypes;
        }

        #endregion

        #region Delete Pharmacy Discount

        public string strDeleteDiscount(Int32 intId, string SP)
        {
            var strMessage = new PharmacyModel();
            var instWriteErrorLogs = new DistributorsController();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    conn.Open();
                    SqlCommand sqlcmd = new SqlCommand(SP, conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@intId", intId));
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                    strMessage.strTypes = " product has been successfully deleted!";
                }
            }
            catch (Exception ex)
            {
                strMessage.strTypes = "Error: " + ex.Message.ToString();
                instWriteErrorLogs.writeErrorLogs(strMessage.strTypes);
            }

            return strMessage.strTypes;
        }

        #endregion
    }
}

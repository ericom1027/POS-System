using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;

namespace Pharmacy
{
    class DistributorsController
    {
        #region Add Update Distributor

        public string SaveUpdateDistributor(string intID, string strCompany, string strAddress, string strHPnumber, string strTIN, string strEmail, string strContactPerson)
        {
            var strSaveResults = new PharmacyModel();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    conn.Open();
                    SqlCommand sqlcmd = new SqlCommand("SP_AddUpdateWSCustomer", conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@Id", intID));
                    sqlcmd.Parameters.Add(new SqlParameter("@Company", strCompany));
                    sqlcmd.Parameters.Add(new SqlParameter("@Address", strAddress));
                    sqlcmd.Parameters.Add(new SqlParameter("@HPNumber", strHPnumber));
                    sqlcmd.Parameters.Add(new SqlParameter("@TIN", strTIN));
                    sqlcmd.Parameters.Add(new SqlParameter("@Email", strEmail));
                    sqlcmd.Parameters.Add(new SqlParameter("@ContactPerson", strContactPerson));
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                strSaveResults.strTypes = "Error: " + ex.Message.ToString();
                writeErrorLogs(strSaveResults.strTypes);
            }
            finally
            {
                strSaveResults.strTypes = "True";
            }

            return strSaveResults.strTypes;
        }

#endregion

        #region Add and Update Distributor Products

		//public string AddUpdateDistributorsProducts(string strProductUID, string strCompany, string strProductDescption, string strType, string strQuantity, string strUM, string strUnitPrice, string strExpiryDate, string strDiscount, string strNetPrice, string strTotalAmount)
		//{

		//    var strSaveResults = new PharmacyModel();
		//    var strProductIDSave = new PharmacyModel();
		//    strProductIDSave.strTypes = strProductUID;
		//    var decValue = new PharmacyModel();
		//    decValue.decValue = Convert.ToDecimal(strNetPrice);

		//    try
		//    {
		//        using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
		//        {

		//            DateTime dtDateTime = DateTime.Parse(strExpiryDate);

		//            conn.Open();
		//            SqlCommand sqlcmd = new SqlCommand("SP_AddUpdateDistributorsProducts", conn);
		//            sqlcmd.CommandType = CommandType.StoredProcedure;
		//            if ((strProductIDSave.strTypes != "") && (strProductIDSave.strTypes != null))
		//            {
		//                sqlcmd.Parameters.Add(new SqlParameter("@UID", Convert.ToInt64(strProductUID)));
		//            }
		//            sqlcmd.Parameters.Add(new SqlParameter("@Company", Convert.ToInt32(strCompany)));
		//            sqlcmd.Parameters.Add(new SqlParameter("@ProductDescription", strProductDescption));
		//            sqlcmd.Parameters.Add(new SqlParameter("@Type", Convert.ToInt32(strType)));
		//            sqlcmd.Parameters.Add(new SqlParameter("@Quantity", Convert.ToInt32(strQuantity)));
		//            sqlcmd.Parameters.Add(new SqlParameter("@UM", Convert.ToInt32(strUM)));
		//            sqlcmd.Parameters.Add(new SqlParameter("@UnitPrice", Convert.ToDecimal(Convert.ToDouble(strUnitPrice))));
		//            sqlcmd.Parameters.Add(new SqlParameter("@ExpirtyDate", dtDateTime));
		//            if (strDiscount != string.Empty)
		//            {
		//                sqlcmd.Parameters.Add(new SqlParameter("@Discount", Convert.ToInt32(strDiscount)));
		//            }
		//            else { sqlcmd.Parameters.Add(new SqlParameter("@Discount", strDiscount)); }

		//            sqlcmd.Parameters.Add(new SqlParameter("@NetPrice", decValue.decValue));
		//            sqlcmd.Parameters.Add(new SqlParameter("@TotalAmount", Convert.ToDecimal(strTotalAmount)));
		//            sqlcmd.ExecuteNonQuery();
		//            conn.Close();
		//            conn.Dispose();
		//            strSaveResults.strTypes = "True";
		//        }
		//    }
		//    catch (Exception ex)
		//    {
		//        strSaveResults.strTypes = "Error: " + ex.Message.ToString();
		//        writeErrorLogs(strSaveResults.strTypes);
		//    }

		//    return strSaveResults.strTypes;
		//}

        #endregion

        #region delete Controller With 1 Parameter

        public string strDeleted(int intID, string strCompanyDeleted, string SP)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    conn.Open();
                    SqlCommand sqlcmd = new SqlCommand(SP, conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@Id", intID));
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                strCompanyDeleted = "Error: " + ex.Message.ToString();
                writeErrorLogs(strCompanyDeleted);
            }

            return strCompanyDeleted;
        }

        #endregion

        #region Delete Distributor Products

        public string strDeleteDistributorProduct(string strUID, string strDistProduct, string SP)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    conn.Open();
                    SqlCommand sqlcmd = new SqlCommand(SP, conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@UID", strUID));
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                strDistProduct = "Error: " + ex.Message.ToString();
                writeErrorLogs(strDistProduct);
            }

            return strDistProduct;
        }

        #endregion

        #region Check Company Name

        public int CheckCompanyName(string strCompanyName, string SP)
        {
            var intTotal = new PharmacyModel();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SP, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@CompanyName", strCompanyName));
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
                writeErrorLogs("Error: " + ex.Message.ToString());
            }

            return intTotal.intNumber;
        }

        #endregion

        #region Return Data Table without Parameter

        public DataTable DT(string strSP)
        {
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
                writeErrorLogs("Error: " + ex.Message.ToString());
            }

            return dt;
        }

        #endregion

        #region Return Data Table with Parameter

        public DataTable dtWithParameter(string strSP, Int32 intId, string strProuctDesc)
        {
            var strProductDesciption = new PharmacyModel();
            strProductDesciption.strTypes = strProuctDesc;

            DataTable dt = new DataTable();
            try
            {
                SqlConnection myConn = new SqlConnection(Properties.Settings.Default.DBConn);
                myConn.Open();
                SqlCommand myCmd = new SqlCommand(strSP, myConn);
                myCmd.CommandType = CommandType.StoredProcedure;

                if (intId != 0)
                {
                    myCmd.Parameters.Add(new SqlParameter("@intId", intId));
                }



                if ((strProductDesciption.strTypes != null) && (strProductDesciption.strTypes != string.Empty))
                {
                    myCmd.Parameters.Add(new SqlParameter("@strProducts", strProductDesciption.strTypes));
                }

                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.Fill(dt);
                myConn.Close();
                myConn.Dispose();

            }
            catch (Exception ex)
            {
                writeErrorLogs("Error: " + ex.Message.ToString());
            }

            return dt;
        }

        #endregion

        #region Check Object Control if Empty

        public string strCheckTxtBoxEmpty(string strTxtboxContain, string strMessage)
        {
            var strValueMessage = new PharmacyModel();

            if (string.IsNullOrEmpty(strTxtboxContain))
            {
                strValueMessage.strTypes = strMessage;
            }

            return strValueMessage.strTypes;
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

        #region Convert Decimal To Currency

        public string convertDecimalToCurrency(Decimal dcCurrency)
        {
            var strCurrentConverted = new PharmacyModel();

            strCurrentConverted.strTypes = dcCurrency.ToString("N2");

            return strCurrentConverted.strTypes;
        }

        #endregion

        #region Write Error Logs

        public void writeErrorLogs(string strMessage)
        {

            dateObject strLogDate2 = new dateObject();
            string path = Properties.Settings.Default.strErrorLogsPath + "Logs_" + strLogDate2.strDate + ".log";

            FileInfo fileInfo = new FileInfo(path);
            if (!fileInfo.Directory.Exists) fileInfo.Directory.Create();

            strLogDate2.SetCurrentDate("GetCurrentDate");
            using (StreamWriter sw2 = File.AppendText(path))
            {
                sw2.WriteLine(strMessage + ";Date:" + strLogDate2.strDate);
                sw2.Close();
                sw2.Dispose();
            }
        }

        #endregion    

    }
}

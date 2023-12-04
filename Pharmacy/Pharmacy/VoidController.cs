using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Pharmacy
{
    class VoidController
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
                instWriteLogs.writeErrorLogs("Error Void: " + ex.Message.ToString());
            }

            return strMessage.strTypes;

        }

        #endregion

        #region Get Invoice Number

        public int GetInvoiceNo(Int32 InvoiceNo, string SP)
        {
            var instWriteErrorLogs = new DistributorsController();
            var intInvoiceNo = new PharmacyModel();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SP, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@InvoiceNo", InvoiceNo));
                    SqlParameter intValue = new SqlParameter("@ReturnInvoiceNo", SqlDbType.Int);
                    intValue.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(intValue);
                    SqlDataReader reader = cmd.ExecuteReader();
                    intInvoiceNo.intNumber = Convert.ToInt16(intValue.Value);
                    reader.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                instWriteErrorLogs.writeErrorLogs("Error Void: " + ex.Message.ToString());
            }

            return intInvoiceNo.intNumber;
        }

        #endregion

		#region Get Invoice Number

		public int checkReceiptNo(string strReceiptNo, string SP)
		{
			var instWriteErrorLogs = new DistributorsController();
			var intInvoiceNo = new PharmacyModel();

			try
			{
				using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand(SP, conn);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add(new SqlParameter("@strReceiptNo", strReceiptNo));
					SqlParameter intValue = new SqlParameter("@ReturnReceiptNo", SqlDbType.Int);
					intValue.Direction = ParameterDirection.Output;
					cmd.Parameters.Add(intValue);
					SqlDataReader reader = cmd.ExecuteReader();
					intInvoiceNo.intNumber = Convert.ToInt16(intValue.Value);
					reader.Close();
					cmd.Dispose();
				}
			}
			catch (Exception ex)
			{
				instWriteErrorLogs.writeErrorLogs("Error Void: " + ex.Message.ToString());
			}

			return intInvoiceNo.intNumber;
		}

		#endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Pharmacy
{
    class WholeSaleController
    {

        #region Return Data Table without Parameter

        public DataTable DT(string strSP)
        {
            var writeLogs = new DistributorsController();
            DataTable dt = new DataTable();

            try
            {
                SqlConnection myConn = new SqlConnection(Properties.Settings.Default.DBConn);
                if (myConn.State == ConnectionState.Closed)
                {
                    myConn.Open();
                }
                SqlCommand myCmd = new SqlCommand(strSP, myConn);
                myCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.Fill(dt);
                myCmd.Dispose();
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

        #region Return Data Table with Parameter

        public DataTable withParDT(string strSP, string strPar)
        {
            var strParValue = new PharmacyModel();
            var writeLogs = new DistributorsController();
            DataTable dt = new DataTable();

            try
            {
                SqlConnection myConn = new SqlConnection(Properties.Settings.Default.DBConn);
                if (myConn.State == ConnectionState.Closed)
                {
                    myConn.Open();
                }
                SqlCommand myCmd = new SqlCommand(strSP, myConn);
                myCmd.CommandType = CommandType.StoredProcedure;
                myCmd.Parameters.Add(new SqlParameter("@strDescription", strPar));
                
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.Fill(dt);
                myCmd.Dispose();
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

        #region Return Data Table with Parameter WholeSaleOrders

        public DataTable getWholeSaleOrdersDT(string strSP, Int32 intInvoiceNo)
        {
            //var strParValue = new PharmacyModel();
            var writeLogs = new DistributorsController();
            DataTable dt = new DataTable();

            try
            {
                SqlConnection myConn = new SqlConnection(Properties.Settings.Default.DBConn);
                if (myConn.State == ConnectionState.Closed)
                {
                    myConn.Open();
                }
                SqlCommand myCmd = new SqlCommand(strSP, myConn);
                myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.Add(new SqlParameter("@intInvoiceNo", intInvoiceNo));
                //myCmd.Parameters.Add(new SqlParameter("@DateOrder", DateOrder));
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.Fill(dt);
                myCmd.Dispose();
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

        #region Add Update Whole Sale Orders

        public string SaveUpdateWholeSaleOrder(Int32 intId, Int32 intCompanyId, Int32 ProductId, DateTime DateOrder, Int32 intQuantity, Decimal decTotal, Int32 InvoiceNo, Int32 StockId)
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
                    SqlCommand sqlcmd = new SqlCommand("SP_AddUpdateWholeSale", conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    //sqlcmd.Parameters.Add(new SqlParameter("@blnUpdate", blnUpdate));

                    if (intId != 0)
                    {
                        sqlcmd.Parameters.Add(new SqlParameter("@intId", intId));
                    }

                    sqlcmd.Parameters.Add(new SqlParameter("@intCompany", intCompanyId));
                    sqlcmd.Parameters.Add(new SqlParameter("@ProductId", ProductId));
                    sqlcmd.Parameters.Add(new SqlParameter("@DateOrder", DateOrder));
                    sqlcmd.Parameters.Add(new SqlParameter("@intQuantity", intQuantity));
                    sqlcmd.Parameters.Add(new SqlParameter("@decTotal", decTotal));
                    sqlcmd.Parameters.Add(new SqlParameter("@intInvoiceNo", InvoiceNo));

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

        #region Check if Products is VAT Exempted

		public int CheckIfVatExempted(string SP, int ProductId)
		{
			var instanceWriteLogs = new DistributorsController();
			var intGot = new PharmacyModel();

			try
			{
				using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand(SP, conn);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add(new SqlParameter("@ProductId", ProductId));
					//cmd.Parameters.Add(new SqlParameter("@DateOrder", DateOrder));
					SqlParameter intValue = new SqlParameter("@intVATExempted", SqlDbType.Int);
					intValue.Direction = ParameterDirection.Output;
					cmd.Parameters.Add(intValue);
					SqlDataReader reader = cmd.ExecuteReader();
					intGot.intNumber = int.Parse(intValue.Value.ToString());
					reader.Close();
					cmd.Dispose();
				}
			}
			catch (Exception ex)
			{
				instanceWriteLogs.writeErrorLogs("Error: " + ex.Message.ToString());
			}

			return intGot.intNumber;

		}

		#endregion

        #region Delete Whole Sale Orders

        public string strDeleteWholeSaleOrder(Int32 OrderId, Int32 StockId, Int32 intQuantity, string SP)
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
                    sqlcmd.Parameters.Add(new SqlParameter("@orderId", OrderId));
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                    strMessage.strTypes = "Order has been successfully Remove!";
                    
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

        #region Get Maximum Id Value in Total Whole Sale Orders

        public int getMaxNumber()
        {
            var instWriteErrorLogs = new DistributorsController();
            int intTotal = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_GetMaxIdInvoiceNo", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter intValue = new SqlParameter("@intMaxId", SqlDbType.Int);
                    intValue.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(intValue);
                    SqlDataReader reader = cmd.ExecuteReader();
                    intTotal = Convert.ToInt16(intValue.Value);
                    reader.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                instWriteErrorLogs.writeErrorLogs("Error: " + ex.Message.ToString());
            }

            return intTotal;
        }
       
        #endregion

        #region Update stock available in each product

        public void updateStock(int StockId, int intQuantity, int intAddSubstract)
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
                    SqlCommand sqlcmd = new SqlCommand("SP_UpdateStockQuantity", conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@StockId", StockId));
                    sqlcmd.Parameters.Add(new SqlParameter("@intQuantity", intQuantity));
                    sqlcmd.Parameters.Add(new SqlParameter("@intAddSubstract", intAddSubstract));

                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                strSaveResults.strTypes = "Error: " + ex.Message.ToString();
                instanceWriteLogs.writeErrorLogs(strSaveResults.strTypes);
            }
            
        }

        #endregion

        #region Add Update Total Whole Sale Orders

        public string SaveUpdateTotalWholeSaleOrders(Int32 intInvoiceNo, Decimal decVatable, Decimal decVat, Decimal decGrandTotal, decimal VATExempted)
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
                    SqlCommand sqlcmd = new SqlCommand("SP_AddUpdateTotalWholeSaleOrders", conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    
                    
                    sqlcmd.Parameters.Add(new SqlParameter("@intInvoiceNo", intInvoiceNo));
                    sqlcmd.Parameters.Add(new SqlParameter("@decVatable", decVatable));
                    sqlcmd.Parameters.Add(new SqlParameter("@decVat", decVat));
                    sqlcmd.Parameters.Add(new SqlParameter("@decGrandTotal", decGrandTotal));
					sqlcmd.Parameters.Add(new SqlParameter("@VATExempted", VATExempted));
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

        #region Update Table WholeSale which Checkout is Yes 

        public void UpdateWholeSaleToCheckout(Int32 intInvoiceNo, string strCheckout)
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
                    SqlCommand sqlcmd = new SqlCommand("SP_UpdateWholeSaleCheckOutField", conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    if (strCheckout != string.Empty)
                    {
                        sqlcmd.Parameters.Add(new SqlParameter("@strCheckout", strCheckout));
                    }
                    sqlcmd.Parameters.Add(new SqlParameter("@InvoiceNo", intInvoiceNo));
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                strSaveResults.strTypes = "Error: " + ex.Message.ToString();
                instanceWriteLogs.writeErrorLogs(strSaveResults.strTypes);
            }
        }

        #endregion

        #region Update Table WholeSale for Void products

        public string UpdateVoidWholeSaleOrders(Int32 OrderId, string strReason)
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
                    SqlCommand sqlcmd = new SqlCommand("SP_UpdateVoidOrders", conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@OrderId", OrderId));
                    sqlcmd.Parameters.Add(new SqlParameter("@StrReason", strReason));
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                    strSaveResults.strTypes = "Void has been successfully remove!";
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

    }
}

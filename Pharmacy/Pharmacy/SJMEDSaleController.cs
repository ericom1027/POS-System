using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Pharmacy
{
	class SJMEDSaleController
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
					SqlCommand cmd = new SqlCommand("SP_GetMaxIdSJMEDSalesOrder", conn);
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

        #region Update SJMED stock available in each product

        public void updateSJMEDStock(int StockId, int intQuantity, int intAddSubstract)
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
                    SqlCommand sqlcmd = new SqlCommand("SP_UpdateSJMEDStockQuantity", conn);
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

        #region Get Product Total Stock

        public string getProductTotalStock(string SP, int intStockId)
        {
            var instanceWriteLogs = new DistributorsController();
            var decTotal = new PharmacyModel();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SP, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@intStockId", intStockId));
                    //cmd.Parameters.Add(new SqlParameter("@DateOrder", DateOrder));
                    SqlParameter decValue = new SqlParameter("@TotalStock", SqlDbType.NVarChar, 250);
                    decValue.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(decValue);
                    SqlDataReader reader = cmd.ExecuteReader();
                    decTotal.strTypes = decValue.Value.ToString();
                    reader.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                instanceWriteLogs.writeErrorLogs("Error: " + ex.Message.ToString());
            }

            return decTotal.strTypes;

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

        #region Add Update Temp SJMED Orders

        public void SaveUpdateTempOrders(string strDesc, Int32 intQty, string strSD, Int32 intPromo, Decimal desPrice, Decimal decTotal, Int32 StockId, string strRN, string strCustomer, DateTime dtDateOrder, Int32 DiscountId, string ProDiscount)
        {
           // var strSaveResults = new PharmacyModel();
            var instanceWriteLogs = new DistributorsController();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand sqlcmd = new SqlCommand("SP_AddUpdateTempOrders", conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.Add(new SqlParameter("@Description", strDesc));
                    sqlcmd.Parameters.Add(new SqlParameter("@Qty", intQty));
                    sqlcmd.Parameters.Add(new SqlParameter("@SD", strSD));
                    sqlcmd.Parameters.Add(new SqlParameter("@Promo", intPromo));
                    sqlcmd.Parameters.Add(new SqlParameter("@decPrice", desPrice));
                    sqlcmd.Parameters.Add(new SqlParameter("@decTotal", decTotal));
                    sqlcmd.Parameters.Add(new SqlParameter("@intStockId", StockId));
                    sqlcmd.Parameters.Add(new SqlParameter("@ReceiptNo", strRN));
                    sqlcmd.Parameters.Add(new SqlParameter("@Customer", strCustomer));
                    sqlcmd.Parameters.Add(new SqlParameter("@DateOrder", dtDateOrder));
                    sqlcmd.Parameters.Add(new SqlParameter("@DiscountId", DiscountId));
					sqlcmd.Parameters.Add(new SqlParameter("@ProDiscount", ProDiscount));
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                    

                }
            }
            catch (Exception ex)
            {
                
                instanceWriteLogs.writeErrorLogs("Error Temp Orders: " + ex.Message.ToString());
            }

          
        }

        #endregion

        #region Add Update SJMED Products Orders

        public string SaveUpdateSJMEDProductOrders(Int32 Id, Int32 ProductId, DateTime DateOrder, Int32 intQty, Int32 DiscountId, Int32 intPromo, Decimal desPrice, Decimal decTotal, string ReceiptNo, string SPDiscount, string ProDiscount)
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
                    SqlCommand sqlcmd = new SqlCommand("SP_AddUpdateSJMEDOrders", conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

					sqlcmd.Parameters.Add(new SqlParameter("@Id", Id));
                    sqlcmd.Parameters.Add(new SqlParameter("@ProductId", ProductId));
                    sqlcmd.Parameters.Add(new SqlParameter("@DateOrder", DateOrder));
                    sqlcmd.Parameters.Add(new SqlParameter("@Qty", intQty));
                    sqlcmd.Parameters.Add(new SqlParameter("@DiscountId", DiscountId));
                    sqlcmd.Parameters.Add(new SqlParameter("@Promo", intPromo));
                    sqlcmd.Parameters.Add(new SqlParameter("@decPrice", desPrice));
                    sqlcmd.Parameters.Add(new SqlParameter("@decTotal", decTotal));
                    sqlcmd.Parameters.Add(new SqlParameter("@ReceiptNo", ReceiptNo));
					sqlcmd.Parameters.Add(new SqlParameter("@SPDiscount", SPDiscount));
					sqlcmd.Parameters.Add(new SqlParameter("@ProDiscount", ProDiscount));
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                    strSaveResults.strTypes = "Checkout has been successfull!";

                }
            }
            catch (Exception ex)
            {

                instanceWriteLogs.writeErrorLogs("Error Temp Orders: " + ex.Message.ToString());
            }

            return strSaveResults.strTypes;
        }

        #endregion

        #region Add Update Total Sales Orders

        public string SaveUpdateSJMEDTotalSales(decimal decVatable, decimal decVAT, decimal decGrandTotal, decimal decAmtRec, decimal decChange, string ReceiptNo, string Customer, decimal VATExemption)
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
                    SqlCommand sqlcmd = new SqlCommand("SP_AddUpdateSJMEDTotalSaleOrders", conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    //sqlcmd.Parameters.Add(new SqlParameter("@Customer", strCustomer));
                    sqlcmd.Parameters.Add(new SqlParameter("@decVatable", decVatable));
                    sqlcmd.Parameters.Add(new SqlParameter("@decVat", decVAT));
                    sqlcmd.Parameters.Add(new SqlParameter("@decGrandTotal", decGrandTotal));
                    sqlcmd.Parameters.Add(new SqlParameter("@decAmtRec", decAmtRec));
                    sqlcmd.Parameters.Add(new SqlParameter("@decChange", decChange));
                    sqlcmd.Parameters.Add(new SqlParameter("@ReceiptNo", ReceiptNo));
                    sqlcmd.Parameters.Add(new SqlParameter("@Customer", Customer));
					sqlcmd.Parameters.Add(new SqlParameter("@VATExempted", VATExemption));
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                    strSaveResults.strTypes = "Checkout has been succcessfull!";

                }
            }
            catch (Exception ex)
            {

                instanceWriteLogs.writeErrorLogs("Error SJMED Total Sales Orders: " + ex.Message.ToString());
            }

            return strSaveResults.strTypes;
        }

        #endregion

        #region Delete Temp SJMED Orders

        public void strDeleteSJMEDOrders(string strReceiptNo, string SP)
        {  
            var instWriteErrorLogs = new DistributorsController();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    conn.Open();
                    SqlCommand sqlcmd = new SqlCommand(SP, conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@ReceiptNo", strReceiptNo));
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
               
                instWriteErrorLogs.writeErrorLogs("Error Temp SJMED Orders Table: " + ex.Message.ToString());
            }

            
        }

        #endregion

		#region Update SJMED Sale Orders for Void products

		public string UpdateVoidSJMEDSaleOrders(Int32 OrderId, string strReason)
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
					SqlCommand sqlcmd = new SqlCommand("SP_VoidUpdateSJMEDSaleOrders", conn);
					sqlcmd.CommandType = CommandType.StoredProcedure;
					sqlcmd.Parameters.Add(new SqlParameter("@OrderId", OrderId));
					sqlcmd.Parameters.Add(new SqlParameter("@StrReason", strReason));
					sqlcmd.ExecuteNonQuery();
					conn.Close();
					conn.Dispose();
					strSaveResults.strTypes = "Void has been successfull!";
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

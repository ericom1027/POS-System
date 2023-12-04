﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Pharmacy
{
	class SJMEDProductsController
	{
		#region Get Maximum Id Value in SJMEDProducts Table

		public int getMaxNoForCodeNo()
		{
			var instWriteErrorLogs = new DistributorsController();
			int intTotal = 0;
			try
			{
				using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand("SP_GetMaxIdSJMEDProductsCodeNo", conn);
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
				myCmd.Parameters.Add(new SqlParameter("@strValue", strPar));

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

		#region Check Product Description if Exists

		public int CheckProductDesction(string SP, string strProductDescOrCode)
		{
			var instanceWriteLogs = new DistributorsController();
			var intTotal = new PharmacyModel();
			var strParValue = new PharmacyModel();

			try
			{
				using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand(SP, conn);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add(new SqlParameter("@strDescription", strProductDescOrCode));
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
				instanceWriteLogs.writeErrorLogs("Error: " + ex.Message.ToString());
			}

			return intTotal.intNumber;

		}

		#endregion

		#region Add Update SJMED Products

		public string SaveUpdateSJMEDProducts(int intId, string strCode, string strDescription, Int32 intType, Int32 intUnit, Int32 intPer, Decimal decPrice, int VATExempted)
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
					SqlCommand sqlcmd = new SqlCommand("SP_AddUpdateSJMEDProducts", conn);
					sqlcmd.CommandType = CommandType.StoredProcedure;
					//sqlcmd.Parameters.Add(new SqlParameter("@blnUpdate", blnUpdate));
					if (intId != 0)
					{
						sqlcmd.Parameters.Add(new SqlParameter("@intId", intId));
					}
					sqlcmd.Parameters.Add(new SqlParameter("@strCode", strCode));
					sqlcmd.Parameters.Add(new SqlParameter("@strDescription", strDescription));
					sqlcmd.Parameters.Add(new SqlParameter("@intType", intType));
					sqlcmd.Parameters.Add(new SqlParameter("@intUnit", intUnit));
					sqlcmd.Parameters.Add(new SqlParameter("@intPer", intPer));
					sqlcmd.Parameters.Add(new SqlParameter("@decPrice", decPrice));
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

		#region Delete SJMED Products

		public string strDeleteSJMEDProduct(Int32 intProductId, string SP)
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
					sqlcmd.Parameters.Add(new SqlParameter("@intId", intProductId));
					sqlcmd.ExecuteNonQuery();
					conn.Close();
					conn.Dispose();
					strMessage.strTypes = "Product has been successfully deleted!";
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

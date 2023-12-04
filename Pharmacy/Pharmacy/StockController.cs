using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Pharmacy
{
    class StockController
    {

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

        #region Add Update Stock Products

        public string SaveUpdateStock(int intId, Int32 ProductId, Int32 intProdType, Int32 intUnit, DateTime DateExpiry)
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
                    SqlCommand sqlcmd = new SqlCommand("SP_AddUpdateStocks", conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    //sqlcmd.Parameters.Add(new SqlParameter("@blnUpdate", blnUpdate));
                    if (intId != 0)
                    {
                        sqlcmd.Parameters.Add(new SqlParameter("@intId", intId));
                    }
                    sqlcmd.Parameters.Add(new SqlParameter("@ProductId", ProductId));
                    sqlcmd.Parameters.Add(new SqlParameter("@ProductType", intProdType));
                    sqlcmd.Parameters.Add(new SqlParameter("@Quantity", intUnit));
                    sqlcmd.Parameters.Add(new SqlParameter("@DateExpiry", DateExpiry));

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
    }
}

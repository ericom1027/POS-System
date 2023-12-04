using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Pharmacy
{
    class PharmacyProductsController
    {

        #region Check Product Name if Exists

        public int CheckProductName(string SP, string strProductName)
        {
            var instanceWriteLogs = new DistributorsController();
            PharmacyModel intTotal = new PharmacyModel();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SP, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@strProductName", strProductName));
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

        #region Add and Update Pharmacy Products

        public string AddUpdatePharmacyProducts(Int32 intId, string strProductName, Int32 intProductType, decimal decPrice, Int32 intPPdiscount, DateTime dtpDateExpiry)
        {
            var instWriteErrorLogs = new DistributorsController();
            var instanceClass = new PharmacyProductsController();
            var strMessage = new PharmacyModel();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
                {
                    conn.Open();
                    SqlCommand sqlcmd = new SqlCommand("SP_AddUpdatePharmacyProducts", conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    if (intId != 0)
                    {
                        sqlcmd.Parameters.Add(new SqlParameter("@intId", intId));
                    }
                    sqlcmd.Parameters.Add(new SqlParameter("@strProductName", strProductName));
                    sqlcmd.Parameters.Add(new SqlParameter("@intProductType", intProductType));
                    sqlcmd.Parameters.Add(new SqlParameter("@decUnitPrice", decPrice));
                    if (intPPdiscount != 0)
                    {
                        sqlcmd.Parameters.Add(new SqlParameter("@intDiscount", intPPdiscount));
                        sqlcmd.Parameters.Add(new SqlParameter("@DateExpiry", dtpDateExpiry));
                    }
                    SqlParameter strValue = new SqlParameter("@strStatus", SqlDbType.NVarChar, 250);
                    strValue.Direction = ParameterDirection.Output;
                    sqlcmd.Parameters.Add(strValue);
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                    strMessage.strTypes = strValue.Value.ToString();
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

        #region Delete Pharmacy Product

        public string strDeleteDistributorProduct(Int32 intId, string SP)
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

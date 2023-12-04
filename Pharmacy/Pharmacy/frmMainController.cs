using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace Pharmacy
{
	class frmMainController
	{
		#region Get Total of Main Near Expiry, Expired and Out Stock SJMED Products

		public int getTotal(string SP)
		{
			var instWriteErrorLogs = new DistributorsController();
			int intTotal = 0;
			try
			{
				using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConn))
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand(SP, conn);
					cmd.CommandType = CommandType.StoredProcedure;
					SqlParameter intValue = new SqlParameter("@intTotal", SqlDbType.Int);
					intValue.Direction = ParameterDirection.Output;
					cmd.Parameters.Add(intValue);
					SqlDataReader reader = cmd.ExecuteReader();
					intTotal = Convert.ToInt16(intValue.Value);
					reader.Close();
					cmd.Dispose();
					conn.Close();
				}
			}
			catch (Exception ex)
			{
				instWriteErrorLogs.writeErrorLogs("Error: " + ex.Message.ToString());
			}

			return intTotal;
		}

		#endregion

        #region Get MacAddress

        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }

        #endregion 

	}
}

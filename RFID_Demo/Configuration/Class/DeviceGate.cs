using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCRFIDReader
{
    public class DeviceGate
    {
        public async static Task<DataTable> GetDataTable()
        {
            DBManager dbMgr = new DBManager();
            string sql = "";
            DataSet ds;
            try
            {

                sql = "exec sp_DCGateReaderSetting_view";
                ds = dbMgr.ExecuteCommand_Select_Ds(sql);

                return ds.Tables[0];
            }
            catch
            {
                return null;
            }
        }
        public static DataTable GetDataTable(string ReaderDeviceId)
        {
            DBManager dbMgr = new DBManager();
            string sql = "";
            string strType = "";
            ArrayList data = new ArrayList();

            DataSet ds;
            try
            {
                data.Clear(); strType = "";
                data.Add(ReaderDeviceId); strType += "T";

                sql = "exec sp_DCGateReaderSetting_view @p1";
                ds = dbMgr.ExecuteCommand_Select_Ds(sql);

                return ds.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        public static string GetGateNumber(DataTable dt, string deviceid, int antenna)
        {
            DataRow[] dr = dt.Select("ReaderDeviceId = '" + deviceid + "' and Antenna = " + antenna.ToString());
            if (dr.Length > 0)
            {
                return dr[0]["GateNumber"].ToString();
            }
            else
            {
                return "";
            }
        }
        public async static Task<string> GetGateNumber(DataTable dt, string deviceid)
        {
            DataRow[] dr = dt.Select("ReaderDeviceId = '" + deviceid + "'");
            if (dr.Length > 0)
            {
                return dr[0]["GateNumber"].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}

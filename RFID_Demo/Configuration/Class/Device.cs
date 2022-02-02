using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCRFIDReader
{
    public class Device
    {
        public static DataTable GetDataTable()
        {
            DBManager dbMgr = new DBManager();
            string sql = "";
            DataSet ds;
            try
            {
                sql = "exec sp_DCReaderDevice_view";
                ds = dbMgr.ExecuteCommand_Select_Ds(sql);

                return ds.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        public static DataSet GetDataSet()
        {
            DBManager dbMgr = new DBManager();
            string sql = "";
            DataSet ds;
            try
            {
                sql = "exec sp_DCReaderDevice_view";
                ds = dbMgr.ExecuteCommand_Select_Ds(sql);

                return ds;
            }
            catch
            {
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCRFIDReader
{
    public class Gate
    {
        public static DataTable GetDataTable()
        {
            DBManager dbMgr = new DBManager();
            string sql = "";
            DataSet ds;
            try
            {
                sql = "exec sp_dcgate_view";
                ds = dbMgr.ExecuteCommand_Select_Ds(sql);

                return ds.Tables[0];
            }
            catch
            {
                return null;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DCRFIDReader
{
    public partial class frmGate
    {
        public string save() {
            DBManager dbmgr = new DBManager();
            string sql = "";
            string strType = "";
            ArrayList data = new ArrayList();
            try
            {
                data.Clear(); strType = "";
                data.Add(txtGateNumber.Text.Trim()); strType += "T";

                sql = "exec sp_dcgate_save @p1";
                dbmgr.ExecuteCommand(sql, strType, data);
            }
            catch (Exception ex)
            {
                return ex.Message;           
            }
            return "";
        }

        public string delete(string id) {
            DBManager dbmgr = new DBManager();
            string sql = "";
            string strType = "";
            ArrayList data = new ArrayList();
            try
            {
                data.Clear(); strType = "";
                data.Add(id); strType += "T";

                sql = "exec sp_dcgate_delete @p1";
                dbmgr.ExecuteCommand(sql, strType, data);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }

        private void loaddata()
        {
            DBManager dbMgr = new DBManager();
            string sql = "";
            DataSet ds;
            try
            {
                sql = "exec sp_dcgate_view";
                ds = dbMgr.ExecuteCommand_Select_Ds(sql);

                gcGate.DataSource = ds;
                gcGate.DataMember = "data";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gate");
            }
        }

        private void clear()
        {
            id = "";
            txtGateNumber.Text = "";
            txtGateNumber.Focus();
        }
    }
}

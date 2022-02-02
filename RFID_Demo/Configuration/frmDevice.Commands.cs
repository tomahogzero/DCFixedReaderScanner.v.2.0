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
    public partial class frmDevice
    {
        public string save() {
            DBManager dbmgr = new DBManager();
            string sql = "";
            string strType = "";
            ArrayList data = new ArrayList();
            try
            {
                data.Clear(); strType = "";
                data.Add(id); strType += "T";
                data.Add(txtIPAddress.Text.Trim()); strType += "T";
                data.Add(txtPort.Text.Trim()); strType += "T";
                data.Add(chkEnable.Checked); strType += "B";

                sql = "exec sp_DCReaderDevice_save @p1,@p2,@p3,@p4";
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

                sql = "exec sp_DCReaderDevice_delete @p1";
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
                sql = "exec sp_DCReaderDevice_view";
                ds = dbMgr.ExecuteCommand_Select_Ds(sql);

                gcDevice.DataSource = ds;
                gcDevice.DataMember = "data";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void clear()
        {
            id = "";
            txtIPAddress.Text = "";
            txtPort.Text = "";
            txtIPAddress.Focus();
        }

    }
}

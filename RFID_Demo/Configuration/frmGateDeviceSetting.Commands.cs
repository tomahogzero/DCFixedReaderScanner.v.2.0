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
    public partial class frmGateDeviceSetting
    {
        public string save() {
            DBManager dbmgr = new DBManager();
            string sql = "";
            string strType = "";
            ArrayList data = new ArrayList();
            try
            {
                data.Clear(); strType = "";
                data.Add(cboGateNumber.EditValue); strType += "T";
                data.Add(cboDevice.EditValue.ToString()); strType += "T";
                data.Add(cboAntenna.Text.Trim()); strType += "T";

                sql = "exec sp_DCGateReaderSetting_save @p1,@p2,@p3";
                dbmgr.ExecuteCommand(sql, strType, data);
            }
            catch (Exception ex)
            {
                return ex.Message;           
            }
            return "";
        }

        public string delete() {
            DBManager dbmgr = new DBManager();
            string sql = "";
            string strType = "";
            ArrayList data = new ArrayList();
            try
            {
                data.Clear(); strType = "";
                data.Add(cboGateNumber.EditValue); strType += "T";
                data.Add(cboDevice.EditValue.ToString()); strType += "T";
                data.Add(cboAntenna.Text.Trim()); strType += "T";

                sql = "exec sp_DCGateReaderSetting_delete @p1,@p2,@p3";
                dbmgr.ExecuteCommand(sql, strType, data);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }


        private void loadGate()
        {
            DBManager dbMgr = new DBManager();
            string sql = "";
            DataSet ds;
            try
            {
                sql = "exec sp_dcgate_view";
                ds = dbMgr.ExecuteCommand_Select_Ds(sql);

                cboGateNumber.Properties.DataSource = ds.Tables[0];
                cboGateNumber.Properties.ValueMember = "GateNumber";
                cboGateNumber.Properties.DisplayMember = "GateNumber";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void loadDevice()
        {
            DBManager dbMgr = new DBManager();
            string sql = "";
            DataSet ds;
            try
            {
                sql = "exec sp_DCReaderDevice_view";
                ds = dbMgr.ExecuteCommand_Select_Ds(sql);

                cboDevice.Properties.DataSource = ds.Tables[0];
                cboDevice.Properties.ValueMember = "Id";
                cboDevice.Properties.DisplayMember = "IPAddress";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void loaddata()
        {
            DBManager dbMgr = new DBManager();
            string sql = "";
            DataSet ds;
            try
            {
                sql = "exec sp_DCGateReaderSetting_view";
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
            cboGateNumber.EditValue = null;
            cboDevice.EditValue = null;
            cboAntenna.Text = "1";            
        }
    }
}

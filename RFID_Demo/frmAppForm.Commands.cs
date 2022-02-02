using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace DCRFIDReader
{
    public partial class frmAppForm
    {
        private DataTable dtDeviceScan;
        public bool inProcess = false;

        private delegate void dg_update_download_command(string value);

        private void update_download_command(string value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new dg_update_download_command(update_download_command), value);
            }
            else
            {
                //btnDownloadData.Text = value;
            }
        }

        private delegate void dg_update_progressbar(int value, int max);

        private void update_progressbar(int value, int max)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new dg_update_progressbar(update_progressbar), value, max);
            }
            else
            {
                //progressBar2.Maximum = max;
                //progressBar2.Value = value;
            }
        }

        private delegate void dg_update_sync_log(string value);

        private void update_sync_log(string value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new dg_update_sync_log(update_sync_log), value);
            }
            else
            {
                lstSyncLog.Items.Insert(0, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + " " + value);
            }
        }

        private void clear_scan_ui()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => { clear_scan_ui(); }));
            }
            else
            {
                inventoryList.Items.Clear();
                m_TagTable.Clear();
                lblTotalEPC.Text = "0";
            }
        }


        #region "function"
        private async Task load_data_po()
        {
            dsTag = await QTags.get_product_epc(deviceid);
            dsBox = await QTags.get_box(deviceid);
            dsProduct = await QTags.get_product(deviceid);
            dsPO = await QTags.get_po(deviceid);
            load_tags();
        }
        #endregion

        #region "Mobile Request Command"

        private async Task scan_command()
        {

            if (inProcess == false)
            {
                inProcess = true;

                DataTable dt = GetDtScanCommand();
                if (dt == null) return;

                foreach (DataRow dr in dt.Rows)
                {
                    switch ((int)dr["CommandCode"])
                    {
                        case 101: // SCAN
                            await command_start();
                            break;

                        case 102: // Re Scan
                            await command_rescan();
                            break;

                        case 103: // Stop
                            await command_stop();
                            break;
                        default:
                            break;
                    }
                }
                inProcess = false;
            }
        }

        private async Task command_start()
        {
            string res = "";
            res = await run_command_scan();
            if (res != "")
            {
                update_sync_log(res);
            }
            else
            {

                // load all data
                await load_data_po();

                currentBookingNo = GetCurrentBooking();

                // clear tag
                await Task.Run(() => {
                    clear_scan_ui();
                });

                if (btnStartRead.Text == "Start Reading")
                {
                    btnStartRead_Click(this, EventArgs.Empty);
                }

                if (m_IsConnected == true)
                {
                    res = await run_command_scan_set_complete();
                    if (res != "")
                    {
                        update_sync_log(res);
                    }
                }
            }
        }

        private async Task command_stop()
        {
            string res = "";
            res = await run_command_stop();
            if (res != "")
            {
                update_sync_log(res);
            }
            else
            {

                // load all data
                await load_data_po();

                // clear tag
                //await Task.Run(() => {
                //    inventoryList.Items.Clear();
                //    m_TagTable.Clear();
                //    lblTotalEPC.Text = "0";
                //});

                // Stop
                if (btnStartRead.Text == "Stop Reading")
                {
                    btnStartRead_Click(this, EventArgs.Empty);
                }

                res = await run_command_stop_set_complete();
                if (res != "")
                {
                    update_sync_log(res);
                }
            }
        }

        private async Task command_rescan()
        {
            string res = "";
            res = await run_command_rescan();
            if (res != "")
            {
                update_sync_log(res);
            }
            else
            {

                // load all data
                await load_data_po();
                currentBookingNo = GetCurrentBooking();

                // clear tag
                await Task.Run(() => {
                    clear_scan_ui();
                });

                //if (btnStartRead.Text == "Start Reading")
                //{
                //    btnStartRead_Click(this, EventArgs.Empty);
                //}

                if (m_IsConnected == true)
                {
                    res = await run_command_rescan_set_complete();
                    if (res != "")
                    {
                        update_sync_log(res);
                    }
                }
            }
        }

        private async Task command_clear_request()
        {
            string res = "";
            res = await run_command_clear_request();
            if (res != "")
            {
                update_sync_log(res);
            }
            else
            {

                // load all data
                await load_data_po();

                // clear tag
                //await Task.Run(() => {
                //    inventoryList.Items.Clear();
                //    m_TagTable.Clear();
                //    lblTotalEPC.Text = "0";
                //});

                // Stop
                if (btnStartRead.Text == "Stop Reading")
                {
                    btnStartRead_Click(this, EventArgs.Empty);
                }
            }
        }
        #endregion

        #region "Back-End"
        public async Task<string> run_command_scan()
        {
            DBManager dbmgr = new DBManager();
            string sql = "";
            string strType = "";
            ArrayList data = new ArrayList();
            try
            {
                data.Clear(); strType = "";
                data.Add(dcGateNumber); strType += "T";

                sql = "exec sp_dc_run_command_scan @p1";
                dbmgr.ExecuteCommand(sql, strType, data);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }

        public async Task<string> run_command_rescan()
        {
            DBManager dbmgr = new DBManager();
            string sql = "";
            string strType = "";
            ArrayList data = new ArrayList();
            try
            {
                data.Clear(); strType = "";
                data.Add(dcGateNumber); strType += "T";

                sql = "exec sp_dc_run_command_rescan @p1";
                dbmgr.ExecuteCommand(sql, strType, data);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }

        public async Task<string> run_command_stop()
        {
            DBManager dbmgr = new DBManager();
            string sql = "";
            string strType = "";
            ArrayList data = new ArrayList();
            try
            {
                data.Clear(); strType = "";
                data.Add(dcGateNumber); strType += "T";

                sql = "exec sp_dc_run_command_stop @p1";
                dbmgr.ExecuteCommand(sql, strType, data);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }

        public async Task<string> run_command_scan_set_complete()
        {
            DBManager dbmgr = new DBManager();
            string sql = "";
            string strType = "";
            ArrayList data = new ArrayList();
            try
            {
                data.Clear(); strType = "";
                data.Add(dcGateNumber); strType += "T";

                sql = "exec sp_dc_run_command_scan_set_complete @p1";
                dbmgr.ExecuteCommand(sql, strType, data);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }

        public async Task<string> run_command_rescan_set_complete()
        {
            DBManager dbmgr = new DBManager();
            string sql = "";
            string strType = "";
            ArrayList data = new ArrayList();
            try
            {
                data.Clear(); strType = "";
                data.Add(dcGateNumber); strType += "T";

                sql = "exec sp_dc_run_command_rescan_set_complete @p1";
                dbmgr.ExecuteCommand(sql, strType, data);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }

        public async Task<string> run_command_stop_set_complete()
        {
            DBManager dbmgr = new DBManager();
            string sql = "";
            string strType = "";
            ArrayList data = new ArrayList();
            try
            {
                data.Clear(); strType = "";
                data.Add(dcGateNumber); strType += "T";

                sql = "exec sp_dc_run_command_stop_set_complete @p1";
                dbmgr.ExecuteCommand(sql, strType, data);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }

        public async Task<string> run_command_clear_request()
        {
            DBManager dbmgr = new DBManager();
            string sql = "";
            try
            {
                sql = "exec sp_dc_scanbutton_clear_command";
                dbmgr.ExecuteCommand(sql);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }

        public async Task<string> save_epc_scan(string GateNumber,string BookingNo, string EPC,string PRProductItemId)
        {
            DBManager dbmgr = new DBManager();
            string sql = "";
            string strType = "";
            ArrayList data = new ArrayList();
            try
            {
                data.Clear(); strType = "";
                data.Add(dcGateNumber); strType += "T";
                data.Add(BookingNo); strType += "T";
                data.Add(EPC); strType += "T";
                data.Add(PRProductItemId); strType += "T";

                sql = "exec sp_dc_save_epc_scan @p1,@p2,@p3,@p4";
                dbmgr.ExecuteCommand(sql, strType, data);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }

        public string GetCurrentBooking()
        {
            DBManager dbMgr = new DBManager();
            string sql = "";
            DataSet ds;
            try
            {
                sql = "select top 1 BookingNo from DCCurrentScan Where GateNumber = '" + dcGateNumber + "'";
                ds = dbMgr.ExecuteCommand_Select_Ds(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0].Rows[0]["BookingNo"].ToString();
                }
                else {
                    return "";
                }
            }
            catch
            {
                return "";
            }
        }

        public static DataTable GetDtScanCommand()
        {
            DBManager dbMgr = new DBManager();
            string sql = "";
            DataSet ds;
            try
            {
                sql = "exec sp_dc_scan_command_view";
                ds = dbMgr.ExecuteCommand_Select_Ds(sql);

                return ds.Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}

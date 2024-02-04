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
        public bool inProcessRefreshButton = false;

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
                //lstSyncLog.Items.Insert(0, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + " " + value);
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""),"update_sync_log | " + value);
            }
        }

        private delegate void dg_clear_scan_ui();
        private void clear_scan_ui()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new dg_clear_scan_ui(clear_scan_ui));
            }
            else
            {
                try
                {
                    inventoryList.Items.Clear();
                    m_TagTable.Clear();
                    lblTotalEPC.Text = "0";
                }
                catch (Exception ex)
                {
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "clear_scan_ui | " + ex.Message);
                }
            }
        }


        #region "function"
        private async Task load_data_po()
        {
            QTags _QTags = new QTags(this);
            dsTag = await _QTags.get_product_epc(deviceid);
            dsBox = await _QTags.get_box(deviceid);
            dsProduct = await _QTags.get_product(deviceid);
            dsPO = await _QTags.get_po(deviceid);
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
                            cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "command_start | start");
                            await command_start();
                            cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "command_start | end");
                            break;

                        case 102: // Re Scan
                            cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "command_rescan | start");
                            await command_rescan();
                            cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "command_rescan | end");
                            break;

                        case 103: // Stop
                            cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "command_stop | start");
                            await command_stop();
                            cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "command_stop | stop");
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
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "command_start | " + res);
            }
            else
            {

                // load all data
                await load_data_po();

                currentBookingNo = GetCurrentBooking();

                // clear tag
                await Task.Run(() =>
                {
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
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "command_start | " + res);
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
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "command_stop | " + res);
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
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "command_stop | " + res);
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
                cFileIO.WriteLogToFile("command_rescan | " + res);
            }
            else
            {

                // load all data
                await load_data_po();
                currentBookingNo = GetCurrentBooking();

                // clear tag
                await Task.Run(() =>
                {
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
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "command_rescan | " + res);
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

        private async Task scan_refresh_button()
        {
            try
            {
                if (inProcessRefreshButton == false)
                {
                    inProcessRefreshButton = true;

                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "refresh button | start");

                    DataTable dt = GetDtButtonView(dcGateNumber);
                    if (dt == null) return;

                    foreach (DataRow dr in dt.Rows)
                    {
                        if ((bool)dr["isScanning"] == true)
                        {
                            // load all data
                            await load_data_po();

                            currentBookingNo = GetCurrentBooking();

                            // clear tag
                            await Task.Run(() =>
                            {
                                clear_scan_ui();
                            });

                            if (btnStartRead.Text == "Start Reading")
                            {
                                btnStartRead_Click(this, EventArgs.Empty);
                            }
                        }
                    }
                    inProcessRefreshButton = false;
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "refresh button | end");
                }
            }
            catch (Exception ex)
            {
                inProcessRefreshButton = false;
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "scan_refresh_button - Error | " + ex.Message);
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

        public async Task<string> save_epc_scan(string GateNumber, string BookingNo, string EPC, string PRProductItemId)
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
                else
                {
                    return "";
                }
            }
            catch(Exception ex)
            {
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "GetCurrentBooking | " + ex.Message);
                return "";
            }
        }

        public DataTable GetDtScanCommand()
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
            catch(Exception ex)
            {
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "GetDtScanCommand | " + ex.Message);
                return null;
            }
        }

        public DataTable GetDtButtonView(string GateNumber)
        {
            DBManager dbMgr = new DBManager();
            string sql = "";
            DataSet ds;
            try
            {
                sql = "exec sp_dc_scanbutton_view '" + GateNumber + "'";
                ds = dbMgr.ExecuteCommand_Select_Ds(sql);

                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "GetDtButtonView | " + ex.Message);
                return null;
            }
        }
        #endregion
    }
}

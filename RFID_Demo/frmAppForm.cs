using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Symbol.RFID3;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Repository;

namespace DCRFIDReader
{
    public partial class frmAppForm : Form
    {
        internal RFIDReader m_ReaderAPI;
        internal bool m_IsConnected;
        internal ConnectionForm m_ConnectionForm;
        internal ReadForm m_ReadForm;
        internal WriteForm m_WriteForm;
        internal LockForm m_LockForm;
        internal KillForm m_KillForm;
        internal BlockEraseForm m_BlockEraseForm;
        internal AccessOperationResult m_AccessOpResult;

        internal string m_SelectedTagID = null;

        private delegate void UpdateStatus(Events.StatusEventData eventData);
        private UpdateStatus m_UpdateStatusHandler = null;
        private delegate void UpdateRead(Events.ReadEventData eventData);
        private delegate void dg_UpdateTimecount();
        private UpdateRead m_UpdateReadHandler = null;
        private TagData m_ReadTag = null;
        private Hashtable m_TagTable;
        private Button button1;
        private uint m_TagTotalCount;

        public cFileIO fIO = new cFileIO();
        public DataSet dsDevice;
        public DataSet dsTag;
        public DataSet dsBox;
        public DataSet dsProduct;
        public DataSet dsPO;
        public DataSet dsPOEPC;
        public DataTable dtGateDevice;
        public string dcGateNumber = "";
        public string currentBookingNo = "";

        public string dbserver = "";
        public string dbname = "";
        public string uid = "";
        public string pwd = "";
        public bool reading = false;
        public bool internal_cal = false;

        public string deviceid = "";
        public string deviceip = "";
        public string deviceport = "";
        public bool ReaderConnectInProcess = false;

        public string Title = "RFID DC Receive Reader ";

        internal class AccessOperationResult
        {
            public RFIDResults m_Result;
            public String m_VendorMessage;
            public String m_StatusDescription;
            public ACCESS_OPERATION_CODE m_OpCode;

            public AccessOperationResult()
            {
                m_Result = RFIDResults.RFID_NO_ACCESS_IN_PROGRESS;
                m_OpCode = ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ;
            }
        }

        public frmAppForm()
        {
            InitializeComponent();
            m_ReadTag = new Symbol.RFID3.TagData();
            m_UpdateStatusHandler = new UpdateStatus(myUpdateStatus);
            m_UpdateReadHandler = new UpdateRead(myUpdateRead);
            m_ConnectionForm = new ConnectionForm(this);
            m_ReadForm = new ReadForm(this);
            m_TagTable = new Hashtable();
            m_AccessOpResult = new AccessOperationResult();
            m_IsConnected = false;
            m_TagTotalCount = 0;

            //dbValues.dbr_dbserver = aconfig.dbr_servername(); // System.Configuration.ConfigurationManager.AppSettings["dbr_servername"].Trim();
            //dbValues.dbr_dbname = aconfig.dbr_databasename(); // System.Configuration.ConfigurationManager.AppSettings["dbr_databasename"].Trim();
            //dbValues.dbr_uid = aconfig.dbr_uid(); // System.Configuration.ConfigurationManager.AppSettings["dbr_uid"].Trim();
            //dbValues.dbr_pwd = "f2Kfec9#c&wvx6gtweaJPrne"; // System.Configuration.ConfigurationManager.AppSettings["dbr_pwd"].Trim();

            //dbValues.dbr_connectionstring = "Data Source=" + dbValues.dbr_dbserver + ";Initial Catalog=" + dbValues.dbr_dbname + ";User ID=" + dbValues.dbr_uid + ";Password=" + dbValues.dbr_pwd;


            //dbValues.dbl_dbserver = aconfig.dbl_servername(); // System.Configuration.ConfigurationManager.AppSettings["dbl_servername"].Trim();
            //dbValues.dbl_dbname = aconfig.dbl_databasename(); // System.Configuration.ConfigurationManager.AppSettings["dbl_databasename"].Trim();
            //dbValues.dbl_uid = aconfig.dbl_uid(); // System.Configuration.ConfigurationManager.AppSettings["dbl_uid"].Trim();
            //dbValues.dbl_pwd = aconfig.dbl_pwd(); // System.Configuration.ConfigurationManager.AppSettings["dbl_pwd"].Trim();

            //dbValues.dbl_connectionstring = "Data Source=" + dbValues.dbl_dbserver + ";Initial Catalog=" + dbValues.dbl_dbname + ";User ID=" + dbValues.dbl_uid + ";Password=" + dbValues.dbl_pwd;


            //dbValues.dbserver = "server.tesco.kaewsai.net";// System.Configuration.ConfigurationManager.AppSettings["db_servername"].Trim();
            //dbValues.dbname = "ApplicationDb";// System.Configuration.ConfigurationManager.AppSettings["db_databasename"].Trim();
            //dbValues.uid = "developer";//System.Configuration.ConfigurationManager.AppSettings["db_uid"].Trim();
            //dbValues.pwd = "f2Kfec9#c&wvx6gtweaJPrne";//System.Configuration.ConfigurationManager.AppSettings["db_pwd"].Trim();
            //load_tags();
        }

        private void myUpdateStatus(Events.StatusEventData eventData)
        {
            switch (eventData.StatusEventType)
            {
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.INVENTORY_START_EVENT:
                    functionCallStatusLabel.Text = "Inventory started";
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "myUpdateStatus : Inventory started");
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.INVENTORY_STOP_EVENT:
                    functionCallStatusLabel.Text = "Inventory stopped";
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "myUpdateStatus : Inventory stopped");
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ACCESS_START_EVENT:
                    functionCallStatusLabel.Text = "Access Operation started";
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "myUpdateStatus : Access Operation started");
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ACCESS_STOP_EVENT:
                    functionCallStatusLabel.Text = "Access Operation stopped";
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "myUpdateStatus : Access Operation stopped");
                    if (this.m_SelectedTagID == string.Empty)
                    {
                        uint successCount, failureCount;
                        successCount = failureCount = 0;
                        m_ReaderAPI.Actions.TagAccess.GetLastAccessResult(ref successCount, ref failureCount);
                        functionCallStatusLabel.Text = "Access completed - Success Count: " + successCount.ToString()
                            + ", Failure Count: " + failureCount.ToString();
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "myUpdateStatus : Access completed - Success Count: " + successCount.ToString()
                            + ", Failure Count: " + failureCount.ToString());
                    }
                    resetButtonState();
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.BUFFER_FULL_WARNING_EVENT:
                    functionCallStatusLabel.Text = " Buffer full warning";
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "myUpdateStatus : Buffer full warning");
                    myUpdateRead(null);
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.BUFFER_FULL_EVENT:
                    functionCallStatusLabel.Text = "Buffer full";
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "myUpdateStatus : Buffer full");
                    myUpdateRead(null);
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.DISCONNECTION_EVENT:
                    functionCallStatusLabel.Text = "Disconnection Event " + eventData.DisconnectionEventData.DisconnectEventInfo.ToString();
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "myUpdateStatus : Disconnection Event " + eventData.DisconnectionEventData.DisconnectEventInfo.ToString());
                    connectBackgroundWorker.RunWorkerAsync("Disconnect");
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ANTENNA_EVENT:
                    functionCallStatusLabel.Text = "Antenna Status Update";
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "myUpdateStatus : Antenna Status Update");
                    break;
                case Symbol.RFID3.Events.STATUS_EVENT_TYPE.READER_EXCEPTION_EVENT:
                    functionCallStatusLabel.Text = "Reader ExceptionEvent " + eventData.ReaderExceptionEventData.ReaderExceptionEventInfo;
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "myUpdateStatus : Reader ExceptionEvent " + eventData.ReaderExceptionEventData.ReaderExceptionEventInfo);
                    break;
                default:
                    break;
            }
        }

        private void myUpdateRead(Events.ReadEventData eventData)
        {
            int index = 0;
            ListViewItem item;

            Symbol.RFID3.TagData[] tagData = m_ReaderAPI.Actions.GetReadTags(1000);
            if (tagData != null)
            {
                for (int nIndex = 0; nIndex < tagData.Length; nIndex++)
                {
                    if (tagData[nIndex].OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_NONE ||
                        (tagData[nIndex].OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ &&
                        tagData[nIndex].OpStatus == ACCESS_OPERATION_STATUS.ACCESS_SUCCESS))
                    {
                        Symbol.RFID3.TagData tag = tagData[nIndex];
                        string tagID = tag.TagID;
                        bool isFound = false;

                        lock (m_TagTable.SyncRoot)
                        {
                            isFound = m_TagTable.ContainsKey(tagID);
                            if (!isFound)
                            {
                                tagID += ((uint)tag.MemoryBank + tag.MemoryBankDataOffset);
                                isFound = m_TagTable.ContainsKey(tagID);
                            }
                        }

                        if (isFound)
                        {
                            uint count = 0;
                            item = (ListViewItem)m_TagTable[tagID];
                            try
                            {
                                count = uint.Parse(item.SubItems[2].Text) + tagData[nIndex].TagSeenCount;
                                m_TagTotalCount += tagData[nIndex].TagSeenCount;
                            }
                            catch (FormatException fe)
                            {
                                functionCallStatusLabel.Text = fe.Message;
                                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "myUpdateRead : " + fe.Message);
                                break;
                            }
                            item.SubItems[1].Text = tag.AntennaID.ToString();
                            item.SubItems[2].Text = count.ToString();
                            item.SubItems[3].Text = tag.PeakRSSI.ToString();

                            string memoryBank = tag.MemoryBank.ToString();
                            index = memoryBank.LastIndexOf('_');
                            if (index != -1)
                            {
                                memoryBank = memoryBank.Substring(index + 1);
                            }
                            if (tag.MemoryBankData.Length > 0 && !memoryBank.Equals(item.SubItems[5].Text))
                            {
                                item.SubItems[5].Text = tag.MemoryBankData;
                                item.SubItems[6].Text = memoryBank;
                                item.SubItems[7].Text = tag.MemoryBankDataOffset.ToString();

                                lock (m_TagTable.SyncRoot)
                                {
                                    m_TagTable.Remove(tagID);
                                    m_TagTable.Add(tag.TagID + tag.MemoryBank.ToString()
                                        + tag.MemoryBankDataOffset.ToString(), item);
                                }
                            }
                        }
                        else
                        {

                            item = new ListViewItem(tag.TagID);
                            ListViewItem.ListViewSubItem subItem;

                            subItem = new ListViewItem.ListViewSubItem(item, tag.AntennaID.ToString());
                            item.SubItems.Add(subItem);

                            subItem = new ListViewItem.ListViewSubItem(item, tag.TagSeenCount.ToString());
                            m_TagTotalCount += tag.TagSeenCount;
                            item.SubItems.Add(subItem);

                            subItem = new ListViewItem.ListViewSubItem(item, tag.PeakRSSI.ToString());
                            item.SubItems.Add(subItem);
                            subItem = new ListViewItem.ListViewSubItem(item, tag.PC.ToString("X"));
                            item.SubItems.Add(subItem);

                            subItem = new ListViewItem.ListViewSubItem(item, "");
                            item.SubItems.Add(subItem);
                            subItem = new ListViewItem.ListViewSubItem(item, "");
                            item.SubItems.Add(subItem);
                            subItem = new ListViewItem.ListViewSubItem(item, "");
                            item.SubItems.Add(subItem);

                            subItem = new ListViewItem.ListViewSubItem(item, "");
                            item.SubItems.Add(subItem);

                            inventoryList.BeginUpdate();
                            inventoryList.Items.Add(item);
                            inventoryList.EndUpdate();

                            lock (m_TagTable.SyncRoot)
                            {
                                m_TagTable.Add(tagID, item);
                            }

                            string logText;

                            logText = "TAG : " + tag.TagID + " Ant : " + tag.AntennaID.ToString();

                            //if (aconfig.StartReaderForTest == "1")
                            //{
                            //cFileIO.WriteLogToFile(logText);
                            //}


                            re_update_sku2(this, tag.TagID, tag.AntennaID);
                        }
                    }
                }
                //totalTagValueLabel.Text = m_TagTable.Count + "(" + m_TagTotalCount + ")";
            }
        }

        private void Events_ReadNotify(object sender, Events.ReadEventArgs readEventArgs)
        {
            try
            {
                this.Invoke(m_UpdateReadHandler, new object[] { readEventArgs.ReadEventData });
            }
            catch (Exception)
            {

            }
        }

        public void Events_StatusNotify(object sender, Events.StatusEventArgs statusEventArgs)
        {
            try
            {
                this.Invoke(m_UpdateStatusHandler, new object[] { statusEventArgs.StatusEventData });
            }
            catch (Exception)
            {
            }
        }

        private void accessBackgroundWorker_DoWork(object sender, DoWorkEventArgs accessEvent)
        {
            try
            {
                m_AccessOpResult.m_OpCode = (ACCESS_OPERATION_CODE)accessEvent.Argument;
                m_AccessOpResult.m_Result = RFIDResults.RFID_API_SUCCESS;

                if ((ACCESS_OPERATION_CODE)accessEvent.Argument == ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ)
                {
                    if (m_SelectedTagID != String.Empty)
                    {
                        m_ReadTag = m_ReaderAPI.Actions.TagAccess.ReadWait(
                        m_SelectedTagID, m_ReadForm.m_ReadParams, null);
                    }
                    else
                    {
                        functionCallStatusLabel.Text = "Enter Tag-Id";
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_DoWork - ACCESS_OPERATION_READ : Enter Tag-Id");
                    }
                }
                else if ((ACCESS_OPERATION_CODE)accessEvent.Argument == ACCESS_OPERATION_CODE.ACCESS_OPERATION_WRITE)
                {
                    if (m_SelectedTagID != String.Empty)
                    {
                        m_ReaderAPI.Actions.TagAccess.WriteWait(
                            m_SelectedTagID, m_WriteForm.m_WriteParams, null);
                    }
                    else
                    {
                        functionCallStatusLabel.Text = "Enter Tag-Id";
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_DoWork - ACCESS_OPERATION_WRITE : Enter Tag-Id");
                    }
                }
                else if ((ACCESS_OPERATION_CODE)accessEvent.Argument == ACCESS_OPERATION_CODE.ACCESS_OPERATION_LOCK)
                {
                    if (m_SelectedTagID != String.Empty)
                    {
                        m_ReaderAPI.Actions.TagAccess.LockWait(
                            m_SelectedTagID, m_LockForm.m_LockParams, null);
                    }
                    else
                    {
                        functionCallStatusLabel.Text = "Enter Tag-Id";
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_DoWork - ACCESS_OPERATION_LOCK : Enter Tag-Id");
                    }
                }
                else if ((ACCESS_OPERATION_CODE)accessEvent.Argument == ACCESS_OPERATION_CODE.ACCESS_OPERATION_KILL)
                {
                    if (m_SelectedTagID != String.Empty)
                    {
                        m_ReaderAPI.Actions.TagAccess.KillWait(
                            m_SelectedTagID, m_KillForm.m_KillParams, null);
                    }
                }
                else if ((ACCESS_OPERATION_CODE)accessEvent.Argument == ACCESS_OPERATION_CODE.ACCESS_OPERATION_BLOCK_ERASE)
                {
                    if (m_SelectedTagID != String.Empty)
                    {
                        m_ReaderAPI.Actions.TagAccess.BlockEraseWait(
                            m_SelectedTagID, m_BlockEraseForm.m_BlockEraseParams, null);
                    }
                    else
                    {
                        functionCallStatusLabel.Text = "Enter Tag-Id";
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_DoWork - ACCESS_OPERATION_BLOCK_ERASE : Enter Tag-Id");
                    }
                }
            }
            catch (OperationFailureException ofe)
            {
                m_AccessOpResult.m_Result = ofe.Result;
                m_AccessOpResult.m_StatusDescription = ofe.StatusDescription;
                m_AccessOpResult.m_VendorMessage = ofe.VendorMessage;
            }
            catch (InvalidUsageException ex)
            {
                m_AccessOpResult.m_Result = RFIDResults.RFID_API_PARAM_ERROR;
                m_AccessOpResult.m_StatusDescription = ex.Info;
                m_AccessOpResult.m_VendorMessage = ex.VendorMessage;
            }
            accessEvent.Result = m_AccessOpResult;
        }

        private void accessBackgroundWorker_ProgressChanged(object sender,
            ProgressChangedEventArgs pce)
        {

        }

        private void accessBackgroundWorker_RunWorkerCompleted(object sender,
            RunWorkerCompletedEventArgs accessEvents)
        {
            int index = 0;
            if (accessEvents.Error != null)
            {
                functionCallStatusLabel.Text = accessEvents.Error.Message;
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_RunWorkerCompleted : " + accessEvents.Error.Message);
            }
            else
            {
                // Handle AccessWait Operations              
                AccessOperationResult accessOpResult = (AccessOperationResult)accessEvents.Result;
                if (accessOpResult.m_Result == RFIDResults.RFID_API_SUCCESS)
                {
                    if (accessOpResult.m_OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ)
                    {
                        if (inventoryList.SelectedItems.Count > 0)
                        {
                            ListViewItem item = inventoryList.SelectedItems[0];
                            string tagID = m_ReadTag.TagID + m_ReadTag.MemoryBank.ToString()
                                + m_ReadTag.MemoryBankDataOffset.ToString();

                            if (item.SubItems[5].Text.Length > 0)
                            {
                                bool isFound = false;

                                // Search or add new one
                                lock (m_TagTable.SyncRoot)
                                {
                                    isFound = m_TagTable.ContainsKey(tagID);
                                }

                                if (!isFound)
                                {
                                    ListViewItem newItem = new ListViewItem(m_ReadTag.TagID);
                                    ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(newItem, m_ReadTag.AntennaID.ToString());
                                    newItem.SubItems.Add(subItem);
                                    subItem = new ListViewItem.ListViewSubItem(item, m_ReadTag.TagSeenCount.ToString());
                                    newItem.SubItems.Add(subItem);
                                    subItem = new ListViewItem.ListViewSubItem(item, m_ReadTag.PeakRSSI.ToString());
                                    newItem.SubItems.Add(subItem);
                                    subItem = new ListViewItem.ListViewSubItem(item, m_ReadTag.PC.ToString("X"));
                                    newItem.SubItems.Add(subItem);
                                    subItem = new ListViewItem.ListViewSubItem(item, m_ReadTag.MemoryBankData);
                                    newItem.SubItems.Add(subItem);

                                    string memoryBank = m_ReadTag.MemoryBank.ToString();
                                    index = memoryBank.LastIndexOf('_');
                                    if (index != -1)
                                    {
                                        memoryBank = memoryBank.Substring(index + 1);
                                    }

                                    subItem = new ListViewItem.ListViewSubItem(item, memoryBank);
                                    newItem.SubItems.Add(subItem);
                                    subItem = new ListViewItem.ListViewSubItem(item, m_ReadTag.MemoryBankDataOffset.ToString());
                                    newItem.SubItems.Add(subItem);

                                    inventoryList.BeginUpdate();
                                    inventoryList.Items.Add(newItem);
                                    inventoryList.EndUpdate();

                                    lock (m_TagTable.SyncRoot)
                                    {
                                        m_TagTable.Add(tagID, newItem);
                                    }
                                }
                            }
                            else
                            {
                                // Empty Memory Bank Slot
                                item.SubItems[5].Text = m_ReadTag.MemoryBankData;

                                string memoryBank = m_ReadForm.m_ReadParams.MemoryBank.ToString();
                                index = memoryBank.LastIndexOf('_');
                                if (index != -1)
                                {
                                    memoryBank = memoryBank.Substring(index + 1);
                                }
                                item.SubItems[6].Text = memoryBank;
                                item.SubItems[7].Text = m_ReadTag.MemoryBankDataOffset.ToString();

                                lock (m_TagTable.SyncRoot)
                                {
                                    if (m_ReadTag.TagID != null)
                                    {
                                        m_TagTable.Remove(m_ReadTag.TagID);
                                    }
                                    m_TagTable.Add(tagID, item);
                                }
                            }
                            this.m_ReadForm.ReadData_TB.Text = m_ReadTag.MemoryBankData;
                            functionCallStatusLabel.Text = "Read Succeed";
                            cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_RunWorkerCompleted - ACCESS_OPERATION_READ : Read Succeed");
                        }
                    }
                    else if (accessOpResult.m_OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_WRITE)
                    {
                        functionCallStatusLabel.Text = "Write Succeed";
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_RunWorkerCompleted - ACCESS_OPERATION_WRITE : Write Succeed");
                    }
                    else if (accessOpResult.m_OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_LOCK)
                    {
                        functionCallStatusLabel.Text = "Lock Succeed";
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_RunWorkerCompleted - ACCESS_OPERATION_LOCK : Lock Succeed");
                    }
                    else if (accessOpResult.m_OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_KILL)
                    {
                        functionCallStatusLabel.Text = "Kill Succeed";
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_RunWorkerCompleted - ACCESS_OPERATION_KILL : Kill Succeed");
                    }
                    else if (accessOpResult.m_OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_BLOCK_ERASE)
                    {
                        functionCallStatusLabel.Text = "BlockErase Succeed";
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_RunWorkerCompleted - ACCESS_OPERATION_BLOCK_ERASE : BlockErase Succeed");
                    }
                }
                else
                {
                    functionCallStatusLabel.Text = accessOpResult.m_StatusDescription + " [" + accessOpResult.m_VendorMessage + "]";
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_RunWorkerCompleted - ELSE : " + accessOpResult.m_StatusDescription + " [" + accessOpResult.m_VendorMessage + "]");
                }
                resetButtonState();
            }
        }

        private void resetButtonState()
        {
            if (m_ReadForm != null)
                m_ReadForm.readButton.Enabled = true;
            if (m_WriteForm != null)
                m_WriteForm.writeButton.Enabled = true;
            if (m_LockForm != null)
                m_LockForm.lockButton.Enabled = true;
            if (m_KillForm != null)
                m_KillForm.killButton.Enabled = true;
            if (m_BlockEraseForm != null)
                m_BlockEraseForm.eraseButton.Enabled = true;
        }

        private void connectBackgroundWorker_DoWork(object sender, DoWorkEventArgs workEventArgs)
        {
            ReaderConnectInProcess = true;
            connectBackgroundWorker.ReportProgress(0, workEventArgs.Argument);

            if ((string)workEventArgs.Argument == "Connect")
            {
                //m_ReaderAPI = new RFIDReader(m_ConnectionForm.IpText, uint.Parse(m_ConnectionForm.PortText), 0);
                m_ReaderAPI = new RFIDReader(deviceip, uint.Parse(deviceport), 0);
                try
                {
                    m_ReaderAPI.Connect();
                    m_IsConnected = true;
                    workEventArgs.Result = "Connect Succeed";

                }
                catch (OperationFailureException operationException)
                {
                    workEventArgs.Result = operationException.StatusDescription;
                }
                catch (Exception ex)
                {
                    workEventArgs.Result = ex.Message;
                }
            }
            else if ((string)workEventArgs.Argument == "Disconnect")
            {
                try
                {

                    m_ReaderAPI.Disconnect();
                    m_IsConnected = false;
                    workEventArgs.Result = "Disconnect Succeed";
                    m_ReaderAPI = null;

                }
                catch (OperationFailureException ofe)
                {
                    workEventArgs.Result = ofe.Result;
                }
            }

        }

        private void connectBackgroundWorker_ProgressChanged(object sender,
            ProgressChangedEventArgs progressEventArgs)
        {
            m_ConnectionForm.connectionButton.Enabled = false;
        }

        private void connectBackgroundWorker_RunWorkerCompleted(object sender,
            RunWorkerCompletedEventArgs connectEventArgs)
        {
            if (m_ConnectionForm.connectionButton.Text == "Connect")
            {
                if (connectEventArgs.Result.ToString() == "Connect Succeed")
                {
                    /*
                     *  UI Updates
                     */
                    m_ConnectionForm.connectionButton.Text = "Disconnect";
                    m_ConnectionForm.hostname_TB.Enabled = false;
                    m_ConnectionForm.port_TB.Enabled = false;
                    m_ConnectionForm.Close();
                    this.btnStartRead.Enabled = true;
                    this.btnStartRead.Text = "Start Reading";

                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_RunWorkerCompleted : Connect Succeed");

                    /*
                     *  Events Registration
                     */
                    m_ReaderAPI.Events.ReadNotify += new Events.ReadNotifyHandler(Events_ReadNotify);
                    m_ReaderAPI.Events.AttachTagDataWithReadEvent = false;
                    m_ReaderAPI.Events.StatusNotify += new Events.StatusNotifyHandler(Events_StatusNotify);
                    m_ReaderAPI.Events.NotifyGPIEvent = true;
                    m_ReaderAPI.Events.NotifyBufferFullEvent = true;
                    m_ReaderAPI.Events.NotifyBufferFullWarningEvent = true;
                    m_ReaderAPI.Events.NotifyReaderDisconnectEvent = true;
                    m_ReaderAPI.Events.NotifyReaderExceptionEvent = true;
                    m_ReaderAPI.Events.NotifyAccessStartEvent = true;
                    m_ReaderAPI.Events.NotifyAccessStopEvent = true;
                    m_ReaderAPI.Events.NotifyInventoryStartEvent = true;
                    m_ReaderAPI.Events.NotifyInventoryStopEvent = true;

                    this.Text = Title + "Connected to " + deviceip + " [" + dcGateNumber + "]";

                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_RunWorkerCompleted : Connected to " + deviceip + "[" + dcGateNumber + "]");

                    this.connectionStatus.BackgroundImage =
                        global::DCRFIDReader.Properties.Resources.connected;
                }
            }
            else if (m_ConnectionForm.connectionButton.Text == "Disconnect")
            {
                if (connectEventArgs.Result.ToString() == "Disconnect Succeed")
                {
                    this.Text = Title + " IP : " + deviceip + " [" + dcGateNumber + "]";
                    this.connectionStatus.BackgroundImage =
                        global::DCRFIDReader.Properties.Resources.disconnected;

                    m_ConnectionForm.connectionButton.Text = "Connect";
                    m_ConnectionForm.hostname_TB.Enabled = true;
                    m_ConnectionForm.port_TB.Enabled = true;
                    this.btnStartRead.Enabled = false;
                    this.btnStartRead.Text = "Start Reading";

                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_RunWorkerCompleted : Disconnect Succeed");
                }
            }
            functionCallStatusLabel.Text = connectEventArgs.Result.ToString();
            cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "accessBackgroundWorker_RunWorkerCompleted : " + connectEventArgs.Result.ToString());

            m_ConnectionForm.connectionButton.Enabled = true;
            ReaderConnectInProcess = false;
        }

        private async void AppForm_Load(object sender, EventArgs e)
        {
            //txtGate.Text = aconfig.gate();
            //load_company();
            dtGateDevice = await DeviceGate.GetDataTable();
            dcGateNumber = await DeviceGate.GetGateNumber(dtGateDevice, deviceid);
            dsTag = await QTags.get_product_epc("");
            dsBox = await QTags.get_box("");
            dsProduct = await QTags.get_product("");
            dsPO = await QTags.get_po("");
            load_tags();

            btnStartAuto.Enabled = true;
            btnStopAuto.Enabled = false;

            this.Text = Title + "IP : " + deviceip + " [" + dcGateNumber + "]";

            try
            {
                this.connectBackgroundWorker.RunWorkerAsync("Connect");
            }
            catch (Exception ex)
            {
                this.functionCallStatusLabel.Text = ex.Message;
                //MessageBox.Show(ex.Message);
            }

            if (aconfig.AutoStart() == "1")
            {
                btnStartAuto_Click(this, EventArgs.Empty);
            }

            int resetBuffer = aconfig.ResetBuffer_Min() * 60000;

            timer_clear_buffer.Interval = resetBuffer;
            timer_clear_buffer.Enabled = true;
            //if (btnStartRead.Text == "Start Reading")
            //{
            //    btnStartRead_Click(this, EventArgs.Empty);
            //}

            notifyIcon1.Text = "Reader : " + deviceip;
        }

        private void load_tags()
        {
            gcTag.DataSource = dsTag;
            gcTag.DataMember = dsTag.Tables[0].TableName;

            gcBox.DataSource = dsBox;
            gcBox.DataMember = dsBox.Tables[0].TableName;

            gcUPC.DataSource = dsProduct;
            gcUPC.DataMember = dsProduct.Tables[0].TableName;

            gcPO.DataSource = dsPO;
            gcPO.DataMember = dsPO.Tables[0].TableName;
        }

        private void AppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (m_IsConnected)
                {
                    connectBackgroundWorker.RunWorkerAsync("Disconnect");
                }
                this.Dispose();
            }
            catch (Exception ex)
            {
                functionCallStatusLabel.Text = ex.Message;
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "AppForm_FormClosing : " + ex.Message);
            }
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_ConnectionForm.ShowDialog(this);
        }

        private void capabilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapabilitiesForm capabilitiesForm = new CapabilitiesForm(this);
            capabilitiesForm.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_IsConnected)
            {
                connectBackgroundWorker.RunWorkerAsync("Disconnect");
            }
            this.Dispose();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                m_ReadForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                functionCallStatusLabel.Text = "Read Form:" + ex.Message;
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "readTool :" + ex.Message);
            }
        }

        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_WriteForm)
            {
                m_WriteForm = new WriteForm(this, false);
            }
            m_WriteForm.ShowDialog(this);
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_LockForm)
            {
                m_LockForm = new LockForm(this);
            }
            m_LockForm.ShowDialog(this);
        }

        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_KillForm)
            {
                m_KillForm = new KillForm(this);
            }
            m_KillForm.ShowDialog(this);
        }

        private void blockWriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_WriteForm)
            {
                m_WriteForm = new WriteForm(this, true);
            }
            m_WriteForm.ShowDialog(this);
        }

        private void blockEraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_BlockEraseForm)
            {
                m_BlockEraseForm = new BlockEraseForm(this);
            }
            m_BlockEraseForm.ShowDialog(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpDialog = new HelpForm(this);
            if (helpDialog.ShowDialog(this) == DialogResult.Yes)
            {

            }
            helpDialog.Dispose();
        }


        void inventoryList_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataContextMenuStrip.Show(inventoryList, new Point(e.X, e.Y));
            }
        }

        private void tagDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TagDataForm tagDataForm = new TagDataForm(this);
            tagDataForm.ShowDialog(this);
        }

        private void readDataContextMenuItem_Click(object sender, EventArgs e)
        {
            m_ReadForm.ShowDialog(this);
        }

        private void writeDataContextMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_WriteForm)
            {
                m_WriteForm = new WriteForm(this, false);
            }
            m_WriteForm.ShowDialog(this);
        }

        private void lockDataContextMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_LockForm)
            {
                m_LockForm = new LockForm(this);
            }
            m_LockForm.ShowDialog(this);
        }

        private void killDataContextMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_KillForm)
            {
                m_KillForm = new KillForm(this);
            }
            m_KillForm.ShowDialog(this);
        }

        private void blockWriteDataContextMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_WriteForm)
            {
                m_WriteForm = new WriteForm(this, true);
            }
            m_WriteForm.ShowDialog(this);
        }

        private void blockEraseDataContextMenuItem_Click(object sender, EventArgs e)
        {
            if (null == m_BlockEraseForm)
            {
                m_BlockEraseForm = new BlockEraseForm(this);
            }
            m_BlockEraseForm.ShowDialog(this);
        }

        private void resetToFactoryDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_ReaderAPI.IsConnected)
                {
                    m_ReaderAPI.Config.ResetFactoryDefaults();
                }
            }
            catch (Exception ex)
            {
                functionCallStatusLabel.Text = ex.Message;
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "resetToFactoryDefaults :" + ex.Message);
            }
        }

        private void clearReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.inventoryList.Items.Clear();
            this.m_TagTable.Clear();
        }

        private void clearReports_CB_CheckedChanged(object sender, EventArgs e)
        {
            //this.totalTagValueLabel.Text = "0(0)";
            //this.lblTotalBox.Text = "0";
            //this.lblTotalSKU.Text = "0";
            this.inventoryList.Items.Clear();
            this.m_TagTable.Clear();

            //dsTag.Tables[0].Clear();
            dsBox.Tables[0].Clear();
            dsProduct.Tables[0].Clear();

            clearReports_CB.Checked = false;
        }

        private void AppForm_ClientSizeChanged(object sender, EventArgs e)
        {
            functionCallStatusLabel.Width = this.Width - 77;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void update_ui()
        {
            //if (this.InvokeRequired)
            //{
            //    this.Invoke(new Action(update_ui));
            //}
            //else {

            //}

            //var t = Task.Run(() =>
            //{
            //    while (reading == true)
            //    {
            //        if (internal_cal == false)
            //        {
            //            re_update_sku();
            //        }
            //    }
            //});
            //t.Wait();
        }

        //private void re_update_sku()
        //{
        //    if (this.InvokeRequired)
        //    {
        //        this.Invoke(new MethodInvoker(re_update_sku));
        //    }
        //    else
        //    {
        //        internal_cal = true;
        //        for (int i = 0; i <= inventoryList.Items.Count - 1; i++)
        //        {
        //            if (inventoryList.Items[i].SubItems[8].Text != "")
        //            {
        //                string tag = inventoryList.Items[i].SubItems[0].Text;
        //                DataSet ds = QTags.get_epc(tag);
        //                if (ds.Tables[0].Rows.Count > 0)
        //                {
        //                    DataRow dr = ds.Tables[0].Rows[0];
        //                    QTagsUpdate_EPC.add(ref dsTag, ref dsPOEPC, tag, dr["ProductSku"].ToString(), dr["Upc"].ToString(), dr["Description"].ToString(), dr["ContainerId"].ToString(), int.Parse(dr["Status"].ToString()), dr["location"].ToString(), dr["vendorid"].ToString());
        //                    QTagsUpdate.add_box(ref this, ref dsBox, dr["OrderNumber"].ToString(), dr["StoreNumber"].ToString(), dr["ContainerId"].ToString());
        //                    QTagsUpdate.add_product(ref dsProduct, dr["OrderNumber"].ToString(), dr["StoreNumber"].ToString(), dr["ContainerId"].ToString(), dr["ProductSku"].ToString());
        //                    QTagsUpdate.add_sl(ref dsPO, dr["OrderNumber"].ToString());
        //                }

        //                // mark read
        //                inventoryList.Items[i].SubItems[8].Text = "1";
        //                for (int c = 0; c <= inventoryList.Columns.Count - 1; c++)
        //                {
        //                    inventoryList.Items[i].BackColor = Color.LightGreen;
        //                }
        //            }
        //        }
        //        lblTotalBox.Text = QTSumary.SumBox(ref dsBox);
        //        lblTotalSKU.Text = QTSumary.SumSKU(ref dsPO);
        //        internal_cal = false;

        //        this.Refresh();
        //    }
        //}

        private delegate void dg_re_update_sku2(System.Windows.Forms.Form m_form, string tags, int antenna);

        private async void re_update_sku2(System.Windows.Forms.Form m_form, string tags, int antenna)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new dg_re_update_sku2(re_update_sku2), m_form, tags, antenna);
            }
            else
            {
                internal_cal = true;
                string tag = tags;// item.SubItems[0].Text;
                //DataSet ds = await QTags.get_epc_is_exist(tag, deviceid, antenna);

                DataRow dr = await QTags.GetEPCDetail(dcGateNumber, dsTag.Tables[0], deviceid, antenna, tag);

                if (dr != null)
                {
                    //DataRow dr = ds.Tables[0].Rows[0];
                    string res = await save_epc_scan(dcGateNumber, currentBookingNo, tag, dr["PRProductItemId"].ToString());
                    if (res != "")
                    {
                        //MessageBox.Show(res);
                        cFileIO.WriteLogToFile("ScanningGateNo" + dcGateNumber, "Booking No. : " + currentBookingNo + " TAG : " + tag + " - Error : " + res);
                    }
                    QTagsUpdate_EPC.updateRead(ref dsTag, tag);
                    QTagsUpdate.add_box(ref m_form, ref dsBox, dr["OrderNumber"].ToString(), dr["StoreNumber"].ToString(), dr["ContainerId"].ToString());
                    QTagsUpdate.add_product(ref dsProduct, dr["OrderNumber"].ToString(), dr["StoreNumber"].ToString(), dr["ContainerId"].ToString(), dr["ProductSku"].ToString());
                    QTagsUpdate.add_po(ref dsPO, dr["OrderNumber"].ToString());

                    //cFileIO.WriteLogToFile("ScanningGateNo" + dcGateNumber, "Booking No. : " + currentBookingNo + " PONo.: " + dr["OrderNumber"] + " TAG : " + tag);
                }
                //else {
                //    QTagsUpdate_EPC.add(ref dsTag, tag,"","", "", "", 0,"", "");
                //}

                gcTag.Refresh();
                gcBox.Refresh();
                gcUPC.Refresh();
                gcPO.Refresh();

                lblTotalEPC.Text = inventoryList.Items.Count.ToString();

                // mark read
                //item.SubItems[8].Text = "1";
                //for (int c = 0; c <= inventoryList.Columns.Count - 1; c++)
                //{
                //    item.BackColor = Color.LightGreen;
                //}


                //item.BackColor = Color.LightGreen;


                //lblNumberOfBox.Text = QTSumary.SumBox(ref dsBox);
                //lblTotalUPC.Text = QTSumary.SumSKU(ref dsProduct);

                //lblNumberOfBox.Refresh();
                //lblTotalUPC.Refresh();
                //totalTagValueLabel.Refresh();

                internal_cal = false;
            }
        }


        private void clear_ui()
        {
            //this.totalTagValueLabel.Text = "0(0)";
            //this.lblTotalBox.Text = "0";
            //this.lblTotalSKU.Text = "0";


            //lblNumberOfBox.Text = "0/0";
            //lblTotalUPC.Text = "0/0";

            this.inventoryList.Items.Clear();
            this.m_TagTable.Clear();

            dsTag.Tables[0].Clear();
            dsBox.Tables[0].Clear();
            dsProduct.Tables[0].Clear();
            dsPO.Tables[0].Clear();

            clearReports_CB.Checked = false;
        }


        private async void gvPO_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            int QtyRead = Convert.ToInt32(gvPO.GetRowCellValue(e.RowHandle, "QtyRead"));
            int DigitalQuantity = Convert.ToInt32(gvPO.GetRowCellValue(e.RowHandle, "DigitalQuantity"));


            if (DigitalQuantity != QtyRead)
            {
                e.Appearance.BackColor = Color.White;
            }
            else
            {
                e.Appearance.BackColor = Color.LightGreen;
            }
            //Override any other formatting  
            e.HighPriority = true;
        }

        private async void gvBox_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            int QtyRead = Convert.ToInt32(gvBox.GetRowCellValue(e.RowHandle, "QtyRead"));
            int DigitalQuantity = Convert.ToInt32(gvBox.GetRowCellValue(e.RowHandle, "DigitalQuantity"));

            if (e.RowHandle >= 0)
            {
                dsBox.Tables[0].Rows[e.RowHandle]["OrderNumber"].ToString();
            }


            string cid = "";

            if (gvBox.GetRowCellValue(e.RowHandle, "ContainerId") != null)
            {
                cid = gvBox.GetRowCellValue(e.RowHandle, "ContainerId").ToString();
            }

            if (DigitalQuantity != QtyRead)
            {
                e.Appearance.BackColor = Color.White;
            }
            else
            {
                //if ((DigitalQuantity == QtyRead) && (QtyRead > 0) && (cid != ""))
                //{
                //    // save cid
                //    save_cid(cid, get_tags(cid));

                //    QTags.accept_box(OrderNumber, cid);
                //    Application.DoEvents();
                //}
                e.Appearance.BackColor = Color.LightGreen;
            }

            //Override any other formatting  
            e.HighPriority = true;
        }

        private async void gvUPC_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            int QtyRead = Convert.ToInt32(gvUPC.GetRowCellValue(e.RowHandle, "QtyRead"));
            int DigitalQuantity = Convert.ToInt32(gvUPC.GetRowCellValue(e.RowHandle, "DigitalQuantity"));

            if (DigitalQuantity != QtyRead)
            {
                e.Appearance.BackColor = Color.White;
            }
            else
            {
                e.Appearance.BackColor = Color.LightGreen;
            }

            //Override any other formatting  
            e.HighPriority = true;
        }


        private void update_time_count()
        {

        }

        private void timecount_start()
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void timecount_stop()
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (worker.CancellationPending == false)
            {
                TimeCount.update_time_count(ref dsPO);
                System.Threading.Thread.Sleep(1000);
            }

            e.Cancel = true;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            gcPO.Refresh();
        }

        public Array get_tags(string cid)
        {
            List<string> add_list = new List<string>();

            //string err = "";
            //DataSet ds = SyncData.GetDt_PRProductItem_Local(cboVendor.EditValue.ToString(), cboBookingNo.EditValue.ToString(), cid, ref err);
            //if (err != "") { update_sync_log("Save EPC: " + err); }

            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{
            //    add_list.Add(dr["ItemUniqueId"].ToString());
            //}
            return add_list.ToArray();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gcBox_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dsPO.Tables[0].Rows[1]["accept"] = 1;
            //string ret = "";
            //ret = po_commit(txtres_person.Text);
            //MessageBox.Show(ret);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dsPOEPC.Tables[0].Rows)
            {
                re_update_sku2(this, dr["EPC"].ToString(), 0);
                System.Threading.Thread.Sleep(500);
            }
        }

        private async void timer1_timecount_Tick(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                update_timecount();
            });
        }

        private void update_timecount()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => { update_timecount(); }));
            }
            else
            {
                TimeCount.update_time_count(ref dsPO);
            }
        }

        private void gvPO_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if (e.Column.Name == "accept") {
            //    gvPO_CustomRowCellEdit(sender,DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs.Empty());
            //}
        }

        private void mnuGate_Click(object sender, EventArgs e)
        {
            frmGate fGate = new frmGate();
            fGate.StartPosition = FormStartPosition.CenterScreen;
            fGate.ShowDialog();
        }

        private void mnuDevice_Click(object sender, EventArgs e)
        {
            frmDevice fDevice = new frmDevice();
            fDevice.StartPosition = FormStartPosition.CenterScreen;
            fDevice.ShowDialog();
        }

        private void mnuSettingDeviceToGate_Click(object sender, EventArgs e)
        {
            frmGateDeviceSetting fGateDeviceSetting = new frmGateDeviceSetting();
            fGateDeviceSetting.StartPosition = FormStartPosition.CenterScreen;
            fGateDeviceSetting.ShowDialog();
        }

        private void btnStartRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_IsConnected)
                {
                    if (btnStartRead.Text == "Start Reading")
                    {
                        //tabControl1.SelectedIndex = 0;
                        m_ReaderAPI.Actions.Inventory.Perform(null, null, null);

                        inventoryList.Items.Clear();
                        m_TagTable.Clear();
                        m_TagTotalCount = 0;

                        //dsTag.Tables[0].Rows.Clear();

                        reading = true;

                        btnStartRead.Text = "Stop Reading";


                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "btnStartRead_Click - Start Reading");

                        //timer_clear_buffer.Enabled = true;

                        // timecount
                        //TimeCount.set_start(ref dsPO);
                        //timecount_start();

                        //timer1_timecount.Enabled = true;

                        //update_ui();
                    }
                    else if (btnStartRead.Text == "Stop Reading")
                    {
                        if (m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0)
                        {
                            m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence();
                        }
                        else
                        {
                            m_ReaderAPI.Actions.Inventory.Stop();
                        }

                        btnStartRead.Text = "Start Reading";
                        //tabControl1.SelectedIndex = 1;

                        //timer_clear_buffer.Enabled = false;

                        reading = false;

                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "btnStartRead_Click - Stop Reading");

                        //re_update_sku();

                        // timecount
                        //timer1_timecount.Enabled = false;
                        //timecount_stop();
                    }
                }
                else
                {
                    functionCallStatusLabel.Text = "Please connect to a reader";
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "btnRead_Click : Please connect to a reader");
                }
            }
            catch (InvalidOperationException ioe)
            {
                functionCallStatusLabel.Text = ioe.Message;
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "btnRead_Click : " + ioe.Message);
            }
            catch (InvalidUsageException iue)
            {
                functionCallStatusLabel.Text = iue.Info;
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "btnRead_Click : " + iue.Info);
            }
            catch (OperationFailureException ofe)
            {
                functionCallStatusLabel.Text = ofe.Result + ":" + ofe.StatusDescription;
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "btnRead_Click : " + ofe.StatusDescription);
            }
            catch (Exception ex)
            {
                functionCallStatusLabel.Text = ex.Message;
                cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "btnRead_Click : " + ex.Message);
            }
        }

        private async void btnClear_Click(object sender, EventArgs e)
        {
            await load_data_po();
            //dsTag = QTags.get_epc("", "");
            //dsBox = QTags.get_box("");
            //dsProduct = QTags.get_product("");
            //dsPO = QTags.get_po("");
            //load_tags();

            //this.totalTagValueLabel.Text = "0(0)";
            //this.lblTotalBox.Text = "0";
            //this.lblTotalSKU.Text = "0";

            //lblNumberOfBox.Text = "0/0";
            //lblTotalUPC.Text = "0/0";

            //dsTag.Tables[0].Clear();
            //dsBox.Tables[0].Clear();
            //dsProduct.Tables[0].Clear();
            //dsPO.Tables[0].Clear();

            await Task.Run(() =>
            {
                inventoryList.Items.Clear();
                m_TagTable.Clear();
                lblTotalEPC.Text = "0";
            });

            cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "btnClear_Click - Clear Tag and Re load data");
            //clearReports_CB.Checked = false;
        }

        private async void timer_getCommand_Tick(object sender, EventArgs e)
        {
            await scan_command();
        }

        private void btnStartAuto_Click(object sender, EventArgs e)
        {
            btnStartAuto.Enabled = false;
            btnStopAuto.Enabled = true;

            timer_getCommand.Enabled = true;

            // ทุกๆ 2 นาที refresh ยอด po แล้ว rescan ปุ่ม
            timer_refresh_button.Interval = (1000 * 60) * 2;
            timer_refresh_button.Enabled = true;

            cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "btnStartAuto_Click - Start Auto Scan");
        }

        private void btnStopAuto_Click(object sender, EventArgs e)
        {
            btnStartAuto.Enabled = true;
            btnStopAuto.Enabled = false;

            timer_getCommand.Enabled = false;
            timer_refresh_button.Enabled = false;

            cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "btnStopAuto_Click - Stop Auto Scan");
        }

        private async void btnScanCommandManual_Click(object sender, EventArgs e)
        {
            await scan_command();
        }

        private void gvTag_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            int QtyRead = Convert.ToInt32(gvTag.GetRowCellValue(e.RowHandle, "QtyRead"));

            if (QtyRead == 0)
            {
                e.Appearance.BackColor = Color.White;
            }
            else
            {
                e.Appearance.BackColor = Color.LightGreen;
            }

            //Override any other formatting  
            e.HighPriority = true;
        }

        private async void btnResetRequest_Click(object sender, EventArgs e)
        {
            await command_clear_request();
        }

        private void timer_reconnect_Tick(object sender, EventArgs e)
        {
            if (ReaderConnectInProcess == false)
            {
                if (m_IsConnected == false)
                {
                    try
                    {
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "Reconnect");
                        this.connectBackgroundWorker.RunWorkerAsync("Connect");
                    }
                    catch (Exception ex)
                    {
                        this.functionCallStatusLabel.Text = ex.Message;
                        //MessageBox.Show(ex.Message);
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "Reconnect : " + ex.Message);
                    }
                }
            }
        }

        private void frmAppForm_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                //this.notifyIcon1.ShowBalloonTip(100, "Notify Message", "Please click for see more detail..", ToolTipIcon.Info);
            }
        }

        private void mnuShow_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private async void timer_clear_buffer_Tick(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    if (btnStartRead.Text == "Stop Reading")
                    {
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "clear buffer : stop");
                        btnStartRead_Click(btnStartRead, null);
                        Thread.Sleep(1000);
                        btnStartRead_Click(btnStartRead, null);
                        cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "clear buffer : start");
                    }

                    inventoryList.Items.Clear();
                    m_TagTable.Clear();
                }
                catch(Exception ex)
                {
                    cFileIO.WriteLogToFile(deviceip.Replace(".", ""), "clear buffer : " + ex.Message);
                }
            });
        }

        private async void refresh_button_Tick(object sender, EventArgs e)
        {
            await scan_refresh_button();
        }
    }
}
